using System;
using System.Collections.Generic;
using System.Text;

namespace TDDHashValue
{
    public class HashValue
    {
        public int GetHashValue(string str)
        {
            int result = 0;
            if (str.Length != 0)
            {
                foreach (char c in str)
                {
                    result = result + ((int)c);
                }

                result = result % 127;
            }
            else
                result = -1;
            
            return result;
        }
    }
}
