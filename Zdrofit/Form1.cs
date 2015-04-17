using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Zdrofit.widoki;

namespace Zdrofit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rezerwacjeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Radosław Wichrowski s10338");
        }

        private void rezerwacjeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Rezerwacje r = new Rezerwacje();
            r.MdiParent = this;
            r.Show();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.sale' table. You can move, or remove it, as needed.
            this.saleTableAdapter.Fill(this.dataSet1.sale);

        }

        private void osobyToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // Zdrofit.widoki.Test f = new Zdrofit.widoki.Test();
           // f.MdiParent = this;
           // f.Show();
        }
    }
}
