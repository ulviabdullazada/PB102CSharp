using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerGeneric
{
    class CustomDictionaryItem<TKey,TValue>
    {
        public TKey Key { get; set; }
        public TValue Value { get; set; }
    }

    class CustomDictionary<Key, Value>
    {
        GenericList<CustomDictionaryItem<Key, Value>> list = new GenericList<CustomDictionaryItem<Key, Value>>();
        public void Add(Key key, Value value)
        {
            list.Add(new CustomDictionaryItem<Key, Value>()
            {
                Key = key,
                Value = value
            });
        }
        public void GetDatas()
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i].Key + ", " + list[i].Value);
            }
        }
    }
}
