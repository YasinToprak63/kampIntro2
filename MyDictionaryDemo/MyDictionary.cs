using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionaryDemo
{
    class MyDictionary<K,V>
    {
        K[] _key;
        V[] _value;
       
        public MyDictionary()
        {
            _key = new K[0];
            _value = new V[0];


        }
        public void Add(K key, V value)
        {
            K[] _tempkey = _key;
            _key = new K[_key.Length + 1];

            for (int i = 0; i < _tempkey.Length; i++)
            {
                _key[i] = _tempkey[i];
            }
            _key[_key.Length - 1] = key;

            V[] _tempvalue = _value;
            _value = new V[_value.Length + 1];

            for (int i = 0; i < _tempvalue.Length; i++)
            {
                _value[i] = _tempvalue[i];

            }
            _value[_value.Length - 1] = value;

        }
         public int Length
        {
            get { return _key.Length; }
        }           
    }
}
