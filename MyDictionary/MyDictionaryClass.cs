using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionaryClass<K, V>
    {
        K[] keys;
        V[] values;

        public MyDictionaryClass()
        {
            keys = new K[0];
            values = new V[0];
        }
        public void Add(K key, V value)
        {
            K[] tempKeys = keys;
            keys = new K[keys.Length + 1];
            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
            }

            keys[keys.Length - 1] = key;

            V[] tempValues = values;
            values = new V[values.Length + 1];
            for (int i = 0; i < tempValues.Length; i++)
            {
                values[i] = tempValues[i];
            }

            values[values.Length - 1] = value;
        }
        public int keysLength
        {
            get
            {
                return keys.Length;
            }
        }
        public int valuesLength
        {
            get
            {
                return values.Length;
            }
        }
        public K[] Keys
        {
            get
            {
                return keys;
            }
        }
        public V[] Values
        {
            get
            {
                return values;
            }
        }
    }
}