public class Printer<T> where T : IPrintable
{
    public void PrintItem(T item)
    {
        item.Print();
    }
}