using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using static System.Windows.Forms.LinkLabel;

namespace Data
{
    partial class Datavisualisatie1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Datavisualisatie1));
            this.myButton = new System.Windows.Forms.Button();
            this.WFDChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.WGSmaand = new System.Windows.Forms.GroupBox();
            this.WGSchartbox = new System.Windows.Forms.CheckBox();
            this.WGSdec = new System.Windows.Forms.CheckBox();
            this.WGSnov = new System.Windows.Forms.CheckBox();
            this.WGSokt = new System.Windows.Forms.CheckBox();
            this.WGSsep = new System.Windows.Forms.CheckBox();
            this.WGSaug = new System.Windows.Forms.CheckBox();
            this.WGSjul = new System.Windows.Forms.CheckBox();
            this.WGSjun = new System.Windows.Forms.CheckBox();
            this.WGSmei = new System.Windows.Forms.CheckBox();
            this.WGSapr = new System.Windows.Forms.CheckBox();
            this.WGSmrt = new System.Windows.Forms.CheckBox();
            this.WGSfeb = new System.Windows.Forms.CheckBox();
            this.WGSjan = new System.Windows.Forms.CheckBox();
            this.WGSinleiding = new System.Windows.Forms.TextBox();
            this.WGStitel = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.WFDChart)).BeginInit();
            this.WGSmaand.SuspendLayout();
            this.SuspendLayout();
            // 
            // myButton
            // 
            this.myButton.Location = new System.Drawing.Point(1011, 670);
            this.myButton.Margin = new System.Windows.Forms.Padding(4);
            this.myButton.Name = "myButton";
            this.myButton.Size = new System.Drawing.Size(167, 28);
            this.myButton.TabIndex = 0;
            this.myButton.Text = "myButton";
            this.myButton.UseVisualStyleBackColor = true;
            this.myButton.Click += new System.EventHandler(this.myButton_Click);
            // 
            // WFDChart
            // 
            this.WFDChart.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            chartArea1.Name = "ChartArea1";
            this.WFDChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.WFDChart.Legends.Add(legend1);
            this.WFDChart.Location = new System.Drawing.Point(712, 153);
            this.WFDChart.Margin = new System.Windows.Forms.Padding(4);
            this.WFDChart.Name = "WFDChart";
            this.WFDChart.Size = new System.Drawing.Size(831, 492);
            this.WFDChart.TabIndex = 30;
            this.WFDChart.Text = "Windsnelheid en geboorte en sterfte";
            // 
            // WGSmaand
            // 
            this.WGSmaand.Controls.Add(this.WGSchartbox);
            this.WGSmaand.Controls.Add(this.WGSdec);
            this.WGSmaand.Controls.Add(this.WGSnov);
            this.WGSmaand.Controls.Add(this.WGSokt);
            this.WGSmaand.Controls.Add(this.WGSsep);
            this.WGSmaand.Controls.Add(this.WGSaug);
            this.WGSmaand.Controls.Add(this.WGSjul);
            this.WGSmaand.Controls.Add(this.WGSjun);
            this.WGSmaand.Controls.Add(this.WGSmei);
            this.WGSmaand.Controls.Add(this.WGSapr);
            this.WGSmaand.Controls.Add(this.WGSmrt);
            this.WGSmaand.Controls.Add(this.WGSfeb);
            this.WGSmaand.Controls.Add(this.WGSjan);
            this.WGSmaand.Location = new System.Drawing.Point(124, 453);
            this.WGSmaand.Margin = new System.Windows.Forms.Padding(4);
            this.WGSmaand.Name = "WGSmaand";
            this.WGSmaand.Padding = new System.Windows.Forms.Padding(4);
            this.WGSmaand.Size = new System.Drawing.Size(533, 160);
            this.WGSmaand.TabIndex = 27;
            this.WGSmaand.TabStop = false;
            this.WGSmaand.Text = "Maand";
            // 
            // WGSchartbox
            // 
            this.WGSchartbox.AutoSize = true;
            this.WGSchartbox.Checked = true;
            this.WGSchartbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.WGSchartbox.Location = new System.Drawing.Point(39, 124);
            this.WGSchartbox.Name = "WGSchartbox";
            this.WGSchartbox.Size = new System.Drawing.Size(93, 21);
            this.WGSchartbox.TabIndex = 31;
            this.WGSchartbox.Text = "hele chart";
            this.WGSchartbox.UseVisualStyleBackColor = true;
            this.WGSchartbox.CheckedChanged += new System.EventHandler(this.WGSchart_CheckedChanged);
            // 
            // WGSdec
            // 
            this.WGSdec.AutoSize = true;
            this.WGSdec.Checked = true;
            this.WGSdec.CheckState = System.Windows.Forms.CheckState.Checked;
            this.WGSdec.Location = new System.Drawing.Point(384, 96);
            this.WGSdec.Margin = new System.Windows.Forms.Padding(4);
            this.WGSdec.Name = "WGSdec";
            this.WGSdec.Size = new System.Drawing.Size(93, 21);
            this.WGSdec.TabIndex = 11;
            this.WGSdec.Text = "december";
            this.WGSdec.UseVisualStyleBackColor = true;
            // 
            // WGSnov
            // 
            this.WGSnov.AutoSize = true;
            this.WGSnov.Checked = true;
            this.WGSnov.CheckState = System.Windows.Forms.CheckState.Checked;
            this.WGSnov.Location = new System.Drawing.Point(269, 96);
            this.WGSnov.Margin = new System.Windows.Forms.Padding(4);
            this.WGSnov.Name = "WGSnov";
            this.WGSnov.Size = new System.Drawing.Size(93, 21);
            this.WGSnov.TabIndex = 10;
            this.WGSnov.Text = "november";
            this.WGSnov.UseVisualStyleBackColor = true;
            // 
            // WGSokt
            // 
            this.WGSokt.AutoSize = true;
            this.WGSokt.Checked = true;
            this.WGSokt.CheckState = System.Windows.Forms.CheckState.Checked;
            this.WGSokt.Location = new System.Drawing.Point(155, 96);
            this.WGSokt.Margin = new System.Windows.Forms.Padding(4);
            this.WGSokt.Name = "WGSokt";
            this.WGSokt.Size = new System.Drawing.Size(78, 21);
            this.WGSokt.TabIndex = 9;
            this.WGSokt.Text = "oktober";
            this.WGSokt.UseVisualStyleBackColor = true;
            // 
            // WGSsep
            // 
            this.WGSsep.AutoSize = true;
            this.WGSsep.Checked = true;
            this.WGSsep.CheckState = System.Windows.Forms.CheckState.Checked;
            this.WGSsep.Location = new System.Drawing.Point(40, 96);
            this.WGSsep.Margin = new System.Windows.Forms.Padding(4);
            this.WGSsep.Name = "WGSsep";
            this.WGSsep.Size = new System.Drawing.Size(97, 21);
            this.WGSsep.TabIndex = 8;
            this.WGSsep.Text = "september";
            this.WGSsep.UseVisualStyleBackColor = true;
            // 
            // WGSaug
            // 
            this.WGSaug.AutoSize = true;
            this.WGSaug.Checked = true;
            this.WGSaug.CheckState = System.Windows.Forms.CheckState.Checked;
            this.WGSaug.Location = new System.Drawing.Point(384, 66);
            this.WGSaug.Margin = new System.Windows.Forms.Padding(4);
            this.WGSaug.Name = "WGSaug";
            this.WGSaug.Size = new System.Drawing.Size(88, 21);
            this.WGSaug.TabIndex = 7;
            this.WGSaug.Text = "augustus";
            this.WGSaug.UseVisualStyleBackColor = true;
            // 
            // WGSjul
            // 
            this.WGSjul.AutoSize = true;
            this.WGSjul.Checked = true;
            this.WGSjul.CheckState = System.Windows.Forms.CheckState.Checked;
            this.WGSjul.Location = new System.Drawing.Point(269, 66);
            this.WGSjul.Margin = new System.Windows.Forms.Padding(4);
            this.WGSjul.Name = "WGSjul";
            this.WGSjul.Size = new System.Drawing.Size(47, 21);
            this.WGSjul.TabIndex = 6;
            this.WGSjul.Text = "juli";
            this.WGSjul.UseVisualStyleBackColor = true;
            // 
            // WGSjun
            // 
            this.WGSjun.AutoSize = true;
            this.WGSjun.Checked = true;
            this.WGSjun.CheckState = System.Windows.Forms.CheckState.Checked;
            this.WGSjun.Location = new System.Drawing.Point(155, 66);
            this.WGSjun.Margin = new System.Windows.Forms.Padding(4);
            this.WGSjun.Name = "WGSjun";
            this.WGSjun.Size = new System.Drawing.Size(52, 21);
            this.WGSjun.TabIndex = 5;
            this.WGSjun.Text = "juni";
            this.WGSjun.UseVisualStyleBackColor = true;
            // 
            // WGSmei
            // 
            this.WGSmei.AutoSize = true;
            this.WGSmei.Checked = true;
            this.WGSmei.CheckState = System.Windows.Forms.CheckState.Checked;
            this.WGSmei.Location = new System.Drawing.Point(40, 66);
            this.WGSmei.Margin = new System.Windows.Forms.Padding(4);
            this.WGSmei.Name = "WGSmei";
            this.WGSmei.Size = new System.Drawing.Size(52, 21);
            this.WGSmei.TabIndex = 4;
            this.WGSmei.Text = "mei";
            this.WGSmei.UseVisualStyleBackColor = true;
            // 
            // WGSapr
            // 
            this.WGSapr.AutoSize = true;
            this.WGSapr.Checked = true;
            this.WGSapr.CheckState = System.Windows.Forms.CheckState.Checked;
            this.WGSapr.Location = new System.Drawing.Point(384, 37);
            this.WGSapr.Margin = new System.Windows.Forms.Padding(4);
            this.WGSapr.Name = "WGSapr";
            this.WGSapr.Size = new System.Drawing.Size(57, 21);
            this.WGSapr.TabIndex = 3;
            this.WGSapr.Text = "april";
            this.WGSapr.UseVisualStyleBackColor = true;
            // 
            // WGSmrt
            // 
            this.WGSmrt.AutoSize = true;
            this.WGSmrt.Checked = true;
            this.WGSmrt.CheckState = System.Windows.Forms.CheckState.Checked;
            this.WGSmrt.Location = new System.Drawing.Point(269, 37);
            this.WGSmrt.Margin = new System.Windows.Forms.Padding(4);
            this.WGSmrt.Name = "WGSmrt";
            this.WGSmrt.Size = new System.Drawing.Size(66, 21);
            this.WGSmrt.TabIndex = 2;
            this.WGSmrt.Text = "maart";
            this.WGSmrt.UseVisualStyleBackColor = true;
            // 
            // WGSfeb
            // 
            this.WGSfeb.AutoSize = true;
            this.WGSfeb.Checked = true;
            this.WGSfeb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.WGSfeb.Location = new System.Drawing.Point(155, 37);
            this.WGSfeb.Margin = new System.Windows.Forms.Padding(4);
            this.WGSfeb.Name = "WGSfeb";
            this.WGSfeb.Size = new System.Drawing.Size(79, 21);
            this.WGSfeb.TabIndex = 1;
            this.WGSfeb.Text = "februari";
            this.WGSfeb.UseVisualStyleBackColor = true;
            // 
            // WGSjan
            // 
            this.WGSjan.AutoSize = true;
            this.WGSjan.Checked = true;
            this.WGSjan.CheckState = System.Windows.Forms.CheckState.Checked;
            this.WGSjan.Location = new System.Drawing.Point(40, 37);
            this.WGSjan.Margin = new System.Windows.Forms.Padding(4);
            this.WGSjan.Name = "WGSjan";
            this.WGSjan.Size = new System.Drawing.Size(73, 21);
            this.WGSjan.TabIndex = 0;
            this.WGSjan.Text = "januari";
            this.WGSjan.UseVisualStyleBackColor = true;
            this.WGSjan.CheckedChanged += new System.EventHandler(this.WGSjan_CheckedChanged);
            // 
            // WGSinleiding
            // 
            this.WGSinleiding.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WGSinleiding.Location = new System.Drawing.Point(77, 231);
            this.WGSinleiding.Margin = new System.Windows.Forms.Padding(4);
            this.WGSinleiding.Multiline = true;
            this.WGSinleiding.Name = "WGSinleiding";
            this.WGSinleiding.ReadOnly = true;
            this.WGSinleiding.Size = new System.Drawing.Size(625, 85);
            this.WGSinleiding.TabIndex = 29;
            this.WGSinleiding.Text = resources.GetString("WGSinleiding.Text");
            // 
            // WGStitel
            // 
            this.WGStitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WGStitel.Location = new System.Drawing.Point(91, 10);
            this.WGStitel.Margin = new System.Windows.Forms.Padding(4);
            this.WGStitel.Name = "WGStitel";
            this.WGStitel.Size = new System.Drawing.Size(1279, 53);
            this.WGStitel.TabIndex = 28;
            this.WGStitel.Text = "Temperatuur en fiets diefstal\r\n";
            this.WGStitel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1011, 705);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 31);
            this.button1.TabIndex = 26;
            this.button1.Text = "Terug naar hoofdmenu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Datavisualisatie1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1559, 791);
            this.Controls.Add(this.WFDChart);
            this.Controls.Add(this.WGSmaand);
            this.Controls.Add(this.WGSinleiding);
            this.Controls.Add(this.WGStitel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.myButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Datavisualisatie1";
            this.Text = "dataVisualisatie1";
            this.Load += new System.EventHandler(this.myButton_Click);
            ((System.ComponentModel.ISupportInitialize)(this.WFDChart)).EndInit();
            this.WGSmaand.ResumeLayout(false);
            this.WGSmaand.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button myButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart WFDChart;
        private System.Windows.Forms.GroupBox WGSmaand;
        private System.Windows.Forms.CheckBox WGSdec;
        private System.Windows.Forms.CheckBox WGSnov;
        private System.Windows.Forms.CheckBox WGSokt;
        private System.Windows.Forms.CheckBox WGSsep;
        private System.Windows.Forms.CheckBox WGSaug;
        private System.Windows.Forms.CheckBox WGSjul;
        private System.Windows.Forms.CheckBox WGSjun;
        private System.Windows.Forms.CheckBox WGSmei;
        private System.Windows.Forms.CheckBox WGSapr;
        private System.Windows.Forms.CheckBox WGSmrt;
        private System.Windows.Forms.CheckBox WGSfeb;
        private System.Windows.Forms.CheckBox WGSjan;
        private System.Windows.Forms.TextBox WGSinleiding;
        private System.Windows.Forms.TextBox WGStitel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox WGSchartbox;
    }
    }
