namespace Cudovista.Forme
{
    partial class IzlistajSposobnostiForma
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
            this.listaSposobnosti = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NAZIV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OPIS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listaSposobnosti
            // 
            this.listaSposobnosti.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.NAZIV,
            this.OPIS,
            this.columnHeader4});
            this.listaSposobnosti.HideSelection = false;
            this.listaSposobnosti.LabelEdit = true;
            this.listaSposobnosti.Location = new System.Drawing.Point(114, 57);
            this.listaSposobnosti.Name = "listaSposobnosti";
            this.listaSposobnosti.Size = new System.Drawing.Size(692, 394);
            this.listaSposobnosti.TabIndex = 0;
            this.listaSposobnosti.UseCompatibleStateImageBehavior = false;
            this.listaSposobnosti.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // NAZIV
            // 
            this.NAZIV.Text = "NAZIV";
            // 
            // OPIS
            // 
            this.OPIS.Text = "OPIS";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "DA LI JE ODBRAMBENA";
            // 
            // IzlistajSposobnostiForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(552, 299);
            this.Controls.Add(this.listaSposobnosti);
            this.Name = "IzlistajSposobnostiForma";
            this.Text = "view";
            this.Load += new System.EventHandler(this.IzlistajSposobnostiForma_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listaSposobnosti;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader NAZIV;
        private System.Windows.Forms.ColumnHeader OPIS;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}