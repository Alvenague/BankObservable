namespace Jalasoft.Bootcamp.Observer.Bank
{
    using System;
    using System.Collections.Generic;
    public class Bank
    {
        //Subject
        public int state;
        public string Name { get; set; }

        public List<Account> accounts;

        List<Notification> notifications;
        public Bank()
        {
            notifications = new List<Notification>();
            accounts = new List<Account>();
        }
        public int GetState()
        {
            return this.state;
        }
        public void Attach(Notification notification)
        {
            notifications.Add(notification);
        }
        public void ReceiveMoneyCredit(Account account, int money)
        {
            foreach (var acount in accounts)
            {
                acount.ReceiveMoneyCredit(money);
                if (account.AccountNumber == acount.AccountNumber)
                {
                    foreach (var person in account.Persons)
                    {
                        if (person.Cellphone.Subcribe) {
                            Notify(person);
                        }
                        
                    }
                }

            }
        }
        private void Notify(Person person)
        {
            
            foreach (var notification in notifications)
            {
                Console.WriteLine("derson name: " + person.Name+" number: "+person.Cellphone.CellphoneNumber);
                notification.Update(person.Cellphone.CellphoneNumber);
            }

        }
    }
}
