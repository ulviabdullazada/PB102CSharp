namespace AbstractInterface
{
    internal class Emlpoyee : IAdd
    {
        public decimal Salary { get; set; }
        public decimal Add(decimal num1, decimal num2)
        {
            ///
            return Salary + num1 / num2;
        }
    }
}
