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
            this.listView1 = new System.Windows.Forms.ListView();
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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
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
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(42, 27);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(486, 390);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
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
            this.label1.Location = new System.Drawing.Point(547, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = " Za brisanje cudovista, selektujte cudoviste.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(570, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 66);
            this.button1.TabIndex = 2;
            this.button1.Text = "Obrisi";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // SvaNemagijskaCudovistaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Name = "SvaNemagijskaCudovistaForma";
            this.Text = "SvaNemagijskaCudovistaForma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
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
        private System.Windows.Forms.Button button1;
    }
}