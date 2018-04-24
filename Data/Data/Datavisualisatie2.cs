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

using System.Data.SqlClient;
using MySql.Data.MySqlClient;
namespace Data
{
    public partial class Datavisualisatie2 : Form
    {
        public static string filePath = "../../Resources/weer.txt";
        public List<Data> Maanden = new List<Data>();

        List<string> lines = File.ReadAllLines(filePath).ToList();


        public Datavisualisatie2()
        {
            string MyConnectionString = "Server=localhost;Database=school;UID=root;PWD=root;PORT=3306;SslMode=none;";

            MySqlConnection connection = new MySqlConnection(MyConnectionString);
            MySqlCommand cmd;
            connection.Open();

            try
            {
                cmd = connection.CreateCommand();
                cmd.CommandText = "select Month(Date) Month, avg(Neerslag) as neerslag, max(max_temp) * 0.1 as max_temp, avg(windsnelheid) * 100 as windsnelheid from kmni group by Month(Date)";
                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                DataSet stocks = new DataSet();
                adap.Fill(stocks);
                DataTable dt = new DataTable();
                dt = stocks.Tables["knmi"];

                foreach (DataRow dr in dt.Rows)
                {
                    MessageBox.Show(dr["max_temp"].ToString());
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
                Name = "Neerslag in mm"
            };
            var series2 = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "Google stock price in euro's"
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
                    cmd.CommandText = "Select Month(stocks.Date) Months, round(avg(stocks.Open)) as stock_price, round(avg(kmni.neerslag)) as neerslag from stocks join kmni on stocks.Date = kmni.Date group by Month(stocks.Date)";
                    MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                    DataSet stocks = new DataSet();
                    adap.Fill(stocks, "stocks");
                    DataTable dt = new DataTable();
                    dt = stocks.Tables["stocks"]; //table exactly like sql table.

                    foreach (DataRow dr in dt.Rows)
                    {
                        var newMaand = new Data
                        {
                            Maand = dr["Months"].ToString(),
                            Neerslag = dr["neerslag"].ToString(),
                            Stock = dr["stock_price"].ToString()
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
                    WGSchart.Series["Neerslag in mm"].Points.AddXY($"Januari", data.Neerslag);
                    WGSchart.Series["Google stock price in euro's"].Points.AddXY($"{data.Maand}", data.Stock);
                }
                else if (feb.Checked == true && data.Maand == "2")
                {
                    WGSchart.Series["Neerslag in mm"].Points.AddXY($"Februari", data.Neerslag);
                    WGSchart.Series["Google stock price in euro's"].Points.AddXY($"{data.Maand}", data.Stock);
                }
                else if (apr.Checked == true && data.Maand == "3")
                {
                    WGSchart.Series["Neerslag in mm"].Points.AddXY($"Maart", data.Neerslag);
                    WGSchart.Series["Google stock price in euro's"].Points.AddXY($"{data.Maand}", data.Stock);

                }
                else if (mrt.Checked == true && data.Maand == "4")
                {
                    WGSchart.Series["Neerslag in mm"].Points.AddXY($"April", data.Neerslag);
                    WGSchart.Series["Google stock price in euro's"].Points.AddXY($"{data.Maand}", data.Stock);

                }
                else if (mei.Checked == true && data.Maand == "5")
                {
                    WGSchart.Series["Neerslag in mm"].Points.AddXY($"Mei", data.Neerslag);
                    WGSchart.Series["Google stock price in euro's"].Points.AddXY($"{data.Maand}", data.Stock);

                }
                else if (jun.Checked == true && data.Maand == "6")
                {
                    WGSchart.Series["Neerslag in mm"].Points.AddXY($"Juni", data.Neerslag);
                    WGSchart.Series["Google stock price in euro's"].Points.AddXY($"{data.Maand}", data.Stock);

                }
                else if (jul.Checked == true && data.Maand == "7")
                {
                    WGSchart.Series["Neerslag in mm"].Points.AddXY($"Juli", data.Neerslag);
                    WGSchart.Series["Google stock price in euro's"].Points.AddXY($"{data.Maand}", data.Stock);

                }
                else if (aug.Checked == true && data.Maand == "8")
                {
                    WGSchart.Series["Neerslag in mm"].Points.AddXY($"Augustus", data.Neerslag);
                    WGSchart.Series["Google stock price in euro's"].Points.AddXY($"{data.Maand}", data.Stock);
                }
                else if (sep.Checked == true && data.Maand == "9")
                {
                    WGSchart.Series["Neerslag in mm"].Points.AddXY($"September", data.Neerslag);
                    WGSchart.Series["Google stock price in euro's"].Points.AddXY($"{data.Maand}", data.Stock);
                }
                else if (okt.Checked == true && data.Maand == "10")
                {
                    WGSchart.Series["Neerslag in mm"].Points.AddXY($"October", data.Neerslag);
                    WGSchart.Series["Google stock price in euro's"].Points.AddXY($"{data.Maand}", data.Stock);

                }
                else if (nov.Checked == true && data.Maand == "11")
                {
                    WGSchart.Series["Neerslag in mm"].Points.AddXY($"November", data.Neerslag);
                    WGSchart.Series["Google stock price in euro's"].Points.AddXY($"{data.Maand}", data.Stock);

                }
                else if (dec.Checked == true && data.Maand == "12")
                {
                    WGSchart.Series["Neerslag in mm"].Points.AddXY($"December", data.Neerslag);
                    WGSchart.Series["Google stock price in euro's"].Points.AddXY($"{data.Maand}", data.Stock);

                }
                else
                {
                    Console.WriteLine("Shouldn't be here but it still looks nice with a extra console line D: ");
                }

            }

            return;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 mainMenu = new Form1();
            mainMenu.Show();
        }

        private void WGSchart_Click(object sender, EventArgs e)
        {

        }

        private void feb_CheckedChanged(object sender, EventArgs e)
        {
            LoadChart(false);
        }

        private void check_jan_CheckedChanged(object sender, EventArgs e)
        {
            LoadChart(false);
        }

        private void mrt_CheckedChanged(object sender, EventArgs e)
        {
            LoadChart(false);
        }

        private void apr_CheckedChanged(object sender, EventArgs e)
        {
            LoadChart(false);
        }

        private void aug_CheckedChanged(object sender, EventArgs e)
        {
            LoadChart(false);
        }

        private void jul_CheckedChanged(object sender, EventArgs e)
        {
            LoadChart(false);
        }

        private void jun_CheckedChanged(object sender, EventArgs e)
        {
            LoadChart(false);
        }

        private void mei_CheckedChanged(object sender, EventArgs e)
        {
            LoadChart(false);
        }

        private void sep_CheckedChanged(object sender, EventArgs e)
        {
            LoadChart(false);
        }

        private void okt_CheckedChanged(object sender, EventArgs e)
        {
            LoadChart(false);
        }

        private void nov_CheckedChanged(object sender, EventArgs e)
        {
            LoadChart(false);
        }

        private void dec_CheckedChanged(object sender, EventArgs e)
        {
            LoadChart(false);
        }
    }
}
