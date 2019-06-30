using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace HelloConsoleVBDialog
{
    class Program
    {
        static void Main(string[] args)
        {
            Interaction.MsgBox("Program na powitanie.", MsgBoxStyle.OkOnly | MsgBoxStyle.Information, "Tytuł okienka");

            string imie = Interaction.InputBox("podaj imię", "Okienko imię");
            
            if (imie == "")
            {
                Console.WriteLine("Koniec");
            }
            else
            {
                Console.WriteLine("Podano imie: " + imie);

                string nazwisko = Interaction.InputBox("podaj nazwisko", "Okienko nazwisko");

                if (nazwisko == "")
                {
                    Console.WriteLine("Koniec");
                }
                else
                {
                    Console.WriteLine("Podano nazwisko: " + nazwisko);

                    Interaction.MsgBox("Witaj " + imie + " " + nazwisko);
                    Interaction.MsgBox("Witaj " + imie + " " + nazwisko + ". Czy Pan " + imie + " rzeczywiście nazywa się " + nazwisko + "?");

                    int wiek = Convert.ToInt32(Interaction.InputBox("podaj wiek", "Okienko wiek"));

                    if (wiek == 0)
                    {
                        Console.WriteLine("Koniec");
                    }
                    else
                    {
                        Console.WriteLine("Podano wiek: " + wiek);

                        if (wiek < 0)
                        {
                            Interaction.MsgBox("Błędne dane!", MsgBoxStyle.OkOnly | MsgBoxStyle.Information, "Okienko emerytura");
                        }
                        else if (wiek < 67)
                        {
                            Interaction.MsgBox(string.Format(" do emerytury zostało Ci {0} lat ", 67 - wiek), MsgBoxStyle.OkOnly | MsgBoxStyle.Information, "Okienko emerytura");
                        }
                        else
                        {
                            Interaction.MsgBox(" jesteś emerytem", MsgBoxStyle.OkOnly | MsgBoxStyle.Information, "Okienko emerytura");
                        }
                    }
                }
            }
        }
    }
}
