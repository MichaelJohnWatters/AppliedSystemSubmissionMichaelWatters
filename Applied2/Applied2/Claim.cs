using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applied2
{
    class Claim
    {
        private double amount;
        private DateTime date;

        public Claim(double _amount, DateTime _date)
        {
            amount = _amount;
            date = _date;
        }

        public double getAmount()
        {
            return amount;
        }
        public DateTime getDate()
        {
            return date;
        }
    }
}

