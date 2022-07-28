using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperPower
{
     public class SuperPowerGenerator
    {
        Random rand = new Random();

        public int getSuperPower(int from=5,int to=10)
        {
            return(rand.Next(from,to));
        }
    }
}
