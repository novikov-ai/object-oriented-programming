using GeneralHierarchy.NoneClosure;

namespace GeneralHierarchy
{
    /// <summary>
    /// Класс открыт для модификации и расширения
    /// </summary>
    public class Any : General
    {
        public static void AssignmentAttempt(ref Any target, Any source)
        {
            if (target.GetType() == source.GetType())
            {
                target = source;
                return;
            }

            target = new None();
        }

        public static void Make()
        {
            Console.WriteLine("...");
        }
    }
}