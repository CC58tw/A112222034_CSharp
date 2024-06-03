using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Account_Simulator
{
    class BankAccount
    {
        private decimal _balance;

        public BankAccount(decimal startingBalance) //建構子
        { _balance = startingBalance; }

        public decimal Balance //屬性
        { get { return _balance; } }

        public void Deposit(decimal amount)
        {
            if (amount > 0)
                _balance += amount;
            else
                MessageBox.Show("存款金額錯誤");
        }
        public void Withdraw(decimal amount)
        {
            if (amount > 0m && amount <= _balance)
                _balance -= amount;
            else
                MessageBox.Show("提款金額錯誤");
        }
    }
}
