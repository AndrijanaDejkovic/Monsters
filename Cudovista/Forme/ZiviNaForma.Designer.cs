namespace Cudovista.Forme
{
    partial class ZiviNaForma
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
            this.listZiviNa = new System.Windows.Forms.ListView();
            this.PredstavnikZivi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lokacijaZivota = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dodajZiviNa = new System.Windows.Forms.Button();
            this.obrisiZiviNa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listZiviNa
            // 
            this.listZiviNa.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PredstavnikZivi,
            this.lokacijaZivota});
            this.listZiviNa.HideSelection = false;
            this.listZiviNa.Location = new System.Drawing.Point(39, 41);
            this.listZiviNa.Name = "listZiviNa";
            this.listZiviNa.Size = new System.Drawing.Size(460, 371);
            this.listZiviNa.TabIndex = 0;
            this.listZiviNa.UseCompatibleStateImageBehavior = false;
            this.listZiviNa.SelectedIndexChanged += new System.EventHandler(this.listZiviNa_SelectedIndexChanged);
            // 
            // PredstavnikZivi
            // 
            this.PredstavnikZivi.Text = "PredstavnikZivi";
            // 
            // lokacijaZivota
            // 
            this.lokacijaZivota.Text = "lokacijaZivota";
            // 
            // dodajZiviNa
            // 
            this.dodajZiviNa.Location = new System.Drawing.Point(576, 106);
            this.dodajZiviNa.Name = "dodajZiviNa";
            this.dodajZiviNa.Size = new System.Drawing.Size(121, 48);
            this.dodajZiviNa.TabIndex = 1;
            this.dodajZiviNa.Text = "dodajZiviNa";
            this.dodajZiviNa.UseVisualStyleBackColor = true;
            this.dodajZiviNa.Click += new System.EventHandler(this.dodajZiviNa_Click);
            // 
            // obrisiZiviNa
            // 
            this.obrisiZiviNa.Location = new System.Drawing.Point(576, 225);
            this.obrisiZiviNa.Name = "obrisiZiviNa";
            this.obrisiZiviNa.Size = new System.Drawing.Size(121, 54);
            this.obrisiZiviNa.TabIndex = 2;
            this.obrisiZiviNa.Text = "obrisiZiviNa";
            this.obrisiZiviNa.UseVisualStyleBackColor = true;
            this.obrisiZiviNa.Click += new System.EventHandler(this.obrisiZiviNa_Click);
            // 
            // ZiviNaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.obrisiZiviNa);
            this.Controls.Add(this.dodajZiviNa);
            this.Controls.Add(this.listZiviNa);
            this.Name = "ZiviNaForma";
            this.Text = "ZiviNaForma";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listZiviNa;
        private System.Windows.Forms.Button dodajZiviNa;
        private System.Windows.Forms.Button obrisiZiviNa;
        private System.Windows.Forms.ColumnHeader PredstavnikZivi;
        private System.Windows.Forms.ColumnHeader lokacijaZivota;
    }
}