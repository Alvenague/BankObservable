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

            var newClient = new Person("Monica", cell, new Account(2));

            List<IBankClient> clientList = BankSistem.AddClient(newClient);

            Assert.NotEmpty(clientList);
        }

        [Fact]
        public void TestRemoveClient()
        {
            var cell = new List<int>
            {
                77252396
            };

            var newClient = new Person("Monica", cell, new Account(2));

            BankSistem.AddClient(newClient);

            List<IBankClient> clientList = BankSistem.RemoveClient(newClient);

            Assert.Empty(clientList);
        }

        [Fact]
        public void TestUpdateAccountStatus()
        {
            var cell = new List<int>
            {
                77252396
            };

            var newClient = new Person("Monica", cell, new Account(2));

            string response = newClient.UpdateAccountStatus(1);

            Assert.Contains("Succeeded", response);
        }

        [Fact]
        public void TestReceivedMoneyCredit()
        {
            var cell = new List<int>
            {
                77252396
            };

            var newClient = new Person("Monica", cell, new Account(2));

            BankSistem.AddClient(newClient);

            var result = BankSistem.ReceiveMoneyCredit(newClient.Account.AccountNumber, 100);

            Assert.True(result);
        }

        [Fact]
        public void TestUnsuscribeCellphone()
        {
            var cell = new List<int>
            {
                77252396
            };

            var newClient = new Person("Monica", cell, new Account(2));

            BankSistem.AddClient(newClient);

            BankSistem.RemoveCellphone(2, 77252396);

            Assert.Empty(newClient.Cellphone);
        }
    }
}
