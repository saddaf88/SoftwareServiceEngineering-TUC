using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern
{
    class CalculatorProxy : ICalculator
    {
        struct Operation
        {
            public double Lhs;
            public double Rhs;
            public double Result;
        }

        private List<Operation> cache = new List<Operation>();


        public double Multiply(double lhs, double rhs)
        {
            var calc = new Calculator();
            return calc.Multiply(lhs, rhs);
        }

        public double Divide(double lhs, double rhs)
        {
            /// Checking existance in the cache. Preventing the redundant operation in the project 
            foreach (var item in cache)
            {
                if(item.Lhs == lhs && item.Rhs == rhs)
                {
                    Console.WriteLine("This result is from cache");
                    return item.Result;
                }
            }

            var calc = new Calculator();
            var result =  calc.Divide(lhs, rhs);
            result = Math.Round(result, 2);

            ///Adding the result in the cache
            cache.Add(
                new Operation 
                {
                    Lhs = lhs, 
                    Rhs = rhs,
                    Result = result 
                }
            );

            /// We are doing extra checking or can take extra precaution from proxy 
            if (rhs == 0)
            {
                return double.NaN;
            }

            return result;
        }
    }
}
