namespace Jalasoft.Bootcamp.Observer.Bank
{
    using System;

    using System.Collections.Generic;

    public class Person : IBankClient
    {
        public Person(string name, List<int> cellphone, Account account)
        {
            this.Name = name;
            this.Cellphone = cellphone;
            this.Account = account;
        }

        public void UnsuscribeNotification(int cellNumber)
        {
            Cellphone.Remove(cellNumber);
        }

        public string UpdateAccountStatus(int money)
        {
            if(Cellphone.Count > 0)
            {
                foreach (var cell in Cellphone)
                {
                    Console.WriteLine("Current money on account " + money + " cellphone notified : " + cell);
                }

                return "Notifications Succeeded";
            }

            return "There are no numbers to notify";
        }

        public string Name { get; set; }

        public List<int> Cellphone { get; set; }

        public Account Account { get; set; }

        public Bank Bank { get; set; }
    }
}