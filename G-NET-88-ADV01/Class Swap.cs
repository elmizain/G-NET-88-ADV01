using System;

namespace G_NET_88_ADV01
{
    internal class Class_Swap
    {
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
}