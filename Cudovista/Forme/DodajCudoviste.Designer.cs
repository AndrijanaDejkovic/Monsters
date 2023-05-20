namespace Cudovista.Forme
{
    partial class DodajCudoviste
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
            this.txtNazivCudovista = new System.Windows.Forms.TextBox();
            this.lblNazivCudovista = new System.Windows.Forms.Label();
            this.txtVek = new System.Windows.Forms.TextBox();
            this.txtPodtip = new System.Windows.Forms.TextBox();
            this.lblVek = new System.Windows.Forms.Label();
            this.lblPodtip = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.txtPostojiLI = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNazivCudovista
            // 
            this.txtNazivCudovista.Location = new System.Drawing.Point(198, 112);
            this.txtNazivCudovista.Name = "txtNazivCudovista";
            this.txtNazivCudovista.Size = new System.Drawing.Size(226, 29);
            this.txtNazivCudovista.TabIndex = 0;
            // 
            // lblNazivCudovista
            // 
            this.lblNazivCudovista.AutoSize = true;
            this.lblNazivCudovista.Location = new System.Drawing.Point(38, 115);
            this.lblNazivCudovista.Name = "lblNazivCudovista";
            this.lblNazivCudovista.Size = new System.Drawing.Size(154, 25);
            this.lblNazivCudovista.TabIndex = 1;
            this.lblNazivCudovista.Text = "Naziv Cudovista";
            // 
            // txtVek
            // 
            this.txtVek.Location = new System.Drawing.Point(249, 209);
            this.txtVek.Name = "txtVek";
            this.txtVek.Size = new System.Drawing.Size(175, 29);
            this.txtVek.TabIndex = 2;
            this.txtVek.Text = "number only";
            // 
            // txtPodtip
            // 
            this.txtPodtip.Location = new System.Drawing.Point(248, 278);
            this.txtPodtip.Name = "txtPodtip";
            this.txtPodtip.Size = new System.Drawing.Size(191, 29);
            this.txtPodtip.TabIndex = 3;
            // 
            // lblVek
            // 
            this.lblVek.AutoSize = true;
            this.lblVek.Location = new System.Drawing.Point(38, 213);
            this.lblVek.Name = "lblVek";
            this.lblVek.Size = new System.Drawing.Size(180, 25);
            this.lblVek.TabIndex = 4;
            this.lblVek.Text = "Vek u kom je zivelo";
            // 
            // lblPodtip
            // 
            this.lblPodtip.AutoSize = true;
            this.lblPodtip.Location = new System.Drawing.Point(92, 278);
            this.lblPodtip.Name = "lblPodtip";
            this.lblPodtip.Size = new System.Drawing.Size(67, 25);
            this.lblPodtip.TabIndex = 5;
            this.lblPodtip.Text = "Podtip";
            this.lblPodtip.Click += new System.EventHandler(this.lblPodtip_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(832, 82);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(102, 48);
            this.btnDodaj.TabIndex = 6;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPostojiLI
            // 
            this.txtPostojiLI.Location = new System.Drawing.Point(291, 340);
            this.txtPostojiLI.Name = "txtPostojiLI";
            this.txtPostojiLI.Size = new System.Drawing.Size(100, 29);
            this.txtPostojiLI.TabIndex = 7;
            // 
            // DodajCudoviste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 592);
            this.Controls.Add(this.txtPostojiLI);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.lblPodtip);
            this.Controls.Add(this.lblVek);
            this.Controls.Add(this.txtPodtip);
            this.Controls.Add(this.txtVek);
            this.Controls.Add(this.lblNazivCudovista);
            this.Controls.Add(this.txtNazivCudovista);
            this.Name = "DodajCudoviste";
            this.Text = "DodajCudoviste";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNazivCudovista;
        private System.Windows.Forms.Label lblNazivCudovista;
        private System.Windows.Forms.TextBox txtVek;
        private System.Windows.Forms.TextBox txtPodtip;
        private System.Windows.Forms.Label lblVek;
        private System.Windows.Forms.Label lblPodtip;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.TextBox txtPostojiLI;
    }
}