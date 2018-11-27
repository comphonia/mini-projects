using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4
{
    class Program
    {
        // Name: Everistus Akpabio
        // Date created: 3/3/2018
        // Purpose: A sales app to calculate the subtotal, discount, tax, and total.
        static void Main(string[] args)
        {

            //Constant for tax rate defined
            const decimal OK_TAX_RATE = 0.08375m;
            //Declaring our variables as decimal
            decimal subtotal, subtotalInput, discount, tax, total;
            //Declaring our variable as in
            int discountInput;
            //Declaring our string variable for response
            string userInput;

            //boolean initialized to true
            bool isSubtotalValid;
            // DO while loop to check for correct input
            do
            {
                // Ask for user input for subtotal amount
                Console.WriteLine("Enter the subtotal amount : ");
                //getting out user input
                userInput = Console.ReadLine();
                //parsing our string into our decimal variable
                isSubtotalValid = decimal.TryParse(userInput, out subtotalInput);

            } while (!isSubtotalValid);

            //boolean initialized to true
            bool isDiscountValid;
            // DO while loop to check for correct input
            do
            {
                // Ask for user input for discount amount
                Console.WriteLine("Enter the discount amount : ");
                //getting out user input
                userInput = Console.ReadLine();
                //parsing our string into our int variable
                isDiscountValid = int.TryParse(userInput, out discountInput);

            } while (!isDiscountValid);

            // Calculating amount to discount pre tax
            discount = subtotalInput * discountInput;

            //Subtotal after discount
            subtotal = subtotalInput - discount;

            // Calculating tax owed after discount
            tax = subtotal * OK_TAX_RATE;

            // Calculating total owed
            total = subtotal + tax;

            // Display all outputs of calculated data
            Console.WriteLine($"The Subtotal is = {subtotal.ToString("c2")} , The discount amount is = {discount.ToString("c2")} , The tax owed is = {tax.ToString("c2")} , and Total owed is = {total.ToString("c2")} ");

            //Wait for use input before closing
            Console.ReadKey();

        }
    }
}
