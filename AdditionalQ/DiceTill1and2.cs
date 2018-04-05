using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalQ
{
    class DiceTill1and2
    {
        static void Main()
        {
            Random rnd = new Random();
            int dice, temp=0;
            bool flag = false;
            do
            {
                dice = rnd.Next(1, 7);
                Console.WriteLine(dice);
                if (dice == 1)
                { temp = dice; }
                else if(dice!=2)
                { temp = 0; }
                
               if (dice == 2 && temp == 1) flag = true;

                
            }
            while (flag==false);

        }
    }
}
