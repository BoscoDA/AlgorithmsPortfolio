using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class PrimeFactorization
    {
        public static List<int> Factor1(int number)
        {
            List<int> factors = new List<int>();
            int i = 2;
            while (i < number)
            {
                //pull out factors of i
                while (number % i == 0)
                {
                    //i is a factor. Add it to the list.
                    factors.Add(i);

                    //Divide the number by i
                    number = number/i;
                }
                //Check the next possible factor
                i = i + 1;
            }

            //if  there's anything left of the number, it is a factor, too.
            if(number > 1)
            {
                factors.Add(number);
            }

            return factors;
        } 

        public static List<int> Factor2(int number)
        {
            List<int> factors = new List<int>();

            //Pull out factors of 2.
            while (number%2 == 0)
            {
                factors.Add(2);
                number = number/2;
            }

            // look for odd factors
            int i = 3;

            int maxFactor = Convert.ToInt32(Math.Sqrt(number));
            while(i<= maxFactor)
            {
                //pull out factors of i.
                while (number % i == 0)
                {
                    //i is a factor. add it to the list
                    factors.Add(i);

                    //divide the number by i
                    number = number / i;

                    //set up a new upper bound.
                    maxFactor = Convert.ToInt32(Math.Sqrt(number));
                }

                //check the next possible odd factor.
                i = i + 2;
            }
            //if there's anything left of the number, it is a factor, too.
            if (number > 1) { factors.Add(number); }
            return factors;
        }
    }
}
