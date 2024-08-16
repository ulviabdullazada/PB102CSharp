namespace AbstractInterface
{
    internal class Calculator : IAdd, IDifference, IDivide, IMultiply
    {
        public decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }

        public decimal Difference(decimal num1, decimal num2)
        {
            return num1 - num2;
        }

        public decimal Divide(decimal num1, decimal num2)
        {
            return num1 / num2;
        }

        public decimal Multiple(decimal num1, decimal num2)
            => num1 * num2;
    }
}
