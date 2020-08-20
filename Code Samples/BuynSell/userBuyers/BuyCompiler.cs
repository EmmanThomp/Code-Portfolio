using BuynSell.userBuyers;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuynSell.userBuyers
{
    class BuyCompiler
    {
        //dynamic variable that
        public static int dyNum = 0;
        

        public int PricePicker()
        {
            var price = new BuyMarket();
            int priceInput = price.PriceChoser();
            dyNum = dyNum + priceInput;
            return priceInput;
        }

        //aggregates data
        public void conjuction()
        {
            var name = new BuyNames();
            var finPrice = new BuyCompiler();
            Console.WriteLine("Hey pal my name is " + name.NameChoser() + " I'll buy '|X|' for $" + finPrice.PricePicker());
            Console.WriteLine("Whaddya say pal. We got ourselves a deal?");
            Console.WriteLine("Type Y/N");
        }
        public int numReturn()
        {
            return dyNum;
        }
    }
}
