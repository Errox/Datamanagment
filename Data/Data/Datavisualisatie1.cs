using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
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


        public void LoadChart()
        {
            WFDChart.Series.Clear();
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
        }

        public void myButton_Click(object sender, EventArgs e)
        {
            myButton.Hide();
            LoadChart();
        }
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 mainMenu = new Form1();
            mainMenu.Show();

        }
    }
}
