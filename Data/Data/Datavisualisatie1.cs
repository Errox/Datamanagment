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

namespace Data
{
    public partial class Datavisualisatie1 : Form
    {
        public static string filePath = "weer.txt";
        public List<Data> Maanden = new List<Data>();

        List<string> lines = File.ReadAllLines(filePath).ToList();
        public static bool JanCheck;
        public bool[] Arraycheck = new bool[] { JanCheck };

        public void LoadChart()
        {
            var series1 = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "Gestolen fietsen"
            };
            var series2 = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "Max. Temperatuur"
            };
            WFDChart.Series.Add(series1);
            WFDChart.Series.Add(series2);
            foreach (var line in lines)
            {
                var entriesLine = line;

                //var newLine = new Maanden
                //{
                //    Maand = entriesLine[0]

                //};

            }
            foreach (var newLine in lines)
            {
                var entries = newLine.Split(';');

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



            foreach (var data in Maanden)
            {
                WFDChart.Series["Gestolen fietsen"].Points.AddXY($"{data.Maand}", data.FietsenDiefstal);
                WFDChart.Series["Max. Temperatuur"].Points.AddXY($"{data.Maand}", data.MaxTemp);
            }

            return;
        }


        public Datavisualisatie1()
        {
            InitializeComponent();
            LoadChart();
        }

        public void myButton_Click(object sender, EventArgs e)
        {
            myButton.Hide();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 mainMenu = new Form1();
            mainMenu.Show();

        }

        private void WGSchart_CheckedChanged(object sender, EventArgs e)
        {
            if (WGSchartbox.Checked == false)
            {
                WGSjan.Checked = false;
                WGSfeb.Checked = false;
                WGSmrt.Checked = false;
                WGSapr.Checked = false;
                WGSmei.Checked = false;
                WGSjun.Checked = false;
                WGSjul.Checked = false;
                WGSaug.Checked = false;
                WGSsep.Checked = false;
                WGSokt.Checked = false;
                WGSnov.Checked = false;
                WGSdec.Checked = false;
            }
            else
            {
                WGSjan.Checked = true;
                WGSfeb.Checked = true;
                WGSmrt.Checked = true;
                WGSapr.Checked = true;
                WGSmei.Checked = true;
                WGSjun.Checked = true;
                WGSjul.Checked = true;
                WGSaug.Checked = true;
                WGSsep.Checked = true;
                WGSokt.Checked = true;
                WGSnov.Checked = true;
                WGSdec.Checked = true;
            }
        }

        private void WGSjan_CheckedChanged(object sender, EventArgs e)
        {
            if (WGSjan.Checked == true)
            {
                JanCheck = true;
            }
        }
    }
}
