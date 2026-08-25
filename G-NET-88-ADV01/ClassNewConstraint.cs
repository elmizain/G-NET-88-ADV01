using System;

namespace G_NET_88_ADV01
{
    internal class Class_NewConstraint
    {
        public static T Create<T>() where T : new()
        {
            return new T();
        }
    }
}