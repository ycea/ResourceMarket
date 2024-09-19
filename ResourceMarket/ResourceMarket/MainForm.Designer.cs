namespace ResourceMarket
{
    partial class MainForm
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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.resourceComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.resourceChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buyButton = new System.Windows.Forms.Button();
            this.goodsNum = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nextWeekButton = new System.Windows.Forms.Button();
            this.sellButton = new System.Windows.Forms.Button();
            this.balanceValue = new System.Windows.Forms.Label();
            this.newsList = new System.Windows.Forms.ListBox();
            this.totalSum = new System.Windows.Forms.Label();
            this.investPortfolioBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.resourceChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsNum)).BeginInit();
            this.SuspendLayout();
            // 
            // resourceComboBox
            // 
            this.resourceComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.resourceComboBox.BackColor = System.Drawing.SystemColors.Menu;
            this.resourceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.resourceComboBox.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resourceComboBox.Items.AddRange(new object[] {
            "Нефть",
            "Драгметалл",
            "Железо",
            "Еда"});
            this.resourceComboBox.Location = new System.Drawing.Point(258, 31);
            this.resourceComboBox.Name = "resourceComboBox";
            this.resourceComboBox.Size = new System.Drawing.Size(121, 32);
            this.resourceComboBox.TabIndex = 0;
            this.resourceComboBox.SelectedIndexChanged += new System.EventHandler(this.resourceComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(96, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выбор ресурса";
            // 
            // resourceChart
            // 
            this.resourceChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resourceChart.BackColor = System.Drawing.Color.LightGray;
            this.resourceChart.BorderlineColor = System.Drawing.Color.Silver;
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX2.TitleFont = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea1.AxisY2.TitleFont = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea1.BackColor = System.Drawing.Color.LightYellow;
            chartArea1.Name = "ChartArea1";
            this.resourceChart.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.LemonChiffon;
            legend1.Name = "Ресурсы";
            legend1.Title = "Ресурсы";
            legend1.TitleFont = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resourceChart.Legends.Add(legend1);
            this.resourceChart.Location = new System.Drawing.Point(313, 87);
            this.resourceChart.Name = "resourceChart";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series1.Legend = "Ресурсы";
            series1.LegendText = "Нефть";
            series1.Name = "Oil";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series2.Legend = "Ресурсы";
            series2.LegendText = "Драгметалл";
            series2.Name = "Gold";
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.Gray;
            series3.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series3.Legend = "Ресурсы";
            series3.LegendText = "Железо";
            series3.Name = "Iron";
            series4.BorderWidth = 3;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series4.Legend = "Ресурсы";
            series4.LegendText = "Еда";
            series4.Name = "Food";
            this.resourceChart.Series.Add(series1);
            this.resourceChart.Series.Add(series2);
            this.resourceChart.Series.Add(series3);
            this.resourceChart.Series.Add(series4);
            this.resourceChart.Size = new System.Drawing.Size(608, 350);
            this.resourceChart.TabIndex = 2;
            this.resourceChart.Text = "chart1";
            title1.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title1.Name = "Prices";
            title1.Text = "Цены на бирже";
            this.resourceChart.Titles.Add(title1);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Громкие новости";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(927, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Портфель";
            // 
            // buyButton
            // 
            this.buyButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buyButton.BackColor = System.Drawing.Color.Honeydew;
            this.buyButton.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buyButton.Location = new System.Drawing.Point(739, 450);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(88, 34);
            this.buyButton.TabIndex = 7;
            this.buyButton.Text = "Купить";
            this.buyButton.UseVisualStyleBackColor = false;
            this.buyButton.Click += new System.EventHandler(this.buyButton_Click);
            // 
            // goodsNum
            // 
            this.goodsNum.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.goodsNum.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.goodsNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.goodsNum.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goodsNum.Location = new System.Drawing.Point(604, 450);
            this.goodsNum.Name = "goodsNum";
            this.goodsNum.Size = new System.Drawing.Size(120, 32);
            this.goodsNum.TabIndex = 9;
            this.goodsNum.ValueChanged += new System.EventHandler(this.goodsNum_ValueChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(507, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Баланс";
            // 
            // nextWeekButton
            // 
            this.nextWeekButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.nextWeekButton.BackColor = System.Drawing.Color.Honeydew;
            this.nextWeekButton.FlatAppearance.BorderColor = System.Drawing.Color.PaleGreen;
            this.nextWeekButton.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nextWeekButton.Location = new System.Drawing.Point(429, 450);
            this.nextWeekButton.Name = "nextWeekButton";
            this.nextWeekButton.Size = new System.Drawing.Size(146, 32);
            this.nextWeekButton.TabIndex = 13;
            this.nextWeekButton.Text = "След. неделя";
            this.nextWeekButton.UseVisualStyleBackColor = false;
            this.nextWeekButton.Click += new System.EventHandler(this.nextWeekButton_Click);
            // 
            // sellButton
            // 
            this.sellButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.sellButton.BackColor = System.Drawing.Color.Honeydew;
            this.sellButton.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sellButton.Location = new System.Drawing.Point(833, 450);
            this.sellButton.Name = "sellButton";
            this.sellButton.Size = new System.Drawing.Size(96, 34);
            this.sellButton.TabIndex = 15;
            this.sellButton.Text = "Продать";
            this.sellButton.UseVisualStyleBackColor = false;
            this.sellButton.Click += new System.EventHandler(this.sellButton_Click);
            // 
            // balanceValue
            // 
            this.balanceValue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.balanceValue.AutoSize = true;
            this.balanceValue.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.balanceValue.Location = new System.Drawing.Point(600, 26);
            this.balanceValue.Name = "balanceValue";
            this.balanceValue.Size = new System.Drawing.Size(55, 24);
            this.balanceValue.TabIndex = 16;
            this.balanceValue.Text = "5000$";
            // 
            // newsList
            // 
            this.newsList.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.newsList.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.newsList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newsList.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newsList.FormattingEnabled = true;
            this.newsList.HorizontalScrollbar = true;
            this.newsList.ItemHeight = 24;
            this.newsList.Location = new System.Drawing.Point(12, 153);
            this.newsList.Name = "newsList";
            this.newsList.Size = new System.Drawing.Size(295, 242);
            this.newsList.TabIndex = 17;
            this.newsList.SelectedIndexChanged += new System.EventHandler(this.newsList_SelectedIndexChanged);
            // 
            // totalSum
            // 
            this.totalSum.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.totalSum.AutoSize = true;
            this.totalSum.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalSum.Location = new System.Drawing.Point(600, 413);
            this.totalSum.Name = "totalSum";
            this.totalSum.Size = new System.Drawing.Size(87, 24);
            this.totalSum.TabIndex = 18;
            this.totalSum.Text = "Сумма: 0";
            // 
            // investPortfolioBox
            // 
            this.investPortfolioBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.investPortfolioBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.investPortfolioBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.investPortfolioBox.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.investPortfolioBox.FormattingEnabled = true;
            this.investPortfolioBox.HorizontalScrollbar = true;
            this.investPortfolioBox.ItemHeight = 24;
            this.investPortfolioBox.Location = new System.Drawing.Point(927, 153);
            this.investPortfolioBox.Name = "investPortfolioBox";
            this.investPortfolioBox.Size = new System.Drawing.Size(221, 242);
            this.investPortfolioBox.TabIndex = 19;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1160, 497);
            this.Controls.Add(this.investPortfolioBox);
            this.Controls.Add(this.totalSum);
            this.Controls.Add(this.newsList);
            this.Controls.Add(this.balanceValue);
            this.Controls.Add(this.sellButton);
            this.Controls.Add(this.nextWeekButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.goodsNum);
            this.Controls.Add(this.buyButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.resourceChart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resourceComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Ресурсная биржа";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resourceChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox resourceComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart resourceChart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buyButton;
        private System.Windows.Forms.NumericUpDown goodsNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button nextWeekButton;
        private System.Windows.Forms.Button sellButton;
        private System.Windows.Forms.Label balanceValue;
        private System.Windows.Forms.ListBox newsList;
        private System.Windows.Forms.Label totalSum;
        private System.Windows.Forms.ListBox investPortfolioBox;
    }
}

