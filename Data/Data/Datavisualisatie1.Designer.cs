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
            this.WGSchart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.WGSinleiding = new System.Windows.Forms.TextBox();
            this.WGSmaand = new System.Windows.Forms.GroupBox();
            this.dec = new System.Windows.Forms.CheckBox();
            this.nov = new System.Windows.Forms.CheckBox();
            this.okt = new System.Windows.Forms.CheckBox();
            this.sep = new System.Windows.Forms.CheckBox();
            this.aug = new System.Windows.Forms.CheckBox();
            this.jul = new System.Windows.Forms.CheckBox();
            this.jun = new System.Windows.Forms.CheckBox();
            this.mei = new System.Windows.Forms.CheckBox();
            this.apr = new System.Windows.Forms.CheckBox();
            this.mrt = new System.Windows.Forms.CheckBox();
            this.feb = new System.Windows.Forms.CheckBox();
            this.Jan = new System.Windows.Forms.CheckBox();
            this.WGStitel = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.WGSchart)).BeginInit();
            this.WGSmaand.SuspendLayout();
            this.SuspendLayout();
            // 
            // WGSchart
            // 
            chartArea1.AxisX.LabelAutoFitMaxFontSize = 14;
            chartArea1.AxisX.LabelAutoFitMinFontSize = 14;
            chartArea1.AxisX2.LabelAutoFitMaxFontSize = 14;
            chartArea1.AxisX2.LabelAutoFitMinFontSize = 14;
            chartArea1.Name = "ChartArea1";
            this.WGSchart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.WGSchart.Legends.Add(legend1);
            this.WGSchart.Location = new System.Drawing.Point(105, 140);
            this.WGSchart.Name = "WGSchart";
            this.WGSchart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            this.WGSchart.Size = new System.Drawing.Size(960, 370);
            this.WGSchart.TabIndex = 30;
            this.WGSchart.Text = "Google stocks en Het weer";
            this.WGSchart.Click += new System.EventHandler(this.WGSchart_Click);
            // 
            // WGSinleiding
            // 
            this.WGSinleiding.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WGSinleiding.Location = new System.Drawing.Point(350, 60);
            this.WGSinleiding.Multiline = true;
            this.WGSinleiding.Name = "WGSinleiding";
            this.WGSinleiding.Size = new System.Drawing.Size(480, 70);
            this.WGSinleiding.TabIndex = 34;
            this.WGSinleiding.Text = resources.GetString("WGSinleiding.Text");
            this.WGSinleiding.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // WGSmaand
            // 
            this.WGSmaand.Controls.Add(this.dec);
            this.WGSmaand.Controls.Add(this.nov);
            this.WGSmaand.Controls.Add(this.okt);
            this.WGSmaand.Controls.Add(this.sep);
            this.WGSmaand.Controls.Add(this.aug);
            this.WGSmaand.Controls.Add(this.jul);
            this.WGSmaand.Controls.Add(this.jun);
            this.WGSmaand.Controls.Add(this.mei);
            this.WGSmaand.Controls.Add(this.apr);
            this.WGSmaand.Controls.Add(this.mrt);
            this.WGSmaand.Controls.Add(this.feb);
            this.WGSmaand.Controls.Add(this.Jan);
            this.WGSmaand.Location = new System.Drawing.Point(400, 520);
            this.WGSmaand.Name = "WGSmaand";
            this.WGSmaand.Size = new System.Drawing.Size(400, 130);
            this.WGSmaand.TabIndex = 32;
            this.WGSmaand.TabStop = false;
            this.WGSmaand.Text = "Maand";
            // 
            // dec
            // 
            this.dec.AutoSize = true;
            this.dec.Checked = true;
            this.dec.CheckState = System.Windows.Forms.CheckState.Checked;
            this.dec.Location = new System.Drawing.Point(288, 78);
            this.dec.Name = "dec";
            this.dec.Size = new System.Drawing.Size(73, 17);
            this.dec.TabIndex = 11;
            this.dec.Text = "december";
            this.dec.UseVisualStyleBackColor = true;
            this.dec.CheckedChanged += new System.EventHandler(this.dec_CheckedChanged_1);
            // 
            // nov
            // 
            this.nov.AutoSize = true;
            this.nov.Checked = true;
            this.nov.CheckState = System.Windows.Forms.CheckState.Checked;
            this.nov.Location = new System.Drawing.Point(202, 78);
            this.nov.Name = "nov";
            this.nov.Size = new System.Drawing.Size(73, 17);
            this.nov.TabIndex = 10;
            this.nov.Text = "november";
            this.nov.UseVisualStyleBackColor = true;
            this.nov.CheckedChanged += new System.EventHandler(this.nov_CheckedChanged_1);
            // 
            // okt
            // 
            this.okt.AutoSize = true;
            this.okt.Checked = true;
            this.okt.CheckState = System.Windows.Forms.CheckState.Checked;
            this.okt.Location = new System.Drawing.Point(116, 78);
            this.okt.Name = "okt";
            this.okt.Size = new System.Drawing.Size(62, 17);
            this.okt.TabIndex = 9;
            this.okt.Text = "oktober";
            this.okt.UseVisualStyleBackColor = true;
            this.okt.CheckedChanged += new System.EventHandler(this.okt_CheckedChanged_1);
            // 
            // sep
            // 
            this.sep.AutoSize = true;
            this.sep.Checked = true;
            this.sep.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sep.Location = new System.Drawing.Point(30, 78);
            this.sep.Name = "sep";
            this.sep.Size = new System.Drawing.Size(75, 17);
            this.sep.TabIndex = 8;
            this.sep.Text = "september";
            this.sep.UseVisualStyleBackColor = true;
            this.sep.CheckedChanged += new System.EventHandler(this.sep_CheckedChanged_1);
            // 
            // aug
            // 
            this.aug.AutoSize = true;
            this.aug.Checked = true;
            this.aug.CheckState = System.Windows.Forms.CheckState.Checked;
            this.aug.Location = new System.Drawing.Point(288, 54);
            this.aug.Name = "aug";
            this.aug.Size = new System.Drawing.Size(69, 17);
            this.aug.TabIndex = 7;
            this.aug.Text = "augustus";
            this.aug.UseVisualStyleBackColor = true;
            this.aug.CheckedChanged += new System.EventHandler(this.aug_CheckedChanged_1);
            // 
            // jul
            // 
            this.jul.AutoSize = true;
            this.jul.Checked = true;
            this.jul.CheckState = System.Windows.Forms.CheckState.Checked;
            this.jul.Location = new System.Drawing.Point(202, 54);
            this.jul.Name = "jul";
            this.jul.Size = new System.Drawing.Size(38, 17);
            this.jul.TabIndex = 6;
            this.jul.Text = "juli";
            this.jul.UseVisualStyleBackColor = true;
            this.jul.CheckedChanged += new System.EventHandler(this.jul_CheckedChanged_1);
            // 
            // jun
            // 
            this.jun.AutoSize = true;
            this.jun.Checked = true;
            this.jun.CheckState = System.Windows.Forms.CheckState.Checked;
            this.jun.Location = new System.Drawing.Point(116, 54);
            this.jun.Name = "jun";
            this.jun.Size = new System.Drawing.Size(42, 17);
            this.jun.TabIndex = 5;
            this.jun.Text = "juni";
            this.jun.UseVisualStyleBackColor = true;
            this.jun.CheckedChanged += new System.EventHandler(this.jun_CheckedChanged_1);
            // 
            // mei
            // 
            this.mei.AutoSize = true;
            this.mei.Checked = true;
            this.mei.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mei.Location = new System.Drawing.Point(30, 54);
            this.mei.Name = "mei";
            this.mei.Size = new System.Drawing.Size(42, 17);
            this.mei.TabIndex = 4;
            this.mei.Text = "mei";
            this.mei.UseVisualStyleBackColor = true;
            this.mei.CheckedChanged += new System.EventHandler(this.mei_CheckedChanged_1);
            // 
            // apr
            // 
            this.apr.AutoSize = true;
            this.apr.Checked = true;
            this.apr.CheckState = System.Windows.Forms.CheckState.Checked;
            this.apr.Location = new System.Drawing.Point(288, 30);
            this.apr.Name = "apr";
            this.apr.Size = new System.Drawing.Size(45, 17);
            this.apr.TabIndex = 3;
            this.apr.Text = "april";
            this.apr.UseVisualStyleBackColor = true;
            this.apr.CheckedChanged += new System.EventHandler(this.apr_CheckedChanged_1);
            // 
            // mrt
            // 
            this.mrt.AutoSize = true;
            this.mrt.Checked = true;
            this.mrt.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mrt.Location = new System.Drawing.Point(202, 30);
            this.mrt.Name = "mrt";
            this.mrt.Size = new System.Drawing.Size(52, 17);
            this.mrt.TabIndex = 2;
            this.mrt.Text = "maart";
            this.mrt.UseVisualStyleBackColor = true;
            this.mrt.CheckedChanged += new System.EventHandler(this.mrt_CheckedChanged_1);
            // 
            // feb
            // 
            this.feb.AutoSize = true;
            this.feb.Checked = true;
            this.feb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.feb.Location = new System.Drawing.Point(116, 30);
            this.feb.Name = "feb";
            this.feb.Size = new System.Drawing.Size(61, 17);
            this.feb.TabIndex = 1;
            this.feb.Text = "februari";
            this.feb.UseVisualStyleBackColor = true;
            this.feb.CheckedChanged += new System.EventHandler(this.feb_CheckedChanged_1);
            // 
            // Jan
            // 
            this.Jan.AutoSize = true;
            this.Jan.Checked = true;
            this.Jan.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Jan.Location = new System.Drawing.Point(30, 30);
            this.Jan.Name = "Jan";
            this.Jan.Size = new System.Drawing.Size(57, 17);
            this.Jan.TabIndex = 0;
            this.Jan.Text = "januari";
            this.Jan.UseVisualStyleBackColor = true;
            this.Jan.CheckedChanged += new System.EventHandler(this.Jan_CheckedChanged);
            // 
            // WGStitel
            // 
            this.WGStitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WGStitel.Location = new System.Drawing.Point(105, 10);
            this.WGStitel.Name = "WGStitel";
            this.WGStitel.Size = new System.Drawing.Size(960, 44);
            this.WGStitel.TabIndex = 33;
            this.WGStitel.Text = "Temperatuur en fietsdiefstal";
            this.WGStitel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(860, 580);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 25);
            this.button2.TabIndex = 31;
            this.button2.Text = "Terug naar hoofdmenu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Datavisualisatie1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Data.Properties.Resources.Wolken_achtergrond;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.WGSchart);
            this.Controls.Add(this.WGSinleiding);
            this.Controls.Add(this.WGSmaand);
            this.Controls.Add(this.WGStitel);
            this.Controls.Add(this.button2);
            this.Name = "Datavisualisatie1";
            this.Text = "dataVisualisatie1";
            ((System.ComponentModel.ISupportInitialize)(this.WGSchart)).EndInit();
            this.WGSmaand.ResumeLayout(false);
            this.WGSmaand.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart WGSchart;
        private System.Windows.Forms.TextBox WGSinleiding;
        private System.Windows.Forms.GroupBox WGSmaand;
        private System.Windows.Forms.CheckBox dec;
        private System.Windows.Forms.CheckBox nov;
        private System.Windows.Forms.CheckBox okt;
        private System.Windows.Forms.CheckBox sep;
        private System.Windows.Forms.CheckBox aug;
        private System.Windows.Forms.CheckBox jul;
        private System.Windows.Forms.CheckBox jun;
        private System.Windows.Forms.CheckBox mei;
        private System.Windows.Forms.CheckBox apr;
        private System.Windows.Forms.CheckBox mrt;
        private System.Windows.Forms.CheckBox feb;
        private System.Windows.Forms.CheckBox Jan;
        private System.Windows.Forms.TextBox WGStitel;
        private System.Windows.Forms.Button button2;
    }
    }
