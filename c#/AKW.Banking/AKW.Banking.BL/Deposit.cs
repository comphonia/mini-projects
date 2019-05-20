using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AKW.Banking.BL
{
    public class Deposit
    {
        private int depositid;

        public int DepositID
        {
            get { return depositid; }
            set { depositid = value; }
        }

        private double depositamount;

        public double DepositAmount
        {
            get { return depositamount; }
            set { depositamount = value; }
        }

        private DateTime depositdate;

        public DateTime DepositDate
        {
            get { return depositdate; }
            set { depositdate = value; }
        }

        //constructor
        public Deposit(int _id, double _depositamount, DateTime _depositdate)
        {
            DepositID = _id;
            DepositAmount = _depositamount;
            DepositDate = _depositdate;
        }

    }
}
