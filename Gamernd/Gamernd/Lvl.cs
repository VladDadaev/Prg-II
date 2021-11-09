using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamernd
{
    class Lvl
    {
        public int Gf(int level)
        {
            if (level == 0)
            {
                Console.WriteLine("YOU LOSE!");
                Console.ReadKey();
                return level;
            }
            else if(level == 1)
            {
                Console.WriteLine("Level 1");
                return level;
            }
            else if(level == 2)
            {
                Console.WriteLine("Level 2");
                return level;
            }
            else if(level == 3)
            {
                Console.WriteLine("Level 3");
                return level;
            }
            return level;
        }
    }
}
