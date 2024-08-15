namespace Static.Extension;

class Person
{
    public string Name { get; set; }
    public string Surname { get; set; }

    public string GetFullName()
        => string.Concat(Name.ToCapitalize(), " ", Surname.ToCapitalize());


    //ajskdhajksdh -> Lower
    //AKSDJHSUSIEKJSDJ -> Upper
    //Askdufhsjkdfhdjskdhf -> Capitalize

    //public readonly string _fin;
    //public const string A = "akjsdhaskhjhd";
    //public string Fin { get; }

    //public Person(string fin)
    //{
    //    Fin = fin;
    //    _fin = "132";
    //    //A = "123";
    //}
    //public Person()
    //{

    //}
    //public static string Test { get; set; } = "asjdkhaksjdh";
    //static Person()
    //{
    //    Console.WriteLine("Static ctor worked");
    //}
    //public Person()
    //{
    //    Console.WriteLine("Non static ctor worked");
    //}
    //public void GetFullName()
    //{
    //    Console.WriteLine(string.Concat(Name, " ", Surname, Test));
    //}
    //public static void SayHi()
    //{
    //    Console.WriteLine(" Salam PB102");
    //}
}
