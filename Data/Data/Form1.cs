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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Datavisualisatie1 Datavisualisatie1 = new Datavisualisatie1();
            Datavisualisatie1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Datavisualisatie2 Datavisualisatie2 = new Datavisualisatie2();
            Datavisualisatie2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Datavisualisatie3 Datavisualisatie3 = new Datavisualisatie3();
            Datavisualisatie3.Show();
        }

        private void Shutdown_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"../1.mp3");
            player.Play();
        }
    }
}
