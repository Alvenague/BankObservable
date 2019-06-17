namespace Jalasoft.Bootcamp.Observer.Bank
{
    using System;

    using System.Collections.Generic;

    public class Person : IBankClient
    {
        public Person(string name, List<int> cellphone, Bank bank)
        {
            this.Name = name;
            this.Cellphone = cellphone;
            this.Bank = bank;
        }

        public string UpdateAccountStatus(int accountNumber)
        {
            int money = Bank.GetStatus(accountNumber);
            if(Cellphone.Count > 0)
            {
                foreach (var cell in Cellphone)
                {
                    Console.WriteLine("Current money on account " + money + " cellphone notified : " + cell);
                }

                return "Notifications Succeeded to " + this.Name;
            }

            return "There are no numbers to notify";
        }

        public string Name { get; set; }

        public List<int> Cellphone { get; set; }

        public Bank Bank { get; set; }
    }
}