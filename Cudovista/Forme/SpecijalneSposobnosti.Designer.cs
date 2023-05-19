namespace Cudovista.Forme
{
    partial class SpecijalneSposobnosti
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
            this.listSpecSposobnosti = new System.Windows.Forms.ListView();
            this.dodajSpecSposobnost = new System.Windows.Forms.Button();
            this.obrisiSpecSposobnost = new System.Windows.Forms.Button();
            this.azurirajSpecSposobnost = new System.Windows.Forms.Button();
            this.SpecijalnaSposobnost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Id_cudovista = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listSpecSposobnosti
            // 
            this.listSpecSposobnosti.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SpecijalnaSposobnost,
            this.Id_cudovista});
            this.listSpecSposobnosti.HideSelection = false;
            this.listSpecSposobnosti.Location = new System.Drawing.Point(50, 34);
            this.listSpecSposobnosti.Name = "listSpecSposobnosti";
            this.listSpecSposobnosti.Size = new System.Drawing.Size(422, 362);
            this.listSpecSposobnosti.TabIndex = 0;
            this.listSpecSposobnosti.UseCompatibleStateImageBehavior = false;
            this.listSpecSposobnosti.SelectedIndexChanged += new System.EventHandler(this.listSpecSposobnosti_SelectedIndexChanged);
            // 
            // dodajSpecSposobnost
            // 
            this.dodajSpecSposobnost.Location = new System.Drawing.Point(530, 44);
            this.dodajSpecSposobnost.Name = "dodajSpecSposobnost";
            this.dodajSpecSposobnost.Size = new System.Drawing.Size(159, 52);
            this.dodajSpecSposobnost.TabIndex = 1;
            this.dodajSpecSposobnost.Text = "dodajSpecSposobnost";
            this.dodajSpecSposobnost.UseVisualStyleBackColor = true;
            this.dodajSpecSposobnost.Click += new System.EventHandler(this.dodajSpecSposobnost_Click);
            // 
            // obrisiSpecSposobnost
            // 
            this.obrisiSpecSposobnost.Location = new System.Drawing.Point(530, 137);
            this.obrisiSpecSposobnost.Name = "obrisiSpecSposobnost";
            this.obrisiSpecSposobnost.Size = new System.Drawing.Size(159, 52);
            this.obrisiSpecSposobnost.TabIndex = 2;
            this.obrisiSpecSposobnost.Text = "obrisiSpecSposobnost";
            this.obrisiSpecSposobnost.UseVisualStyleBackColor = true;
            this.obrisiSpecSposobnost.Click += new System.EventHandler(this.obrisiSpecSposobnost_Click);
            // 
            // azurirajSpecSposobnost
            // 
            this.azurirajSpecSposobnost.Location = new System.Drawing.Point(530, 241);
            this.azurirajSpecSposobnost.Name = "azurirajSpecSposobnost";
            this.azurirajSpecSposobnost.Size = new System.Drawing.Size(159, 49);
            this.azurirajSpecSposobnost.TabIndex = 3;
            this.azurirajSpecSposobnost.Text = "azurirajSpecSposobnost";
            this.azurirajSpecSposobnost.UseVisualStyleBackColor = true;
            this.azurirajSpecSposobnost.Click += new System.EventHandler(this.azurirajSpecSposobnost_Click);
            // 
            // SpecijalnaSposobnost
            // 
            this.SpecijalnaSposobnost.Text = "SpecijalnaSposobnost";
            // 
            // Id_cudovista
            // 
            this.Id_cudovista.Text = "Id_cudovista";
            // 
            // SpecijalneSposobnosti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.azurirajSpecSposobnost);
            this.Controls.Add(this.obrisiSpecSposobnost);
            this.Controls.Add(this.dodajSpecSposobnost);
            this.Controls.Add(this.listSpecSposobnosti);
            this.Name = "SpecijalneSposobnosti";
            this.Text = "SpecijalneSposobnosti";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listSpecSposobnosti;
        private System.Windows.Forms.Button dodajSpecSposobnost;
        private System.Windows.Forms.Button obrisiSpecSposobnost;
        private System.Windows.Forms.Button azurirajSpecSposobnost;
        private System.Windows.Forms.ColumnHeader SpecijalnaSposobnost;
        private System.Windows.Forms.ColumnHeader Id_cudovista;
    }
}