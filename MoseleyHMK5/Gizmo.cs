using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoseleyHMK5
{
    class Gizmo
    {
        //private data members

        private int noOfCorners;
        private string color;

        //build object- constructors

        public Gizmo ()//default
        {
            noOfCorners = 2;
            color = "Beige";
        }

        public Gizmo (int noOfCorners, string color)//perameterized constructor
        {
            if (noOfCorners >= 2)     //protection -- add protection in properties too, and within program
            { this.noOfCorners = noOfCorners; }
            else
            { Console.WriteLine("Error.  Default set to 2.");
                this.noOfCorners = 2;
            }
            this.color = color;
        }

        //Properties-- control get/set access to your private data

        public int NoOfCorners  //uses same name as private data member, only capitalized
        {
            get { return noOfCorners; }

            set { if (value >= 2)
                {
                    noOfCorners = value;
                }
                else
                { Console.WriteLine("Error.  Default set to 2."); noOfCorners = 2; }

                }//end of set

        }//end of property NoOfCorners


        public string Color
        {
            get { return color; }

            set { color = value; }

        }//end of property Color

        //Methods inside Gizmo class

        public void PrintInfo()
        {
            Console.WriteLine("This Gizmo has {0} corners and is {1}.", noOfCorners, color);
        }


        public double GetPrice()
        {   double price;

            price = 3 * (noOfCorners) * (noOfCorners) + 2 * (noOfCorners) + 1.99;


            return price;
        }


    }//end of class Gizmo

}//end of namespace
