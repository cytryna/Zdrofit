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
            // TODO: This line of code loads data into the 'dataSet11.OsobyProcownicySelectCommand' table. You can move, or remove it, as needed.
            this.osobyProcownicySelectCommandTableAdapter.Fill(this.dataSet11.OsobyProcownicySelectCommand);
            // TODO: This line of code loads data into the 'dataSet1.zajecia' table. You can move, or remove it, as needed.
            this.zajeciaTableAdapter.Fill(this.dataSet1.zajecia);
            // TODO: This line of code loads data into the 'dataSet1.dni_tygodnia' table. You can move, or remove it, as needed.
            this.dni_tygodniaTableAdapter.Fill(this.dataSet1.dni_tygodnia);
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

                tabControl1.SelectedIndex = 1;
                //Trace.WriteLine(row.Cells["zajeciaDataGridViewTextBoxColumn"].Value);
                //var a = row.Cells["zajeciaDataGridViewTextBoxColumn"];
                label4.Text = row.Cells["zajeciaDataGridViewTextBoxColumn"].FormattedValue.ToString();
            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.grafikTableAdapter.Update(this.dataSet1.grafik);

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
