using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace codetestInput2
{
    class Program
    {
        static void Main(string[] args)
        {
            //user input (Prices)
            Console.WriteLine("How much is the imported perfume?");
            string importedPerfumeInit = Console.ReadLine();
            decimal importedPerfumePrice = IsNumOnly(importedPerfumeInit) ? decimal.Parse(importedPerfumeInit) : 0;


            Console.WriteLine("How much is the imported chocolates?");
            string importedChocolatesInit = Console.ReadLine();
            decimal importedChocolatesPrice = IsNumOnly(importedChocolatesInit) ? decimal.Parse(importedChocolatesInit) : 0;

           


            //imported taxs entered by user
            Console.WriteLine("Enter in 0.05% for import tax.");
            string importTaxInit = Console.ReadLine();
            decimal importTaxAmount = IsNumOnly(importTaxInit) ? decimal.Parse(importTaxInit) : 0;            
            decimal salesTaxTotal = 7.65m;



            //calculations
            decimal importedPerfume = Math.Round(importedPerfumePrice * importTaxAmount, 2) + importedPerfumePrice;
            decimal importedChocolate = Math.Round(importedChocolatesPrice * importTaxAmount, 2) + importedChocolatesPrice;
            decimal overAllTotal = (importedPerfumePrice + importedChocolatesPrice + salesTaxTotal);

            //output
            Console.ReadLine();
            Console.WriteLine("Imported bottle of perfume:" + " " + importedPerfume);
            Console.WriteLine("Imported bottle of chocolate:" + " " + importedChocolate);
            Console.WriteLine("Sales Taxes:" + " " + salesTaxTotal);
            Console.WriteLine("Total:" + " " + overAllTotal);
            Console.ReadLine();





        }

        
        static bool IsNumOnly(string userInput)
        {
            //checks to see if there is any spaces entered in by the user.
            if (string.IsNullOrEmpty(userInput))
            {
                return false;
            }

            //checks to see if numbers entered by user matches if so returns results if not returns false. 
            Regex r = new Regex(@"^-{0,1}\d+\.{0,1}\d*$");
            Match m = r.Match(userInput);
            if (m.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
