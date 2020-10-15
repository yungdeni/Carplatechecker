using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Carplatechecker
{
    class Program
    {
        static void Main(string[] args)
        {
            string regplate;
            regplate = Console.ReadLine().ToUpper();
            if (regplate.Length != 6)
            {
                Console.WriteLine("Regnumber " + regplate + " is not correct");
            }
            //check if second too last two characters are numbers
            else if (int.TryParse(regplate.Substring(3, 2), out _) == false)
            {
                Console.WriteLine("Regnumber " + regplate + " is not correct");
            }
            //check if first three characters are letters
            else if (int.TryParse(regplate.Substring(0, 3), out _) == true)
            {
                Console.WriteLine("Regnumber " + regplate + " is not correct");
            }
            else if (regplate.Substring(0, 3).Contains("I") || regplate.Substring(0, 3).Contains("Q") || regplate.Substring(0, 3).Contains("V"))
            {
                Console.WriteLine("Regnumber " + regplate + " is not correct");
            }
            else if (regplate.Substring(5, 1).Contains("I") || regplate.Substring(5, 1).Contains("Q") || regplate.Substring(5, 1).Contains("V"))
            {
            }
            else
            {
                Console.WriteLine("Regnumber " + regplate + " is correct");
            }
            Console.ReadKey();
        }
    }
}
