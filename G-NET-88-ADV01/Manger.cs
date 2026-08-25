public class Manager<T> where T : Person, IPrintable
{
    public void Process(T item)
    {
        Console.WriteLine(item.Name);
        item.Print();
    }
}