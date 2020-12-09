using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern
{
    class CalculatorProxy : ICalculator
    {
        public double Multiply(double lhs, double rhs)
        {
            var calc = new Calculator();
            return calc.Multiply(lhs, rhs);
        }

        public double Divide(double lhs, double rhs)
        {
            var calc = new Calculator();
            var result =  calc.Divide(lhs, rhs);
            Console.WriteLine("I am from proxy class");

            /// We are doing extra checking or can take extra precaution from proxy 
            if (rhs == 0)
            {
                return double.NaN;
            }

            return Math.Round(result, 2);
        }
    }
}
