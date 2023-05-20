namespace Cudovista.Forme
{
    partial class ZastitaForma
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
            this.listZastita = new System.Windows.Forms.ListView();
            this.Naziv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tip_zastite = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Id_lokacije = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dodajDuha = new System.Windows.Forms.Button();
            this.dodajZmaja = new System.Windows.Forms.Button();
            this.obrisiZastitu = new System.Windows.Forms.Button();
            this.dodajKletvu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listZastita
            // 
            this.listZastita.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Naziv,
            this.Tip_zastite,
            this.Id_lokacije});
            this.listZastita.HideSelection = false;
            this.listZastita.Location = new System.Drawing.Point(45, 36);
            this.listZastita.Name = "listZastita";
            this.listZastita.Size = new System.Drawing.Size(453, 371);
            this.listZastita.TabIndex = 0;
            this.listZastita.UseCompatibleStateImageBehavior = false;
            this.listZastita.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Naziv
            // 
            this.Naziv.Text = "Naziv";
            // 
            // Tip_zastite
            // 
            this.Tip_zastite.Text = "Tip_zastite";
            // 
            // Id_lokacije
            // 
            this.Id_lokacije.Text = "Id_lokacije";
            // 
            // dodajDuha
            // 
            this.dodajDuha.Location = new System.Drawing.Point(521, 36);
            this.dodajDuha.Name = "dodajDuha";
            this.dodajDuha.Size = new System.Drawing.Size(90, 44);
            this.dodajDuha.TabIndex = 1;
            this.dodajDuha.Text = "dodajDuha";
            this.dodajDuha.UseVisualStyleBackColor = true;
            this.dodajDuha.Click += new System.EventHandler(this.dodajDuha_Click);
            // 
            // dodajZmaja
            // 
            this.dodajZmaja.Location = new System.Drawing.Point(521, 102);
            this.dodajZmaja.Name = "dodajZmaja";
            this.dodajZmaja.Size = new System.Drawing.Size(90, 39);
            this.dodajZmaja.TabIndex = 4;
            this.dodajZmaja.Text = "dodajZmaja";
            this.dodajZmaja.UseVisualStyleBackColor = true;
            this.dodajZmaja.Click += new System.EventHandler(this.dodajZmaja_Click);
            // 
            // obrisiZastitu
            // 
            this.obrisiZastitu.Location = new System.Drawing.Point(698, 102);
            this.obrisiZastitu.Name = "obrisiZastitu";
            this.obrisiZastitu.Size = new System.Drawing.Size(109, 39);
            this.obrisiZastitu.TabIndex = 5;
            this.obrisiZastitu.Text = "obrisiZastitu";
            this.obrisiZastitu.UseVisualStyleBackColor = true;
            this.obrisiZastitu.Click += new System.EventHandler(this.obrisiZmaja_Click);
            // 
            // dodajKletvu
            // 
            this.dodajKletvu.Location = new System.Drawing.Point(521, 167);
            this.dodajKletvu.Name = "dodajKletvu";
            this.dodajKletvu.Size = new System.Drawing.Size(90, 43);
            this.dodajKletvu.TabIndex = 7;
            this.dodajKletvu.Text = "dodajKletvu";
            this.dodajKletvu.UseVisualStyleBackColor = true;
            this.dodajKletvu.Click += new System.EventHandler(this.dodajKletvu_Click);
            // 
            // ZastitaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(887, 506);
            this.Controls.Add(this.dodajKletvu);
            this.Controls.Add(this.obrisiZastitu);
            this.Controls.Add(this.dodajZmaja);
            this.Controls.Add(this.dodajDuha);
            this.Controls.Add(this.listZastita);
            this.Name = "ZastitaForma";
            this.Text = "Zastita";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listZastita;
        private System.Windows.Forms.ColumnHeader Naziv;
        private System.Windows.Forms.ColumnHeader Tip_zastite;
        private System.Windows.Forms.ColumnHeader Id_lokacije;
        private System.Windows.Forms.Button dodajDuha;
        private System.Windows.Forms.Button dodajZmaja;
        private System.Windows.Forms.Button obrisiZastitu;
        private System.Windows.Forms.Button dodajKletvu;
    }
}