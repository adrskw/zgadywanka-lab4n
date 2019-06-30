namespace GraGUI
{
    partial class FormHistoria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NrGry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.propozycja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odpowiedz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.czas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NrGry,
            this.propozycja,
            this.odpowiedz,
            this.czas});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(660, 380);
            this.dataGridView1.TabIndex = 0;
            // 
            // NrGry
            // 
            this.NrGry.HeaderText = "Numer Gry";
            this.NrGry.Name = "NrGry";
            this.NrGry.ReadOnly = true;
            // 
            // propozycja
            // 
            this.propozycja.HeaderText = "Propozycja";
            this.propozycja.Name = "propozycja";
            this.propozycja.ReadOnly = true;
            // 
            // odpowiedz
            // 
            this.odpowiedz.HeaderText = "Odpowiedź";
            this.odpowiedz.Name = "odpowiedz";
            this.odpowiedz.ReadOnly = true;
            // 
            // czas
            // 
            this.czas.HeaderText = "Czas";
            this.czas.Name = "czas";
            this.czas.ReadOnly = true;
            this.czas.Width = 150;
            // 
            // FormHistoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 380);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormHistoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historia Gry";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NrGry;
        private System.Windows.Forms.DataGridViewTextBoxColumn propozycja;
        private System.Windows.Forms.DataGridViewTextBoxColumn odpowiedz;
        private System.Windows.Forms.DataGridViewTextBoxColumn czas;
    }
}