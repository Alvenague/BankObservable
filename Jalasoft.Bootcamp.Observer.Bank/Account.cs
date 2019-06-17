namespace Jalasoft.Bootcamp.Observer.Bank
{
    using System.Collections.Generic;
    public class Account
    {
        public Account(int account)
        {
            this.AccountNumber = account;
            this.MoneyCredit = 0;
        }

        public int AccountNumber { get; set; }

        public int MoneyCredit { get; set; }
    }
}