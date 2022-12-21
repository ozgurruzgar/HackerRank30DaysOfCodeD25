using System;

namespace HackerRank30DaysOfCodeD25
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            /* Kodunu buraya yaz. Consol'dan gelen değeri oku. Sonucu bas. Class'ın isminin Solution olması tavsiye edilir.*/

            int n = int.Parse(Console.ReadLine());

            for (var i = 0; i < n; i++)
            {
                int curr = int.Parse(Console.ReadLine());
                Console.WriteLine(IsPrime(curr) ? "Prime" : "Not prime");
            }
        }

        private static bool IsPrime(int n)
        {
            if (n < 2) return false;
            if (n == 2) return true;
            if (n % 2 == 0) return false;

            int root = (int)Math.Floor(Math.Sqrt(n));

            for (var i = 3; i <= root; i += 2)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
