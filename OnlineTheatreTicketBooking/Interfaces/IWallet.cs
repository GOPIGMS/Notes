using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTheatreTicketBooking.Interfaces
{
    public interface IWallet
    {
        //properties
        public double WalletBalance {get;}
        //Methods
        public double RechargeWallet(double amount);
        public double DeductBalance (double amount);
    }
}