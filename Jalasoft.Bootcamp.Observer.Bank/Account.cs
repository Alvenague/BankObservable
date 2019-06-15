namespace Jalasoft.Bootcamp.Observer.Bank
{
    using System.Collections.Generic;
    public class Account
    {
        public int AccountNumber { get; set; }
        public List<Person> Persons  { get; set; }
        public int MoneyCredit { get; set; }

        public Account(int account, List<Person> persons)
        {
            this.AccountNumber = account;
            this.Persons = persons;
            this.MoneyCredit = 0;

        }

        public void ReceiveMoneyCredit(int moneycredit)
        {

            this.MoneyCredit += moneycredit;
        }
    }
}
