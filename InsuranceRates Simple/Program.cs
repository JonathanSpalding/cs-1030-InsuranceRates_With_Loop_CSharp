using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Insurance Rates With Loop
 * 
 * by: Jonathan Spalding
 * Assignment: 2.2 
 * */

namespace InsuranceRates_Simple
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 0;
            float rate = 0f;
            String classification = "";
            string inputText = "";

            // Input Person's Age as an integer

            do
            
            {
                    Console.Write("Please enter person's age: ");
                    inputText = Console.ReadLine();
                    if (inputText == "") break;

                    if (!int.TryParse(inputText, out age))
                    {
                        Console.WriteLine("You must enter an integer for age. You entered: " + inputText);
                    }
                    else
                    // Given Age assign classification and rate

                    if (age <= 12)
                    {
                        classification = "Child";
                        rate = 1.0f;

                    }
                    else if (age <= 18)
                    {
                        classification = "Teen";
                        rate = 1.5f;
                    }
                    else if (age <= 65)
                    {
                        classification = "Adult";
                        rate = 1.7f;
                    }
                    else // 66 and above
                    {
                        classification = "Senior";
                        rate = 2f;
                    }

                    //   Outputs:
                    Console.WriteLine("\nPerson's Age: \t" + age.ToString());
                    Console.WriteLine("Classification: \t" + classification);
                    Console.WriteLine("Rate Multiplier: \t" + rate.ToString());
            } while (true);
        }
    }
}
