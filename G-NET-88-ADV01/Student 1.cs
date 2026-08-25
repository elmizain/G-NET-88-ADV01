public class Student : Person, IPrintable
{
    public Student(string name) : base(name)
    {
    }

    public void Print()
    {
        Console.WriteLine("Student: " + Name);
    }
}