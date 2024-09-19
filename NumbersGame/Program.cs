using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NumbersGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej välkommen till nummberspelet!");
            Random random = new Random();
            int number = random.Next(1, 20);
            Console.WriteLine("Jag tänker på ett nummer. Gissa vilket det är");
            int player = int.Parse(Console.ReadLine());

            if (number == player)
            {
                Console.WriteLine("Wohoo! Du klarade det!");
            }
            else
            {
                Console.WriteLine("FEL!");
            }






        }
    }
}
