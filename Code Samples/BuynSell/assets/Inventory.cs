using System;
using BuynSell.assets;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace BuynSell.assets
{
    class Inventory
    {
        public static int xSpace = 0;
       public void addX(){
            xSpace = xSpace + 1;
        }
       public void subX()
        {
            xSpace = xSpace - 1;
        }
       public int xReturn()
        {
            return xSpace;
        }
    }
}
