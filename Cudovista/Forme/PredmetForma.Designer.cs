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
            this.dodajLobanju = new System.Windows.Forms.Button();
            this.obrisiLobanju = new System.Windows.Forms.Button();
            this.azurirajLobanju = new System.Windows.Forms.Button();
            this.dodajKrst = new System.Windows.Forms.Button();
            this.obrisiKrst = new System.Windows.Forms.Button();
            this.azurirajKrst = new System.Windows.Forms.Button();
            this.dodajMac = new System.Windows.Forms.Button();
            this.obrisiMac = new System.Windows.Forms.Button();
            this.azurirajMac = new System.Windows.Forms.Button();
            this.dodajKnjigu = new System.Windows.Forms.Button();
            this.obrisiKnjigu = new System.Windows.Forms.Button();
            this.azurirajKnjigu = new System.Windows.Forms.Button();
            this.Id_cudovista = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Id_materijala = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tip_predmeta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listPredmeti
            // 
            this.listPredmeti.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id_cudovista,
            this.Id_materijala,
            this.Tip_predmeta});
            this.listPredmeti.HideSelection = false;
            this.listPredmeti.Location = new System.Drawing.Point(47, 37);
            this.listPredmeti.Name = "listPredmeti";
            this.listPredmeti.Size = new System.Drawing.Size(469, 355);
            this.listPredmeti.TabIndex = 0;
            this.listPredmeti.UseCompatibleStateImageBehavior = false;
            this.listPredmeti.SelectedIndexChanged += new System.EventHandler(this.listPredmeti_SelectedIndexChanged);
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
            // obrisiLobanju
            // 
            this.obrisiLobanju.Location = new System.Drawing.Point(627, 48);
            this.obrisiLobanju.Name = "obrisiLobanju";
            this.obrisiLobanju.Size = new System.Drawing.Size(95, 32);
            this.obrisiLobanju.TabIndex = 2;
            this.obrisiLobanju.Text = "obrisiLobanju";
            this.obrisiLobanju.UseVisualStyleBackColor = true;
            this.obrisiLobanju.Click += new System.EventHandler(this.obrisiLobanju_Click);
            // 
            // azurirajLobanju
            // 
            this.azurirajLobanju.Location = new System.Drawing.Point(728, 49);
            this.azurirajLobanju.Name = "azurirajLobanju";
            this.azurirajLobanju.Size = new System.Drawing.Size(97, 33);
            this.azurirajLobanju.TabIndex = 3;
            this.azurirajLobanju.Text = "azurirajLobanju";
            this.azurirajLobanju.UseVisualStyleBackColor = true;
            this.azurirajLobanju.Click += new System.EventHandler(this.azurirajLobanju_Click);
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
            // obrisiKrst
            // 
            this.obrisiKrst.Location = new System.Drawing.Point(627, 107);
            this.obrisiKrst.Name = "obrisiKrst";
            this.obrisiKrst.Size = new System.Drawing.Size(95, 33);
            this.obrisiKrst.TabIndex = 5;
            this.obrisiKrst.Text = "obrisiKrst";
            this.obrisiKrst.UseVisualStyleBackColor = true;
            this.obrisiKrst.Click += new System.EventHandler(this.obrisiKrst_Click);
            // 
            // azurirajKrst
            // 
            this.azurirajKrst.Location = new System.Drawing.Point(728, 107);
            this.azurirajKrst.Name = "azurirajKrst";
            this.azurirajKrst.Size = new System.Drawing.Size(97, 33);
            this.azurirajKrst.TabIndex = 6;
            this.azurirajKrst.Text = "azurirajKrst";
            this.azurirajKrst.UseVisualStyleBackColor = true;
            this.azurirajKrst.Click += new System.EventHandler(this.azurirajKrst_Click);
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
            // obrisiMac
            // 
            this.obrisiMac.Location = new System.Drawing.Point(635, 168);
            this.obrisiMac.Name = "obrisiMac";
            this.obrisiMac.Size = new System.Drawing.Size(75, 35);
            this.obrisiMac.TabIndex = 9;
            this.obrisiMac.Text = "obrisiMac";
            this.obrisiMac.UseVisualStyleBackColor = true;
            this.obrisiMac.Click += new System.EventHandler(this.obrisiMac_Click);
            // 
            // azurirajMac
            // 
            this.azurirajMac.Location = new System.Drawing.Point(728, 168);
            this.azurirajMac.Name = "azurirajMac";
            this.azurirajMac.Size = new System.Drawing.Size(97, 35);
            this.azurirajMac.TabIndex = 10;
            this.azurirajMac.Text = "azurirajMac";
            this.azurirajMac.UseVisualStyleBackColor = true;
            this.azurirajMac.Click += new System.EventHandler(this.azurirajMac_Click);
            // 
            // dodajKnjigu
            // 
            this.dodajKnjigu.Location = new System.Drawing.Point(536, 224);
            this.dodajKnjigu.Name = "dodajKnjigu";
            this.dodajKnjigu.Size = new System.Drawing.Size(75, 33);
            this.dodajKnjigu.TabIndex = 11;
            this.dodajKnjigu.Text = "dodajKnjigu";
            this.dodajKnjigu.UseVisualStyleBackColor = true;
            this.dodajKnjigu.Click += new System.EventHandler(this.dodajKnjigu_Click);
            // 
            // obrisiKnjigu
            // 
            this.obrisiKnjigu.Location = new System.Drawing.Point(635, 224);
            this.obrisiKnjigu.Name = "obrisiKnjigu";
            this.obrisiKnjigu.Size = new System.Drawing.Size(75, 33);
            this.obrisiKnjigu.TabIndex = 12;
            this.obrisiKnjigu.Text = "obrisiKnjigu";
            this.obrisiKnjigu.UseVisualStyleBackColor = true;
            this.obrisiKnjigu.Click += new System.EventHandler(this.obrisiKnjigu_Click);
            // 
            // azurirajKnjigu
            // 
            this.azurirajKnjigu.Location = new System.Drawing.Point(728, 224);
            this.azurirajKnjigu.Name = "azurirajKnjigu";
            this.azurirajKnjigu.Size = new System.Drawing.Size(87, 33);
            this.azurirajKnjigu.TabIndex = 13;
            this.azurirajKnjigu.Text = "azurirajKnjigu";
            this.azurirajKnjigu.UseVisualStyleBackColor = true;
            this.azurirajKnjigu.Click += new System.EventHandler(this.azurirajKnjigu_Click);
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
            // PredmetForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(864, 528);
            this.Controls.Add(this.azurirajKnjigu);
            this.Controls.Add(this.obrisiKnjigu);
            this.Controls.Add(this.dodajKnjigu);
            this.Controls.Add(this.azurirajMac);
            this.Controls.Add(this.obrisiMac);
            this.Controls.Add(this.dodajMac);
            this.Controls.Add(this.azurirajKrst);
            this.Controls.Add(this.obrisiKrst);
            this.Controls.Add(this.dodajKrst);
            this.Controls.Add(this.azurirajLobanju);
            this.Controls.Add(this.obrisiLobanju);
            this.Controls.Add(this.dodajLobanju);
            this.Controls.Add(this.listPredmeti);
            this.Name = "PredmetForma";
            this.Text = "PredmetForma";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listPredmeti;
        private System.Windows.Forms.Button dodajLobanju;
        private System.Windows.Forms.Button obrisiLobanju;
        private System.Windows.Forms.Button azurirajLobanju;
        private System.Windows.Forms.Button dodajKrst;
        private System.Windows.Forms.Button obrisiKrst;
        private System.Windows.Forms.Button azurirajKrst;
        private System.Windows.Forms.Button dodajMac;
        private System.Windows.Forms.Button obrisiMac;
        private System.Windows.Forms.Button azurirajMac;
        private System.Windows.Forms.Button dodajKnjigu;
        private System.Windows.Forms.Button obrisiKnjigu;
        private System.Windows.Forms.Button azurirajKnjigu;
        private System.Windows.Forms.ColumnHeader Id_cudovista;
        private System.Windows.Forms.ColumnHeader Id_materijala;
        private System.Windows.Forms.ColumnHeader Tip_predmeta;
    }
}