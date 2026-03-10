namespace NumberReadValidation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float floatNum = 0F;
            double doubleNum = 0D;

            Console.WriteLine("Please, give two decimals");

            if (!float.TryParse(Console.ReadLine(), out floatNum))
                Console.WriteLine("Invalid number for a float number!");

            if(!double.TryParse(Console.ReadLine(), out doubleNum))
                Console.WriteLine("Invalid number for a double number!");

            Console.WriteLine($"f = {floatNum:N2} \t d = {doubleNum:N2}");
        }
    }
}
