namespace Jalasoft.Bootcamp.Observer.Bank
{
    using System;
    using System.Collections.Generic;

    public class Bank : IBank
    {
        public int state;

        public string Name { get; set; }

        private static List<IBankClient> Clients;

        public Bank()
        {
            Clients = new List<IBankClient>();
        }

        public void RemoveCellphone(int accountNumber, int cell)
        {
            IBankClient client = Clients.Find(c => c.Account.AccountNumber == accountNumber);
            client.Cellphone.Remove(cell);
        }

        public List<IBankClient> AddClient(IBankClient client)
        {
            Clients.Add(client);

            return Clients;
        }

        public List<IBankClient> RemoveClient(IBankClient client)
        {
            Clients.Remove(client);

            return Clients;
        }

        public void NotifyClient(IBankClient client)
        {
            string response= System.String.Empty;
            string cellResponse;       
            cellResponse = client.UpdateAccountStatus(client.Account.MoneyCredit);
            Console.WriteLine(cellResponse);            
        }

        public bool ReceiveMoneyCredit(int accountNumber, int money)
        {
            IBankClient client = Clients.Find(c => c.Account.AccountNumber == accountNumber);
            if (client != null)
            {
                client.Account.MoneyCredit += money;
                NotifyClient(client);
                return true;
            }
            return false;
        }
    }
}
