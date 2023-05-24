namespace Cudovista.Forme
{
    partial class SvaNemagijskaCudovistaForma
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
            this.listaNemagijskih = new System.Windows.Forms.ListView();
            this.BrojOciju = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BrojGlava = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BrojEkstremiteta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Duzina = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tezina = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ZiviUVodi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Leti = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ImaRep = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Otrovno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ImaKandze = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.btnObrisiNemagijskoCudoviste = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listaNemagijskih
            // 
            this.listaNemagijskih.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.BrojOciju,
            this.BrojGlava,
            this.BrojEkstremiteta,
            this.Duzina,
            this.Tezina,
            this.ZiviUVodi,
            this.Leti,
            this.ImaRep,
            this.Otrovno,
            this.ImaKandze});
            this.listaNemagijskih.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listaNemagijskih.HideSelection = false;
            this.listaNemagijskih.Location = new System.Drawing.Point(77, 50);
            this.listaNemagijskih.Margin = new System.Windows.Forms.Padding(6);
            this.listaNemagijskih.Name = "listaNemagijskih";
            this.listaNemagijskih.Size = new System.Drawing.Size(888, 717);
            this.listaNemagijskih.TabIndex = 0;
            this.listaNemagijskih.UseCompatibleStateImageBehavior = false;
            this.listaNemagijskih.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // BrojOciju
            // 
            this.BrojOciju.Text = "BrojOciju";
            // 
            // BrojGlava
            // 
            this.BrojGlava.Text = "BrojGlava";
            // 
            // BrojEkstremiteta
            // 
            this.BrojEkstremiteta.Text = "BrojEkstremiteta";
            // 
            // Duzina
            // 
            this.Duzina.Text = "Duzina";
            // 
            // Tezina
            // 
            this.Tezina.Text = "Tezina";
            // 
            // ZiviUVodi
            // 
            this.ZiviUVodi.Text = "ZiviUVodi";
            // 
            // Leti
            // 
            this.Leti.Text = "Leti";
            // 
            // ImaRep
            // 
            this.ImaRep.Text = "ImaRep";
            // 
            // Otrovno
            // 
            this.Otrovno.Text = "Otrovno";
            // 
            // ImaKandze
            // 
            this.ImaKandze.Text = "ImaKandze";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1003, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(442, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = " Za brisanje cudovista, selektujte cudoviste.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnObrisiNemagijskoCudoviste
            // 
            this.btnObrisiNemagijskoCudoviste.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiNemagijskoCudoviste.Location = new System.Drawing.Point(1053, 150);
            this.btnObrisiNemagijskoCudoviste.Margin = new System.Windows.Forms.Padding(6);
            this.btnObrisiNemagijskoCudoviste.Name = "btnObrisiNemagijskoCudoviste";
            this.btnObrisiNemagijskoCudoviste.Size = new System.Drawing.Size(350, 122);
            this.btnObrisiNemagijskoCudoviste.TabIndex = 2;
            this.btnObrisiNemagijskoCudoviste.Text = "Obrisi";
            this.btnObrisiNemagijskoCudoviste.UseVisualStyleBackColor = true;
            this.btnObrisiNemagijskoCudoviste.Click += new System.EventHandler(this.btnObrisiNemagijskoCudoviste_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnDodaj.Location = new System.Drawing.Point(1067, 306);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(336, 101);
            this.btnDodaj.TabIndex = 3;
            this.btnDodaj.Text = "Dodaj Nemagijsko";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnIzmeni.Location = new System.Drawing.Point(1067, 432);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(336, 112);
            this.btnIzmeni.TabIndex = 4;
            this.btnIzmeni.Text = "Izmeni Nemagijsko";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // SvaNemagijskaCudovistaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1467, 831);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnObrisiNemagijskoCudoviste);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listaNemagijskih);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "SvaNemagijskaCudovistaForma";
            this.Text = "SvaNemagijskaCudovistaForma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listaNemagijskih;
        private System.Windows.Forms.ColumnHeader BrojOciju;
        private System.Windows.Forms.ColumnHeader BrojGlava;
        private System.Windows.Forms.ColumnHeader BrojEkstremiteta;
        private System.Windows.Forms.ColumnHeader Duzina;
        private System.Windows.Forms.ColumnHeader Tezina;
        private System.Windows.Forms.ColumnHeader ZiviUVodi;
        private System.Windows.Forms.ColumnHeader Leti;
        private System.Windows.Forms.ColumnHeader ImaRep;
        private System.Windows.Forms.ColumnHeader Otrovno;
        private System.Windows.Forms.ColumnHeader ImaKandze;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnObrisiNemagijskoCudoviste;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnIzmeni;
    }
}