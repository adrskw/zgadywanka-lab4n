using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloConsoleAppBatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program na powitanie.");

            string imie = "";
            string nazwisko = "";
            int wiek = 0;

            if (args.Length == 1)
            {
                imie = args[0];
                
                Console.Write("Podaj nazwisko: ");
                nazwisko = Console.ReadLine();

                Console.WriteLine("Witaj " + imie + " " + nazwisko);
                Console.WriteLine("Witaj {0} {1}. Czy Pan {0} rzeczywiście nazywa się {1}?", imie, nazwisko);

                Console.Write("Podaj wiek: ");
                wiek = Convert.ToInt32(Console.ReadLine());

                if (wiek < 0)
                {
                    Console.WriteLine("Błędne dane!");
                }
                else if (wiek < 67)
                {
                    Console.WriteLine(" do emerytury zostało Ci {0} lat ", 67 - wiek);
                }
                else
                {
                    Console.WriteLine(" jesteś emerytem");
                }
            }
            else if (args.Length == 2)
            {
                imie = args[0];
                nazwisko = args[1];

                Console.WriteLine("Witaj " + imie + " " + nazwisko);
                Console.WriteLine("Witaj {0} {1}. Czy Pan {0} rzeczywiście nazywa się {1}?", imie, nazwisko);

                Console.Write("Podaj wiek: ");
                wiek = Convert.ToInt32(Console.ReadLine());

                if (wiek < 0)
                {
                    Console.WriteLine("Błędne dane!");
                }
                else if (wiek < 67)
                {
                    Console.WriteLine(" do emerytury zostało Ci {0} lat ", 67 - wiek);
                }
                else
                {
                    Console.WriteLine(" jesteś emerytem");
                }
            }
            else if (args.Length >= 3)
            {
                imie = args[0];
                nazwisko = args[1];
                wiek = Convert.ToInt32(args[2]);

                Console.WriteLine("Witaj " + imie + " " + nazwisko);
                Console.WriteLine("Witaj {0} {1}. Czy Pan {0} rzeczywiście nazywa się {1}?", imie, nazwisko);

                if (wiek < 0)
                {
                    Console.WriteLine("Błędne dane!");
                }
                else if (wiek < 67)
                {
                    Console.WriteLine(" do emerytury zostało Ci {0} lat ", 67 - wiek);
                }
                else
                {
                    Console.WriteLine(" jesteś emerytem");
                }
            }
            else
            {
                Console.Write("Podaj imię: ");
                imie = Console.ReadLine();

                Console.Write("Podaj nazwisko: ");
                nazwisko = Console.ReadLine();

                Console.WriteLine("Witaj " + imie + " " + nazwisko);
                Console.WriteLine("Witaj {0} {1}. Czy Pan {0} rzeczywiście nazywa się {1}?", imie, nazwisko);

                Console.Write("Podaj wiek: ");
                wiek = Convert.ToInt32(Console.ReadLine());

                if (wiek < 0)
                {
                    Console.WriteLine("Błędne dane!");
                }
                else if (wiek < 67)
                {
                    Console.WriteLine(" do emerytury zostało Ci {0} lat ", 67 - wiek);
                }
                else
                {
                    Console.WriteLine(" jesteś emerytem");
                }
            }

            Console.WriteLine("... naciśnij dowolny klawisz, aby zakończyć");
            Console.ReadKey();
        }
    }
}
