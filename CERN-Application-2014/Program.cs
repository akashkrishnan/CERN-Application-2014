using System;
using System.Linq;
using System.Numerics;

namespace CERN_Application_2014
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SumOfPrimes(4000000, 5000000));
            Console.WriteLine(SumOfDigits(BigInteger.Pow(2, 3502)));
            Console.ReadKey(false);
        }

        private static BigInteger SumOfPrimes(int min, int max)
        {
            BigInteger sum = 0;
            for (int n = min; n < max; n++) if (IsPrime(n)) sum += n;
            return sum;
        }

        private static bool IsPrime(int n)
        {
            if (n == 1 || (n > 2 && n % 2 == 0)) return false;
            for (int i = 3; i * i <= n; i += 2) if (n % i == 0) return false;
            return true;
        }

        private static int SumOfDigits(BigInteger n)
        {
            int sum = 0;
            while (n > 0)
            {
                sum += (int)(n % 10);
                n /= 10;
            }
            return sum;
        }
    }
}
