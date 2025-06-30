using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroTicketManagement.Interfaces
{
    public interface IBalance
    {
        //properties declaration
        public double Balance {get;}
        //method declaration
        public double WalletRecharge(double amount);
        public double DeductBalance(double amount);
    }
}