namespace Models;

public class Person
{
    public static int _instanceCount = 0;
    public int Id { get; }
    //public readonly int Id;
    public string Name { get; set; }
    public string Surname { get; set; }
    public Person(string name, string surname)
    {
        _instanceCount++;
        Id = _instanceCount;
        Name = name;
        Surname = surname;
    }

    public override string ToString()
    {
        return $"{Id}. {Name} {Surname}";
    }
}
