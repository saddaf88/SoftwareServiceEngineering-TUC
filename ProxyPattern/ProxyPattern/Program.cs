﻿using System;

namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program is for understanding the proxy pattern");
            Console.WriteLine("***************************************************");
            ICalculator calc = new CalculatorProxy();
            double result = calc.Divide(10, 3);
            Console.WriteLine("Then result is : " + result);
        }
    }
}