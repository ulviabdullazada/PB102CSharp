namespace StructCasting
{
    class ClassA
    {
        public string Name;
        public int Num;
        public ClassA(string name)
        {
            Name = name;
        }
    }
    readonly struct StructA
    {
        public readonly string Name;
        public readonly int Num;
        public int Salam { get; init; }
        public StructA(string name)
        {
            Name = name;
            Num = 0;
            Salam = 0;
        }
        public void Hi()
        {
            Console.WriteLine("Salam");
        }
    }
}
