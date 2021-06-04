
namespace CourseProj
{
    partial class Menu
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.expencesChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.backToLoginFromMenu = new System.Windows.Forms.Label();
            this.statisticsButton = new System.Windows.Forms.Button();
            this.expencesButton = new System.Windows.Forms.Button();
            this.walletsButton = new System.Windows.Forms.Button();
            this.incomeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.expencesChart)).BeginInit();
            this.SuspendLayout();
            // 
            // expencesChart
            // 
            chartArea2.Name = "ChartArea1";
            this.expencesChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.expencesChart.Legends.Add(legend2);
            this.expencesChart.Location = new System.Drawing.Point(296, 0);
            this.expencesChart.Name = "expencesChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "expences";
            this.expencesChart.Series.Add(series2);
            this.expencesChart.Size = new System.Drawing.Size(491, 562);
            this.expencesChart.TabIndex = 4;
            this.expencesChart.Text = "chart1";
            title2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title2.Name = "Title1";
            title2.Text = "Диаграмма расходов";
            this.expencesChart.Titles.Add(title2);
            // 
            // backToLoginFromMenu
            // 
            this.backToLoginFromMenu.AutoSize = true;
            this.backToLoginFromMenu.BackColor = System.Drawing.Color.White;
            this.backToLoginFromMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backToLoginFromMenu.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backToLoginFromMenu.ForeColor = System.Drawing.Color.Gray;
            this.backToLoginFromMenu.Location = new System.Drawing.Point(439, 522);
            this.backToLoginFromMenu.Name = "backToLoginFromMenu";
            this.backToLoginFromMenu.Size = new System.Drawing.Size(197, 22);
            this.backToLoginFromMenu.TabIndex = 16;
            this.backToLoginFromMenu.Text = "Сменить аккаунт →";
            this.backToLoginFromMenu.Click += new System.EventHandler(this.backToLoginFromMenu_Click);
            this.backToLoginFromMenu.MouseEnter += new System.EventHandler(this.backToLoginFromMenu_MouseEnter);
            this.backToLoginFromMenu.MouseLeave += new System.EventHandler(this.backToLoginFromMenu_MouseLeave);
            // 
            // statisticsButton
            // 
            this.statisticsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.statisticsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(187)))), ((int)(((byte)(255)))));
            this.statisticsButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("statisticsButton.BackgroundImage")));
            this.statisticsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.statisticsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.statisticsButton.FlatAppearance.BorderSize = 0;
            this.statisticsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statisticsButton.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statisticsButton.Location = new System.Drawing.Point(788, 274);
            this.statisticsButton.Name = "statisticsButton";
            this.statisticsButton.Size = new System.Drawing.Size(300, 288);
            this.statisticsButton.TabIndex = 3;
            this.statisticsButton.Text = "Статистика";
            this.statisticsButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.statisticsButton.UseVisualStyleBackColor = false;
            this.statisticsButton.Click += new System.EventHandler(this.statisticsButton_Click);
            // 
            // expencesButton
            // 
            this.expencesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.expencesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(187)))), ((int)(((byte)(255)))));
            this.expencesButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("expencesButton.BackgroundImage")));
            this.expencesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.expencesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.expencesButton.FlatAppearance.BorderSize = 0;
            this.expencesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.expencesButton.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.expencesButton.Location = new System.Drawing.Point(788, 0);
            this.expencesButton.Name = "expencesButton";
            this.expencesButton.Size = new System.Drawing.Size(300, 283);
            this.expencesButton.TabIndex = 2;
            this.expencesButton.Text = "Расход";
            this.expencesButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.expencesButton.UseVisualStyleBackColor = false;
            this.expencesButton.Click += new System.EventHandler(this.expencesButton_Click);
            // 
            // walletsButton
            // 
            this.walletsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.walletsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(187)))), ((int)(((byte)(255)))));
            this.walletsButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("walletsButton.BackgroundImage")));
            this.walletsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.walletsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.walletsButton.FlatAppearance.BorderSize = 0;
            this.walletsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.walletsButton.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.walletsButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.walletsButton.Location = new System.Drawing.Point(-1, 274);
            this.walletsButton.Name = "walletsButton";
            this.walletsButton.Size = new System.Drawing.Size(300, 288);
            this.walletsButton.TabIndex = 1;
            this.walletsButton.Text = "Кошельки";
            this.walletsButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.walletsButton.UseVisualStyleBackColor = false;
            this.walletsButton.Click += new System.EventHandler(this.walletsButton_Click);
            // 
            // incomeButton
            // 
            this.incomeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(187)))), ((int)(((byte)(255)))));
            this.incomeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("incomeButton.BackgroundImage")));
            this.incomeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.incomeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.incomeButton.FlatAppearance.BorderSize = 0;
            this.incomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.incomeButton.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.incomeButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.incomeButton.Location = new System.Drawing.Point(-1, 0);
            this.incomeButton.Name = "incomeButton";
            this.incomeButton.Size = new System.Drawing.Size(300, 283);
            this.incomeButton.TabIndex = 0;
            this.incomeButton.Text = "Доход";
            this.incomeButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.incomeButton.UseVisualStyleBackColor = false;
            this.incomeButton.Click += new System.EventHandler(this.incomeButton_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1082, 553);
            this.Controls.Add(this.backToLoginFromMenu);
            this.Controls.Add(this.expencesChart);
            this.Controls.Add(this.statisticsButton);
            this.Controls.Add(this.expencesButton);
            this.Controls.Add(this.walletsButton);
            this.Controls.Add(this.incomeButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1100, 600);
            this.MinimumSize = new System.Drawing.Size(1100, 600);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ну как там с деньгами?";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.expencesChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button incomeButton;
        private System.Windows.Forms.Button walletsButton;
        private System.Windows.Forms.Button expencesButton;
        private System.Windows.Forms.Button statisticsButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart expencesChart;
        private System.Windows.Forms.Label backToLoginFromMenu;
    }
}