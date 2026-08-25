using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_88_ADV01
{
    public class Pair<TKey, TValue>

    {
        public TKey Key {  get; set;}
        public TValue Value { get; set;}
        public Pair(TKey key, TValue value)
        {
            Key = key;
            Value = value;
        }
    }
}
