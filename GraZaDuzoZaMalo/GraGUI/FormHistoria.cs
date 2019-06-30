using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraGUI
{
    public partial class FormHistoria : Form
    {
        public FormHistoria(List<HistoriaGier> historia)
        {
            InitializeComponent();
            this.historia = historia;
            LadujHistorie();
        }

        private List<HistoriaGier> historia;

        private void LadujHistorie()
        {
            foreach (HistoriaGier item in historia)
            {
                dataGridView1.Rows.Add(item.NrGry, item.Propozycja, item.Odpowiedz, item.Czas);
            }
        }

    }
}
