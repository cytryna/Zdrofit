using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Zdrofit
{
    public partial class Rezerwacje : Form
    {
        public Rezerwacje()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Rezerwacje_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.GrafikSelectCommand' table. You can move, or remove it, as needed.
            this.grafikSelectCommandTableAdapter.Fill(this.dataSet1.GrafikSelectCommand);
            // TODO: This line of code loads data into the 'dataSet1.sale' table. You can move, or remove it, as needed.
            //this.saleTableAdapter.Fill(this.dataSet1.sale);
            // TODO: This line of code loads data into the 'dataSet1.grafik' table. You can move, or remove it, as needed.
            //this.grafikTableAdapter.Fill(this.dataSet1.grafik);

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.grafikTableAdapter.Update(this.dataSet1.grafik);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
