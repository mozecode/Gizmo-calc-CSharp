using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoseleyHMK5
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput; //max counter
            int input = 1; //counter
            string color;
            int noOfCorners;
            double sum = 0;

            Console.WriteLine("\tWelcome to the Gizmo Store!");

            Console.WriteLine();//blank

            Console.Write("How many Gizmos would you like to order? >> ");

            while (int.TryParse(Console.ReadLine(), out userInput) == false)
            {
                Console.Write("Error.  Please try again: ");
             }

            while (input<=userInput)
            {
                Console.WriteLine();//blank

                Console.Write("Please enter the color you would like for Gizmo {0}: ", input);
                color = Console.ReadLine();

                Console.Write("How many corners would you like?  " );
                while (int.TryParse(Console.ReadLine(), out noOfCorners) == false)
                {
                    Console.Write("Invalid input.  Please try again: ");
                }

                Gizmo G1 = new Gizmo(noOfCorners, color);//initialize gizmo with perameters

                double price= G1.GetPrice();  //capture price information in variable

                G1.PrintInfo();// print gizmo characteristics

                Console.WriteLine("This Gizmo costs {0:C}.", price);//print price info
                Console.WriteLine();//blank

                sum = sum + G1.GetPrice(); //add up total

                input++;//stops the loop at max input #  (counter)
            }


            Console.WriteLine("Your total Gizmo purchase comes to {0:C}.", sum);

            Console.ReadKey();
        }
    }
}
