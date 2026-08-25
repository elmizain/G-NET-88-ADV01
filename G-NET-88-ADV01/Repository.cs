public class Repository<T> where T : Person
{
    public void Display(T person)
    {
        Console.WriteLine(person.Name);
    }
}