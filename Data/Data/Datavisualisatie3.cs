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
    public partial class Datavisualisatie3 : Form
    {
        public List<Data> Maanden = new List<Data>();

        public Datavisualisatie3()
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
                Name = "Windsnelheid"
            };
            var series2 = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "Sterfte"
            };
            var series3 = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "Geboorte"
            };
            WGSchart.Series.Add(series1);
            WGSchart.Series.Add(series2);
            WGSchart.Series.Add(series3);
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
                    cmd.CommandText = "Select Month(Bevolking_per_maand.Perioden) Months, avg(Bevolking_per_maand.Levendgeborenen) as Geboren, avg(Bevolking_per_maand.Overledenen) as Overledenen, round(avg(kmni.windsnelheid)) * 100 as Windsnelheid from Bevolking_per_maand join kmni on Bevolking_per_maand.Perioden = kmni.Date group by Month(Bevolking_per_maand.Perioden)";
                    MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                    DataSet geboorte = new DataSet();
                    adap.Fill(geboorte, "geboorte");
                    DataTable dt = new DataTable();
                    dt = geboorte.Tables["geboorte"];

                    foreach (DataRow dr in dt.Rows)
                    {

                        var newMaand = new Data
                        {
                            Maand = dr["Months"].ToString(),
                            Geboorte = dr["Geboren"].ToString(),
                            Sterfte = dr["Overledenen"].ToString(),
                            Windsnelheid = dr["Windsnelheid"].ToString()
                        };

                        Maanden.Add(newMaand);
                    }

                }
                catch (Exception e)
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
                    WGSchart.Series["Windsnelheid"].Points.AddXY($"Januari", data.Windsnelheid);
                    WGSchart.Series["Sterfte"].Points.AddXY($"Januari", data.Sterfte);
                    WGSchart.Series["Geboorte"].Points.AddXY($"Januari", data.Geboorte);
                }
                else if (feb.Checked == true && data.Maand == "2")
                {
                    WGSchart.Series["Windsnelheid"].Points.AddXY($"Februari", data.Windsnelheid);
                    WGSchart.Series["Sterfte"].Points.AddXY($"Februari", data.Sterfte);
                    WGSchart.Series["Geboorte"].Points.AddXY($"Februari", data.Geboorte);
                }
                else if (mrt.Checked == true && data.Maand == "3")
                {
                    WGSchart.Series["Windsnelheid"].Points.AddXY($"Maart", data.Windsnelheid);
                    WGSchart.Series["Sterfte"].Points.AddXY($"Maart", data.Sterfte);
                    WGSchart.Series["Geboorte"].Points.AddXY($"Maart", data.Geboorte);
                }
                else if (apr.Checked == true && data.Maand == "4")
                {
                    WGSchart.Series["Windsnelheid"].Points.AddXY($"April", data.Windsnelheid);
                    WGSchart.Series["Sterfte"].Points.AddXY($"April", data.Sterfte);
                    WGSchart.Series["Geboorte"].Points.AddXY($"April", data.Geboorte);
                }
                else if (mei.Checked == true && data.Maand == "5")
                {
                    WGSchart.Series["Windsnelheid"].Points.AddXY($"Mei", data.Windsnelheid);
                    WGSchart.Series["Sterfte"].Points.AddXY($"Mei", data.Sterfte);
                    WGSchart.Series["Geboorte"].Points.AddXY($"Mei", data.Geboorte);
                }
                else if (jun.Checked == true && data.Maand == "6")
                {
                    WGSchart.Series["Windsnelheid"].Points.AddXY($"Juni", data.Windsnelheid);
                    WGSchart.Series["Sterfte"].Points.AddXY($"Juni", data.Sterfte);
                    WGSchart.Series["Geboorte"].Points.AddXY($"Juni", data.Geboorte);
                }
                else if (jul.Checked == true && data.Maand == "7")
                {
                    WGSchart.Series["Windsnelheid"].Points.AddXY($"Juli", data.Windsnelheid);
                    WGSchart.Series["Sterfte"].Points.AddXY($"Juli", data.Sterfte);
                    WGSchart.Series["Geboorte"].Points.AddXY($"Juli", data.Geboorte);
                }
                else if (aug.Checked == true && data.Maand == "8")
                {
                    WGSchart.Series["Windsnelheid"].Points.AddXY($"Augustus", data.Windsnelheid);
                    WGSchart.Series["Sterfte"].Points.AddXY($"Augustus", data.Sterfte);
                    WGSchart.Series["Geboorte"].Points.AddXY($"Augustus", data.Geboorte);
                }
                else if (sep.Checked == true && data.Maand == "9")
                {
                    WGSchart.Series["Windsnelheid"].Points.AddXY($"September", data.Windsnelheid);
                    WGSchart.Series["Sterfte"].Points.AddXY($"September", data.Sterfte);
                    WGSchart.Series["Geboorte"].Points.AddXY($"September", data.Geboorte);
                }
                else if (okt.Checked == true && data.Maand == "10")
                {
                    WGSchart.Series["Windsnelheid"].Points.AddXY($"October", data.Windsnelheid);
                    WGSchart.Series["Sterfte"].Points.AddXY($"October", data.Sterfte);
                    WGSchart.Series["Geboorte"].Points.AddXY($"October", data.Geboorte);
                }
                else if (nov.Checked == true && data.Maand == "11")
                {
                    WGSchart.Series["Windsnelheid"].Points.AddXY($"November", data.Windsnelheid);
                    WGSchart.Series["Sterfte"].Points.AddXY($"November", data.Sterfte);
                    WGSchart.Series["Geboorte"].Points.AddXY($"November", data.Geboorte);
                }
                else if (dec.Checked == true && data.Maand == "12")
                {
                    WGSchart.Series["Windsnelheid"].Points.AddXY($"December", data.Windsnelheid);
                    WGSchart.Series["Sterfte"].Points.AddXY($"December", data.Sterfte);
                    WGSchart.Series["Geboorte"].Points.AddXY($"December", data.Geboorte);
                }
                else
                {
                    Console.WriteLine("log_1 ");
                }
                
            }

            return;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 mainMenu = new Form1();
            mainMenu.Show();
        }

        private void dec_CheckedChanged_2(object sender, EventArgs e)
        {
            LoadChart(false);
        }

        private void Jan_CheckedChanged_2(object sender, EventArgs e)
        {
            LoadChart(false);
        }

        private void feb_CheckedChanged_2(object sender, EventArgs e)
        {
            LoadChart(false);
        }

        private void mrt_CheckedChanged_2(object sender, EventArgs e)
        {
            LoadChart(false);
        }

        private void apr_CheckedChanged_2(object sender, EventArgs e)
        {
            LoadChart(false);
        }

        private void mei_CheckedChanged_2(object sender, EventArgs e)
        {
            LoadChart(false);
        }

        private void jun_CheckedChanged_2(object sender, EventArgs e)
        {
            LoadChart(false);
        }

        private void jul_CheckedChanged_2(object sender, EventArgs e)
        {
            LoadChart(false);
        }

        private void aug_CheckedChanged_2(object sender, EventArgs e)
        {
            LoadChart(false);
        }

        private void sep_CheckedChanged_2(object sender, EventArgs e)
        {
            LoadChart(false);
        }

        private void okt_CheckedChanged_2(object sender, EventArgs e)
        {
            LoadChart(false);
        }

        private void nov_CheckedChanged_2(object sender, EventArgs e)
        {
            LoadChart(false);
        }

        private void Datavisualisatie3_Load(object sender, EventArgs e)
        {

        }

        private void WGSchart_Click(object sender, EventArgs e)
        {

        }
    }
}

