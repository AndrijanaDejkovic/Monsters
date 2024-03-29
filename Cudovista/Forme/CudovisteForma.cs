﻿using System;
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
    public partial class CudovisteForma : Form
    {
        public CudovisteForma()
        {
            InitializeComponent();
        }


        private void Lista_Cudovista_Enter(object sender, EventArgs e)
        {

        }

        public void popuniPodacima()
        {


            listaCudovista.Items.Clear();
            List<MagijskoCudovistePregled> podaci = DTOManager.vratiSvaMagijskaCudovista();

            foreach (MagijskoCudovistePregled p in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { p.ID.ToString(), p.Naziv_cudovista, p.Vek.ToString(), p.Podtip, p.Da_li_postoji.ToString()});
                listaCudovista.Items.Add(item);

            }
            listaCudovista.Refresh();
        }
        private void btnDodajCudoviste_Click(object sender, EventArgs e)
        {
            DodajCudoviste formaDodajC = new DodajCudoviste();
            formaDodajC.ShowDialog();
            this.popuniPodacima();

        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (listaCudovista.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite cudoviste koju zelite da obrisete!");
                return;
            }

            int idCudovista = Int32.Parse(listaCudovista.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li zelite da obrisete izabrano cudoviste?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                
                DTOManager.obrisiMagijskoCudoviste(idCudovista);
                MessageBox.Show("Brisanje cudovista je uspesno obavljeno!");
                this.popuniPodacima();
            }
            else
            {

            }
        }

        private void CudovisteForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (listaCudovista.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite cudoviste cije podatke zelite da izmenite!");
                return;
            }

            int idCudovista = Int32.Parse(listaCudovista.SelectedItems[0].SubItems[0].Text);
            MagijskoCudovisteBasic ob = DTOManager.vratiMagijskoCudoviste(idCudovista);

            CudovisteUpdateForm formaUpdate = new CudovisteUpdateForm(ob);
            formaUpdate.ShowDialog();

            this.popuniPodacima();
        }

        private void btnSposobnost_Click(object sender, EventArgs e)
        {
            if (listaCudovista.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite cudoviste kom zelite da dodate sposobnost!");
                return;
            }

            int idCudovista = Int32.Parse(listaCudovista.SelectedItems[0].SubItems[0].Text);
            MagijskoCudovisteBasic ob = DTOManager.vratiMagijskoCudoviste(idCudovista);

            DodajSposobnostForma formaUpdate = new DodajSposobnostForma(ob);
            formaUpdate.ShowDialog();

            this.popuniPodacima();
        }

        private void btnIzlistaj_Click(object sender, EventArgs e)
        {
            if (listaCudovista.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite cudoviste cije sposobnosti zelite da vidite!");
                return;
            }

            int idCudovista = Int32.Parse(listaCudovista.SelectedItems[0].SubItems[0].Text);
            MagijskoCudovisteBasic ob = DTOManager.vratiMagijskoCudoviste(idCudovista);

            IzlistajSposobnostiForma forma = new IzlistajSposobnostiForma(ob);
            forma.ShowDialog();

            this.popuniPodacima();
        }
    }
}
