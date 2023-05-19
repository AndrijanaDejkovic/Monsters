namespace Cudovista.Forme
{
    partial class PredstavnikForm
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
            this.listPredstavnik = new System.Windows.Forms.ListView();
            this.dodajPredstavnika = new System.Windows.Forms.Button();
            this.obrisiPredstavnika = new System.Windows.Forms.Button();
            this.azurirajPredstavnika = new System.Windows.Forms.Button();
            this.Ime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Starost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DatumSusreta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ishod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Id_cudovista = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Id_lokacije = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listPredstavnik
            // 
            this.listPredstavnik.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Ime,
            this.Starost,
            this.DatumSusreta,
            this.Ishod,
            this.Id_cudovista,
            this.Id_lokacije});
            this.listPredstavnik.HideSelection = false;
            this.listPredstavnik.Location = new System.Drawing.Point(41, 38);
            this.listPredstavnik.Name = "listPredstavnik";
            this.listPredstavnik.Size = new System.Drawing.Size(471, 364);
            this.listPredstavnik.TabIndex = 0;
            this.listPredstavnik.UseCompatibleStateImageBehavior = false;
            this.listPredstavnik.SelectedIndexChanged += new System.EventHandler(this.listPredstavnik_SelectedIndexChanged);
            // 
            // dodajPredstavnika
            // 
            this.dodajPredstavnika.Location = new System.Drawing.Point(552, 51);
            this.dodajPredstavnika.Name = "dodajPredstavnika";
            this.dodajPredstavnika.Size = new System.Drawing.Size(165, 59);
            this.dodajPredstavnika.TabIndex = 1;
            this.dodajPredstavnika.Text = "dodajPredstavnika";
            this.dodajPredstavnika.UseVisualStyleBackColor = true;
            this.dodajPredstavnika.Click += new System.EventHandler(this.dodajPredstavnika_Click);
            // 
            // obrisiPredstavnika
            // 
            this.obrisiPredstavnika.Location = new System.Drawing.Point(552, 153);
            this.obrisiPredstavnika.Name = "obrisiPredstavnika";
            this.obrisiPredstavnika.Size = new System.Drawing.Size(165, 65);
            this.obrisiPredstavnika.TabIndex = 2;
            this.obrisiPredstavnika.Text = "obrisiPredstavnika";
            this.obrisiPredstavnika.UseVisualStyleBackColor = true;
            this.obrisiPredstavnika.Click += new System.EventHandler(this.obrisiPredstavnika_Click);
            // 
            // azurirajPredstavnika
            // 
            this.azurirajPredstavnika.Location = new System.Drawing.Point(552, 275);
            this.azurirajPredstavnika.Name = "azurirajPredstavnika";
            this.azurirajPredstavnika.Size = new System.Drawing.Size(165, 69);
            this.azurirajPredstavnika.TabIndex = 3;
            this.azurirajPredstavnika.Text = "azurirajPredstavnika";
            this.azurirajPredstavnika.UseVisualStyleBackColor = true;
            this.azurirajPredstavnika.Click += new System.EventHandler(this.azurirajPredstavnika_Click);
            // 
            // Ime
            // 
            this.Ime.Text = "Ime";
            // 
            // Starost
            // 
            this.Starost.Text = "Starost";
            // 
            // DatumSusreta
            // 
            this.DatumSusreta.Text = "DatumSusreta";
            // 
            // Ishod
            // 
            this.Ishod.Text = "Ishod";
            // 
            // Id_cudovista
            // 
            this.Id_cudovista.Text = "Id_cudovista";
            // 
            // Id_lokacije
            // 
            this.Id_lokacije.Text = "Id_lokacije";
            // 
            // PredstavnikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.azurirajPredstavnika);
            this.Controls.Add(this.obrisiPredstavnika);
            this.Controls.Add(this.dodajPredstavnika);
            this.Controls.Add(this.listPredstavnik);
            this.Name = "PredstavnikForm";
            this.Text = "PredstavnikForm";
            this.Load += new System.EventHandler(this.PredstavnikForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listPredstavnik;
        private System.Windows.Forms.Button dodajPredstavnika;
        private System.Windows.Forms.Button obrisiPredstavnika;
        private System.Windows.Forms.Button azurirajPredstavnika;
        private System.Windows.Forms.ColumnHeader Ime;
        private System.Windows.Forms.ColumnHeader Starost;
        private System.Windows.Forms.ColumnHeader DatumSusreta;
        private System.Windows.Forms.ColumnHeader Ishod;
        private System.Windows.Forms.ColumnHeader Id_cudovista;
        private System.Windows.Forms.ColumnHeader Id_lokacije;
    }
}