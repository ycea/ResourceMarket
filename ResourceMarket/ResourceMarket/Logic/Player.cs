using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourceMarket.Logic
{
    public class Player
    {
        public double balance;
        public Dictionary<string, int> investPortfolio;
        public Player()
        {
            balance = 500;
            investPortfolio = new Dictionary<string, int>();
        }
        public void BuyResource(string resourceName, int lotsNum, double buyPrice)
        {
            if(balance - lotsNum * buyPrice < 0) { return; }
            if (investPortfolio.ContainsKey(resourceName))
            {
                investPortfolio[resourceName] =  investPortfolio[resourceName]+lotsNum;
            }
            else
            {
                investPortfolio.Add(resourceName, lotsNum);
            }
            balance -= lotsNum*buyPrice;
            balance = Math.Round(balance, 3);
        }
        public void SellResource(string resourceName, int lotsNum, double sellPrice)
        {
            if(investPortfolio.ContainsKey(resourceName) && investPortfolio[resourceName] > 0 && lotsNum <= investPortfolio[resourceName])
            {
                investPortfolio[resourceName] = investPortfolio[resourceName] - lotsNum;
                balance += lotsNum * sellPrice;
                balance = Math.Round(balance, 3);
            }
        }
    }
}
