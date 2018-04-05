using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalQ
{
    class DiceTill6
    {
        static void Main()
        {
            Random random = new Random();
            int dice1=0;
            //int dice2 = 0;

            while (dice1 != 6)
            { 
                dice1 = random.Next(1, 7);
                //dice2 = random.Next(1, 7);
                Console.WriteLine("{0} " ,dice1);
                
            }

;        }
    }
}
