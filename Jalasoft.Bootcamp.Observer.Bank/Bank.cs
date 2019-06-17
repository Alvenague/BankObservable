namespace Jalasoft.Bootcamp.Observer.Bank
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Bank : IBank
    {
        public int state;

        public string Name { get; set; }

        private static List<Account> Accounts;

        public Bank()
        {
            Accounts = new List<Account>();
        }

        public int GetStatus(int accountNumber)
        {
            Account account = Accounts.Find(a => a.AccountNumber == accountNumber);
            return account.MoneyCredit;
        }

        public void RemoveCellphone(int accountNumber, int cell)
        {
            Account account = Accounts.Find(c => c.AccountNumber == accountNumber);
            account.Owners.Find(o => o.Cellphone.Remove(cell));
        }

        public List<Account> AddClient(Account account)
        {
            Accounts.Add(account);

            return Accounts;
        }

        public List<Account> RemoveClient(Account account)
        {
            Accounts.Remove(account);

            return Accounts;
        }

        public void NotifyClient(IBankClient client, int accountNumber)
        {
            string response= System.String.Empty;
            string cellResponse;       
            cellResponse = client.UpdateAccountStatus(accountNumber);
            Console.WriteLine(cellResponse);            
        }

        public bool ReceiveMoneyCredit(int accountNumber, int money)
        {
            var account = Accounts.Find(a => a.AccountNumber == accountNumber);
            if (account != null)
            {
                account.MoneyCredit += money;
                foreach (var owner in account.Owners)
                {
                    NotifyClient(owner, account.AccountNumber);
                }                
                return true;
            }
            return false;
        }
    }
}
