using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamernd
{
    class Program
    {
        public int Randomchik()
        {
            Random rnd = new Random();
            int value = rnd.Next(0, 100);
            return value;
        }
    }
}
