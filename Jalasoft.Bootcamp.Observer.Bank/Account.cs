namespace Jalasoft.Bootcamp.Observer.Bank
{
    using System.Collections.Generic;
    public class Account
    {
        public Account(int account, List<IBankClient> owners)
        {
            this.AccountNumber = account;
            this.MoneyCredit = 0;
            this.Owners = owners;
        }

        public int AccountNumber { get; set; }

        public int MoneyCredit { get; set; }

        public List<IBankClient> Owners { get; set; }
    }
}