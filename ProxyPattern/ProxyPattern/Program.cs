using System;

namespace ProxyPattern
{
    ///Client
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program is for understanding the proxy pattern");
            Console.WriteLine("***************************************************");
            ICalculator calc = new CalculatorProxy();
            double result = calc.Divide(10, 0);
            Console.WriteLine("Then result is : " + result);

            /// Testing the cache implementation
            Console.WriteLine(calc.Divide(10, 5));
            Console.WriteLine(calc.Divide(13, 5));
            Console.WriteLine(calc.Divide(20, 2));
            Console.WriteLine(calc.Divide(15, 4));
            Console.WriteLine(calc.Divide(10, 5));
            Console.WriteLine(calc.Divide(19, 3));
            Console.WriteLine(calc.Divide(50, 5));
            Console.WriteLine(calc.Divide(10, 5));
        }
    }
}
