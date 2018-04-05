using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalQ
{
    class DiceTill2NumSame
    {
        static void Main()
        {
            Random rnd = new Random();
            int dice, temp=0;
            int count = 0 ;

            do
            {
                dice = rnd.Next(1, 7);
                Console.WriteLine(dice);
                if (temp != dice) temp = dice;
                else if (temp == dice) count++;
                
                
            }
            while (count<2);

        }
    }
}
