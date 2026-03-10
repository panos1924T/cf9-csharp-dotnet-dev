using System.Globalization;

namespace CultureInfoDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime d = new DateTime(2024, 6, 1);

            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
            Console.WriteLine("{0:N}", 1234.56);
            Console.WriteLine("{0:D}", d);

            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("el-GR");
            Console.WriteLine("{0:N}", 1234.56);
            Console.WriteLine("{0:D}", d);
            
        }
    }
}
