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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCudovista2 = new System.Windows.Forms.Button();
            this.btnPredstavnici2 = new System.Windows.Forms.Button();
            this.btnNemagijskaCudovista2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(110, 29);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(234, 176);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(149, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "CUDOVISTA";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnCudovista2
            // 
            this.btnCudovista2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCudovista2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCudovista2.Location = new System.Drawing.Point(154, 269);
            this.btnCudovista2.Name = "btnCudovista2";
            this.btnCudovista2.Size = new System.Drawing.Size(146, 41);
            this.btnCudovista2.TabIndex = 2;
            this.btnCudovista2.Text = "Cudovista";
            this.btnCudovista2.UseVisualStyleBackColor = false;
            this.btnCudovista2.Click += new System.EventHandler(this.btnCudovista2_Click);
            // 
            // btnPredstavnici2
            // 
            this.btnPredstavnici2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnPredstavnici2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPredstavnici2.Location = new System.Drawing.Point(154, 316);
            this.btnPredstavnici2.Name = "btnPredstavnici2";
            this.btnPredstavnici2.Size = new System.Drawing.Size(146, 43);
            this.btnPredstavnici2.TabIndex = 3;
            this.btnPredstavnici2.Text = "Predstavnici";
            this.btnPredstavnici2.UseVisualStyleBackColor = false;
            this.btnPredstavnici2.Click += new System.EventHandler(this.btnPredstavnici2_Click);
            // 
            // btnNemagijskaCudovista2
            // 
            this.btnNemagijskaCudovista2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnNemagijskaCudovista2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNemagijskaCudovista2.Location = new System.Drawing.Point(154, 365);
            this.btnNemagijskaCudovista2.Name = "btnNemagijskaCudovista2";
            this.btnNemagijskaCudovista2.Size = new System.Drawing.Size(146, 52);
            this.btnNemagijskaCudovista2.TabIndex = 4;
            this.btnNemagijskaCudovista2.Text = "Nemagijska Cudovista";
            this.btnNemagijskaCudovista2.UseVisualStyleBackColor = false;
            this.btnNemagijskaCudovista2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(446, 471);
            this.Controls.Add(this.btnNemagijskaCudovista2);
            this.Controls.Add(this.btnPredstavnici2);
            this.Controls.Add(this.btnCudovista2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCudovista;
        private System.Windows.Forms.Button btnPredstavnici;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCudovista2;
        private System.Windows.Forms.Button btnPredstavnici2;
        private System.Windows.Forms.Button btnNemagijskaCudovista2;
    }
}

