using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    class Program
    {
        // Name: Everistus Akpabio
        // Date created: 2/16/2018
        // Purpose: An application to sell tickets for an event.
        static void Main(string[] args)
        {
            //Defining our variables 
            //Declaring our integer variables
            int seatNumber, rowNumber;
            //Declaring decimal variable for our costs
            decimal ticketCost = 0m, ccCost = 0m, deliveryCost = 0m, totalCost = 0m;
            //Declaring our decimal constant for ROW 1 and 2
            const decimal ROW_1_2_PRICE = 450m;
            //Declaring our decimal constant for ROW 3 and 4
            const decimal ROW_3_4_PRICE = 350m;
            //Declaring our decimal constant for ROW 5,6 and 7
            const decimal ROW_5_6_7_PRICE = 450m;
            //Declaring our decimal constant for ROW 8
            const decimal ROW_8 = 250m;

            // Request User Input for number of seats
            Console.WriteLine("Enter the number of seats you would like to purchase : ");
            // Convert and Store user input in variable
            seatNumber = Convert.ToInt32(Console.ReadLine());
            // Check if 0 or less or greater than 12
            if (seatNumber <= 0 || seatNumber > 12)
            //Display and error message
            {
                Console.WriteLine("ERROR: Restart and enter a seat number greater than 0 and less than 12");
                //Set seat number to 0
                seatNumber = 0;
            }
            else
            {
                // Request User Input for row of seats
                Console.WriteLine("Enter the row you would like to seat in : ");
                // Convert and Store user input in variable
                rowNumber = Convert.ToInt32(Console.ReadLine());
                //Check if row number is between 1 and 8
                if (rowNumber >=1 && rowNumber <= 8){
                    // Check if row 1 or 2
                    if (rowNumber == 1 || rowNumber == 2)
                    {
                        // add row price to ticketCost
                        ticketCost += ROW_1_2_PRICE;
                        //multiply ticketCost by no. of seats
                        ticketCost *= seatNumber;
                    }
                    // Check if row 3 or 4
                    else if (rowNumber == 3 || rowNumber == 4)
                    {
                        // add row price to ticketCost
                        ticketCost += ROW_3_4_PRICE;
                        //multiply ticketCost by no. of seats
                        ticketCost *= seatNumber;
                    }
                    // Check if row 5 or 6 or 7
                    else if (rowNumber == 5 || rowNumber == 6 || rowNumber == 7)
                    {
                        // add row price to ticketCost
                        ticketCost += ROW_5_6_7_PRICE;
                        //multiply ticketCost by no. of seats
                        ticketCost *= seatNumber;
                    }
                    // Check if row 8
                    else if (rowNumber == 8)
                    {
                        // add row price to ticketCost
                        ticketCost += ROW_8;
                        //multiply ticketCost by no. of seats
                        ticketCost *= seatNumber;
                    }
                    //Ask for user input for card
                    Console.WriteLine("Would you like to charge the tickets to your credit card ? ");
                    //store input as string
                    string userEntry = Console.ReadLine();
                    //define string and make user input uppercase
                    userEntry = userEntry.ToUpper().Trim();
                    //check if user entered yes
                    if (userEntry.Equals("Y") || userEntry.Equals("YES"))
                    {
                        // if yes, add $5 to credit card cost
                        ccCost += 5.00m;
                        // add ccCost to total
                        totalCost += ccCost;
                    }
                    //Ask for user input for delivery
                    Console.WriteLine("Would you like to have tickets delivered ? ");
                    //store input as string
                    userEntry = Console.ReadLine();
                    //define string and make user input uppercase
                    userEntry = userEntry.ToUpper().Trim();
                    //check if user entered yes
                    if (userEntry.Equals("Y") || userEntry.Equals("YES"))
                    {
                        // if yes, add $8 to delivery cost
                        deliveryCost += 8.00m;
                        // add delivery cost to total
                        totalCost += 8.00m;
                    }
                    //Add ticket cost to total cost
                    totalCost += ticketCost;

                    //Display all the calculations for costs
                    Console.WriteLine($"The ticket cost is : {ticketCost.ToString("c")} , The credit card processing cost is = {ccCost.ToString("c")} , The delivery cost is = {deliveryCost.ToString("c")} " +
                        $"and the total cost is = {totalCost.ToString("c")}");
                }

                //Display and error message for row
                else
                {
                    //Output enter a number bewtween 1 to 8
                    Console.WriteLine(" ERROR: restart and enter a row number between 1 to 8");
                    //Set row number to 0
                    rowNumber = 0;
                }


         
            }
            //Wait for user input before closing application
            Console.ReadKey();
        }
    }
}
