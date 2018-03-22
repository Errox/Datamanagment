using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data
{
    public partial class Datavisualisatie1 : Form
    {
        public Datavisualisatie1()
        {
            InitializeComponent();
        }

        private void myButton_Click(object sender, EventArgs e)
        {
            this.WFDChart.Series["Gestolen fietsen"].Points.AddXY("Jan", 33);
            this.WFDChart.Series["Gestolen fietsen"].Points.AddXY("Feb", 33);
            this.WFDChart.Series["Gestolen fietsen"].Points.AddXY("Maa", 33);
            this.WFDChart.Series["Gestolen fietsen"].Points.AddXY("Apr", 33);
            this.WFDChart.Series["Gestolen fietsen"].Points.AddXY("Mei", 33);
            this.WFDChart.Series["Gestolen fietsen"].Points.AddXY("Jun", 33);
            this.WFDChart.Series["Gestolen fietsen"].Points.AddXY("Jul", 33);
            this.WFDChart.Series["Gestolen fietsen"].Points.AddXY("Aug", 33);
            this.WFDChart.Series["Gestolen fietsen"].Points.AddXY("Sept", 33);
            this.WFDChart.Series["Gestolen fietsen"].Points.AddXY("Oct", 33);
            this.WFDChart.Series["Gestolen fietsen"].Points.AddXY("Nov", 33);
            this.WFDChart.Series["Gestolen fietsen"].Points.AddXY("Dec", 33);

            this.WFDChart.Series["Max. Temperatuur"].Points.AddXY("Jan", 33);
            this.WFDChart.Series["Max. Temperatuur"].Points.AddXY("Feb", 33);
            this.WFDChart.Series["Max. Temperatuur"].Points.AddXY("Maa", 33);
            this.WFDChart.Series["Max. Temperatuur"].Points.AddXY("Apr", 33);
            this.WFDChart.Series["Max. Temperatuur"].Points.AddXY("Mei", 33);
            this.WFDChart.Series["Max. Temperatuur"].Points.AddXY("Jun", 33);
            this.WFDChart.Series["Max. Temperatuur"].Points.AddXY("Jul", 33);
            this.WFDChart.Series["Max. Temperatuur"].Points.AddXY("Aug", 33);
            this.WFDChart.Series["Max. Temperatuur"].Points.AddXY("Sept", 33);
            this.WFDChart.Series["Max. Temperatuur"].Points.AddXY("Oct", 33);
            this.WFDChart.Series["Max. Temperatuur"].Points.AddXY("Nov", 33);
            this.WFDChart.Series["Max. Temperatuur"].Points.AddXY("Dec", 33);

            this.WFDChart.Series["Min. Temperatuur"].Points.AddXY("Jan", 33);
            this.WFDChart.Series["Min. Temperatuur"].Points.AddXY("Feb", 33);
            this.WFDChart.Series["Min. Temperatuur"].Points.AddXY("Maa", 33);
            this.WFDChart.Series["Min. Temperatuur"].Points.AddXY("Apr", 33);
            this.WFDChart.Series["Min. Temperatuur"].Points.AddXY("Mei", 33);
            this.WFDChart.Series["Min. Temperatuur"].Points.AddXY("Jun", 33);
            this.WFDChart.Series["Min. Temperatuur"].Points.AddXY("Jul", 33);
            this.WFDChart.Series["Min. Temperatuur"].Points.AddXY("Aug", 33);
            this.WFDChart.Series["Min. Temperatuur"].Points.AddXY("Sept", 33);
            this.WFDChart.Series["Min. Temperatuur"].Points.AddXY("Oct", 33);
            this.WFDChart.Series["Min. Temperatuur"].Points.AddXY("Nov", 33);
            this.WFDChart.Series["Min. Temperatuur"].Points.AddXY("Dec", 33);
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

        }
    }
}
