using System;

namespace G_NET_88_ADV01
{
    internal class Class_StructConstraint
    {
        public static void Show<T>(T value) where T : struct
        {
            Console.WriteLine(value);
        }
    }
}
