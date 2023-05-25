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
    public partial class DodajSposobnostForma : Form
    {
        public MagijskoCudovisteBasic cudoviste;
        public MagijskeSposobnostiBasic sposobnost;
        public DodajSposobnostForma()
        {
            InitializeComponent();
        }
        public DodajSposobnostForma(MagijskoCudovisteBasic m)
        {
            InitializeComponent();
            this.cudoviste = m;
            sposobnost = new MagijskeSposobnostiBasic();
        }

        private void btnDodajSposobnost_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da dodate ovu sposobnost?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
               // this.sposobnost.Id_cudovista = this.cudoviste;
                this.sposobnost.Naziv_sposobnosti = txtNaziv.Text;
                this.sposobnost.Opis_sposobnosti= txtOpis.Text;
                this.sposobnost.Da_li_je_odbrambena = Int32.Parse(txtOdbrambena.Text);


               // this.cudoviste.Poseduje_sposobnosti.Add(this.sposobnost);
                DTOManager.dodajMagijskuSposobnost(this.sposobnost);
                MessageBox.Show("Uspesno ste dodali novu sposobnost!");
                this.Close();

            }
            else
            {

            }
        }
    }
}
