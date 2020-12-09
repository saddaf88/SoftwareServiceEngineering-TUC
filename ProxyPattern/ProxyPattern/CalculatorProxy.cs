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

            //if (rhs == 0)
            //{
            //    return double.NaN;
            //}
            return calc.Divide(lhs, rhs);
        }
    }
}
