using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_22_Lab
{
    internal class BankAccount
    {
        private int id;
        private string name;
        private int balance;

        public BankAccount(string _name, int _balance)
        {
            name = _name;
            balance = _balance;
        }

        #region getters and setters
        public void SetId(int _id)
        {
            id = _id;
        }
        public int GetId() { return this.id; }

        public void SetName(string _name)
        {
            name = _name;
        }
        public string GetName() { return this.name; }

        public int GetBalance() { return this.balance; }
        public void Deposite(int deposite) 
        { 
            this.balance += deposite; 
        }
        public void Withdraw(int withdraw)
        {
            this.balance -= withdraw;
        }
        #endregion
    }
}
