using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeFactors
{
    public class Prime
    {
        int Num, i;
        public void Factors()
        {
            Console.WriteLine("Enter a Number");
            Num = Convert.ToInt32(Console.ReadLine());

            for ( i = 2; Num > 1; i++)
            {
                if (Num % i == 0)
                {
                    int r = 0;
                    while ( Num % i == 0)
                    {
                        Num /= i;
                        r++;
                    }
                    Console.WriteLine("{0} is a Prime Factor {1} times. ", i, r);
                }
            }
        }
    }
}
