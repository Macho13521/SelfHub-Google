
namespace OurSelf
{
    partial class Logowanie
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
            this.button1 = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.TextBox();
            this.haslo = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.wiek = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.identyfikator = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pobranywiek = new System.Windows.Forms.NumericUpDown();
            this.pobranyemail = new System.Windows.Forms.TextBox();
            this.pobranehaslo = new System.Windows.Forms.TextBox();
            this.pobranylogin = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.komorka = new System.Windows.Forms.TextBox();
            this.szukanepole = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.szukanawartosc = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.szukanyciag = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.pole2 = new System.Windows.Forms.TextBox();
            this.znalezionyciag = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.wiek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pobranywiek)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(101, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_ClickAsync);
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(101, 41);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(100, 20);
            this.login.TabIndex = 1;
            // 
            // haslo
            // 
            this.haslo.Location = new System.Drawing.Point(101, 104);
            this.haslo.Name = "haslo";
            this.haslo.Size = new System.Drawing.Size(100, 20);
            this.haslo.TabIndex = 2;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(101, 164);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(100, 20);
            this.email.TabIndex = 3;
            // 
            // wiek
            // 
            this.wiek.Location = new System.Drawing.Point(101, 223);
            this.wiek.Name = "wiek";
            this.wiek.Size = new System.Drawing.Size(100, 20);
            this.wiek.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Login:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Haslo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "wiek:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(612, 353);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Pobierz";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_ClickAsync);
            // 
            // identyfikator
            // 
            this.identyfikator.Location = new System.Drawing.Point(603, 307);
            this.identyfikator.Name = "identyfikator";
            this.identyfikator.Size = new System.Drawing.Size(169, 20);
            this.identyfikator.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(569, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(739, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "wiek:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(736, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "email:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(736, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Haslo:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(736, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Login:";
            // 
            // pobranywiek
            // 
            this.pobranywiek.Location = new System.Drawing.Point(804, 213);
            this.pobranywiek.Name = "pobranywiek";
            this.pobranywiek.Size = new System.Drawing.Size(185, 20);
            this.pobranywiek.TabIndex = 17;
            // 
            // pobranyemail
            // 
            this.pobranyemail.Location = new System.Drawing.Point(804, 154);
            this.pobranyemail.Name = "pobranyemail";
            this.pobranyemail.Size = new System.Drawing.Size(185, 20);
            this.pobranyemail.TabIndex = 16;
            // 
            // pobranehaslo
            // 
            this.pobranehaslo.Location = new System.Drawing.Point(804, 94);
            this.pobranehaslo.Name = "pobranehaslo";
            this.pobranehaslo.Size = new System.Drawing.Size(185, 20);
            this.pobranehaslo.TabIndex = 15;
            // 
            // pobranylogin
            // 
            this.pobranylogin.Location = new System.Drawing.Point(804, 31);
            this.pobranylogin.Name = "pobranylogin";
            this.pobranylogin.Size = new System.Drawing.Size(185, 20);
            this.pobranylogin.TabIndex = 14;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(804, 308);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(160, 23);
            this.button3.TabIndex = 22;
            this.button3.Text = "Aktualizuj";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(804, 353);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(160, 23);
            this.button4.TabIndex = 23;
            this.button4.Text = "Usuń";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(546, 138);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 24;
            this.button5.Text = "Usuń Pole";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // komorka
            // 
            this.komorka.Location = new System.Drawing.Point(534, 105);
            this.komorka.Name = "komorka";
            this.komorka.Size = new System.Drawing.Size(109, 20);
            this.komorka.TabIndex = 25;
            // 
            // szukanepole
            // 
            this.szukanepole.Location = new System.Drawing.Point(101, 439);
            this.szukanepole.Name = "szukanepole";
            this.szukanepole.Size = new System.Drawing.Size(100, 20);
            this.szukanepole.TabIndex = 26;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(177, 483);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 27;
            this.button6.Text = "SzukajID";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // szukanawartosc
            // 
            this.szukanawartosc.Location = new System.Drawing.Point(224, 439);
            this.szukanawartosc.Name = "szukanawartosc";
            this.szukanawartosc.Size = new System.Drawing.Size(100, 20);
            this.szukanawartosc.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(136, 423);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Pole";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(252, 423);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "Wartość";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(539, 470);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 35;
            this.label12.Text = "Wartość";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(423, 470);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 13);
            this.label13.TabIndex = 34;
            this.label13.Text = "Pole";
            // 
            // szukanyciag
            // 
            this.szukanyciag.Location = new System.Drawing.Point(511, 486);
            this.szukanyciag.Name = "szukanyciag";
            this.szukanyciag.Size = new System.Drawing.Size(100, 20);
            this.szukanyciag.TabIndex = 33;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(458, 460);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 32;
            this.button7.Text = "Znajdź";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // pole2
            // 
            this.pole2.Location = new System.Drawing.Point(388, 486);
            this.pole2.Name = "pole2";
            this.pole2.Size = new System.Drawing.Size(100, 20);
            this.pole2.TabIndex = 31;
            // 
            // znalezionyciag
            // 
            this.znalezionyciag.AutoSize = true;
            this.znalezionyciag.Location = new System.Drawing.Point(460, 518);
            this.znalezionyciag.Name = "znalezionyciag";
            this.znalezionyciag.Size = new System.Drawing.Size(73, 13);
            this.znalezionyciag.TabIndex = 36;
            this.znalezionyciag.Text = "ID Znalezione";
            // 
            // Logowanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 606);
            this.Controls.Add(this.znalezionyciag);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.szukanyciag);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.pole2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.szukanawartosc);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.szukanepole);
            this.Controls.Add(this.komorka);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pobranywiek);
            this.Controls.Add(this.pobranyemail);
            this.Controls.Add(this.pobranehaslo);
            this.Controls.Add(this.pobranylogin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.identyfikator);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wiek);
            this.Controls.Add(this.email);
            this.Controls.Add(this.haslo);
            this.Controls.Add(this.login);
            this.Controls.Add(this.button1);
            this.Name = "Logowanie";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wiek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pobranywiek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TextBox haslo;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.NumericUpDown wiek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox identyfikator;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown pobranywiek;
        private System.Windows.Forms.TextBox pobranyemail;
        private System.Windows.Forms.TextBox pobranehaslo;
        private System.Windows.Forms.TextBox pobranylogin;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox komorka;
        private System.Windows.Forms.TextBox szukanepole;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox szukanawartosc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox szukanyciag;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox pole2;
        private System.Windows.Forms.Label znalezionyciag;
    }
}

