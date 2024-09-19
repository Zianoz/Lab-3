using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NumbersGame
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Userinput();

        }
        static int Userinput()
        {
            Console.WriteLine("Hej! Välkommen till gissningsspelet!");
            Console.WriteLine("Hur många försök vill du ha på dig?");
            int userTries = Convert.ToInt32(Console.ReadLine());
            return userTries;

        }

        static int Gamegenerator()
        {
            Random random = new random();

            for (int i = 1, i <= userTries 
        }


    }
}
