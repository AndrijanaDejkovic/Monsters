namespace Cudovista.Forme
{
    partial class CudovisteUpdateForm
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
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.Naziv = new System.Windows.Forms.Label();
            this.txtVek = new System.Windows.Forms.TextBox();
            this.Vek = new System.Windows.Forms.Label();
            this.txtPodtip = new System.Windows.Forms.TextBox();
            this.Podtip = new System.Windows.Forms.Label();
            this.txtDaLi = new System.Windows.Forms.TextBox();
            this.DaLi = new System.Windows.Forms.Label();
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(255, 105);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(100, 29);
            this.txtNaziv.TabIndex = 0;
            // 
            // Naziv
            // 
            this.Naziv.AutoSize = true;
            this.Naziv.Location = new System.Drawing.Point(113, 105);
            this.Naziv.Name = "Naziv";
            this.Naziv.Size = new System.Drawing.Size(61, 25);
            this.Naziv.TabIndex = 1;
            this.Naziv.Text = "Naziv";
            this.Naziv.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtVek
            // 
            this.txtVek.Location = new System.Drawing.Point(255, 176);
            this.txtVek.Name = "txtVek";
            this.txtVek.Size = new System.Drawing.Size(100, 29);
            this.txtVek.TabIndex = 2;
            // 
            // Vek
            // 
            this.Vek.AutoSize = true;
            this.Vek.Location = new System.Drawing.Point(113, 176);
            this.Vek.Name = "Vek";
            this.Vek.Size = new System.Drawing.Size(47, 25);
            this.Vek.TabIndex = 3;
            this.Vek.Text = "Vek";
            // 
            // txtPodtip
            // 
            this.txtPodtip.Location = new System.Drawing.Point(255, 242);
            this.txtPodtip.Name = "txtPodtip";
            this.txtPodtip.Size = new System.Drawing.Size(100, 29);
            this.txtPodtip.TabIndex = 4;
            // 
            // Podtip
            // 
            this.Podtip.AutoSize = true;
            this.Podtip.Location = new System.Drawing.Point(99, 245);
            this.Podtip.Name = "Podtip";
            this.Podtip.Size = new System.Drawing.Size(67, 25);
            this.Podtip.TabIndex = 5;
            this.Podtip.Text = "Podtip";
            // 
            // txtDaLi
            // 
            this.txtDaLi.Location = new System.Drawing.Point(244, 308);
            this.txtDaLi.Name = "txtDaLi";
            this.txtDaLi.Size = new System.Drawing.Size(142, 29);
            this.txtDaLi.TabIndex = 6;
            // 
            // DaLi
            // 
            this.DaLi.AutoSize = true;
            this.DaLi.Location = new System.Drawing.Point(84, 308);
            this.DaLi.Name = "DaLi";
            this.DaLi.Size = new System.Drawing.Size(111, 25);
            this.DaLi.TabIndex = 7;
            this.DaLi.Text = "Da li postoji";
            this.DaLi.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnAzuriraj.Location = new System.Drawing.Point(164, 386);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(191, 68);
            this.btnAzuriraj.TabIndex = 8;
            this.btnAzuriraj.Text = "Azuriraj";
            this.btnAzuriraj.UseVisualStyleBackColor = true;
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // CudovisteUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1151, 656);
            this.Controls.Add(this.btnAzuriraj);
            this.Controls.Add(this.DaLi);
            this.Controls.Add(this.txtDaLi);
            this.Controls.Add(this.Podtip);
            this.Controls.Add(this.txtPodtip);
            this.Controls.Add(this.Vek);
            this.Controls.Add(this.txtVek);
            this.Controls.Add(this.Naziv);
            this.Controls.Add(this.txtNaziv);
            this.Name = "CudovisteUpdateForm";
            this.Text = "CudovisteUpdateForm";
            this.Load += new System.EventHandler(this.CudovisteUpdateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label Naziv;
        private System.Windows.Forms.TextBox txtVek;
        private System.Windows.Forms.Label Vek;
        private System.Windows.Forms.TextBox txtPodtip;
        private System.Windows.Forms.Label Podtip;
        private System.Windows.Forms.TextBox txtDaLi;
        private System.Windows.Forms.Label DaLi;
        private System.Windows.Forms.Button btnAzuriraj;
    }
}