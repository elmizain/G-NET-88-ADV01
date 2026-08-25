public class Container<T>
{
    private T value = default!;

    public void Add(T item)
    {
        value = item;
    }

    public T Get()
    {
        return value;
    }
}