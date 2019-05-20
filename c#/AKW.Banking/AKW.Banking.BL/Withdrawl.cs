using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AKW.Banking.BL
{
    public class Withdrawl
    {
        private int withdrawlid;

        public int WithdrawlID
        {
            get { return withdrawlid; }
            set { withdrawlid = value; }
        }

        private double withdrawlamount;

        public double WithdrawlAmount
        {
            get { return withdrawlamount; }
            set { withdrawlamount = value; }
        }

        private DateTime withdrawldate;

        public DateTime WithdrawlDate
        {
            get { return withdrawldate; }
            set { withdrawldate = value; }
        }

        //constructor
        public Withdrawl(int _id, double _withdrawlamount, DateTime _withdrawldate)
        {
            WithdrawlID = _id;
            WithdrawlAmount = _withdrawlamount;
            WithdrawlDate = _withdrawldate;
        }


    }
}
