﻿namespace Data
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Datavisualisatie1));
            this.myButton = new System.Windows.Forms.Button();
            this.WFDChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.WGSmaand = new System.Windows.Forms.GroupBox();
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
            this.myButton.Location = new System.Drawing.Point(758, 544);
            this.myButton.Name = "myButton";
            this.myButton.Size = new System.Drawing.Size(125, 23);
            this.myButton.TabIndex = 0;
            this.myButton.Text = "myButton";
            this.myButton.UseVisualStyleBackColor = true;
            this.myButton.Click += new System.EventHandler(this.myButton_Click);
            // 
            // WFDChart
            // 
            chartArea2.Name = "ChartArea1";
            this.WFDChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.WFDChart.Legends.Add(legend2);
            this.WFDChart.Location = new System.Drawing.Point(534, 124);
            this.WFDChart.Name = "WFDChart";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Min. Temperatuur";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Max. Temperatuur";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Gestolen fietsen";
            this.WFDChart.Series.Add(series4);
            this.WFDChart.Series.Add(series5);
            this.WFDChart.Series.Add(series6);
            this.WFDChart.Size = new System.Drawing.Size(623, 400);
            this.WFDChart.TabIndex = 30;
            this.WFDChart.Text = "Windsnelheid en geboorte en sterfte";
            this.WFDChart.Click += new System.EventHandler(this.WGSchart_Click);
            // 
            // WGSmaand
            // 
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
            this.WGSmaand.Location = new System.Drawing.Point(93, 368);
            this.WGSmaand.Name = "WGSmaand";
            this.WGSmaand.Size = new System.Drawing.Size(400, 130);
            this.WGSmaand.TabIndex = 27;
            this.WGSmaand.TabStop = false;
            this.WGSmaand.Text = "Maand";
            // 
            // WGSdec
            // 
            this.WGSdec.AutoSize = true;
            this.WGSdec.Location = new System.Drawing.Point(288, 78);
            this.WGSdec.Name = "WGSdec";
            this.WGSdec.Size = new System.Drawing.Size(73, 17);
            this.WGSdec.TabIndex = 11;
            this.WGSdec.Text = "december";
            this.WGSdec.UseVisualStyleBackColor = true;
            // 
            // WGSnov
            // 
            this.WGSnov.AutoSize = true;
            this.WGSnov.Location = new System.Drawing.Point(202, 78);
            this.WGSnov.Name = "WGSnov";
            this.WGSnov.Size = new System.Drawing.Size(73, 17);
            this.WGSnov.TabIndex = 10;
            this.WGSnov.Text = "november";
            this.WGSnov.UseVisualStyleBackColor = true;
            // 
            // WGSokt
            // 
            this.WGSokt.AutoSize = true;
            this.WGSokt.Location = new System.Drawing.Point(116, 78);
            this.WGSokt.Name = "WGSokt";
            this.WGSokt.Size = new System.Drawing.Size(62, 17);
            this.WGSokt.TabIndex = 9;
            this.WGSokt.Text = "oktober";
            this.WGSokt.UseVisualStyleBackColor = true;
            // 
            // WGSsep
            // 
            this.WGSsep.AutoSize = true;
            this.WGSsep.Location = new System.Drawing.Point(30, 78);
            this.WGSsep.Name = "WGSsep";
            this.WGSsep.Size = new System.Drawing.Size(75, 17);
            this.WGSsep.TabIndex = 8;
            this.WGSsep.Text = "september";
            this.WGSsep.UseVisualStyleBackColor = true;
            // 
            // WGSaug
            // 
            this.WGSaug.AutoSize = true;
            this.WGSaug.Location = new System.Drawing.Point(288, 54);
            this.WGSaug.Name = "WGSaug";
            this.WGSaug.Size = new System.Drawing.Size(69, 17);
            this.WGSaug.TabIndex = 7;
            this.WGSaug.Text = "augustus";
            this.WGSaug.UseVisualStyleBackColor = true;
            // 
            // WGSjul
            // 
            this.WGSjul.AutoSize = true;
            this.WGSjul.Location = new System.Drawing.Point(202, 54);
            this.WGSjul.Name = "WGSjul";
            this.WGSjul.Size = new System.Drawing.Size(38, 17);
            this.WGSjul.TabIndex = 6;
            this.WGSjul.Text = "juli";
            this.WGSjul.UseVisualStyleBackColor = true;
            // 
            // WGSjun
            // 
            this.WGSjun.AutoSize = true;
            this.WGSjun.Location = new System.Drawing.Point(116, 54);
            this.WGSjun.Name = "WGSjun";
            this.WGSjun.Size = new System.Drawing.Size(42, 17);
            this.WGSjun.TabIndex = 5;
            this.WGSjun.Text = "juni";
            this.WGSjun.UseVisualStyleBackColor = true;
            // 
            // WGSmei
            // 
            this.WGSmei.AutoSize = true;
            this.WGSmei.Location = new System.Drawing.Point(30, 54);
            this.WGSmei.Name = "WGSmei";
            this.WGSmei.Size = new System.Drawing.Size(42, 17);
            this.WGSmei.TabIndex = 4;
            this.WGSmei.Text = "mei";
            this.WGSmei.UseVisualStyleBackColor = true;
            // 
            // WGSapr
            // 
            this.WGSapr.AutoSize = true;
            this.WGSapr.Location = new System.Drawing.Point(288, 30);
            this.WGSapr.Name = "WGSapr";
            this.WGSapr.Size = new System.Drawing.Size(45, 17);
            this.WGSapr.TabIndex = 3;
            this.WGSapr.Text = "april";
            this.WGSapr.UseVisualStyleBackColor = true;
            // 
            // WGSmrt
            // 
            this.WGSmrt.AutoSize = true;
            this.WGSmrt.Location = new System.Drawing.Point(202, 30);
            this.WGSmrt.Name = "WGSmrt";
            this.WGSmrt.Size = new System.Drawing.Size(52, 17);
            this.WGSmrt.TabIndex = 2;
            this.WGSmrt.Text = "maart";
            this.WGSmrt.UseVisualStyleBackColor = true;
            // 
            // WGSfeb
            // 
            this.WGSfeb.AutoSize = true;
            this.WGSfeb.Location = new System.Drawing.Point(116, 30);
            this.WGSfeb.Name = "WGSfeb";
            this.WGSfeb.Size = new System.Drawing.Size(61, 17);
            this.WGSfeb.TabIndex = 1;
            this.WGSfeb.Text = "februari";
            this.WGSfeb.UseVisualStyleBackColor = true;
            // 
            // WGSjan
            // 
            this.WGSjan.AutoSize = true;
            this.WGSjan.Location = new System.Drawing.Point(30, 30);
            this.WGSjan.Name = "WGSjan";
            this.WGSjan.Size = new System.Drawing.Size(57, 17);
            this.WGSjan.TabIndex = 0;
            this.WGSjan.Text = "januari";
            this.WGSjan.UseVisualStyleBackColor = true;
            // 
            // WGSinleiding
            // 
            this.WGSinleiding.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WGSinleiding.Location = new System.Drawing.Point(58, 188);
            this.WGSinleiding.Multiline = true;
            this.WGSinleiding.Name = "WGSinleiding";
            this.WGSinleiding.Size = new System.Drawing.Size(470, 70);
            this.WGSinleiding.TabIndex = 29;
            this.WGSinleiding.Text = resources.GetString("WGSinleiding.Text");
            // 
            // WGStitel
            // 
            this.WGStitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WGStitel.Location = new System.Drawing.Point(68, 8);
            this.WGStitel.Name = "WGStitel";
            this.WGStitel.Size = new System.Drawing.Size(960, 44);
            this.WGStitel.TabIndex = 28;
            this.WGStitel.Text = "Temperatuur en fiets diefstal\r\n";
            this.WGStitel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.WGStitel.TextChanged += new System.EventHandler(this.WGStitel_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(758, 573);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 25);
            this.button1.TabIndex = 26;
            this.button1.Text = "Terug naar hoofdmenu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Datavisualisatie1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 643);
            this.Controls.Add(this.WFDChart);
            this.Controls.Add(this.WGSmaand);
            this.Controls.Add(this.WGSinleiding);
            this.Controls.Add(this.WGStitel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.myButton);
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
    }
}