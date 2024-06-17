﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAccounts
{
    class Account
    {
        private string _id;
        private string _name;
        private decimal _balance;

        public Account(string id, string name, decimal balance)
        {
            _id = id;
            _name = name;
            _balance = balance;
        }

        public string Id
        {
            get { return _id; }
        }
        public string Name { get { return _name; } }
        public decimal Balance { get { return _balance; } }
         
        public void Deposit(decimal amount)
        {
            if (amount != 0)
                _balance += amount;
            else
                MessageBox.Show("存款金額錯誤");

        }

        public void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= _balance)
                _balance -= amount;
            else
                MessageBox.Show("提款金額錯誤");

        }
    }
}
