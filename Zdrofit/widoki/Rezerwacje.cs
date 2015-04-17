using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Zdrofit.widoki
{
    public partial class Rezerwacje : Form
    {
        private int idGraf = 0;
        public Rezerwacje()
        {
            InitializeComponent();
        }

        private void Rezerwacje_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Osoby' table. You can move, or remove it, as needed.
            this.osobySelectLikeTableAdapter.Fill(this.dataSet1.OsobySelectLike, "%");
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

            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {

                var row = senderGrid.Rows[e.RowIndex];

                tabControl1.SelectedIndex = 1;
                //Trace.WriteLine(row.Cells["zajeciaDataGridViewTextBoxColumn"].Value);
                //var a = row.Cells["zajeciaDataGridViewTextBoxColumn"];
                label4.Text = row.Cells["zajeciaDataGridViewTextBoxColumn"].FormattedValue.ToString();
                var i = row.Cells["dzientygodniaDataGridViewTextBoxColumn"].Value.ToString();
                label2.Text = getNajblizszyDzienTygodnia(i).ToString("yyyy-MM-dd");
                label8.Text = row.Cells["dzientygodniaDataGridViewTextBoxColumn"].FormattedValue.ToString();
                label6.Text = row.Cells["godzinaodDataGridViewTextBoxColumn"].FormattedValue.ToString();
                idGraf = Convert.ToInt32(row.Cells["idGrafiku"].Value);
                
            }
        }

        private DateTime getNajblizszyDzienTygodnia(String dzien)
        {
            DateTime saveNow = DateTime.Now;

            while (!saveNow.DayOfWeek.Equals(getDayOfWeek(dzien)))
            {
                Trace.WriteLine(saveNow.ToString());
                saveNow = saveNow.AddDays(1);
            }
            return saveNow;
        }
        private DayOfWeek getDayOfWeek(String dzien)
        {

            switch (dzien)
            {
                case "1":
                    return DayOfWeek.Monday;
                case "2":
                    return DayOfWeek.Tuesday;
                case "3":
                    return DayOfWeek.Wednesday;
                case "4":
                    return DayOfWeek.Thursday;
                case "5":
                    return DayOfWeek.Friday;
                case "6":
                    return DayOfWeek.Saturday;
                case "7":
                    return DayOfWeek.Sunday;
                default:
                    Console.WriteLine("Brak dnia tygodnia dla liczby" + dzien);
                    return DayOfWeek.Monday;
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.grafikTableAdapter.Update(this.dataSet1.grafik);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.osobySelectLikeTableAdapter.Fill(this.dataSet1.OsobySelectLike, textBox1.Text);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {

                var row = senderGrid.Rows[e.RowIndex];

                tabControl1.SelectedIndex = 1;
                
                SqlConnection con = new SqlConnection(Properties.Settings.Default.fitnessConnectionString);
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "RezerwacjaInsertCommand";
                cmd.Parameters.AddWithValue("@osoba_id", row.Cells["idOsoby"].FormattedValue.ToString());
                cmd.Parameters.AddWithValue("@data", label2.Text);
                cmd.Parameters.AddWithValue("@obecnosc", DBNull.Value);
                cmd.Parameters.AddWithValue("@grafik_id", idGraf);

                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Zapisano na zajęcia");

            }
        }
    }
}
