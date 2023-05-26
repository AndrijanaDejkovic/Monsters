namespace Cudovista.Forme
{
    partial class CudovisteForma
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
            this.Lista_Cudovista = new System.Windows.Forms.GroupBox();
            this.listaCudovista = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Naziv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Vek = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Podtip = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Da_li_postoji = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDodajCudoviste = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnSposobnost = new System.Windows.Forms.Button();
            this.btnIzlistaj = new System.Windows.Forms.Button();
            this.Lista_Cudovista.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lista_Cudovista
            // 
            this.Lista_Cudovista.Controls.Add(this.listaCudovista);
            this.Lista_Cudovista.Location = new System.Drawing.Point(0, 0);
            this.Lista_Cudovista.Name = "Lista_Cudovista";
            this.Lista_Cudovista.Size = new System.Drawing.Size(697, 438);
            this.Lista_Cudovista.TabIndex = 0;
            this.Lista_Cudovista.TabStop = false;
            this.Lista_Cudovista.Text = "Lista_Cudovista";
            this.Lista_Cudovista.Enter += new System.EventHandler(this.Lista_Cudovista_Enter);
            // 
            // listaCudovista
            // 
            this.listaCudovista.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.Naziv,
            this.Vek,
            this.Podtip,
            this.Da_li_postoji});
            this.listaCudovista.HideSelection = false;
            this.listaCudovista.Location = new System.Drawing.Point(11, 46);
            this.listaCudovista.Margin = new System.Windows.Forms.Padding(6);
            this.listaCudovista.Name = "listaCudovista";
            this.listaCudovista.Size = new System.Drawing.Size(925, 576);
            this.listaCudovista.TabIndex = 4;
            this.listaCudovista.TileSize = new System.Drawing.Size(320, 52);
            this.listaCudovista.UseCompatibleStateImageBehavior = false;
            this.listaCudovista.View = System.Windows.Forms.View.Details;
            this.listaCudovista.SelectedIndexChanged += new System.EventHandler(this.btnObrisi_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 57;
            // 
            // Naziv
            // 
            this.Naziv.Text = "Naziv";
            // 
            // Vek
            // 
            this.Vek.Text = "Vek";
            // 
            // Podtip
            // 
            this.Podtip.Text = "Podtip";
            this.Podtip.Width = 86;
            // 
            // Da_li_postoji
            // 
            this.Da_li_postoji.Text = "Da_li_postoji";
            this.Da_li_postoji.Width = 227;
            // 
            // btnDodajCudoviste
            // 
            this.btnDodajCudoviste.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnDodajCudoviste.Location = new System.Drawing.Point(822, 93);
            this.btnDodajCudoviste.Name = "btnDodajCudoviste";
            this.btnDodajCudoviste.Size = new System.Drawing.Size(169, 60);
            this.btnDodajCudoviste.TabIndex = 0;
            this.btnDodajCudoviste.Text = "Dodaj Cudoviste";
            this.btnDodajCudoviste.UseVisualStyleBackColor = true;
            this.btnDodajCudoviste.Click += new System.EventHandler(this.btnDodajCudoviste_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnObrisi.Location = new System.Drawing.Point(822, 183);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(175, 49);
            this.btnObrisi.TabIndex = 1;
            this.btnObrisi.Text = "Obrisi ";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnIzmeni.Location = new System.Drawing.Point(822, 249);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(175, 48);
            this.btnIzmeni.TabIndex = 2;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // btnSposobnost
            // 
            this.btnSposobnost.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnSposobnost.Location = new System.Drawing.Point(787, 325);
            this.btnSposobnost.Name = "btnSposobnost";
            this.btnSposobnost.Size = new System.Drawing.Size(243, 113);
            this.btnSposobnost.TabIndex = 3;
            this.btnSposobnost.Text = "Dodaj sposobnost cudovistu";
            this.btnSposobnost.UseVisualStyleBackColor = true;
            this.btnSposobnost.Click += new System.EventHandler(this.btnSposobnost_Click);
            // 
            // btnIzlistaj
            // 
            this.btnIzlistaj.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnIzlistaj.Location = new System.Drawing.Point(787, 456);
            this.btnIzlistaj.Name = "btnIzlistaj";
            this.btnIzlistaj.Size = new System.Drawing.Size(243, 54);
            this.btnIzlistaj.TabIndex = 4;
            this.btnIzlistaj.Text = "Sposobnosti cudovista";
            this.btnIzlistaj.UseVisualStyleBackColor = true;
            this.btnIzlistaj.Click += new System.EventHandler(this.btnIzlistaj_Click);
            // 
            // CudovisteForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1354, 660);
            this.Controls.Add(this.btnIzlistaj);
            this.Controls.Add(this.btnSposobnost);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnDodajCudoviste);
            this.Controls.Add(this.Lista_Cudovista);
            this.Name = "CudovisteForma";
            this.Text = "CudovisteForma";
            this.Load += new System.EventHandler(this.CudovisteForma_Load);
            this.Lista_Cudovista.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Lista_Cudovista;
        private System.Windows.Forms.Button btnDodajCudoviste;
        private System.Windows.Forms.ListView listaCudovista;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader Naziv;
        private System.Windows.Forms.ColumnHeader Vek;
        private System.Windows.Forms.ColumnHeader Podtip;
        private System.Windows.Forms.ColumnHeader Da_li_postoji;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnSposobnost;
        private System.Windows.Forms.Button btnIzlistaj;
    }
}