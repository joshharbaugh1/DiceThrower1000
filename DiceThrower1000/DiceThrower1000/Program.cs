using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceThrower1000
{
    class Program
    {
        static void Main(string[] args)
        {
            ThrowDice("10d6");
            ThrowDice("3d20");
            ThrowDice("100d6");
            Console.ReadKey();
        }
        static void ThrowDice(string diceString)
        {
            //creating random number generator
            Random rng = new Random();
            //creating an int for total amount rolled
            int totalAmount = 0;
            //making an array of strings and splitting it in between 'd'
            string[] holder = diceString.Split('d');
            //creating holders for numberOfRolled and numberOfSides
            int numberOfRolls = int.Parse(holder[0]);
            int numberOfSides = int.Parse(holder[1]);
           //prints out total dice used
            Console.WriteLine("Throwing: " + diceString);
            //loops numberOfRolls needed
            for (int i = numberOfRolls; i > 0; i--)
			{
             //creates random number generator
                int numberRolled = rng.Next(1, (numberOfSides + 1));
			 //prints out number rolled
                Console.Write(numberRolled+ " ");
                //adds to total amount
                totalAmount+=numberRolled;
            
			}
            //prints out the average of all numbers rolled
            Console.WriteLine();
            Console.WriteLine("Average: " +totalAmount/numberOfRolls);
            Console.WriteLine();
        }
    }
}
