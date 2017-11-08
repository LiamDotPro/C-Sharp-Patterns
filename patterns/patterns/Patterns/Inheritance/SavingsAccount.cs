using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patterns.Patterns.Inheritance
{
    class SavingsAccount : BankAccount, IAccountable
    {
        /**
         * C# Uses base as opposed to calling something like Super to essentially pass the variables back to the parent class.
         * This example shows how you can still use the parameters as the intended object creation to gain the benefits
         * of inheriting from a parent class.
         */ 
        public SavingsAccount(string Bname, double IRate, string Oname, double _Balance) : base(Bname, IRate, Oname, _Balance)
        {
            Console.WriteLine(getBalance());
        }
    }
}
