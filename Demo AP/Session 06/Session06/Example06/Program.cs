using System;
using System.Collections.Generic;
using System.Text;

namespace Example06
{
    public delegate void delegateSms(double amount);
    class Account
    {
        //khai bao event
        public event delegateSms balanceChangeEvent;
        public Account(string name, double balance)
        {
            this.name = name;
            this.balance = balance;
        }
        private string name; //ten chu tai khoan

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private double balance; //so du

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        //phuong thuc rut tien
        public void withdraw(double amount)
        {
            balance = balance - amount;
            //goi event thay doi du
            balanceChangeEvent(amount);
        }
        public void deposit(double amount)
        {
            balance = balance + amount;
            balanceChangeEvent(amount);
        }
    }
    class Notification
    {
        //phuong thuc in ra so du thay doi khi rut tien - gui tien
        public void Notify(double amount)
        {
            Console.WriteLine("Tai khoan cua ban thay doi: " + amount);
        }
    }
    class Run
    {
        static void Main(string[] args)
        {
            //tao doi tuong chua event
            Account objAccount = new Account("TungPH", 1000000);
            //tao doi tuong chua phuong thuc xu ly event
            Notification objEventHandling = new Notification();
            //subcrible event to method
            objAccount.balanceChangeEvent += new delegateSms(objEventHandling.Notify);
            //raise event
            //gui tien
            objAccount.deposit(100000);
            //rut tien
            objAccount.withdraw(50000);

        }
    }

}
