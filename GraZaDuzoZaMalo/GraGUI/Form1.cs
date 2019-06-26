using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelGry;

namespace GraGUI
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private Gra gra;

        // Variables
        private int od { get; set; } // textBoxZakresOd value
        private int _do { get; set; } // textBoxZakresDo value

        #region Ustawienia nowej gry i przycisku

        private void NowaGra()
        {
            textBoxLiczba.Text = "";
            textBoxZakresDo.Text = "";
            textBoxZakresOd.Text = "";
            groupBoxWylosowano.Visible = false;
            groupBoxLosuj.Visible = false;
        }

        private void buttonNowaGra_Click(object sender, EventArgs e)
        {
            if (gra != null)
            {
                if (gra.StanGry == Gra.State.Trwa)
                {
                    MessageBox.Show("Gra już trwa! Poddaj się lub odgadnij liczbę");
                    return;
                }
            }
            groupBoxLosuj.Visible = true;
        }
        #endregion

        #region Losuj liczbę
        private void buttonLosuj_Click_1(object sender, EventArgs e)
        {
            if (gra != null)
            {
                if (gra.StanGry == Gra.State.Trwa)
                {
                    MessageBox.Show("Gra już trwa! Poddaj się lub odgadnij liczbę");
                    return;
                }
            }
            if (String.IsNullOrEmpty(textBoxZakresOd.Text))
            {
                MessageBox.Show("Podaj Zakres od!");
                return;
            }
            if (String.IsNullOrEmpty(textBoxZakresDo.Text))
            {
                MessageBox.Show("Podaj Zakres do!");
                return;
            }

            int od;
            if (!Int32.TryParse(textBoxZakresOd.Text, out od))
            {
                MessageBox.Show("Nieprawidłowa wartość: zakres od. Można podawać tylko liczby całkowite.");
                return;
            }

            int _do;
            if (!Int32.TryParse(textBoxZakresDo.Text, out _do))
            {
                MessageBox.Show("Nieprawidłowa wartość: zakres do. Można podawać tylko liczby całkowite.");
                return;
            }

            this.od = od;
            this._do = _do;

            gra = new Gra(od, _do);
            MessageBox.Show("Wylosowano!");
            groupBoxWylosowano.Visible = true;
        }
        #endregion

        #region Sprawdź liczbę
        private void buttonSprawdz_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(textBoxLiczba.Text))
            {
                MessageBox.Show("Podaj Liczbe!");
                return;
            }

            int liczba;

            if (!Int32.TryParse(textBoxLiczba.Text, out liczba))
            {
                MessageBox.Show("Nieprawidłowa wartość odgadniętej liczby. Można podawać tylko liczby całkowite.");
                return;
            }

            if (liczba > _do || liczba < od)
            {
                MessageBox.Show("Nieprawidlowa wartość! Wybrałeś zakres od " + od + " do " + _do);
                return;
            }

            var odp = gra.Ocena(liczba);

            switch (odp)
            {
                case Gra.Odp.ZaMalo:
                    MessageBox.Show("Za mało! To była próba nr: " + gra.LicznikRuchow);
                    break;
                case Gra.Odp.Trafiono:
                    MessageBox.Show("Trafiłeś za " + gra.LicznikRuchow + " razem!" + " Gratulacje!");
                    NowaGra();
                    break;
                case Gra.Odp.ZaDuzo:
                    MessageBox.Show("Za dużo! To była próba nr: " + gra.LicznikRuchow);
                    break;
                default:
                    break;
            }
        }
        #endregion

        #region Poddaj się
        private void buttonPoddajSie_Click(object sender, EventArgs e)
        {
            int num = gra.LicznikRuchow;
            num++;
            gra.Poddaj();
            MessageBox.Show("Poddałeś się za " + num + " razem! Liczba to: " + gra.Wylosowana);
            NowaGra();
        }
        #endregion

    }
}