namespace Jalasoft.Bootcamp.Observer.Bank
{
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            Cellphone cellphone = new Cellphone(65666666);
            Person person = new Person("Person 1", cellphone);

            Cellphone cellphone2 = new Cellphone(77565555);
            Person person2 = new Person("Person 1", cellphone2);

            var persons = new List<Person>();
            persons.Add(person);
            persons.Add(person2);

            Account account = new Account(11111,persons);
            Bank bank = new Bank();
            bank.accounts.Add(account);
                     
            CellphoneNotification notification= new CellphoneNotification(bank);

            bank.ReceiveMoneyCredit(account,13);
            person.UnsuscribeNotification();
            bank.ReceiveMoneyCredit(account, 100);

        }
    }
}
