using BuynSell.assets;
using System;
using BuynSell.userSellers;
using BuynSell.userBuyers;

namespace BuynSell
{
    class UserInterface
    {

        static void Main()
        {
            Console.WriteLine("Hello and welcome to BuynSell! \n" +
                "You recently purchased you're own retail shop and you're accomplishing your life long dream of Selling '|X|', \n" +
                "but in order to maintain your fallacy you must buy said product buy pressing B and sell said product buy pressing S. \n" +
                "Becareful not to go bankrupt, because the market is volatile and you gotta make sure you get a good deal. \n" +
                "You recieved a loan from 'Da-Bank' for $1,000. Don't Lose this money or Don Jon will break your legs. \n" +
                "Also press C to check you assets.");

            while (1 < 5)
            {
                var userPB = Console.ReadLine();
                var funds = new YourMoney();
                var x = new Inventory();
                
                if (userPB == "C")
                {
                    Console.WriteLine("You have $" + funds.CurrentBalance() +" and you have " + x.xReturn() + " ammount of inventory");
                }
                if (userPB == "S")
                {
                    var namePrice = new BuyCompiler();
                    namePrice.conjuction();
                    var buyAns = Console.ReadLine();
                    if (buyAns == "Y")
                    {
                        funds.Add();
                        x.subX();
                    }
                    else
                    {
                        Console.WriteLine("Sorry we must not be on the same wavelength");
                    }
                }
                if (userPB == "B")
                {
                    var sellPrice = new SellCompiler();
                    sellPrice.conjuction();
                    var sellAns = Console.ReadLine();
                    if (sellAns == "Y")
                    {
                        x.addX();
                        funds.Sub();
                    }
                    else
                    {
                        Console.WriteLine("Sorry we must not be on the same wavelength");
                    }
                }
            }
        }
    }
}