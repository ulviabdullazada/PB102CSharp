using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerGeneric
{
    class GenericList<T>
    {
        T[] _array;
        private int _count;
        public int Capacity { get; }
        public int Count => _count;
        public GenericList(int capacity = 5)
        {
            Capacity = capacity;
            _array = new T[capacity];
            _count = 0;
        }
        public void Add(T value)
        {
            if (_array.Length == _count)
            {
                Resize();
            }
            _array[_count++] = value;

        }
        void Resize()
        {
            Array.Resize(ref _array, _array.Length + Capacity);
        }
        public override string ToString()
        {
            string result = string.Empty;
            for (int i = 0; i < Count; i++)
            {
                result += _array[i].ToString() + " ";
            }
            return result;
        }
        public T this[int index]
        {
            get
            {
                if (index >= Count)
                {
                    throw new Exception();
                }
                return _array[index];
            }
            set
            {
                if (index >= Count)
                {
                    throw new Exception();
                }
                _array[index] = value;
            }
        }
    }
}
