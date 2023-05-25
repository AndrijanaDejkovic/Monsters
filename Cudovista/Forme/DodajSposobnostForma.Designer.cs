namespace Cudovista.Forme
{
    partial class DodajSposobnostForma
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
            this.lblNaziv = new System.Windows.Forms.Label();
            this.lblOpis = new System.Windows.Forms.Label();
            this.lblOdbrambena = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtOdbrambena = new System.Windows.Forms.TextBox();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.btnDodajSposobnost = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(144, 100);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(171, 25);
            this.lblNaziv.TabIndex = 0;
            this.lblNaziv.Text = "Naziv sposobnosti";
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Location = new System.Drawing.Point(144, 147);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(58, 25);
            this.lblOpis.TabIndex = 1;
            this.lblOpis.Text = "Opis ";
            // 
            // lblOdbrambena
            // 
            this.lblOdbrambena.AutoSize = true;
            this.lblOdbrambena.Location = new System.Drawing.Point(144, 211);
            this.lblOdbrambena.Name = "lblOdbrambena";
            this.lblOdbrambena.Size = new System.Drawing.Size(185, 25);
            this.lblOdbrambena.TabIndex = 2;
            this.lblOdbrambena.Text = "Da li je odbrambena";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(406, 100);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(288, 29);
            this.txtNaziv.TabIndex = 3;
            // 
            // txtOdbrambena
            // 
            this.txtOdbrambena.Location = new System.Drawing.Point(407, 211);
            this.txtOdbrambena.Name = "txtOdbrambena";
            this.txtOdbrambena.Size = new System.Drawing.Size(61, 29);
            this.txtOdbrambena.TabIndex = 4;
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(406, 147);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(288, 29);
            this.txtOpis.TabIndex = 5;
            // 
            // btnDodajSposobnost
            // 
            this.btnDodajSposobnost.Location = new System.Drawing.Point(331, 330);
            this.btnDodajSposobnost.Name = "btnDodajSposobnost";
            this.btnDodajSposobnost.Size = new System.Drawing.Size(162, 64);
            this.btnDodajSposobnost.TabIndex = 6;
            this.btnDodajSposobnost.Text = "Dodaj sposobnost";
            this.btnDodajSposobnost.UseVisualStyleBackColor = true;
            this.btnDodajSposobnost.Click += new System.EventHandler(this.btnDodajSposobnost_Click);
            // 
            // DodajSposobnostForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(844, 515);
            this.Controls.Add(this.btnDodajSposobnost);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.txtOdbrambena);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.lblOdbrambena);
            this.Controls.Add(this.lblOpis);
            this.Controls.Add(this.lblNaziv);
            this.Name = "DodajSposobnostForma";
            this.Text = "DodajSposobnostForma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.Label lblOdbrambena;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtOdbrambena;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.Button btnDodajSposobnost;
    }
}