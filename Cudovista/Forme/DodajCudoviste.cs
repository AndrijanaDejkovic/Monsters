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
        CudivisteBasic c;
        
        private void lblPodtip_Click(object sender, EventArgs e)
        {

        }
        
        public DodajCudoviste()
        {
            InitializeComponent();
            cudoviste = new MagijskoCudovisteBasic();
            c= new CudivisteBasic();
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

                this.c.Naziv_cudovista= txtNazivCudovista.Text;
                this.c.Vek = Int32.Parse(txtVek.Text);
                this.c.Podtip = txtPodtip.Text;


                DTOManager.dodajCudoviste(this.c);
                DTOManager.dodajMagijskoCudoviste(this.cudoviste);
                MessageBox.Show("Uspesno ste dodali novo cudoviste!");
                this.Close();

            }
            else
            {

            }
        }
    }
}
