using System;
using System.Collections.Generic;
using System.Text;

namespace Jalasoft.Bootcamp.Observer.Bank
{
    public interface IBankClient
    {
        string UpdateAccountStatus(int accountNumber);

        void UnsuscribeNotification(int cellNumber);

        string Name { get; set; }

        Account Account { get; set; }

        List<int> Cellphone { get; set; }
    }
}
