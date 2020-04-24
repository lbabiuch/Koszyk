namespace WindowsFormsApp2
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.koszyk = new System.Windows.Forms.PictureBox();
            this.koszt = new System.Windows.Forms.Label();
            this.ilosc = new System.Windows.Forms.TextBox();
            this.productUserControl1 = new WindowsFormsApp2.ProductUserControl();
            ((System.ComponentModel.ISupportInitialize)(this.koszyk)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Produkt 1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(24, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Produkt 2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(24, 70);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Produkt 3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(24, 99);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Produkt 4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(24, 128);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "Produkt 5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(24, 157);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 5;
            this.button6.Text = "Produkt 6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // koszyk
            // 
            this.koszyk.Location = new System.Drawing.Point(719, 24);
            this.koszyk.Name = "koszyk";
            this.koszyk.Size = new System.Drawing.Size(40, 40);
            this.koszyk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.koszyk.TabIndex = 7;
            this.koszyk.TabStop = false;
            this.koszyk.Click += new System.EventHandler(this.koszyk_Click);
            // 
            // koszt
            // 
            this.koszt.AutoSize = true;
            this.koszt.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.koszt.Location = new System.Drawing.Point(673, 99);
            this.koszt.Name = "koszt";
            this.koszt.Size = new System.Drawing.Size(14, 15);
            this.koszt.TabIndex = 8;
            this.koszt.Text = "0";
            // 
            // ilosc
            // 
            this.ilosc.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ilosc.Location = new System.Drawing.Point(683, 24);
            this.ilosc.Name = "ilosc";
            this.ilosc.Size = new System.Drawing.Size(30, 29);
            this.ilosc.TabIndex = 10;
            this.ilosc.Text = "1";
            this.ilosc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // productUserControl1
            // 
            this.productUserControl1.Location = new System.Drawing.Point(120, 12);
            this.productUserControl1.Name = "productUserControl1";
            this.productUserControl1.Size = new System.Drawing.Size(547, 412);
            this.productUserControl1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ilosc);
            this.Controls.Add(this.koszt);
            this.Controls.Add(this.koszyk);
            this.Controls.Add(this.productUserControl1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.koszyk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private ProductUserControl productUserControl1;
        private System.Windows.Forms.PictureBox koszyk;
        private System.Windows.Forms.Label koszt;
        private System.Windows.Forms.TextBox ilosc;
    }
}

