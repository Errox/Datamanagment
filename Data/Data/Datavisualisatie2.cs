using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data
{
    public partial class Datavisualisatie2 : Form
    {
        public static string filePath = "../weer.txt";
        public List<Data> Maanden = new List<Data>();

        List<string> lines = File.ReadAllLines(filePath).ToList();


        public Datavisualisatie2()
        {
            InitializeComponent();
            LoadChart(true);
        }


        public void LoadChart(bool first)
        {
//            var values = check_checkbox();
            WGSchart.Series.Clear();
            WGSchart.ResetAutoValues();
            
            foreach (var series in WGSchart.Series)
            {
                series.Points.Clear();
            }
            var series1 = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "Neerslag"
            };
            var series2 = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "Google stock price"
            };
            WGSchart.Series.Add(series1);
            WGSchart.Series.Add(series2);
            WGSchart.ChartAreas[0].AxisX.Interval = 1;

            if (first == true)
            {
                foreach (var line in lines)
                {
                    var entries = line.Split(';');


                    var newMaand = new Data
                    {
                        Maand = entries[0],
                        Windsnelheid = entries[1],
                        Sterfte = entries[2],
                        Geboorte = entries[3],
                        Neerslag = entries[4],
                        Stock = entries[5],
                        MaxTemp = entries[6],
                        FietsenDiefstal = entries[7]
                    };

                    Maanden.Add(newMaand);
                    Console.WriteLine(Maanden);
                }

            }


            foreach (var data in Maanden)
            {

                if (Jan.Checked == true && data.Maand == "jan")
                {
                    WGSchart.Series["Neerslag"].Points.AddXY($"{data.Maand}", data.Neerslag);
                    WGSchart.Series["Google stock price"].Points.AddXY($"{data.Maand}", data.Stock);
                    Console.WriteLine("je moeder");
                }
                else if (feb.Checked == true && data.Maand == "feb")
                {
                    WGSchart.Series["Neerslag"].Points.AddXY($"{data.Maand}", data.Neerslag);
                    WGSchart.Series["Google stock price"].Points.AddXY($"{data.Maand}", data.Stock);
                }
                else if (apr.Checked == true && data.Maand == "apr")
                {
                    WGSchart.Series["Neerslag"].Points.AddXY($"{data.Maand}", data.Neerslag);
                    WGSchart.Series["Google stock price"].Points.AddXY($"{data.Maand}", data.Stock);

                }
                else if (mrt.Checked == true && data.Maand == "mrt")
                {
                    WGSchart.Series["Neerslag"].Points.AddXY($"{data.Maand}", data.Neerslag);
                    WGSchart.Series["Google stock price"].Points.AddXY($"{data.Maand}", data.Stock);

                }
                else if (mei.Checked == true && data.Maand == "mei")
                {
                    WGSchart.Series["Neerslag"].Points.AddXY($"{data.Maand}", data.Neerslag);
                    WGSchart.Series["Google stock price"].Points.AddXY($"{data.Maand}", data.Stock);

                }
                else if (jun.Checked == true && data.Maand == "jun")
                {
                    WGSchart.Series["Neerslag"].Points.AddXY($"{data.Maand}", data.Neerslag);
                    WGSchart.Series["Google stock price"].Points.AddXY($"{data.Maand}", data.Stock);

                }
                else if (jul.Checked == true && data.Maand == "jul")
                {
                    WGSchart.Series["Neerslag"].Points.AddXY($"{data.Maand}", data.Neerslag);
                    WGSchart.Series["Google stock price"].Points.AddXY($"{data.Maand}", data.Stock);

                }
                else if (aug.Checked == true && data.Maand == "aug")
                {
                    WGSchart.Series["Neerslag"].Points.AddXY($"{data.Maand}", data.Neerslag);
                    WGSchart.Series["Google stock price"].Points.AddXY($"{data.Maand}", data.Stock);
                }
                else if (sep.Checked == true && data.Maand == "sep")
                {
                    WGSchart.Series["Neerslag"].Points.AddXY($"{data.Maand}", data.Neerslag);
                    WGSchart.Series["Google stock price"].Points.AddXY($"{data.Maand}", data.Stock);
                }
                else if (okt.Checked == true && data.Maand == "okt")
                {
                    WGSchart.Series["Neerslag"].Points.AddXY($"{data.Maand}", data.Neerslag);
                    WGSchart.Series["Google stock price"].Points.AddXY($"{data.Maand}", data.Stock);

                }
                else if (nov.Checked == true && data.Maand == "nov")
                {
                    WGSchart.Series["Neerslag"].Points.AddXY($"{data.Maand}", data.Neerslag);
                    WGSchart.Series["Google stock price"].Points.AddXY($"{data.Maand}", data.Stock);

                }
                else if (dec.Checked == true && data.Maand == "dec")
                {
                    WGSchart.Series["Neerslag"].Points.AddXY($"{data.Maand}", data.Neerslag);
                    WGSchart.Series["Google stock price"].Points.AddXY($"{data.Maand}", data.Stock);

                }
                else
                {
                    Console.WriteLine("je moeder");
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
