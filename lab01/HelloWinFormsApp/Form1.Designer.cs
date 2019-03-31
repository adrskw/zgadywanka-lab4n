namespace HelloWinFormsApp
{
    partial class Form1
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
            this.labelImie = new System.Windows.Forms.Label();
            this.textBoxImie = new System.Windows.Forms.TextBox();
            this.labelNazwisko = new System.Windows.Forms.Label();
            this.textBoxNazwisko = new System.Windows.Forms.TextBox();
            this.labelWiek = new System.Windows.Forms.Label();
            this.textBoxWiek = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.labelKomunikat1 = new System.Windows.Forms.Label();
            this.labelKomunikat2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelImie
            // 
            this.labelImie.AutoSize = true;
            this.labelImie.Location = new System.Drawing.Point(27, 29);
            this.labelImie.Name = "labelImie";
            this.labelImie.Size = new System.Drawing.Size(25, 13);
            this.labelImie.TabIndex = 0;
            this.labelImie.Text = "imię";
            // 
            // textBoxImie
            // 
            this.textBoxImie.Location = new System.Drawing.Point(81, 26);
            this.textBoxImie.Name = "textBoxImie";
            this.textBoxImie.Size = new System.Drawing.Size(100, 20);
            this.textBoxImie.TabIndex = 1;
            // 
            // labelNazwisko
            // 
            this.labelNazwisko.AutoSize = true;
            this.labelNazwisko.Location = new System.Drawing.Point(27, 60);
            this.labelNazwisko.Name = "labelNazwisko";
            this.labelNazwisko.Size = new System.Drawing.Size(51, 13);
            this.labelNazwisko.TabIndex = 2;
            this.labelNazwisko.Text = "nazwisko";
            // 
            // textBoxNazwisko
            // 
            this.textBoxNazwisko.Location = new System.Drawing.Point(81, 57);
            this.textBoxNazwisko.Name = "textBoxNazwisko";
            this.textBoxNazwisko.Size = new System.Drawing.Size(100, 20);
            this.textBoxNazwisko.TabIndex = 3;
            // 
            // labelWiek
            // 
            this.labelWiek.AutoSize = true;
            this.labelWiek.Location = new System.Drawing.Point(27, 93);
            this.labelWiek.Name = "labelWiek";
            this.labelWiek.Size = new System.Drawing.Size(29, 13);
            this.labelWiek.TabIndex = 4;
            this.labelWiek.Text = "wiek";
            // 
            // textBoxWiek
            // 
            this.textBoxWiek.Location = new System.Drawing.Point(81, 90);
            this.textBoxWiek.Name = "textBoxWiek";
            this.textBoxWiek.Size = new System.Drawing.Size(100, 20);
            this.textBoxWiek.TabIndex = 5;
            this.textBoxWiek.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(81, 129);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 6;
            this.buttonOK.Text = "Kliknij";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // labelKomunikat1
            // 
            this.labelKomunikat1.AutoSize = true;
            this.labelKomunikat1.Location = new System.Drawing.Point(27, 165);
            this.labelKomunikat1.Name = "labelKomunikat1";
            this.labelKomunikat1.Size = new System.Drawing.Size(66, 13);
            this.labelKomunikat1.TabIndex = 7;
            this.labelKomunikat1.Text = "Komunikat 1";
            // 
            // labelKomunikat2
            // 
            this.labelKomunikat2.AutoSize = true;
            this.labelKomunikat2.Location = new System.Drawing.Point(27, 195);
            this.labelKomunikat2.Name = "labelKomunikat2";
            this.labelKomunikat2.Size = new System.Drawing.Size(66, 13);
            this.labelKomunikat2.TabIndex = 8;
            this.labelKomunikat2.Text = "Komunikat 2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 233);
            this.Controls.Add(this.labelKomunikat2);
            this.Controls.Add(this.labelKomunikat1);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBoxWiek);
            this.Controls.Add(this.labelWiek);
            this.Controls.Add(this.textBoxNazwisko);
            this.Controls.Add(this.labelNazwisko);
            this.Controls.Add(this.textBoxImie);
            this.Controls.Add(this.labelImie);
            this.Name = "Form1";
            this.Text = "Aplikacja Witaj";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelImie;
        private System.Windows.Forms.TextBox textBoxImie;
        private System.Windows.Forms.Label labelNazwisko;
        private System.Windows.Forms.TextBox textBoxNazwisko;
        private System.Windows.Forms.Label labelWiek;
        private System.Windows.Forms.TextBox textBoxWiek;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label labelKomunikat1;
        private System.Windows.Forms.Label labelKomunikat2;
    }
}

