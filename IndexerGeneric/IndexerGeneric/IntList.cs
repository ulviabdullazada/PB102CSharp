using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerGeneric
{
    class IntList
    {
        private readonly Type type;
        object[] _array;
        private int _count;
        public int Capacity { get; }
        public int Count => _count;
        public IntList(Type typeOfArray, int capacity = 5)
        {
            Capacity = capacity;
            _array = new object[capacity];
            _count = 0;
            type = typeOfArray;
        }
        public void Add(object value)
        {
            if (value.GetType() == type)
            {
                if (_array.Length == _count)
                {
                    Resize();
                }
                _array[_count++] = value;
            }
            else
            {
                throw new Exception();
            }
            
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
    }
}
