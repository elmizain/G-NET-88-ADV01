namespace G_NET_88_ADV01
{
    internal interface IRepository<T>
    {
        void Add(T item);
        T Get(int index);
    }
}