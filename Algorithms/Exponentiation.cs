using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class Exponentiation
    {
        public static BigInteger Exponentiate(int value, int exponent)
        {
            //set to one to hold the value of the 0th power which is always one
            //https://learn.microsoft.com/en-us/dotnet/api/system.numerics.biginteger?view=netcore-3.1
            //https://learn.microsoft.com/en-us/dotnet/api/system.numerics.biginteger.modpow?view=netcore-3.1
            BigInteger bigResult = 1;
            //represents that value of the power, intially holding 0, value of the first power
            BigInteger factor = value;
            while (exponent != 0)
            {
                if(exponent % 2 == 1)
                {
                    bigResult *= factor;
                }
                factor *= factor;
                exponent /= 2;
            }

            return bigResult;
        }
    }
}
