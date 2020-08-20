using BuynSell.userBuyers;
using BuynSell.userSellers;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using BuynSell.assets;
using System.ComponentModel.DataAnnotations.Schema;

namespace BuynSell.assets
{
    class YourMoney
    {
        public static int balance = 1000;

        public int Add()
        {
            var xSpace = new Inventory();
            var inVal = xSpace.xReturn();
            if(inVal > 0)
            {
                var getNum = new BuyCompiler();
                var addAmount = getNum.numReturn();
                var newBal = addAmount + balance;
                balance = balance + addAmount;
                return newBal;
            }else
            {
                Console.WriteLine("Tyrna scam the Market eh?? \n" +
                    "Your assets have been repossessed \n" +
                    "and your legs have been broken");
                balance = 0;
                return 0;
            }
        }
        public int Sub()
        {
            if(balance > 0)
            {
                var getNum = new SellCompiler();
                var subAmount = getNum.numReturn();
                var newBal = balance - subAmount;
                balance = balance - subAmount;
                return newBal;
            }
            else
            {
                Console.WriteLine("Nice try wise guy \n" +
                    "Your Legs have been broken");
                return 0;
            }
                
        }
        public int CurrentBalance()
        {
            return balance;
        }
    }
}
