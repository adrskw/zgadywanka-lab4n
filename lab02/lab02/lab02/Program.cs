﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab02
{
    class Program
    {
        const char CHAR = '*';
        static void Star() => Console.Write(CHAR);
        static void StarLn() => Console.WriteLine(CHAR);
        static void Space() => Console.Write(" ");
        static void SpaceLn() => Console.WriteLine(" ");
        static void NewLine() => Console.WriteLine();

        static void LiteraX(int n)
        {
            if (n < 3) throw new ArgumentException("zbyt mały rozmiar");
            if (n % 2 == 0) n = n + 1;

            //górna połówka
            for (int i = 0; i < n / 2; i++)
            {
                for (int j = 0; j < i; j++)
                    Space();
                Star();
                for (int j = 0; j < n - 2 - 2 * i; j++)
                    Space();
                StarLn();
            }

            //pojedyncza gwiazdka w środku
            for (int i = 0; i < n / 2; i++)
            {
                Space();   
            }
            StarLn();

            //dolna połówka, symetrycznie do górnej
            for (int i = 0; i < n / 2; i++)
            {
                for (int j = 0; j < n / 2 - i - 1; j++)
                    Space();

                Star();

                for (int j = 0; j < 1 + 2 * i; j++)
                    Space();

                StarLn();
            }
        }
        static void LiteraZ(int n)
        {
            for (int i = 0; i < n - 1; i++)
                Star();
            StarLn();

            for (int i = 0; i < n - 2; i++)
            {
                for (int j = 0; j < n - 2 - i; j++)
                    Space();
                StarLn();
            }

            for (int i = 0; i < n - 1; i++)
                Star();
            StarLn();
        }
        static void LiteraZOdwrot(int n)
        {
            for (int i = 0; i < n - 1; i++)
                Star();
            StarLn();

            for (int i = 0; i < n - 2; i++)
            {
                for (int j = 0; j < i + 1; j++)
                    Space();
                StarLn();
            }

            for (int i = 0; i < n - 1; i++)
                Star();
            StarLn();
        }

        static void Klepsydra(int n)
        {
            // górna część
            for (int i = 0; i < n - 1; i++)
                Star();
            StarLn();

            for (int i = 0; i < n / 2 - 1; i++)
            {
                for (int j = 0; j < i + 1; j++)
                    Space();
                Star();

                for (int j = 0; j < n - 4 - 2 * i; j++)
                    Space();
                StarLn();
            }

            // środek
            if (n % 2 > 0)
            {
                for (int j = 0; j < n / 2; j++)
                    Space();
                StarLn();
            }
            else
            {
                for (int j = 0; j < n / 2 - 1; j++)
                    Space();
                Star();
                StarLn();
            }

            // dolna część
            for (int i = 0; i < n / 2 - 2; i++)
            {
                for (int j = 0; j < n / 2 - 2 - i; j++)
                    Space();
                Star();

                for (int j = 0; j < 2 + 2 * i; j++)
                    Space();
                StarLn();
            }

            for (int i = 0; i < n - 1; i++)
                Star();
            StarLn();
        }

        static void Main(string[] args)
        {
            LiteraX(8);
            Console.WriteLine("");
            LiteraZ(8);
            Console.WriteLine("");
            LiteraZOdwrot(8);
            Console.WriteLine("");
            Klepsydra(7);
            Console.WriteLine("");
            Klepsydra(20);
        }
    }
}
