using System;
using System.Collections.Generic;
using System.Text;

namespace Jalasoft.Bootcamp.Observer.Bank
{
    public interface IBank
    {
        bool ReceiveMoneyCredit(int accountNumber, int money);
    }
}
