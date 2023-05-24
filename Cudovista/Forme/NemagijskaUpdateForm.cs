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
    public partial class NemagijskaUpdateForm : Form
    {
        public NemagijskoCudovisteBasic cudoviste;
        public NemagijskaUpdateForm()
        {
            InitializeComponent();
        }

        public NemagijskaUpdateForm(NemagijskoCudovisteBasic m)
        {
            InitializeComponent();
            this.cudoviste = m;
        }
        public void popuniPodacima()
        {
            txtNaziv.Text = this.cudoviste.Naziv_cudovista;
            txtVek.Text = this.cudoviste.Vek.ToString();
            txtPodtip.Text = this.cudoviste.Podtip;
            txtBrOciju.Text=this.cudoviste.Broj_ociju.ToString();
            txtDuzina.Text= this.cudoviste.Duzina.ToString();
            txtEkstremiteti.Text=cudoviste.Broj_ekstremiteta.ToString();
            txtGlava.Text=this.cudoviste.Broj_glava.ToString();
            txtKandze.Text=this.cudoviste.Da_li_ima_kandze.ToString();
            txtLeti.Text=this.cudoviste.Da_li_leti.ToString();
            txtOtrovno.Text=this.cudoviste.Da_li_je_otrovno.ToString();
            txtRep.Text=this.cudoviste.Da_li_ima_rep.ToString();
            txtTezina.Text=this.cudoviste.Tezina.ToString();
            txtVoda.Text=this.cudoviste.Da_li_zivi_u_vodi.ToString();
            
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
                this.cudoviste.Vek = Int32.Parse(txtVek.Text);
                this.cudoviste.Podtip = txtPodtip.Text;
                this.cudoviste.Broj_ekstremiteta = Int32.Parse(txtEkstremiteti.Text);
                this.cudoviste.Duzina = Int32.Parse(txtDuzina.Text);
                this.cudoviste.Broj_glava = Int32.Parse(txtGlava.Text);
                this.cudoviste.Da_li_ima_kandze = Int32.Parse(txtKandze.Text);
                this.cudoviste.Da_li_je_otrovno = Int32.Parse(txtOtrovno.Text);
                this.cudoviste.Da_li_ima_rep = Int32.Parse(txtRep.Text);
                this.cudoviste.Tezina = Int32.Parse(txtTezina.Text);
                this.cudoviste.Da_li_zivi_u_vodi = Int32.Parse(txtVoda.Text);
                

                DTOManager.azurirajNemagijskoCudoviste(this.cudoviste);
                MessageBox.Show("Azuriranje cudovista je uspesno izvrseno!");
                this.Close();
            }
            else
            {

            }
        }


        private void NemagijskaUpdateForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
            this.Text = $"AZURIRANJE CUDOVISTA {cudoviste.Naziv_cudovista.ToUpper()}";
        }
    }
}
