namespace Jalasoft.Bootcamp.Observer.Bank
{
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            var bank = new Bank();

            var cell = new List<int>
            {
                77252396,
                70688999
            };

            IBankClient person = new Person("Person 1", cell, bank);

            var cell2 = new List<int>
            {
                77252396
            };

            IBankClient person2 = new Person("Person 2", cell2, bank);

            var cell3 = new List<int>
            {
                70145689
            };

            IBankClient person3 = new Person("Person 3", cell3, bank);

            var list1 = new List<IBankClient>()
            {
                person, person2
            };

            var list2 = new List<IBankClient>()
            {
                person3, person
            };

            var account1 = new Account(1, list1);
            var account2 = new Account(2, list2);
            
            bank.AddClient(account1);
            bank.AddClient(account2);

            bank.ReceiveMoneyCredit(1,13);
            bank.ReceiveMoneyCredit(2, 113);
            bank.RemoveCellphone(1, 70688999);
            bank.ReceiveMoneyCredit(1, 13);
            bank.ReceiveMoneyCredit(2,10);
        }
    }
}
