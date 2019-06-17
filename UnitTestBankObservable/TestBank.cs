using System;
using Xunit;
using Jalasoft.Bootcamp.Observer.Bank;
using System.Collections.Generic;
using System.Linq;

namespace Jalasoft.Bootcamp.Observer.Bank.Tests
{
    public class TestBank
    {
        public TestBank()
        {
            this.BankSistem = new Bank();
        }

        private List<IBankClient> Clients { get; set; }

        private Bank BankSistem { get; set; }

        [Fact]
        public void TestAddClient()
        {
            var cell = new List<int>
            {
                77254896, 70584963
            };

            var client = new Person("Monica", cell, BankSistem);

            var list1 = new List<IBankClient>()
            {
                client
            };

            var account1 = new Account(1, list1);
            
            List<Account> accountList = BankSistem.AddClient(account1);

            Assert.NotEmpty(accountList);
        }

        [Fact]
        public void TestRemoveClient()
        {
            var cell = new List<int>
            {
                77254896, 70584963
            };

            var client = new Person("Monica", cell, BankSistem);

            var list1 = new List<IBankClient>()
            {
                client
            };

            var account1 = new Account(1, list1);

            BankSistem.AddClient(account1);

            List<Account> clientList = BankSistem.RemoveClient(account1);

            Assert.Empty(clientList);
        }

        [Fact]
        public void TestUpdateAccountStatus()
        {
            var cell = new List<int>
            {
                77254896, 70584963
            };

            var client = new Person("Monica", cell, BankSistem);

            var list1 = new List<IBankClient>()
            {
                client
            };

            var account1 = new Account(1, list1);

            BankSistem.AddClient(account1);

            string response = client.UpdateAccountStatus(1);

            Assert.Contains("Succeeded", response);
        }

        [Fact]
        public void TestReceivedMoneyCredit()
        {
            var cell = new List<int>
            {
                77254896, 70584963
            };

            var client = new Person("Monica", cell, BankSistem);

            var list1 = new List<IBankClient>()
            {
                client
            };

            var account1 = new Account(1, list1);

            BankSistem.AddClient(account1);

            var result = BankSistem.ReceiveMoneyCredit(account1.AccountNumber, 100);

            Assert.True(result);
        }

        [Fact]
        public void TestUnsuscribeCellphone()
        {
            var cell = new List<int>
            {
                77254896
            };

            var client = new Person("Monica", cell, BankSistem);

            var list1 = new List<IBankClient>()
            {
                client
            };

            var account1 = new Account(1, list1);

            BankSistem.AddClient(account1);

            BankSistem.RemoveCellphone(1, 77254896);

            Assert.Empty(client.Cellphone);
        }
    }
}
