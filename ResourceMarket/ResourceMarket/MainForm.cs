using ResourceMarket.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ResourceMarket
{
    public partial class MainForm : Form
    {
        News news = new News();
        Random random = new Random();
        Dictionary<string,double> prices= new Dictionary<string,double>();
        double[] changeSpeed = new double[4];
        Player player = new Player();
        List<string> pricesKey = new List<string>();
        string selectedResource = "";
        (string eventResource, int direction) resourceEvent;
        int weekCount= 1;
        int startOfEvent = 0;
        private string translateWord(string word)
        {
            switch(word)
            {
                case "Oil":
                    return "Нефть";
                case "Gold":
                    return "Драгметалл";
                case "Food":
                    return "Еда";
                case "Iron":
                    return "Металл";
            }
            return "failed to translate";
        }
        public MainForm()
        {
            prices["Oil"] = 30;
            prices["Gold"] = 40;
            prices["Iron"] = 20;
            prices["Food"] = 10;
            for(int i = 0; i < 4; i++) 
            {
                changeSpeed[i] = random.NextDouble();
            }
            pricesKey = prices.Keys.ToList<string>();
            InitializeComponent();
        }

        private void nextWeekButton_Click(object sender, EventArgs e)
        {

            if(weekCount == 31)
            {
                weekCount = 1;
                for (int i =0; i < pricesKey.Count; i++)
                {
                    resetChart(i);
                }
            }
            for (int i = 0; i < prices.Count; i++)
            {
                if (prices[pricesKey[i]] > 0)
                {

                    if (pricesKey[i] == resourceEvent.eventResource && Math.Abs(weekCount - startOfEvent) < 3)
                    {
                        prices[pricesKey[i]] += random.Next(Math.Min(5 * resourceEvent.direction, 10 * resourceEvent.direction),
                            Math.Max(5 * resourceEvent.direction, 10 * resourceEvent.direction)) ;
                        
                    }
                    else
                    {
                        prices[pricesKey[i]] += random.Next(-4, 6)*changeSpeed[i];
                    }
                    changeSpeed[i] = Math.Abs(changeSpeed[i] - random.NextDouble());
                    prices[pricesKey[i]] = Math.Abs(prices[pricesKey[i]]);
                }
                else
                {
                    prices[pricesKey[i]] += 10;
                }
                resourceChart.Series[i].Points.AddXY(weekCount,prices[pricesKey[i]]);
            }
            if (weekCount % random.Next(4, 8) == 0 && Math.Abs(weekCount - startOfEvent) >= 3)
            {
                (string, int, int) newsSelected = news.chooseRandomNews();
                int direction = 0;
                if (newsSelected.Item3 % 2 == 0)
                {
                    direction = 1;
                }
                else
                {
                    direction = -1;
                }
                startOfEvent = weekCount;
                resourceEvent = (pricesKey[newsSelected.Item2], direction);
                newsList.Items.Add(newsSelected.Item1);
            }
            weekCount++;
            refreshTotalSum();
            refreshInvestPortfolio();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < prices.Count; i++)
            {
                resetChart(i);
                resourceChart.Series[i].Points.AddXY(0, prices[pricesKey[i]]);
                resourceChart.Series[i].XValueType = ChartValueType.Int32;
            }
            balanceValue.Text = player.balance.ToString();
            resourceChart.ChartAreas[0].AxisX.Title = "недели";
            resourceChart.ChartAreas[0].AxisY.Title = "стоимость";
            
        }
        private void resetChart(int seriesIndex) {
            resourceChart.ChartAreas[0].AxisY.Minimum = 0;
            resourceChart.ChartAreas[0].AxisX.Minimum = 0;
            resourceChart.ChartAreas[0].AxisX.Maximum = 30;
            resourceChart.ChartAreas[0].AxisX.Interval = 3;
            resourceChart.Series[seriesIndex].Points.Clear();
        }
        private void resourceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedResource = pricesKey[resourceComboBox.SelectedIndex];
            refreshTotalSum();
            for (int i = 0; i < pricesKey.Count; i++)
            {
                if (pricesKey[i] != selectedResource)
                {
                    resourceChart.Series[i].BorderWidth = 1;
                }
                else
                {
                    resourceChart.Series[i].BorderWidth = 4;
                }
            }
        }
        private void newsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (newsList.SelectedIndex != -1) 
            {
                string selectedItem = newsList.SelectedItem.ToString();
                MessageBox.Show(selectedItem, "Подробнее");
            }
        }
        private void sellButton_Click(object sender, EventArgs e)
        {
            if (selectedResource != "" && (int)goodsNum.Value > 0)
            {
                player.SellResource(selectedResource, (int)goodsNum.Value, prices[selectedResource]);
                balanceValue.Text = player.balance.ToString();
                refreshInvestPortfolio();
            }
        }

        private void buyButton_Click(object sender, EventArgs e)
        {
            if (selectedResource != "" && (int)goodsNum.Value>0) 
            {
                player.BuyResource(selectedResource, (int)goodsNum.Value,prices[selectedResource]);
                balanceValue.Text = player.balance.ToString();
                refreshInvestPortfolio();
            }
        }
        private void refreshTotalSum()
        {
            if (selectedResource != "")
            {
                double sum = prices[selectedResource] * ((int)goodsNum.Value);
                sum = Math.Round(sum, 2);
                totalSum.Text = "Сумма: " + sum.ToString();
            }
        }
        private void refreshInvestPortfolio()
        {
            investPortfolioBox.Items.Clear();
            List<string> actualGoods = player.investPortfolio.Keys.ToList();
            for(int i = 0; i < actualGoods.Count; i++)
            {
                int numGoods = player.investPortfolio[actualGoods[i]];
                double price = prices[actualGoods[i]];
                price *= numGoods;
                price = Math.Round(price, 2);
                investPortfolioBox.Items.Add(translateWord(actualGoods[i]) +" "+numGoods.ToString()+"шт. "+price.ToString());
            }
            
        }
        private void goodsNum_ValueChanged(object sender, EventArgs e)
        {
            refreshTotalSum();
        }
    }
}
