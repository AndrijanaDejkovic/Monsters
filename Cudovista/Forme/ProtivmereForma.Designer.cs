namespace Cudovista.Forme
{
    partial class ProtivmereForma
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
            this.listProtivmere = new System.Windows.Forms.ListView();
            this.Naziv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Opis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Uslovi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Id_cudovista = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dodajProtivmeru = new System.Windows.Forms.Button();
            this.obrisiProtivmeru = new System.Windows.Forms.Button();
            this.azurirajProtivmeru = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listProtivmere
            // 
            this.listProtivmere.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Naziv,
            this.Opis,
            this.Uslovi,
            this.Id_cudovista});
            this.listProtivmere.HideSelection = false;
            this.listProtivmere.Location = new System.Drawing.Point(56, 39);
            this.listProtivmere.Name = "listProtivmere";
            this.listProtivmere.Size = new System.Drawing.Size(434, 375);
            this.listProtivmere.TabIndex = 0;
            this.listProtivmere.UseCompatibleStateImageBehavior = false;
            this.listProtivmere.SelectedIndexChanged += new System.EventHandler(this.listProtivmere_SelectedIndexChanged);
            // 
            // Naziv
            // 
            this.Naziv.Text = "Naziv";
            // 
            // Opis
            // 
            this.Opis.Text = "Opis";
            // 
            // Uslovi
            // 
            this.Uslovi.Text = "Uslovi";
            // 
            // Id_cudovista
            // 
            this.Id_cudovista.Text = "Id_cudovista";
            // 
            // dodajProtivmeru
            // 
            this.dodajProtivmeru.Location = new System.Drawing.Point(518, 48);
            this.dodajProtivmeru.Name = "dodajProtivmeru";
            this.dodajProtivmeru.Size = new System.Drawing.Size(140, 52);
            this.dodajProtivmeru.TabIndex = 1;
            this.dodajProtivmeru.Text = "dodajProtivmeru";
            this.dodajProtivmeru.UseVisualStyleBackColor = true;
            this.dodajProtivmeru.Click += new System.EventHandler(this.button1_Click);
            // 
            // obrisiProtivmeru
            // 
            this.obrisiProtivmeru.Location = new System.Drawing.Point(518, 125);
            this.obrisiProtivmeru.Name = "obrisiProtivmeru";
            this.obrisiProtivmeru.Size = new System.Drawing.Size(140, 52);
            this.obrisiProtivmeru.TabIndex = 2;
            this.obrisiProtivmeru.Text = "obrisiProtivmeru";
            this.obrisiProtivmeru.UseVisualStyleBackColor = true;
            this.obrisiProtivmeru.Click += new System.EventHandler(this.obrisiProtivmeru_Click);
            // 
            // azurirajProtivmeru
            // 
            this.azurirajProtivmeru.Location = new System.Drawing.Point(518, 202);
            this.azurirajProtivmeru.Name = "azurirajProtivmeru";
            this.azurirajProtivmeru.Size = new System.Drawing.Size(139, 59);
            this.azurirajProtivmeru.TabIndex = 3;
            this.azurirajProtivmeru.Text = "azurirajProtivmeru";
            this.azurirajProtivmeru.UseVisualStyleBackColor = true;
            this.azurirajProtivmeru.Click += new System.EventHandler(this.azurirajProtivmeru_Click);
            // 
            // ProtivmereForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.azurirajProtivmeru);
            this.Controls.Add(this.obrisiProtivmeru);
            this.Controls.Add(this.dodajProtivmeru);
            this.Controls.Add(this.listProtivmere);
            this.Name = "ProtivmereForma";
            this.Text = "ProtivmereForma";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listProtivmere;
        private System.Windows.Forms.ColumnHeader Naziv;
        private System.Windows.Forms.ColumnHeader Opis;
        private System.Windows.Forms.ColumnHeader Uslovi;
        private System.Windows.Forms.ColumnHeader Id_cudovista;
        private System.Windows.Forms.Button dodajProtivmeru;
        private System.Windows.Forms.Button obrisiProtivmeru;
        private System.Windows.Forms.Button azurirajProtivmeru;
    }
}