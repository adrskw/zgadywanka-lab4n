using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab01_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program na powitanie.");

            Console.Write("Podaj imię: ");
            string imie = Console.ReadLine();

            Console.Write("Podaj nazwisko: ");
            string nazwisko = Console.ReadLine();

            Console.WriteLine("Witaj " + imie + " " + nazwisko);
            Console.WriteLine("Witaj {0} {1}. Czy Pan {0} rzeczywiście nazwywa się {1}?", imie, nazwisko);

            Console.Write("Podaj wiek: ");
            int wiek = Convert.ToInt32(Console.ReadLine());

            if(wiek < 67)
            {
                Console.WriteLine(" do emerytury zostało Ci {0} lat ", 67 - wiek);
            }
            else if(wiek < 0)
            {
                Console.WriteLine("Błędne dane!");
            }
            else
            {
                Console.WriteLine(" jesteś emerytem");
            }
        }
    }
}
