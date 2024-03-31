using System.Collections;
using System.Numerics;

namespace GeneralHierarchy.Generics
{
    // над которым допустима операция сложения, реализуемая как сложение соответствующих значений типа T двух векторов одинаковой длины.
    public class Vector<T> : General, IEnumerable<T>
    where T : INumber<T>
    {
        private T[] _vectors;

        public Vector(params T[] values)
        {
            _vectors = values;
        }

        public T[] GetValues()
        {
            return _vectors;
        }

        public int Len()
        {
            return _vectors.Length;
        }

        public static Vector<T>? operator +(Vector<T> v1, Vector<T> v2)
        {
            if (v1.Len() != v2.Len())
            {
                return null;
            }
            
            T[] resultValues = new T[v1.Len()];
            for (int i = 0; i < v1.Len(); i++)
            {
                resultValues[i] = v1.GetValues()[i] + v2.GetValues()[i];
            }

            return new Vector<T>(resultValues);
        }

        public IEnumerator GetEnumerator()
        {
            return new VectorEnumerator<T>(_vectors);
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
             foreach (var item in _vectors)
             {
                yield return item;
             }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
             return GetEnumerator();
        }
    }

    public class VectorEnumerator<T> : IEnumerator
    {
        public T[] _vectors;

        int position = -1;

        public VectorEnumerator(T[] values)
        {
            _vectors = values;
        }

        object IEnumerator.Current => Current();

        public object Current()
        {
            try
            {
                return _vectors[position];
            }
            catch (IndexOutOfRangeException)
            {
                throw new InvalidOperationException();
            }
        }

        public bool MoveNext()
        {
            position++;
            return position < _vectors.Length;
        }

        public void Reset()
        {
            position = -1;
        }
    }
}