﻿using System;
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

namespace Data
{
    public partial class Datavisualisatie3 : Form
    {
        public static string filePath = "../../Resources/weer.txt";
        public List<Data> Maanden = new List<Data>();

        List<string> lines = File.ReadAllLines(filePath).ToList();


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
                }

            }


            foreach (var data in Maanden)
            {

                if (Jan.Checked == true && data.Maand == "jan")
                {
                    WGSchart.Series["Windsnelheid"].Points.AddXY($"{data.Maand}", data.Windsnelheid);
                    WGSchart.Series["Sterfte"].Points.AddXY($"{data.Maand}", data.Sterfte);
                    WGSchart.Series["Geboorte"].Points.AddXY($"{data.Maand}", data.Geboorte);
                }
                else if (feb.Checked == true && data.Maand == "feb")
                {
                    WGSchart.Series["Windsnelheid"].Points.AddXY($"{data.Maand}", data.Windsnelheid);
                    WGSchart.Series["Sterfte"].Points.AddXY($"{data.Maand}", data.Sterfte);
                    WGSchart.Series["Geboorte"].Points.AddXY($"{data.Maand}", data.Geboorte);
                }
                else if (apr.Checked == true && data.Maand == "apr")
                {
                    WGSchart.Series["Windsnelheid"].Points.AddXY($"{data.Maand}", data.Windsnelheid);
                    WGSchart.Series["Sterfte"].Points.AddXY($"{data.Maand}", data.Sterfte);
                    WGSchart.Series["Geboorte"].Points.AddXY($"{data.Maand}", data.Geboorte);
                }
                else if (mrt.Checked == true && data.Maand == "mrt")
                {
                    WGSchart.Series["Windsnelheid"].Points.AddXY($"{data.Maand}", data.Windsnelheid);
                    WGSchart.Series["Sterfte"].Points.AddXY($"{data.Maand}", data.Sterfte);
                    WGSchart.Series["Geboorte"].Points.AddXY($"{data.Maand}", data.Geboorte);
                }
                else if (mei.Checked == true && data.Maand == "mei")
                {
                    WGSchart.Series["Windsnelheid"].Points.AddXY($"{data.Maand}", data.Windsnelheid);
                    WGSchart.Series["Sterfte"].Points.AddXY($"{data.Maand}", data.Sterfte);
                    WGSchart.Series["Geboorte"].Points.AddXY($"{data.Maand}", data.Geboorte);
                }
                else if (jun.Checked == true && data.Maand == "jun")
                {
                    WGSchart.Series["Windsnelheid"].Points.AddXY($"{data.Maand}", data.Windsnelheid);
                    WGSchart.Series["Sterfte"].Points.AddXY($"{data.Maand}", data.Sterfte);
                    WGSchart.Series["Geboorte"].Points.AddXY($"{data.Maand}", data.Geboorte);
                }
                else if (jul.Checked == true && data.Maand == "jul")
                {
                    WGSchart.Series["Windsnelheid"].Points.AddXY($"{data.Maand}", data.Windsnelheid);
                    WGSchart.Series["Sterfte"].Points.AddXY($"{data.Maand}", data.Sterfte);
                    WGSchart.Series["Geboorte"].Points.AddXY($"{data.Maand}", data.Geboorte);
                }
                else if (aug.Checked == true && data.Maand == "aug")
                {
                    WGSchart.Series["Windsnelheid"].Points.AddXY($"{data.Maand}", data.Windsnelheid);
                    WGSchart.Series["Sterfte"].Points.AddXY($"{data.Maand}", data.Sterfte);
                    WGSchart.Series["Geboorte"].Points.AddXY($"{data.Maand}", data.Geboorte);
                }
                else if (sep.Checked == true && data.Maand == "sep")
                {
                    WGSchart.Series["Windsnelheid"].Points.AddXY($"{data.Maand}", data.Windsnelheid);
                    WGSchart.Series["Sterfte"].Points.AddXY($"{data.Maand}", data.Sterfte);
                    WGSchart.Series["Geboorte"].Points.AddXY($"{data.Maand}", data.Geboorte);
                }
                else if (okt.Checked == true && data.Maand == "okt")
                {
                    WGSchart.Series["Windsnelheid"].Points.AddXY($"{data.Maand}", data.Windsnelheid);
                    WGSchart.Series["Sterfte"].Points.AddXY($"{data.Maand}", data.Sterfte);
                    WGSchart.Series["Geboorte"].Points.AddXY($"{data.Maand}", data.Geboorte);
                }
                else if (nov.Checked == true && data.Maand == "nov")
                {
                    WGSchart.Series["Windsnelheid"].Points.AddXY($"{data.Maand}", data.Windsnelheid);
                    WGSchart.Series["Sterfte"].Points.AddXY($"{data.Maand}", data.Sterfte);
                    WGSchart.Series["Geboorte"].Points.AddXY($"{data.Maand}", data.Geboorte);
                }
                else if (dec.Checked == true && data.Maand == "dec")
                {
                    WGSchart.Series["Windsnelheid"].Points.AddXY($"{data.Maand}", data.Windsnelheid);
                    WGSchart.Series["Sterfte"].Points.AddXY($"{data.Maand}", data.Sterfte);
                    WGSchart.Series["Geboorte"].Points.AddXY($"{data.Maand}", data.Geboorte);
                }
<<<<<<< HEAD
=======
                else
                {
                    Console.WriteLine("Shouldn't be here but it still looks nice with a extra console line D: ");
                }

>>>>>>> a3cea27e79a4e2d551ef202dc492534825fbb8f4
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

