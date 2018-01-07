using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Operations
    {
        public Double firstNumber = 0;
        public Double secondNumber = 0;

        public void Numbers()
        {
            //Første nummer
            try
            {
                Console.Write("Type a number: ");
                firstNumber = Convert.ToDouble(Console.ReadLine());

                //Andre nummer
                try
                {
                    Console.Write("Type another number: ");
                    secondNumber = Convert.ToDouble(Console.ReadLine());
                }
                catch
                {
                    Console.Clear(); //Tøm skjerm
                    Console.WriteLine("You have to enter a valid number!\n");
                    throw;
                }
            }
            catch
            {
                Console.Clear(); //Tøm skjerm
                Console.WriteLine("You have to enter a valid number!\n");
                throw;
            }


        }

        public void Add()
        {
            //Resultat
            Console.WriteLine("\n" + firstNumber + " + " + secondNumber + " = " + (firstNumber += secondNumber));
        }

        public void Subtract()
        {
            //Resultat
            Console.WriteLine("\n" + firstNumber + " - " + secondNumber + " = " + (firstNumber -= secondNumber));
        }

        public void Multiply()
        {
            //Resultat
            Console.WriteLine("\n" + firstNumber + " * " + secondNumber + " = " + (firstNumber *= secondNumber));
        }

        public void Divide()
        {
            //Resultat
            Console.WriteLine("\n" + firstNumber + " / " + secondNumber + " = " + (firstNumber /= secondNumber));
        }

        public void Percent()
        {
            //Resultat
            Console.WriteLine("\n" + secondNumber + "% of " + firstNumber + " = " + (firstNumber *= (secondNumber /= 100)));
        }
    }
}
