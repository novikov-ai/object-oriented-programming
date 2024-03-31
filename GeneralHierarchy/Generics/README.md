# Сложение элементов произвольных типов

В С# реализовать поддержку сложения элементов произвольных типов проще всего следующим образом:

1. Наследуемся от `IEnumerable<T>` и реализуем методы, чтобы была возможность итерироваться по классу и, следовательно, использовать потенциал LINQ в частности `Enumerable.Sum()`
2. Для общего типа ставим ограничение `where T : INumber<T>`, чтобы была возможность осуществлять базовые операции с элементами

Из недостатков подхода: ограничение на типы заданное в п.2 не позволяет использовать более сложные, такие как `Vector<Vector<Vector<T>>>`.  

### Реализация

~~~C#
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
~~~

### Использование

~~~C#
using GeneralHierarchy.Generics;

var v1 = new Vector<Double>(5, 2, 3);
var v2 = new Vector<Double>(5.123, 123, 6.112);

Console.WriteLine(Enumerable.Sum(v1 + v2)); // 144.23499999999999

var v3 = new Vector<int>(5, 2, 3);
var v4 = new Vector<int>(6, 11, 1000);

Console.WriteLine(Enumerable.Sum(v3 + v4)); // 1027
~~~