
namespace OurSelf
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
            this.components = new System.ComponentModel.Container();
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pobranywiek = new System.Windows.Forms.NumericUpDown();
            this.pobranyemail = new System.Windows.Forms.TextBox();
            this.pobranehaslo = new System.Windows.Forms.TextBox();
            this.pobranylogin = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
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
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.button2.Location = new System.Drawing.Point(411, 387);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Pobierz";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_ClickAsync);
            // 
            // identyfikator
            // 
            this.identyfikator.Location = new System.Drawing.Point(402, 341);
            this.identyfikator.Name = "identyfikator";
            this.identyfikator.Size = new System.Drawing.Size(169, 20);
            this.identyfikator.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(368, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "ID";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(538, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "wiek:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(535, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "email:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(535, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Haslo:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(535, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Login:";
            // 
            // pobranywiek
            // 
            this.pobranywiek.Location = new System.Drawing.Point(603, 247);
            this.pobranywiek.Name = "pobranywiek";
            this.pobranywiek.Size = new System.Drawing.Size(185, 20);
            this.pobranywiek.TabIndex = 17;
            // 
            // pobranyemail
            // 
            this.pobranyemail.Location = new System.Drawing.Point(603, 188);
            this.pobranyemail.Name = "pobranyemail";
            this.pobranyemail.Size = new System.Drawing.Size(185, 20);
            this.pobranyemail.TabIndex = 16;
            // 
            // pobranehaslo
            // 
            this.pobranehaslo.Location = new System.Drawing.Point(603, 128);
            this.pobranehaslo.Name = "pobranehaslo";
            this.pobranehaslo.Size = new System.Drawing.Size(185, 20);
            this.pobranehaslo.TabIndex = 15;
            // 
            // pobranylogin
            // 
            this.pobranylogin.Location = new System.Drawing.Point(603, 65);
            this.pobranylogin.Name = "pobranylogin";
            this.pobranylogin.Size = new System.Drawing.Size(185, 20);
            this.pobranylogin.TabIndex = 14;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(603, 342);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(160, 23);
            this.button3.TabIndex = 22;
            this.button3.Text = "Aktualizuj";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "Form1";
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
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown pobranywiek;
        private System.Windows.Forms.TextBox pobranyemail;
        private System.Windows.Forms.TextBox pobranehaslo;
        private System.Windows.Forms.TextBox pobranylogin;
        private System.Windows.Forms.Button button3;
    }
}

