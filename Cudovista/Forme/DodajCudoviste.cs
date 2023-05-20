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
    public partial class DodajCudoviste : Form
    {
        MagijskoCudovisteBasic cudoviste;
        public DodajCudoviste()
        {
            InitializeComponent();
        }

        private void lblPodtip_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da dodate ovo cudoviste?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                this.cudoviste.Naziv_cudovista = txtNazivCudovista.Text;
                this.cudoviste.Vek = Int32.Parse(txtVek.Text);
                this.cudoviste.Podtip = txtPodtip.Text;
                this.cudoviste.Da_li_postoji = Int32.Parse(txtPostojiLI.Text);

                DTOManager.dodajCudoviste(this.cudoviste);
                MessageBox.Show("Uspesno ste dodali novo cudoviste!");
                this.Close();
            }
            else
            {

            }
        }
    }
}
