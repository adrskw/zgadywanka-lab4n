namespace GraGUI
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonNowaGra = new System.Windows.Forms.Button();
            this.groupBoxLosuj = new System.Windows.Forms.GroupBox();
            this.buttonLosuj = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxZakresDo = new System.Windows.Forms.TextBox();
            this.textBoxZakresOd = new System.Windows.Forms.TextBox();
            this.groupBoxWylosowano = new System.Windows.Forms.GroupBox();
            this.buttonPoddajSie = new System.Windows.Forms.Button();
            this.buttonSprawdz = new System.Windows.Forms.Button();
            this.textBoxLiczba = new System.Windows.Forms.TextBox();
            this.groupBoxLosuj.SuspendLayout();
            this.groupBoxWylosowano.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonNowaGra
            // 
            this.buttonNowaGra.Location = new System.Drawing.Point(16, 14);
            this.buttonNowaGra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonNowaGra.Name = "buttonNowaGra";
            this.buttonNowaGra.Size = new System.Drawing.Size(121, 50);
            this.buttonNowaGra.TabIndex = 0;
            this.buttonNowaGra.Text = "Nowa Gra";
            this.buttonNowaGra.UseVisualStyleBackColor = true;
            this.buttonNowaGra.Click += new System.EventHandler(this.buttonNowaGra_Click);
            // 
            // groupBoxLosuj
            // 
            this.groupBoxLosuj.Controls.Add(this.buttonLosuj);
            this.groupBoxLosuj.Controls.Add(this.label2);
            this.groupBoxLosuj.Controls.Add(this.label1);
            this.groupBoxLosuj.Controls.Add(this.textBoxZakresDo);
            this.groupBoxLosuj.Controls.Add(this.textBoxZakresOd);
            this.groupBoxLosuj.Location = new System.Drawing.Point(18, 89);
            this.groupBoxLosuj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxLosuj.Name = "groupBoxLosuj";
            this.groupBoxLosuj.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxLosuj.Size = new System.Drawing.Size(564, 114);
            this.groupBoxLosuj.TabIndex = 1;
            this.groupBoxLosuj.TabStop = false;
            this.groupBoxLosuj.Text = "Losowanie";
            this.groupBoxLosuj.Visible = false;
            // 
            // buttonLosuj
            // 
            this.buttonLosuj.Location = new System.Drawing.Point(267, 59);
            this.buttonLosuj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonLosuj.Name = "buttonLosuj";
            this.buttonLosuj.Size = new System.Drawing.Size(103, 37);
            this.buttonLosuj.TabIndex = 2;
            this.buttonLosuj.Text = "Wylosuj";
            this.buttonLosuj.UseVisualStyleBackColor = true;
            this.buttonLosuj.Click += new System.EventHandler(this.buttonLosuj_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Zakres do:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Zakres od:";
            // 
            // textBoxZakresDo
            // 
            this.textBoxZakresDo.Location = new System.Drawing.Point(93, 66);
            this.textBoxZakresDo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxZakresDo.Name = "textBoxZakresDo";
            this.textBoxZakresDo.Size = new System.Drawing.Size(132, 22);
            this.textBoxZakresDo.TabIndex = 1;
            // 
            // textBoxZakresOd
            // 
            this.textBoxZakresOd.Location = new System.Drawing.Point(93, 23);
            this.textBoxZakresOd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxZakresOd.Name = "textBoxZakresOd";
            this.textBoxZakresOd.Size = new System.Drawing.Size(132, 22);
            this.textBoxZakresOd.TabIndex = 0;
            // 
            // groupBoxWylosowano
            // 
            this.groupBoxWylosowano.Controls.Add(this.buttonPoddajSie);
            this.groupBoxWylosowano.Controls.Add(this.buttonSprawdz);
            this.groupBoxWylosowano.Controls.Add(this.textBoxLiczba);
            this.groupBoxWylosowano.Location = new System.Drawing.Point(16, 222);
            this.groupBoxWylosowano.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxWylosowano.Name = "groupBoxWylosowano";
            this.groupBoxWylosowano.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxWylosowano.Size = new System.Drawing.Size(564, 202);
            this.groupBoxWylosowano.TabIndex = 2;
            this.groupBoxWylosowano.TabStop = false;
            this.groupBoxWylosowano.Text = "Wylosowano liczbę. Odgadnij ją!";
            this.groupBoxWylosowano.Visible = false;
            // 
            // buttonPoddajSie
            // 
            this.buttonPoddajSie.Location = new System.Drawing.Point(319, 30);
            this.buttonPoddajSie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPoddajSie.Name = "buttonPoddajSie";
            this.buttonPoddajSie.Size = new System.Drawing.Size(107, 34);
            this.buttonPoddajSie.TabIndex = 5;
            this.buttonPoddajSie.Text = "Poddaj się";
            this.buttonPoddajSie.UseVisualStyleBackColor = true;
            this.buttonPoddajSie.Click += new System.EventHandler(this.buttonPoddajSie_Click);
            // 
            // buttonSprawdz
            // 
            this.buttonSprawdz.Location = new System.Drawing.Point(206, 30);
            this.buttonSprawdz.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSprawdz.Name = "buttonSprawdz";
            this.buttonSprawdz.Size = new System.Drawing.Size(107, 34);
            this.buttonSprawdz.TabIndex = 4;
            this.buttonSprawdz.Text = "Sprawdź";
            this.buttonSprawdz.UseVisualStyleBackColor = true;
            this.buttonSprawdz.Click += new System.EventHandler(this.buttonSprawdz_Click);
            // 
            // textBoxLiczba
            // 
            this.textBoxLiczba.Location = new System.Drawing.Point(34, 36);
            this.textBoxLiczba.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxLiczba.Name = "textBoxLiczba";
            this.textBoxLiczba.Size = new System.Drawing.Size(132, 22);
            this.textBoxLiczba.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 644);
            this.Controls.Add(this.groupBoxWylosowano);
            this.Controls.Add(this.groupBoxLosuj);
            this.Controls.Add(this.buttonNowaGra);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBoxLosuj.ResumeLayout(false);
            this.groupBoxLosuj.PerformLayout();
            this.groupBoxWylosowano.ResumeLayout(false);
            this.groupBoxWylosowano.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonNowaGra;
        private System.Windows.Forms.GroupBox groupBoxLosuj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxZakresDo;
        private System.Windows.Forms.TextBox textBoxZakresOd;
        private System.Windows.Forms.Button buttonLosuj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxWylosowano;
        private System.Windows.Forms.TextBox textBoxLiczba;
        private System.Windows.Forms.Button buttonSprawdz;
        private System.Windows.Forms.Button buttonPoddajSie;
    }
}