using System.Reflection;
using System.Text.Json;
using GeneralHierarchy.NoneClosure;

namespace GeneralHierarchy
{
    /// <summary>
    /// Класс представляет базовые методы для работы с объектами (закрыт для модификации)
    /// </summary>
    public class General
    {
        public static void AssignmentAttempt(ref General target, General source)
        {
            if (target.GetType() == source.GetType())
            {
                target = source;
                return;
            }

            target = new None();
        }

        public static void Copy(object source, object destination)
        {
            PropertyInfo[] srcProps = source.GetType().GetProperties();
            PropertyInfo[] dstProps = destination.GetType().GetProperties();

            foreach (var srcProp in srcProps)
            {
                var dstProp = Array.Find(dstProps, p => p.Name == srcProp.Name && p.PropertyType == srcProp.PropertyType);
                if (dstProp != null && dstProp.CanWrite)
                {
                    dstProp.SetValue(destination, srcProp.GetValue(source));
                }
            }
        }

        public static object Clone(object source)
        {
            var assemblyType = GetClass(source);

            var emptyInstance = Activator.CreateInstance(assemblyType);
            if (emptyInstance == null)
            {
                throw new NullReferenceException("can't create a new instance of source");
            }

            Copy(source, emptyInstance);
            return emptyInstance;
        }

        public static bool Compare(object source, object destination)
        {
            PropertyInfo[] srcProps = source.GetType().GetProperties();
            PropertyInfo[] dstProps = destination.GetType().GetProperties();

            foreach (var srcProp in srcProps)
            {
                var dstProp = Array.Find(dstProps, p => p.Name == srcProp.Name && p.PropertyType == srcProp.PropertyType);
                if (dstProp == null)
                {
                    return false;
                }

                var dstValue = dstProp.GetValue(destination);
                var srcValue = srcProp.GetValue(source);

                if (dstValue is Array dsrValueArr && srcValue is Array srcValueArr && arraysEqual(dsrValueArr, srcValueArr))
                {
                    continue;
                }

                if (dstValue.Equals(srcValue))
                {
                    continue;
                }

                return Compare(dstValue, srcValue);
            }

            return true;
        }

        private static bool arraysEqual(Array arr1, Array arr2)
        {
            if (arr1.Length != arr2.Length)
            {
                return false;
            }

            for (int i = 0; i < arr1.Length; i++)
            {
                if (!Equals(arr1.GetValue(i), arr2.GetValue(i)))
                {
                    return false;
                }
            }

            return true;
        }

        public static string Serialize(object source)
        {
            return JsonSerializer.Serialize(source);
        }

        public static T Deserialize<T>(string serialized)
        {
            return JsonSerializer.Deserialize<T>(serialized);
        }

        public static void Print(object source)
        {
            System.Console.WriteLine($"Class: {GetClass(source).FullName}");

            PropertyInfo[] srcProps = source.GetType().GetProperties();

            foreach (PropertyInfo srcProp in srcProps)
            {
                Console.WriteLine($"{srcProp.Name} ({srcProp.PropertyType}) = {srcProp.GetValue(source)}");
            }
        }

        public static bool IsType<T>(object source)
        {
            return source.GetType() == typeof(T);
        }

        public static Type GetClass(object source)
        {
            var srcType = source.GetType();
            var assemblyType = srcType.Assembly.GetType(srcType.FullName);
            if (assemblyType == null)
            {
                throw new NullReferenceException("can't get object of source type");
            }

            return srcType;
        }
    }
}