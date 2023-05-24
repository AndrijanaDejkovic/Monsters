using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cudovista.Forme
{
    public partial class CudovisteUpdateForm : Form

    {
        public MagijskoCudovisteBasic cudoviste;
        public CudovisteUpdateForm()
        {
            InitializeComponent();
        }
        public CudovisteUpdateForm( MagijskoCudovisteBasic m)
        {
            InitializeComponent();
            this.cudoviste = m;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da izvrsite izmene cudovista?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {
                this.cudoviste.Naziv_cudovista = txtNaziv.Text;
                this.cudoviste.Vek =Int32.Parse(txtVek.Text);
                this.cudoviste.Podtip = txtPodtip.Text;
                this.cudoviste.Da_li_postoji = Int32.Parse(txtDaLi.Text);

                DTOManager.azurirajMagijskoCudoviste(this.cudoviste);
                MessageBox.Show("Azuriranje cudovista je uspesno izvrseno!");
                this.Close();
            }
            else
            {

            }
        }

        private void CudovisteUpdateForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
            this.Text = $"AZURIRANJE CUDOVISTA {cudoviste.Naziv_cudovista.ToUpper()}";
        }
        public void popuniPodacima()
        {
            txtNaziv.Text = this.cudoviste.Naziv_cudovista;
            txtVek.Text = this.cudoviste.Vek.ToString();
            txtPodtip.Text = this.cudoviste.Podtip;
            txtDaLi.Text = this.cudoviste.Da_li_postoji.ToString();
        }
    }
}
