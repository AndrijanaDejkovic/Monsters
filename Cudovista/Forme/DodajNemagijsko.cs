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
    public partial class DodajNemagijsko : Form
    {
        NemagijskoCudovisteBasic cudoviste;
        public DodajNemagijsko()
        {
            InitializeComponent();
            cudoviste = new NemagijskoCudovisteBasic();
        }

        private void DodajNemagijsko_Load(object sender, EventArgs e)
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
                this.cudoviste.Naziv_cudovista = textBoxNaziv.Text;
                this.cudoviste.Vek = Int32.Parse(textBoxVek.Text);
                this.cudoviste.Podtip = textBoxPodtip.Text;
                this.cudoviste.Da_li_zivi_u_vodi = Int32.Parse(textVoda.Text);
                this.cudoviste.Da_li_leti =  Int32.Parse(textBoxLet.Text);
                this.cudoviste.Da_li_je_otrovno = Int32.Parse(textBoxOtrov.Text);
                this.cudoviste.Da_li_ima_rep = Int32.Parse(textBoxRep.Text);
                this.cudoviste.Da_li_ima_kandze = Int32.Parse(textBoxKandze.Text);
                this.cudoviste.Broj_glava = Int32.Parse(textBoxGlava.Text);
                this.cudoviste.Broj_ekstremiteta = Int32.Parse(textBoxEktremiteti.Text);
                this.cudoviste.Broj_ociju = Int32.Parse(textBoxOci.Text);
                this.cudoviste.Tezina = Int32.Parse(textBoxTezina.Text);
                this.cudoviste.Duzina = Int32.Parse(textBoxDuzina.Text);

                DTOManager.dodajNemagijskoCudoviste(this.cudoviste);
                MessageBox.Show("Uspesno ste dodali novo cudoviste!");
                this.Close();


            }
            else
            {

            }
        }
    }
}
