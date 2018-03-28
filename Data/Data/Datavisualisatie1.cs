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
    public partial class Datavisualisatie1 : Form
    {
        public static string filePath = @"../weer.txt";
        public List<Data> Maanden = new List<Data>();

        List<string> lines = File.ReadAllLines(filePath).ToList();
            
        public Datavisualisatie1()
        {
            InitializeComponent();
        }
        
        private void myButton_Click(object sender, EventArgs e)
        {
            foreach (var line in lines)
            {
                string[] entries = line.Split(';');

                Data newMaand = new Data
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
                this.WFDChart.Series["Gestolen fietsen"].Points.AddXY($"{ data.Maand }", data.FietsenDiefstal);
                this.WFDChart.Series["Max. Temperatuur"].Points.AddXY($"{ data.Maand }", data.MaxTemp);
                this.WFDChart.Series["Min. Temperatuur"].Points.AddXY($"{ data.Maand }", 33);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 mainMenu = new Form1();
            mainMenu.Show();
        }

        private void WGStitel_TextChanged(object sender, EventArgs e)
        {

        }

        private void WGSchart_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
