using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Password
    {
        static bool checkCase(string a)
        {
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (char.IsUpper(a[i])) count++;

            }
            if (count == 0 || count==a.Length)
            {
                Console.WriteLine("No mix of Uppercase and Lowercase");
                return true;
            }
            else return false;

        }

        static bool CountString(string a)
        {
            if (a.Length < 8)
            {
                Console.WriteLine("Password not long enough");
                return true;
            }
            else
            {
                return false;
            }
        }

        static string getInput()
        {
            Console.Write(" Input new password: ");
            return Console.ReadLine();
           
        }
        static void Main()
        {
            bool a = false;
            bool b = true;
            
            bool isWrong = false;
            do
            {
                string s = getInput();
                isWrong = (CountString(s) || checkCase(s));


            } while (isWrong == true);

            if (isWrong == false) Console.WriteLine("password accepted");


        }

    }
}
