using System;
using System.Collections.Generic;
using System.Text;

namespace Jalasoft.Bootcamp.Observer.Bank
{
    public interface IBankClient
    {
        string UpdateAccountStatus(int accountNumber);

        string Name { get; set; }

        List<int> Cellphone { get; set; }
    }
}
