using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmMail1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            int N;
            s = Console.ReadLine();
            N = int.Parse(s);

            int i = 2;
            while(N > 1)
            {
                while(N % i == 0)
                {
                    Console.Write("{0} ", i);
                    N /= i;
                }
                i++;
            }
            Console.WriteLine();
            Console.ReadLine();
        }
        static bool IsSimple(int m)
        {
            int k = (int)Math.Sqrt(m) + 1;
            if (m == 1) return false;
            for (int i = 2; i <= k; i++)
            {
                if (m % i == 0) return false;
            }
            return true;
        }
    }
}
