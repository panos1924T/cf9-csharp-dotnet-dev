namespace Writing2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 10;

            // 1. Concatenation (old way)
            Console.WriteLine("Num = " + num);

            // 2. Composite formatting
            Console.WriteLine("num = {0}", num);

            // 3. String interpolation (new and prefered way)
            Console.WriteLine($"num = {num}");

        }
    }
}
