using System;
using System.Collections.Generic;
using System.Text;
using BuynSell.userSellers;

namespace BuynSell.userSellers
{
    class SellCompiler
    {
        public static int dyNum = 0;
        public int PricePicker()
        {
            var price = new SellMarket();
            var priceInput = price.SellPriceChoser();
            dyNum = dyNum + priceInput;
            return priceInput;
        }
        public void conjuction()
        {
            var finPrice = new SellCompiler();
            var name = new SellNames();
            Console.WriteLine("Hey pal my name is " + name.SellNameChoser() + " I'll sell you '|X|' for $" + finPrice.PricePicker());
            Console.WriteLine("Whaddya say pal. We got ourselves a deal?");
            Console.WriteLine("Type Y/N");
        }
        public int numReturn()
        {
            return dyNum;
        }
    }
}
