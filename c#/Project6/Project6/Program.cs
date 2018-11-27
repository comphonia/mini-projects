using System;
using System.Collections.Generic;

namespace Project6
{
    class Program
    {
        // Name: Everistus Akpabio
        // Date created: 4/7/2018
        // Purpose: Application to calculate tax and insurance based salaries
        static void Main(string[] args)
        {
            //array to store the salaries
            double[] salary = { 31600, 31975, 32350, 32725, 33100, 33500, 33900 };
            //an empty array for the user salary
            double[] xpSalary;
            //variable to hole the minimum salary
            double minSalary = 0;
            //bool for the try parse
            bool isInt;
            //variable for the switch statement
            int years;
            //total expenses
            double expenses=0;
            //do-while loop for expenses
            do
            {
                //initialize expenses to 0
                expenses = 0;
                //initialize the array
                xpSalary  = new double[salary.Length];
                //for-loop to get input
                for (int i = 0; i < salary.Length; i++)
                {
                    //do-while loop for correct input
                    do
                    {
                        //space
                        Console.WriteLine("");
                        //ask for input
                        Console.WriteLine("Enter your position " + i + " years of experience : ");
                        //strore input
                        string userInput = Console.ReadLine();
                        //try parse for correct input
                        isInt = int.TryParse(userInput, out years);
                        //if wrong input
                        if (!isInt)
                        {
                            //space
                            Console.WriteLine("");
                            //re enter input
                            Console.WriteLine("Please enter a number from 1-6");
                            //space
                            Console.WriteLine("");
                        }
                        //else check input value
                        else
                        {
                            //swich statement to select proper minimum salary
                            switch (years)
                            {
                                //case to check
                                case 0:
                                    //assign the min value
                                    minSalary = salary[0];
                                    //break from case
                                    break;
                                //case to check
                                case 1:
                                    //assign the min value
                                    minSalary = salary[1];
                                    //break from case
                                    break;
                                //case to check
                                case 2:
                                    //assign the min value
                                    minSalary = salary[2];
                                    //break from case
                                    break;
                                //case to check
                                case 3:
                                    //assign the min value
                                    minSalary = salary[3];
                                    //break from case
                                    break;
                                //case to check
                                case 4:
                                    //assign the min value
                                    minSalary = salary[4];
                                    //break from case
                                    break;
                                //case to check
                                case 5:
                                    //assign the min value
                                    minSalary = salary[5];
                                    //break from case
                                    break;
                                //case to check
                                case 6:
                                    //assign the min value
                                    minSalary = salary[6];
                                    break;
                                //case to check
                                default:
                                    //break from case
                                    break;
                            }
                            //add the min salaries to an array
                            xpSalary[i] = minSalary;
                        }
                    }
                    //while bool is false
                    while (!isInt);
                    //expenses assigned from method
                    expenses = CalculateTotalSalaries(xpSalary);
                    //if greater than 250000
                    if (expenses > 250000)
                    {
                        //tell user to start over
                        Console.WriteLine("You have overspent your salary expense. Try again ");
                        //break from loop
                        break;
                    }


                }
                //while expenses is over limit
            } while (expenses > 250000);
            //display total
            Console.WriteLine("The total salary for all six positions is : " + CalculateTotalSalaries(xpSalary).ToString("C2"));
            //display tax and expense total
            Console.WriteLine("The total tax and insurance expenses is : " + CalculateTaxAndInsurance(xpSalary).ToString("C2"));
            //hold output
            Console.ReadKey();


        }

        //Method to return total salaries
        private static double CalculateTotalSalaries(double[] salaries)
        {
            //variable sum
            double sum = 0;
            //loop through array
            for (int i = 0; i < salaries.Length; i++)
            {
                //add each salary to sum
                sum += salaries[i];
            }
            //return the double
            return sum;
        }

        //Method to return total expenses
        private static double CalculateTaxAndInsurance(double[] salaries)
        {
            //variable expenses
            double expenses = 0;
            //loop through array
            for (int i = 0; i < salaries.Length; i++)
            {
                //add 25% of each salary to expenses
                expenses += (salaries[i] * 0.25);
            }
            //return the double
            return expenses;
        }
    }
}
