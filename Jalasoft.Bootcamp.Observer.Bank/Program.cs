namespace Jalasoft.Bootcamp.Observer.Bank
{
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            var cell = new List<int>
            {
                77252396,
                70688999
            };

            IBankClient person = new Person("Person 1", cell, new Account(1));

            var cell2 = new List<int>
            {
                77252396
            };

            IBankClient person2 = new Person("Person 1", cell2, new Account(2));
            
            Bank bank = new Bank();

            bank.AddClient(person);
            bank.AddClient(person2);


            bank.ReceiveMoneyCredit(1,13);
            bank.ReceiveMoneyCredit(1, 113);
            bank.RemoveCellphone(1, 70688999);
            bank.ReceiveMoneyCredit(1, 13);
        }
    }
}
