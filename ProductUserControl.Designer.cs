namespace WindowsFormsApp2
{
    partial class ProductUserControl
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

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.pbxImage = new System.Windows.Forms.PictureBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblkategoria = new System.Windows.Forms.Label();
            this.lblcena = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblName.Location = new System.Drawing.Point(15, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 24);
            this.lblName.TabIndex = 0;
            // 
            // pbxImage
            // 
            this.pbxImage.Location = new System.Drawing.Point(11, 56);
            this.pbxImage.Name = "pbxImage";
            this.pbxImage.Size = new System.Drawing.Size(176, 146);
            this.pbxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxImage.TabIndex = 1;
            this.pbxImage.TabStop = false;
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(8, 222);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(335, 99);
            this.lblDescription.TabIndex = 2;
            // 
            // lblkategoria
            // 
            this.lblkategoria.AutoSize = true;
            this.lblkategoria.Location = new System.Drawing.Point(16, 29);
            this.lblkategoria.Name = "lblkategoria";
            this.lblkategoria.Size = new System.Drawing.Size(0, 13);
            this.lblkategoria.TabIndex = 3;
            // 
            // lblcena
            // 
            this.lblcena.AutoSize = true;
            this.lblcena.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblcena.Location = new System.Drawing.Point(212, 43);
            this.lblcena.Name = "lblcena";
            this.lblcena.Size = new System.Drawing.Size(0, 19);
            this.lblcena.TabIndex = 4;
            // 
            // ProductUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblcena);
            this.Controls.Add(this.lblkategoria);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.pbxImage);
            this.Controls.Add(this.lblName);
            this.Name = "ProductUserControl";
            this.Size = new System.Drawing.Size(381, 321);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox pbxImage;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblkategoria;
        private System.Windows.Forms.Label lblcena;
    }
}
