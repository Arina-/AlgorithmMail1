using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxValue
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1, s2;
            int n = int.Parse(Console.ReadLine());
            int mi = 0, mj = 0, msi = 0, msj = 0;

            string[] sA = new string[n];
            string[] sB = new string[n];
            double[] A = new double[n];
            double[] B = new double[n];

            s1 = Console.ReadLine();
            s2 = Console.ReadLine();

            sA = s1.Split(' ');
            sB = s2.Split(' ');

            A[0] = double.Parse(sA[0]);
            B[0] = double.Parse(sB[0]);
            double maxSum = A[0] + B[0];

            for (int ii = 1; ii < n; ii++)
            {
                A[ii] = double.Parse(sA[ii]);
                B[ii] = double.Parse(sB[ii]);
            }

            int j = 0;
            int i = 0;
            for (j = 1; j < n; j++)
            {
                if (A[i] + B[j] > maxSum)
                {
                    maxSum = A[i] + B[j];
                    msi = i;
                    msj = j;
                    for (i = 0; i <= j; i++)
                    {
                        if (A[i] + B[j] > maxSum)
                        {
                            maxSum = A[i] + B[j];
                            msi = i;
                            msj = j;
                        }
                    }
                }
            }
            Console.WriteLine("{0} {1}", msi, msj);
            Console.ReadLine();
        }
    }
}
