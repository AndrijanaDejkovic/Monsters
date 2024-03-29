﻿using Cudovista.Forme;
using NHibernate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cudovista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCudovista2_Click(object sender, EventArgs e)
        {
            CudovisteForma forma = new CudovisteForma();
            forma.ShowDialog();
        }

        private void btnPredstavnici2_Click(object sender, EventArgs e)
        {
            PredstavnikForm forma= new PredstavnikForm();
            forma.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NemagijskaCudovistaForma forma = new NemagijskaCudovistaForma();
            forma.ShowDialog();
        }

        private void btnTestiranje_Click(object sender, EventArgs e)
        {
            FormaTest forma = new FormaTest();
            forma.ShowDialog();
        }

        private void btnNemagijska_Click(object sender, EventArgs e)
        {
            NemagijskaCudovistaForma forma = new NemagijskaCudovistaForma();
            forma.ShowDialog();
        }

        private void Predstavnici_Click(object sender, EventArgs e)
        {
            PredstavnikForm forma = new PredstavnikForm();
            forma.ShowDialog();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            NemagijskaCudovistaForma f = new NemagijskaCudovistaForma();
            f.ShowDialog();
        }
    }
}
