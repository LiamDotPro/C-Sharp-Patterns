using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patterns.Patterns.Inheritance
{
    class BankAccount : IAccountable
    {
        private string BankName;
        private double IntrestRate;
        private string Owner;
        private double Balance;

        public BankAccount(string Bname, double IRate, string Oname, double _Balance) {
            BankName = Bname;
            IntrestRate = IRate;
            Owner = Oname;
            Balance = _Balance;
        }

        public double getBalance()
        {
            return Balance;
        }

        public string getBankName() {
            return BankName;
        }

        public string getOwner()
        {
            return Owner;
        }
    }
}
