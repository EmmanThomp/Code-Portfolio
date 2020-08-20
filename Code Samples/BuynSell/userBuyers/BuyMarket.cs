using System;

namespace BuynSell.userBuyers
{
    public class BuyMarket
    {
        //area prices pull from when Press B
        int[] prices = new int[5] { 20, 50, 100, 40, 70 };
        Random random = new Random();
        public int PriceChoser()
        {
            var randomArrayVal = random.Next(0, prices.Length);
            var randomPrice = prices[randomArrayVal];
            return randomPrice;
        }
    }
}