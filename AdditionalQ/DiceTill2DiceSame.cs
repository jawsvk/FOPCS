using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalQ
{
    class DiceTill2DiceSame
    {
        static void Main()
        {
            Random random = new Random();
            int dice1;
            int dice2;

            do
            {
                dice1 = random.Next(1, 7);
                dice2 = random.Next(1, 7);
                Console.WriteLine("{0}  {1}", dice1, dice2);

            }
            while (dice1 != dice2);
            
        }
    }
}
