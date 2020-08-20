using System;
using System.Collections.Generic;
using System.Text;

namespace BuynSell.userSellers
{
    class SellMarket
    {
        //area prices pull from when press S
        int[] prices = new int[5] { 10, 60, 80, 15, 110 };
        Random random = new Random();
        public int SellPriceChoser()
        {
            var randomArrayVal = random.Next(0, prices.Length);
            var randomPrice = prices[randomArrayVal];
            return randomPrice;
        }
    }
}
