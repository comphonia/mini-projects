using System;

namespace AKW.Banking.BL
{
    public class Customer : Person
    {
        private int customerid;

        public int CustomerID
        {
            get { return customerid; }
            set { customerid = value; }
        }

        private DepositList depositlist;

        public DepositList DepositList
        {
            get { return depositlist; }
            set { depositlist = value; }
        }

        private WithDrawlList withdrawllist;

        public WithDrawlList WithDrawlList
        {
            get { return withdrawllist; }
            set { withdrawllist = value; }
        }

        //empty constructor
        public Customer()
        {
            depositlist = new DepositList();
            withdrawllist = new WithDrawlList();
        }


        //CUstom COnstructor
        public Customer(int _id, string _ssn, string _firstname, string _lastname, int _age, DateTime _birthdate, string _fullname)
        {
            depositlist = new DepositList();
            withdrawllist = new WithDrawlList();

            CustomerID = _id;

            this.SSN = _ssn;
            this.FirstName = _firstname;
            this.LastName = _lastname;
            this.Age = _age;
            this.BirthDate = _birthdate;
            this.FullName = _fullname;
        }

        public void Populate()
        {
            CustomerID = 1;
            FirstName = "Adam";
            LastName = "Lang";
            Age = 19;
            BirthDate = DateTime.Now;
            FullName = FirstName + " " + LastName;
            AddDeposits(1, 500.5, DateTime.Now);
        }


        public void AddDeposits(int id, double DepositAmount, DateTime Time)
        {
            this.depositlist.Add(new Deposit(id, DepositAmount, Time));
        }

        public void AddWithDrawl(int id, double WithdrawlAmount, DateTime Time)
        {
            this.withdrawllist.Add(new Withdrawl(id, WithdrawlAmount, Time));
        }

    }
}
