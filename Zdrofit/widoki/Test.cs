using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Zdrofit.widoki
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void Test_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.sale' table. You can move, or remove it, as needed.
            this.saleTableAdapter.Fill(this.dataSet1.sale);
            // TODO: This line of code loads data into the 'dataSet1.GrafikSelectCommand' table. You can move, or remove it, as needed.
            this.grafikSelectCommandTableAdapter.Fill(this.dataSet1.GrafikSelectCommand);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
