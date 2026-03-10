namespace Writing3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            int result = a + b;

            // 1. Concatenation 
            Console.WriteLine("The result of " + a + " and " + b + " is: " + result);

            // 2. Composite formatting
            Console.WriteLine("The result of {0} and {1} is: {2}", a, b, result);

            // 3. String interpolation
            Console.WriteLine($"The result of {a} and {b} is: {result}");
        }
    }
}
