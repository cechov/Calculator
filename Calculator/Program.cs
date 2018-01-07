using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        enum calculatorFunction
        {
            Add = 1,
            Subtract = 2,
            Multiply = 3,
            Divide = 4,
            Percent = 5
        };
        
            static void Main(string[] args)
        {
            while(true)
            {
                Console.Clear(); //Tøm skjerm
                int selectedFunction = 0;
                
                do
                {
                    //Skriv ut liste med funksjoner
                    Console.WriteLine("Choose from the following functions:");
                    Console.WriteLine("1. " + calculatorFunction.Add);
                    Console.WriteLine("2. " + calculatorFunction.Subtract);
                    Console.WriteLine("3. " + calculatorFunction.Multiply);
                    Console.WriteLine("4. " + calculatorFunction.Divide);
                    Console.WriteLine("5. " + calculatorFunction.Percent + "\n");
                    Console.Write("Please enter the desired function (1-5):");
                    //Sjekke om input er mellom 1 og 5
                    try
                    {
                        selectedFunction = Convert.ToUInt16(Console.ReadLine());
                    }
                    catch
                    {
                        Console.Clear(); //Tøm skjerm
                        Console.WriteLine("You have to enter a valid number!\n");
                        continue;
                    }
                }
                while ((selectedFunction >= 6) || (selectedFunction <= 0));

                bool confirmValidation = false;
                string confirmFunction;

                do
                {
                    //Bruker må bekrefte for å fortsette
                    Console.WriteLine("\nYou have selected the following function: {0}. Do you want to continue? (Y / N)", Enum.GetName(typeof(calculatorFunction), selectedFunction));
                    
                    try
                    {
                        confirmFunction = Convert.ToString(Console.ReadLine()).Substring(0, 1).ToUpper();
                        try
                        {
                            //Sjekk om Y / N
                            if ((confirmFunction.ToUpper().Contains("Y")) | (confirmFunction.ToUpper().Contains("N")))
                            {
                                confirmValidation = true;
                                //Hvis Y
                                if ((confirmFunction.ToUpper().Contains("Y")))
                                {
                                    Console.Clear(); //Tøm skjerm
                                    Console.WriteLine("Function: " + Enum.GetName(typeof(calculatorFunction), selectedFunction) + "\n");
                                    //Skrive inn 2 tall og utføre valgt kommando
                                    Operations o = new Operations();
                                    o.Numbers();

                                    if (selectedFunction == 1) { o.Add(); }
                                    if (selectedFunction == 2) { o.Subtract(); }
                                    if (selectedFunction == 3) { o.Multiply(); }
                                    if (selectedFunction == 4) { o.Divide(); }
                                    if (selectedFunction == 5) { o.Percent(); }

                                }
                                //Hvis N
                                else
                                {
                                    Console.Clear(); //Tøm skjerm
                                    continue;
                                }
                            }
                            else
                            {
                                Console.Clear(); //Tøm skjerm
                                Console.WriteLine("\nInvalid entry. \n");
                            }
                        }
                        catch
                        {
                            throw;
                        }
                    }
                    catch
                    {
                        continue;
                    }
                } while (confirmValidation == false);

                
                //Starte på ny eller avslutte
                Console.WriteLine("\nPress any key to restart, or press Esc to finish.");
                var userInput = Console.ReadKey();
                if (userInput.Key == ConsoleKey.Escape)
                return;
            }
        } 
    }
}
