using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniGames
{
    class Parse
    {
        public static int tryParse(string q) //Try to parse the string as an integer
        {
            int value;

            if (int.TryParse(q, out value)) 
            {
                return value;
            }
            else
            {
                return 0;
            }
        }

    }
}
