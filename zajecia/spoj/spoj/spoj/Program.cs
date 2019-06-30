using System;
using System.Diagnostics;
using System.IO;

namespace spoj
{
    class Program
    {
        static void Main(string[] args)
        {
            StringReader wejscie = new StringReader(test1); // do skasowania

            // wczytaj sekwencję s
            string line1 = wejscie.ReadLine();
            int n = Convert.ToInt32(line1);

            string line2 = wejscie.ReadLine();
            string[] tab2 = line2.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Debug.Assert(tab2.Length == n);

            int[] s = new int[n];

            for (int i = 0; i < n; i++)
            {
                s[i] = int.Parse(tab2[i]);
            }

            // wczytaj sekwencję q
            string line3 = wejscie.ReadLine();
            int m = Convert.ToInt32(line3);

            string line4 = wejscie.ReadLine();
            string[] tab4 = line4.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Debug.Assert(tab4.Length == m);

            int[] q = new int[m];

            for (int i = 0; i < m; i++)
            {
                q[i] = int.Parse(tab4[i]);
            }

            // oblicz
            string wynik = "";

            for (int i = 0; i < Math.Min(n, m); i++)
            {
                if(s[i] == q[i])
                {
                    wynik += i + 1 + " ";
                }
            }
            Console.Write(wynik.Trim());
        }
        static string test1 = @"5
-2 -2 -1 1 4 
6
-3 -2 -1 1 2 3";
        static string test2 = "5\n-2 -2 -1 1 4\n6\n-3 -2 -1 1 2 3";
    }
}
