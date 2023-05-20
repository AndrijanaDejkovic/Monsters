namespace Cudovista.Forme
{
    partial class PredmetForma
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
            this.listPredmeti = new System.Windows.Forms.ListView();
            this.Id_cudovista = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Id_materijala = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tip_predmeta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dodajLobanju = new System.Windows.Forms.Button();
            this.obrisiPredmet = new System.Windows.Forms.Button();
            this.dodajKrst = new System.Windows.Forms.Button();
            this.dodajMac = new System.Windows.Forms.Button();
            this.dodajKnjigu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listPredmeti
            // 
            this.listPredmeti.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id_cudovista,
            this.Id_materijala,
            this.Tip_predmeta});
            this.listPredmeti.HideSelection = false;
            this.listPredmeti.Location = new System.Drawing.Point(36, 49);
            this.listPredmeti.Name = "listPredmeti";
            this.listPredmeti.Size = new System.Drawing.Size(469, 355);
            this.listPredmeti.TabIndex = 0;
            this.listPredmeti.UseCompatibleStateImageBehavior = false;
            this.listPredmeti.SelectedIndexChanged += new System.EventHandler(this.listPredmeti_SelectedIndexChanged);
            // 
            // Id_cudovista
            // 
            this.Id_cudovista.Text = "Id_cudovista";
            // 
            // Id_materijala
            // 
            this.Id_materijala.Text = "Id_materijala";
            // 
            // Tip_predmeta
            // 
            this.Tip_predmeta.Text = "Tip_predmeta";
            // 
            // dodajLobanju
            // 
            this.dodajLobanju.Location = new System.Drawing.Point(536, 48);
            this.dodajLobanju.Name = "dodajLobanju";
            this.dodajLobanju.Size = new System.Drawing.Size(85, 34);
            this.dodajLobanju.TabIndex = 1;
            this.dodajLobanju.Text = "dodajLobanju";
            this.dodajLobanju.UseVisualStyleBackColor = true;
            this.dodajLobanju.Click += new System.EventHandler(this.dodajLobanju_Click);
            // 
            // obrisiPredmet
            // 
            this.obrisiPredmet.Location = new System.Drawing.Point(682, 124);
            this.obrisiPredmet.Name = "obrisiPredmet";
            this.obrisiPredmet.Size = new System.Drawing.Size(133, 64);
            this.obrisiPredmet.TabIndex = 2;
            this.obrisiPredmet.Text = "obrisiPredmet";
            this.obrisiPredmet.UseVisualStyleBackColor = true;
            this.obrisiPredmet.Click += new System.EventHandler(this.obrisiLobanju_Click);
            // 
            // dodajKrst
            // 
            this.dodajKrst.Location = new System.Drawing.Point(536, 107);
            this.dodajKrst.Name = "dodajKrst";
            this.dodajKrst.Size = new System.Drawing.Size(85, 33);
            this.dodajKrst.TabIndex = 4;
            this.dodajKrst.Text = "dodajKrst";
            this.dodajKrst.UseVisualStyleBackColor = true;
            this.dodajKrst.Click += new System.EventHandler(this.dodajKrst_Click);
            // 
            // dodajMac
            // 
            this.dodajMac.Location = new System.Drawing.Point(536, 168);
            this.dodajMac.Name = "dodajMac";
            this.dodajMac.Size = new System.Drawing.Size(85, 35);
            this.dodajMac.TabIndex = 8;
            this.dodajMac.Text = "dodajMac";
            this.dodajMac.UseVisualStyleBackColor = true;
            this.dodajMac.Click += new System.EventHandler(this.dodajMac_Click);
            // 
            // dodajKnjigu
            // 
            this.dodajKnjigu.Location = new System.Drawing.Point(536, 224);
            this.dodajKnjigu.Name = "dodajKnjigu";
            this.dodajKnjigu.Size = new System.Drawing.Size(85, 33);
            this.dodajKnjigu.TabIndex = 11;
            this.dodajKnjigu.Text = "dodajKnjigu";
            this.dodajKnjigu.UseVisualStyleBackColor = true;
            this.dodajKnjigu.Click += new System.EventHandler(this.dodajKnjigu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(544, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Prikaz predmeta za 1 cudoviste";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // PredmetForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(864, 528);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dodajKnjigu);
            this.Controls.Add(this.dodajMac);
            this.Controls.Add(this.dodajKrst);
            this.Controls.Add(this.obrisiPredmet);
            this.Controls.Add(this.dodajLobanju);
            this.Controls.Add(this.listPredmeti);
            this.Name = "PredmetForma";
            this.Text = "PredmetForma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listPredmeti;
        private System.Windows.Forms.Button dodajLobanju;
        private System.Windows.Forms.Button obrisiPredmet;
        private System.Windows.Forms.Button dodajKrst;
        private System.Windows.Forms.Button dodajMac;
        private System.Windows.Forms.Button dodajKnjigu;
        private System.Windows.Forms.ColumnHeader Id_cudovista;
        private System.Windows.Forms.ColumnHeader Id_materijala;
        private System.Windows.Forms.ColumnHeader Tip_predmeta;
        private System.Windows.Forms.Label label1;
    }
}