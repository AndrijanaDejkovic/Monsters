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
    public partial class SvaNemagijskaCudovistaForma : Form
    {
        public SvaNemagijskaCudovistaForma()
        {
            InitializeComponent();
        }
        public void popuniPodacima()
        {


            listaNemagijskih.Items.Clear();
            List<NemagijskoCudovistePregled> podaci = DTOManager.vratiSvaNemagijskaCudovista();



            foreach (NemagijskoCudovistePregled p in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { p.ID.ToString(), p.Naziv_cudovista, p.Vek.ToString(), p.Podtip, p.Broj_ekstremiteta.ToString(), p.Broj_glava.ToString(),
                p.Broj_ociju.ToString(), p.Da_li_ima_kandze.ToString(), p.Da_li_ima_rep.ToString(), p.Da_li_je_otrovno.ToString(), p.Da_li_leti.ToString(),
                p.Da_li_zivi_u_vodi.ToString(), p.Duzina.ToString(),p.Tezina.ToString()});
                listaNemagijskih.Items.Add(item);

            }
            listaNemagijskih.Refresh();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnObrisiNemagijskoCudoviste_Click(object sender, EventArgs e)
        {

        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (listaNemagijskih.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite prodavnicu cije podatke zelite da izmenite!");
                return;
            }

            int idCud = Int32.Parse(listaNemagijskih.SelectedItems[0].SubItems[0].Text);
            NemagijskoCudovisteBasic ob = DTOManager.vratiNemagijskoCudoviste(idCud);

            NemagijskaUpdateForm formaUpdate = new NemagijskaUpdateForm(ob);
            formaUpdate.ShowDialog();

            this.popuniPodacima();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {

        }
    }
}
