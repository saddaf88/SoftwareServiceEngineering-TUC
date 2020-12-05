using System;

namespace TDDCalculator
{
    public class Calculator
    {
        public double Multiply(double lhs, double rhs)
        {
            return lhs * rhs;
        }

        public double Division(int lhs, int rhs)
        {
            if (rhs == 0)
                return double.NaN;
            return lhs / rhs;
        }
    }
}
