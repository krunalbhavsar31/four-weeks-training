namespace IteratorsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fibonacci = FibonacciSequence().Take(10);
            foreach (int number in fibonacci)
            {
                Console.WriteLine(number);
            }
        }
        // https://www.c-sharpcorner.com/UploadFile/5ef30d/understanding-yield-return-in-C-Sharp/
        // https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/yield
        public static IEnumerable<int> FibonacciSequence()
        {
            int a = 0;
            int b = 1;
                
            for (int i = 0; i < 10; i++)
            {
                yield return a;
                int c = a + b;
                a = b;
                b = c;
            }

            //throw new NotImplementedException();
        }
    }
}