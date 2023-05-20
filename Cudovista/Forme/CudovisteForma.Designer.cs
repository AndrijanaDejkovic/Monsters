namespace Cudovista.Forme
{
    partial class CudovisteForma
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
            this.Lista_Cudovista = new System.Windows.Forms.GroupBox();
            this.btnDodajCudoviste = new System.Windows.Forms.Button();
            this.listaCudovista = new System.Windows.Forms.ListView();
            this.Lista_Cudovista.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lista_Cudovista
            // 
            this.Lista_Cudovista.Controls.Add(this.listaCudovista);
            this.Lista_Cudovista.Location = new System.Drawing.Point(0, 0);
            this.Lista_Cudovista.Name = "Lista_Cudovista";
            this.Lista_Cudovista.Size = new System.Drawing.Size(697, 438);
            this.Lista_Cudovista.TabIndex = 0;
            this.Lista_Cudovista.TabStop = false;
            this.Lista_Cudovista.Text = "Lista_Cudovista";
            this.Lista_Cudovista.Enter += new System.EventHandler(this.Lista_Cudovista_Enter);
            // 
            // btnDodajCudoviste
            // 
            this.btnDodajCudoviste.Location = new System.Drawing.Point(1041, 57);
            this.btnDodajCudoviste.Name = "btnDodajCudoviste";
            this.btnDodajCudoviste.Size = new System.Drawing.Size(185, 74);
            this.btnDodajCudoviste.TabIndex = 0;
            this.btnDodajCudoviste.Text = "Dodaj Cudoviste";
            this.btnDodajCudoviste.UseVisualStyleBackColor = true;
            this.btnDodajCudoviste.Click += new System.EventHandler(this.btnDodajCudoviste_Click);
            // 
            // listaCudovista
            // 
            this.listaCudovista.HideSelection = false;
            this.listaCudovista.Location = new System.Drawing.Point(63, 72);
            this.listaCudovista.Name = "listaCudovista";
            this.listaCudovista.Size = new System.Drawing.Size(449, 242);
            this.listaCudovista.TabIndex = 0;
            this.listaCudovista.UseCompatibleStateImageBehavior = false;
            // 
            // CudovisteForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 660);
            this.Controls.Add(this.btnDodajCudoviste);
            this.Controls.Add(this.Lista_Cudovista);
            this.Name = "CudovisteForma";
            this.Text = "CudovisteForma";
            this.Lista_Cudovista.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Lista_Cudovista;
        private System.Windows.Forms.Button btnDodajCudoviste;
        private System.Windows.Forms.ListView listaCudovista;
    }
}