using System;

namespace G_NET_88_ADV01
{
    internal class Class_ClassConstraint
    {
        public static void Show<T>(T value) where T : class
        {
            Console.WriteLine(value);
        }
    }
}