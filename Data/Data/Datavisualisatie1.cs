using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Data
{
    public partial class Datavisualisatie1 : Form
    {

        public List<Data> Maanden = new List<Data>();

        public Datavisualisatie1()
        {
            InitializeComponent();
            LoadChart(true);
        }

        public void LoadChart(bool first)
        {
            WGSchart.Series.Clear();
            WGSchart.ResetAutoValues();

            foreach (var series in WGSchart.Series)
            {
                series.Points.Clear();
            }
            var series1 = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "MaxTemp"
            };
            var series2 = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "GestolenFietsen"
            };
            WGSchart.Series.Add(series1);
            WGSchart.Series.Add(series2);
            WGSchart.ChartAreas[0].AxisX.Interval = 1;

            if (first == true)
            {
                string MyConnectionString = "Server=localhost;Database=school;UID=homestead;PWD=secret;PORT=33060;SslMode=none;";

                MySqlConnection connection = new MySqlConnection(MyConnectionString);
                MySqlCommand cmd;
                connection.Open();

                try
                {
                    cmd = connection.CreateCommand();
                    cmd.CommandText = "Select Month(fietsen_diefstal.datum) Months, count(fietsen_diefstal.merk) as aantal, round(max(kmni.max_temp)) as max_temp from fietsen_diefstal join kmni on fietsen_diefstal.datum = kmni.Date group by Month(fietsen_diefstal.datum)";
                    MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                    DataSet fietsen = new DataSet();
                    adap.Fill(fietsen, "fietsen");
                    DataTable dt = new DataTable();
                    dt = fietsen.Tables["fietsen"]; //table exactly like sql table.

                    foreach (DataRow dr in dt.Rows)
                    {
                        var newMaand = new Data
                        {
                            Maand = dr["Months"].ToString(),
                            FietsenDiefstal = dr["aantal"].ToString(),
                            MaxTemp = dr["max_temp"].ToString()
                        };

                        Maanden.Add(newMaand);
                    }

                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Clone();
                    }
                }


            }

            foreach (var data in Maanden)
            {

                if (Jan.Checked == true && data.Maand == "1")
                {
                    WGSchart.Series["MaxTemp"].Points.AddXY($"Januari", data.MaxTemp);
                    WGSchart.Series["GestolenFietsen"].Points.AddXY($"{data.Maand}", data.FietsenDiefstal);
                }
                else if (feb.Checked == true && data.Maand == "2")
                {
                    WGSchart.Series["MaxTemp"].Points.AddXY($"Februari", data.MaxTemp);
                    WGSchart.Series["GestolenFietsen"].Points.AddXY($"{data.Maand}", data.FietsenDiefstal);
                }
                else if (apr.Checked == true && data.Maand == "4")
                {
                    WGSchart.Series["MaxTemp"].Points.AddXY($"April", data.MaxTemp);
                    WGSchart.Series["GestolenFietsen"].Points.AddXY($"{data.Maand}", data.FietsenDiefstal);

                }
                else if (mrt.Checked == true && data.Maand == "3")
                {
                    WGSchart.Series["MaxTemp"].Points.AddXY($"Maart", data.MaxTemp);
                    WGSchart.Series["GestolenFietsen"].Points.AddXY($"{data.Maand}", data.FietsenDiefstal);

                }
                else if (mei.Checked == true && data.Maand == "5")
                {
                    WGSchart.Series["MaxTemp"].Points.AddXY($"Mei", data.MaxTemp);
                    WGSchart.Series["GestolenFietsen"].Points.AddXY($"{data.Maand}", data.FietsenDiefstal);

                }
                else if (jun.Checked == true && data.Maand == "6")
                {
                    WGSchart.Series["MaxTemp"].Points.AddXY($"Juni", data.MaxTemp);
                    WGSchart.Series["GestolenFietsen"].Points.AddXY($"{data.Maand}", data.FietsenDiefstal);

                }
                else if (jul.Checked == true && data.Maand == "7")
                {
                    WGSchart.Series["MaxTemp"].Points.AddXY($"Juli", data.MaxTemp);
                    WGSchart.Series["GestolenFietsen"].Points.AddXY($"{data.Maand}", data.FietsenDiefstal);

                }
                else if (aug.Checked == true && data.Maand == "8")
                {
                    WGSchart.Series["MaxTemp"].Points.AddXY($"Augustus", data.MaxTemp);
                    WGSchart.Series["GestolenFietsen"].Points.AddXY($"{data.Maand}", data.FietsenDiefstal);
                }
                else if (sep.Checked == true && data.Maand == "9")
                {
                    WGSchart.Series["MaxTemp"].Points.AddXY($"September", data.MaxTemp);
                    WGSchart.Series["GestolenFietsen"].Points.AddXY($"{data.Maand}", data.FietsenDiefstal);
                }
                else if (okt.Checked == true && data.Maand == "10")
                {
                    WGSchart.Series["MaxTemp"].Points.AddXY($"Oktober", data.MaxTemp);
                    WGSchart.Series["GestolenFietsen"].Points.AddXY($"{data.Maand}", data.FietsenDiefstal);

                }
                else if (nov.Checked == true && data.Maand == "11")
                {
                    WGSchart.Series["MaxTemp"].Points.AddXY($"November", data.MaxTemp);
                    WGSchart.Series["GestolenFietsen"].Points.AddXY($"{data.Maand}", data.FietsenDiefstal);

                }
                else if (dec.Checked == true && data.Maand == "12")
                {
                    WGSchart.Series["MaxTemp"].Points.AddXY($"Decmeber", data.MaxTemp);
                    WGSchart.Series["GestolenFietsen"].Points.AddXY($"{data.Maand}", data.FietsenDiefstal);

                }
                else
                {
                    Console.WriteLine("Shouldn't be here but it still looks nice with a extra console line D: ");
                }

            }

            return;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 mainMenu = new Form1();
            mainMenu.Show();
        }

        private void dec_CheckedChanged_1(object sender, EventArgs e)
        {
            LoadChart(false);
        }

        private void Jan_CheckedChanged(object sender, EventArgs e)
        {
            LoadChart(false);
        }

        private void feb_CheckedChanged_1(object sender, EventArgs e)
        {
            LoadChart(false);
        }

        private void mrt_CheckedChanged_1(object sender, EventArgs e)
        {
            LoadChart(false);
        }

        private void apr_CheckedChanged_1(object sender, EventArgs e)
        {
            LoadChart(false);
        }

        private void mei_CheckedChanged_1(object sender, EventArgs e)
        {
            LoadChart(false);
        }

        private void jun_CheckedChanged_1(object sender, EventArgs e)
        {
            LoadChart(false);
        }

        private void jul_CheckedChanged_1(object sender, EventArgs e)
        {
            LoadChart(false);
        }

        private void aug_CheckedChanged_1(object sender, EventArgs e)
        {
            LoadChart(false);
        }

        private void sep_CheckedChanged_1(object sender, EventArgs e)
        {
            LoadChart(false);
        }

        private void okt_CheckedChanged_1(object sender, EventArgs e)
        {
            LoadChart(false);
        }

        private void nov_CheckedChanged_1(object sender, EventArgs e)
        {
            LoadChart(false);
        }

        private void WGSchart_Click(object sender, EventArgs e)
        {

        }
    }
}
