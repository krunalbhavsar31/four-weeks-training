namespace CovariantAndContravariantGenerics
{
    interface IProcessor<in TInput, out TResult>
    {
        TResult Process(TInput input);
    }

    class StringToIntProcessor : IProcessor<string, int>
    {
        // Implement Process method
        public int Process(string input)
        {
            //throw new NotImplementedException();
            return input.Length;
        }
    }

    class DoubleToStringProcessor : IProcessor<double, string>
    {
        // Implement Process method
        public string Process(double input)
        {
            //throw new NotImplementedException();
            return input.ToString();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Demonstrate covariance and contravariance with IProcessor interface
            // Demonstrating covariance
            IProcessor<double, string> processor1 = new DoubleToStringProcessor();
            string result1 = processor1.Process(3.14);
            Console.WriteLine($"String representation of double: {result1}");

            // Demonstrating contravariance
            IProcessor<string, int> processor2 = new StringToIntProcessor();
            IProcessor<string, int> processor3 = processor2;
            int result2 = processor3.Process("Hello, world!");
            Console.WriteLine($"String length: {result2}");

        }
    }
}