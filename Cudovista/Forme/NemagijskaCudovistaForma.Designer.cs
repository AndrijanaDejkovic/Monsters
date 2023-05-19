namespace Cudovista.Forme
{
    partial class NemagijskaCudovistaForma
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
            this.listNemagijska = new System.Windows.Forms.ListView();
            this.ZiviUVodi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Leti = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ImaRep = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Otrovno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ImaKandze = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BrojOciju = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BrojGlava = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BrojEkstr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Duzina = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tezina = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ObrisiNemagijsko = new System.Windows.Forms.Button();
            this.DodajNemagijsko = new System.Windows.Forms.Button();
            this.AzurirajNemagijsko = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listNemagijska
            // 
            this.listNemagijska.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ZiviUVodi,
            this.Leti,
            this.ImaRep,
            this.Otrovno,
            this.ImaKandze,
            this.BrojOciju,
            this.BrojGlava,
            this.BrojEkstr,
            this.Duzina,
            this.Tezina});
            this.listNemagijska.HideSelection = false;
            this.listNemagijska.Location = new System.Drawing.Point(25, 12);
            this.listNemagijska.Name = "listNemagijska";
            this.listNemagijska.Size = new System.Drawing.Size(477, 388);
            this.listNemagijska.TabIndex = 0;
            this.listNemagijska.UseCompatibleStateImageBehavior = false;
            this.listNemagijska.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
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
            // BrojOciju
            // 
            this.BrojOciju.Text = "BrojOciju";
            // 
            // BrojGlava
            // 
            this.BrojGlava.Text = "BrojGlava";
            // 
            // BrojEkstr
            // 
            this.BrojEkstr.Text = "BrojEkstr";
            // 
            // Duzina
            // 
            this.Duzina.Text = "Duzina";
            // 
            // Tezina
            // 
            this.Tezina.Text = "Tezina";
            // 
            // ObrisiNemagijsko
            // 
            this.ObrisiNemagijsko.Location = new System.Drawing.Point(577, 40);
            this.ObrisiNemagijsko.Name = "ObrisiNemagijsko";
            this.ObrisiNemagijsko.Size = new System.Drawing.Size(130, 53);
            this.ObrisiNemagijsko.TabIndex = 1;
            this.ObrisiNemagijsko.Text = "ObrisiNemagijsko";
            this.ObrisiNemagijsko.UseVisualStyleBackColor = true;
            this.ObrisiNemagijsko.Click += new System.EventHandler(this.button1_Click);
            // 
            // DodajNemagijsko
            // 
            this.DodajNemagijsko.Location = new System.Drawing.Point(577, 150);
            this.DodajNemagijsko.Name = "DodajNemagijsko";
            this.DodajNemagijsko.Size = new System.Drawing.Size(131, 58);
            this.DodajNemagijsko.TabIndex = 2;
            this.DodajNemagijsko.Text = "DodajNemagijsko";
            this.DodajNemagijsko.UseVisualStyleBackColor = true;
            this.DodajNemagijsko.Click += new System.EventHandler(this.DodajNemagijsko_Click);
            // 
            // AzurirajNemagijsko
            // 
            this.AzurirajNemagijsko.Location = new System.Drawing.Point(577, 260);
            this.AzurirajNemagijsko.Name = "AzurirajNemagijsko";
            this.AzurirajNemagijsko.Size = new System.Drawing.Size(130, 66);
            this.AzurirajNemagijsko.TabIndex = 3;
            this.AzurirajNemagijsko.Text = "AzurirajNemagijsko";
            this.AzurirajNemagijsko.UseVisualStyleBackColor = true;
            this.AzurirajNemagijsko.Click += new System.EventHandler(this.AzurirajNemagijsko_Click);
            // 
            // NemagijskaCudovistaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AzurirajNemagijsko);
            this.Controls.Add(this.DodajNemagijsko);
            this.Controls.Add(this.ObrisiNemagijsko);
            this.Controls.Add(this.listNemagijska);
            this.Name = "NemagijskaCudovistaForma";
            this.Text = "NemagijskaCudovistaForma";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listNemagijska;
        private System.Windows.Forms.ColumnHeader ZiviUVodi;
        private System.Windows.Forms.ColumnHeader Leti;
        private System.Windows.Forms.ColumnHeader ImaRep;
        private System.Windows.Forms.ColumnHeader Otrovno;
        private System.Windows.Forms.ColumnHeader ImaKandze;
        private System.Windows.Forms.ColumnHeader BrojOciju;
        private System.Windows.Forms.ColumnHeader BrojGlava;
        private System.Windows.Forms.ColumnHeader BrojEkstr;
        private System.Windows.Forms.ColumnHeader Duzina;
        private System.Windows.Forms.ColumnHeader Tezina;
        private System.Windows.Forms.Button ObrisiNemagijsko;
        private System.Windows.Forms.Button DodajNemagijsko;
        private System.Windows.Forms.Button AzurirajNemagijsko;
    }
}