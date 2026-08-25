using System;

namespace G_NET_88_ADV01
{
    internal class Class_FindMax
    {
        public static T FindMax<T>(T[] values) where T : IComparable<T>
        {
            T max = values[0];

            for (int i = 1; i < values.Length; i++)
            {
                if (values[i].CompareTo(max) > 0)
                {
                    max = values[i];
                }
            }

            return max;
        }
    }
}
