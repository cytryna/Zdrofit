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
    public partial class Osoby : Form
    {
        public Osoby()
        {
            InitializeComponent();
        }

        private void Osoby_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Osoby' table. You can move, or remove it, as needed.
            this.osobyTableAdapter.Fill(this.dataSet1.Osoby);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.osobyTableAdapter.Update(this.dataSet1.Osoby);
        }
    }
}
