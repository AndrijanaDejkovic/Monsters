namespace Cudovista
{
    partial class Form1
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
            this.findNameCudoviste = new System.Windows.Forms.Button();
            this.findBajalica = new System.Windows.Forms.Button();
            this.findLegende = new System.Windows.Forms.Button();
            this.findNemagijsko = new System.Windows.Forms.Button();
            this.findProtivmera = new System.Windows.Forms.Button();
            this.findSpecSposobnost = new System.Windows.Forms.Button();
            this.findLovac = new System.Windows.Forms.Button();
            this.findMagijsko = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // findNameCudoviste
            // 
            this.findNameCudoviste.Location = new System.Drawing.Point(12, 12);
            this.findNameCudoviste.Name = "findNameCudoviste";
            this.findNameCudoviste.Size = new System.Drawing.Size(173, 45);
            this.findNameCudoviste.TabIndex = 0;
            this.findNameCudoviste.Text = "NadjiCudoviste";
            this.findNameCudoviste.Click += new System.EventHandler(this.findNameCudoviste_Click);
            // 
            // findBajalica
            // 
            this.findBajalica.Location = new System.Drawing.Point(12, 63);
            this.findBajalica.Name = "findBajalica";
            this.findBajalica.Size = new System.Drawing.Size(173, 42);
            this.findBajalica.TabIndex = 1;
            this.findBajalica.Text = "NadjiBajalicu";
            this.findBajalica.UseVisualStyleBackColor = true;
            this.findBajalica.Click += new System.EventHandler(this.findBajalica_Click);
            // 
            // findLegende
            // 
            this.findLegende.Location = new System.Drawing.Point(12, 119);
            this.findLegende.Name = "findLegende";
            this.findLegende.Size = new System.Drawing.Size(173, 44);
            this.findLegende.TabIndex = 2;
            this.findLegende.Text = "NadjiLegendu";
            this.findLegende.UseVisualStyleBackColor = true;
            this.findLegende.Click += new System.EventHandler(this.findLegende_Click);
            // 
            // findNemagijsko
            // 
            this.findNemagijsko.Location = new System.Drawing.Point(223, 12);
            this.findNemagijsko.Name = "findNemagijsko";
            this.findNemagijsko.Size = new System.Drawing.Size(198, 53);
            this.findNemagijsko.TabIndex = 4;
            this.findNemagijsko.Text = "ImeNemagijskog";
            this.findNemagijsko.UseVisualStyleBackColor = true;
            this.findNemagijsko.Click += new System.EventHandler(this.findNemagijsko_Click);
            // 
            // findProtivmera
            // 
            this.findProtivmera.Location = new System.Drawing.Point(230, 98);
            this.findProtivmera.Name = "findProtivmera";
            this.findProtivmera.Size = new System.Drawing.Size(190, 55);
            this.findProtivmera.TabIndex = 5;
            this.findProtivmera.Text = "NadjiProtivmeru";
            this.findProtivmera.UseVisualStyleBackColor = true;
            this.findProtivmera.Click += new System.EventHandler(this.findProtivmera_Click);
            // 
            // findSpecSposobnost
            // 
            this.findSpecSposobnost.Location = new System.Drawing.Point(227, 184);
            this.findSpecSposobnost.Name = "findSpecSposobnost";
            this.findSpecSposobnost.Size = new System.Drawing.Size(217, 57);
            this.findSpecSposobnost.TabIndex = 6;
            this.findSpecSposobnost.Text = "SpecijalnaSposobnost";
            this.findSpecSposobnost.UseVisualStyleBackColor = true;
            this.findSpecSposobnost.Click += new System.EventHandler(this.findSpecSposobnost_Click);
            // 
            // findLovac
            // 
            this.findLovac.Location = new System.Drawing.Point(497, 35);
            this.findLovac.Name = "findLovac";
            this.findLovac.Size = new System.Drawing.Size(156, 101);
            this.findLovac.TabIndex = 7;
            this.findLovac.Text = "Lovac";
            this.findLovac.UseVisualStyleBackColor = true;
            this.findLovac.Click += new System.EventHandler(this.findLovac_Click);
            // 
            // findMagijsko
            // 
            this.findMagijsko.Location = new System.Drawing.Point(488, 188);
            this.findMagijsko.Name = "findMagijsko";
            this.findMagijsko.Size = new System.Drawing.Size(164, 43);
            this.findMagijsko.TabIndex = 8;
            this.findMagijsko.Text = "MagijskoC";
            this.findMagijsko.UseVisualStyleBackColor = true;
            this.findMagijsko.Click += new System.EventHandler(this.findMagijsko_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.findMagijsko);
            this.Controls.Add(this.findLovac);
            this.Controls.Add(this.findSpecSposobnost);
            this.Controls.Add(this.findProtivmera);
            this.Controls.Add(this.findNemagijsko);
            this.Controls.Add(this.findLegende);
            this.Controls.Add(this.findBajalica);
            this.Controls.Add(this.findNameCudoviste);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button findNameCudoviste;
        private System.Windows.Forms.Button findBajalica;
        private System.Windows.Forms.Button findLegende;
        private System.Windows.Forms.Button findNemagijsko;
        private System.Windows.Forms.Button findProtivmera;
        private System.Windows.Forms.Button findSpecSposobnost;
        private System.Windows.Forms.Button findLovac;
        private System.Windows.Forms.Button findMagijsko;
    }
}

