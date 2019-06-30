using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelGry;

namespace GraGUI
{
    public partial class FormGra : Form
    {
        public FormGra()
        {
            InitializeComponent();
        }

        // Fields
        private int _od { get; set; } // textBoxZakresOd value
        private int _do { get; set; } // textBoxZakresDo value
        private Gra gra;
        private Stopwatch licznik;
        private List<HistoriaGier> historia = new List<HistoriaGier>();

        #region Ustawienia nowej gry i przycisku

        private void NowaGra()
        {
            textBoxLiczba.Text = "";
            textBoxZakresDo.Text = "";
            textBoxZakresOd.Text = "";
            groupBoxWylosowano.Visible = false;
            groupBoxLosuj.Visible = false;
            timer1.Enabled = false;
            licznik.Stop();
            licznik.Reset();
            //historia.Clear();
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
                MessageBox.Show("Podaj liczbę minimalną");
                return;
            }
            if (String.IsNullOrEmpty(textBoxZakresDo.Text))
            {
                MessageBox.Show("Podaj liczbę maksymalną");
                return;
            }

            int _od;
            if (!Int32.TryParse(textBoxZakresOd.Text, out _od))
            {
                MessageBox.Show("Nieprawidłowa liczba minimalna. Można podawać tylko liczby całkowite.");
                return;
            }

            int _do;
            if (!Int32.TryParse(textBoxZakresDo.Text, out _do))
            {
                MessageBox.Show("Nieprawidłowa liczba maksymalna. Można podawać tylko liczby całkowite.");
                return;
            }

            this._od = _od;
            this._do = _do;

            gra = new Gra(_od, _do);
            licznik = new Stopwatch();
            
            timer1.Enabled = true;
            MessageBox.Show("Wylosowano!");
            licznik.Start();
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
                MessageBox.Show("Nieprawidłowa wartość zgadywanej liczby. Można podawać tylko liczby całkowite.");
                return;
            }

            if (liczba < Math.Min(_od, _do) || liczba > Math.Max(_od, _do))
            {
                MessageBox.Show("Nieprawidlowa wartość! Wybrałeś zakres od " + Math.Min(_od, _do) + " do " + Math.Max(_od, _do));
                return;
            }

            var odp = gra.Ocena(liczba);

            switch (odp)
            {
                case Gra.Odp.ZaMalo:
                    historia.Add(new HistoriaGier { NrGry = Gra.NrGry, Propozycja = liczba, Odpowiedz = "Za Mało", Czas = DateTime.Now });
                    MessageBox.Show("Za mało! To była próba nr: " + gra.LicznikRuchow);
                    break;
                case Gra.Odp.Trafiono:
                    historia.Add(new HistoriaGier { NrGry = Gra.NrGry, Propozycja = liczba, Odpowiedz = "Trafiono", Czas = DateTime.Now });
                    MessageBox.Show("Trafiłeś za " + gra.LicznikRuchow + " razem!" + " Gratulacje!");
                    buttonHistoria.PerformClick();
                    NowaGra();
                    break;
                case Gra.Odp.ZaDuzo:
                    historia.Add(new HistoriaGier { NrGry = Gra.NrGry, Propozycja = liczba, Odpowiedz = "Za Dużo", Czas = DateTime.Now });
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
            historia.Add(new HistoriaGier { NrGry = Gra.NrGry, Propozycja = "Poddaje się", Odpowiedz = "Liczba to: " + gra.Wylosowana, Czas = DateTime.Now });
            MessageBox.Show("Poddałeś się za " + num + " razem! Liczba to: " + gra.Wylosowana);
            buttonHistoria.PerformClick();
            NowaGra();
        }
        #endregion

        #region Przycisk historii gier
        private void buttonHistoria_Click(object sender, EventArgs e)
        {
            Form historiaForm = new FormHistoria(historia);
            historiaForm.Show();
        }
        #endregion

        #region Licznik czasu
        private void timer1_Tick(object sender, EventArgs e) => time.Text = string.Format("{0:00}:{1:00}:{2:00}",
                licznik.Elapsed.Hours,
                licznik.Elapsed.Minutes,
                licznik.Elapsed.Seconds);
        #endregion

    }
}
