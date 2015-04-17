using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Zdrofit.widoki
{
    public partial class Rezerwacje : Form
    {
        public Rezerwacje()
        {
            InitializeComponent();
        }

        private void Rezerwacje_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.sale' table. You can move, or remove it, as needed.
            this.saleTableAdapter.Fill(this.dataSet1.sale);
            // TODO: This line of code loads data into the 'dataSet1.grafik' table. You can move, or remove it, as needed.
            this.grafikTableAdapter.Fill(this.dataSet1.grafik);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView) sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                var row = senderGrid.Rows[e.RowIndex];

                Trace.WriteLine(row.Cells["dzientygodniaDataGridViewTextBoxColumn"].Value);
            }
        }
    }
}
