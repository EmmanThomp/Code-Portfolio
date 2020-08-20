using System;

namespace BuynSell.userBuyers
{
    public class BuyNames
    {
        //area names pull from when press B
        string[] buyers = new string[5] { "Bonnie", "SUE", "Azskebell", "Newman", "White" };
        Random random = new Random();
        public string NameChoser()
        {
            var randomArrayVal = random.Next(0, buyers.Length);
            var randomName = buyers[randomArrayVal];
            return randomName;
        }
    }
}