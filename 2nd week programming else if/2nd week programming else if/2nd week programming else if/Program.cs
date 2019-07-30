using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2nd_week_programming_else_if
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number between 1 and 10: ");
            int num1 = int.Parse(Console.ReadLine());

            if (num1==4)
            { Console.WriteLine("Congratulations you have guessed the correct number!");
            }

            else
            { Console.WriteLine("You lose :("); }
            Console.ReadLine();
            
        }
    }
}
