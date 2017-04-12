﻿namespace VeiligWonenLoginUI
{
    partial class ChildMainUI
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.GoogleMapsControl = new GMap.NET.WindowsForms.GMapControl();
            this.Stadsgebied_Dropdown = new System.Windows.Forms.ComboBox();
            this.Wijk_Dropdown = new System.Windows.Forms.ComboBox();
            this.Straat_TextBox = new System.Windows.Forms.TextBox();
            this.Huisnummer_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PrijsTot_Textbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.KoopHuur_Dropdown = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Zoek_Button = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Data_Tabcontrol = new System.Windows.Forms.TabControl();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label8 = new System.Windows.Forms.Label();
            this.Woninginbraak_perc = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Autoinbraak_perc = new System.Windows.Forms.Label();
            this.tabPage2.SuspendLayout();
            this.Data_Tabcontrol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // GoogleMapsControl
            // 
            this.GoogleMapsControl.Bearing = 0F;
            this.GoogleMapsControl.CanDragMap = true;
            this.GoogleMapsControl.EmptyTileColor = System.Drawing.Color.Navy;
            this.GoogleMapsControl.GrayScaleMode = false;
            this.GoogleMapsControl.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.GoogleMapsControl.LevelsKeepInMemmory = 5;
            this.GoogleMapsControl.Location = new System.Drawing.Point(-1, 295);
            this.GoogleMapsControl.MarkersEnabled = true;
            this.GoogleMapsControl.MaxZoom = 2;
            this.GoogleMapsControl.MinZoom = 2;
            this.GoogleMapsControl.MouseWheelZoomEnabled = true;
            this.GoogleMapsControl.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.GoogleMapsControl.Name = "GoogleMapsControl";
            this.GoogleMapsControl.NegativeMode = false;
            this.GoogleMapsControl.PolygonsEnabled = true;
            this.GoogleMapsControl.RetryLoadTile = 0;
            this.GoogleMapsControl.RoutesEnabled = true;
            this.GoogleMapsControl.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.GoogleMapsControl.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.GoogleMapsControl.ShowTileGridLines = false;
            this.GoogleMapsControl.Size = new System.Drawing.Size(859, 543);
            this.GoogleMapsControl.TabIndex = 0;
            this.GoogleMapsControl.Zoom = 0D;
            // 
            // Stadsgebied_Dropdown
            // 
            this.Stadsgebied_Dropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Stadsgebied_Dropdown.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stadsgebied_Dropdown.FormattingEnabled = true;
            this.Stadsgebied_Dropdown.Location = new System.Drawing.Point(161, 25);
            this.Stadsgebied_Dropdown.Name = "Stadsgebied_Dropdown";
            this.Stadsgebied_Dropdown.Size = new System.Drawing.Size(260, 33);
            this.Stadsgebied_Dropdown.TabIndex = 2;
            this.Stadsgebied_Dropdown.SelectedIndexChanged += new System.EventHandler(this.Stadsgebied_Dropdown_SelectedIndexChanged);
            this.Stadsgebied_Dropdown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Stadsgebied_Dropdown_MouseDown);
            // 
            // Wijk_Dropdown
            // 
            this.Wijk_Dropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Wijk_Dropdown.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Wijk_Dropdown.FormattingEnabled = true;
            this.Wijk_Dropdown.Location = new System.Drawing.Point(161, 82);
            this.Wijk_Dropdown.Name = "Wijk_Dropdown";
            this.Wijk_Dropdown.Size = new System.Drawing.Size(232, 33);
            this.Wijk_Dropdown.TabIndex = 3;
            // 
            // Straat_TextBox
            // 
            this.Straat_TextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Straat_TextBox.Location = new System.Drawing.Point(161, 143);
            this.Straat_TextBox.Name = "Straat_TextBox";
            this.Straat_TextBox.Size = new System.Drawing.Size(181, 32);
            this.Straat_TextBox.TabIndex = 4;
            // 
            // Huisnummer_TextBox
            // 
            this.Huisnummer_TextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Huisnummer_TextBox.Location = new System.Drawing.Point(161, 197);
            this.Huisnummer_TextBox.Name = "Huisnummer_TextBox";
            this.Huisnummer_TextBox.Size = new System.Drawing.Size(82, 32);
            this.Huisnummer_TextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Stadsgebied :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Huisnummer :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Straat :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Wijk :";
            // 
            // PrijsTot_Textbox
            // 
            this.PrijsTot_Textbox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrijsTot_Textbox.Location = new System.Drawing.Point(638, 91);
            this.PrijsTot_Textbox.Name = "PrijsTot_Textbox";
            this.PrijsTot_Textbox.Size = new System.Drawing.Size(82, 32);
            this.PrijsTot_Textbox.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(531, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "Prijs tot :";
            // 
            // KoopHuur_Dropdown
            // 
            this.KoopHuur_Dropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.KoopHuur_Dropdown.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KoopHuur_Dropdown.FormattingEnabled = true;
            this.KoopHuur_Dropdown.Items.AddRange(new object[] {
            "Te Koop",
            "Te Huur"});
            this.KoopHuur_Dropdown.Location = new System.Drawing.Point(638, 25);
            this.KoopHuur_Dropdown.Name = "KoopHuur_Dropdown";
            this.KoopHuur_Dropdown.Size = new System.Drawing.Size(181, 33);
            this.KoopHuur_Dropdown.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(443, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(189, 23);
            this.label7.TabIndex = 15;
            this.label7.Text = "Te koop/ Te huur :";
            // 
            // Zoek_Button
            // 
            this.Zoek_Button.Location = new System.Drawing.Point(655, 233);
            this.Zoek_Button.Name = "Zoek_Button";
            this.Zoek_Button.Size = new System.Drawing.Size(132, 40);
            this.Zoek_Button.TabIndex = 16;
            this.Zoek_Button.Text = "Zoek";
            this.Zoek_Button.UseVisualStyleBackColor = true;
            this.Zoek_Button.Click += new System.EventHandler(this.Zoek_Button_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chart1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(444, 813);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Geweldpleging";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Data_Tabcontrol
            // 
            this.Data_Tabcontrol.Controls.Add(this.tabPage1);
            this.Data_Tabcontrol.Controls.Add(this.tabPage2);
            this.Data_Tabcontrol.Location = new System.Drawing.Point(850, -4);
            this.Data_Tabcontrol.Multiline = true;
            this.Data_Tabcontrol.Name = "Data_Tabcontrol";
            this.Data_Tabcontrol.SelectedIndex = 0;
            this.Data_Tabcontrol.Size = new System.Drawing.Size(452, 842);
            this.Data_Tabcontrol.TabIndex = 1;
            // 
            // chart1
            // 
            this.chart1.BorderSkin.BackColor = System.Drawing.Color.Black;
            this.chart1.BorderSkin.BorderWidth = 4;
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(-4, 0);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(436, 300);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Autoinbraak_perc);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.Woninginbraak_perc);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.chart2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(444, 813);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Inbraak";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chart2
            // 
            chartArea3.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart2.Legends.Add(legend3);
            this.chart2.Location = new System.Drawing.Point(-4, 0);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart2.Series.Add(series3);
            this.chart2.Size = new System.Drawing.Size(452, 300);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chart2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 347);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "% Woninginbraak :";
            // 
            // Woninginbraak_perc
            // 
            this.Woninginbraak_perc.AutoSize = true;
            this.Woninginbraak_perc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Woninginbraak_perc.Location = new System.Drawing.Point(176, 347);
            this.Woninginbraak_perc.Name = "Woninginbraak_perc";
            this.Woninginbraak_perc.Size = new System.Drawing.Size(42, 20);
            this.Woninginbraak_perc.TabIndex = 3;
            this.Woninginbraak_perc.Text = "perc";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(10, 389);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 20);
            this.label10.TabIndex = 4;
            this.label10.Text = "% Auto-inbraak :";
            // 
            // Autoinbraak_perc
            // 
            this.Autoinbraak_perc.AutoSize = true;
            this.Autoinbraak_perc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Autoinbraak_perc.Location = new System.Drawing.Point(176, 389);
            this.Autoinbraak_perc.Name = "Autoinbraak_perc";
            this.Autoinbraak_perc.Size = new System.Drawing.Size(42, 20);
            this.Autoinbraak_perc.TabIndex = 5;
            this.Autoinbraak_perc.Text = "perc";
            // 
            // ChildMainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 842);
            this.Controls.Add(this.Zoek_Button);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.KoopHuur_Dropdown);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PrijsTot_Textbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Huisnummer_TextBox);
            this.Controls.Add(this.Straat_TextBox);
            this.Controls.Add(this.Wijk_Dropdown);
            this.Controls.Add(this.Stadsgebied_Dropdown);
            this.Controls.Add(this.Data_Tabcontrol);
            this.Controls.Add(this.GoogleMapsControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChildMainUI";
            this.Text = "ChildMainUI";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ChildMainUI_FormClosed);
            this.Load += new System.EventHandler(this.ChildMainUI_Load);
            this.tabPage2.ResumeLayout(false);
            this.Data_Tabcontrol.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl GoogleMapsControl;
        private System.Windows.Forms.ComboBox Stadsgebied_Dropdown;
        private System.Windows.Forms.ComboBox Wijk_Dropdown;
        private System.Windows.Forms.TextBox Straat_TextBox;
        private System.Windows.Forms.TextBox Huisnummer_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PrijsTot_Textbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox KoopHuur_Dropdown;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Zoek_Button;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TabControl Data_Tabcontrol;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label Autoinbraak_perc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label Woninginbraak_perc;
        private System.Windows.Forms.Label label8;
    }
}