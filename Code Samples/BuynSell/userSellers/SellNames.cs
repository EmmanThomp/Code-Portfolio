using System;
using System.Collections.Generic;
using System.Text;

namespace BuynSell.userSellers
{
    class SellNames
    {
        //The area names pulled from when press S
        string[] buyers = new string[5] { "Barnbo", "Anne", "Azskebell", "Ackman", "Black" };
        Random random = new Random();
        public string SellNameChoser()
        {
            var randomArrayVal = random.Next(0, buyers.Length);
            var randomName = buyers[randomArrayVal];
            return randomName;
        }
    }
}
