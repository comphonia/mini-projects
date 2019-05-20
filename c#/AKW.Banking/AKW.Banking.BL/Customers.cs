using System;
using System.Collections.Generic;
using System.IO;
namespace AKW.Banking.BL
{

    public class Customers : List<Customer>
    {

        public void Populate()
        {
            //Create Customers
            Customer customer;
            customer = new Customer(2, "594-59-6666", "Adam", "Krieger", 5, DateTime.Now, "Adam Krieger");
            customer.AddDeposits(2, 500.63, DateTime.Now);
            customer.AddWithDrawl(2, 23.56, DateTime.Now);
            this.Add(customer);

            customer = new Customer(3, "111-11-1111", "Mark", "Krieger", 10, DateTime.Now, "Mark Krieger");
            customer.AddDeposits(3, 2.63, DateTime.Now);
            customer.AddWithDrawl(3, 66.66, DateTime.Now);
            this.Add(customer);
        }
        //StreamWriter

        string path = @"Text.txt";
        public void WriteFile(List<Customer> customerData)
        {
            StreamWriter outputFile;
            outputFile = File.CreateText(path);
            try
            {
                foreach (var data in customerData)
                {
                    double depAmt = 0;
                    string depTime = "";
                    foreach (var deposit in data.DepositList)
                    {
                        depAmt = deposit.DepositAmount;
                        depTime = deposit.DepositDate.Date.ToString("M/dd/yyyy");
                    }
                    double withAmt = 0;
                    string withTime = "";
                    foreach (var withdrawl in data.WithDrawlList)
                    {
                        withAmt = withdrawl.WithdrawlAmount;
                        withTime = withdrawl.WithdrawlDate.Date.ToString("M/dd/yyyy");
                    }
                    outputFile.WriteLine($"{data.CustomerID},{data.SSN},{data.LastName},{data.FirstName},{data.Age},{data.BirthDate.Date.ToString("M/dd/yyyy")},{data.FullName} | {depAmt},{depTime} | {withAmt},{withTime}");
                }


            }
            catch (Exception e)
            {
                // Let the user know what went wrong.
            }
            outputFile.Close();
        }

        public List<Customer> ReadFile()
        {
            List<Customer> CustomerList = new List<Customer>();
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    var lines = File.ReadAllLines(path);

                    foreach (var line in lines)
                    {
                        Console.WriteLine(line);
                        // splits each line into Customer | AddDeposits | AddWithDrawl
                        string[] data = line.Split('|');
                        //customer variables
                        string[] customerData = data[0].Split(',');
                        int id = Convert.ToInt32(customerData[0]);
                        string ssn = customerData[1];
                        string firstName = customerData[2];
                        string lastName = customerData[3];
                        int age = Convert.ToInt32(customerData[4]);
                        DateTime date = Convert.ToDateTime(customerData[5]).Date;
                        string fullName = customerData[6];
                        //deposit variables
                        string[] addDeposit = data[1].Split(',');
                        double depositAmt = Convert.ToDouble(addDeposit[0]);
                        DateTime depositTime = Convert.ToDateTime(addDeposit[1]).Date;
                        //withdrawal variables
                        string[] addWithdrawal = data[2].Split(',');
                        double withdrawalAmt = Convert.ToDouble(addWithdrawal[0]);
                        DateTime withdrawalTime = Convert.ToDateTime(addWithdrawal[1]).Date;
                        // create an instance of a Customer and populate it
                        Customer customer;
                        customer = new Customer(id, ssn, firstName, lastName, age, date, fullName);
                        customer.AddDeposits(id, depositAmt, depositTime);
                        customer.AddWithDrawl(id, withdrawalAmt, withdrawalTime);
                        // add each customer to a list
                        CustomerList.Add(customer);
                    }

                }
            }
            catch (Exception e)
            {
                // Let the user know what went wrong.
            }
            return CustomerList;
        }
    }
}
