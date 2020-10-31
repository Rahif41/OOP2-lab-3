using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Account
    {
        string accName, acid;
        int balance;
        public string getAccName()
        {
            return accName;
        }
        public void setAccName(string AccName)
        {
            accName = AccName;
        }
        public string getAcid()
        {
            return accName;
        }
        public void setAcid(string Acid)
        {
            acid = Acid;
        }
        public int getBalance()
        {
            return Balance;
        }
        public void Deposite(int ammount)
        {
            balance = balance + ammount;
        }
        public void withdraw(int ammount)
        {
            balance = balance - ammount;
        }
    }
}
