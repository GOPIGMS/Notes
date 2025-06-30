using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagementApplication.Interfaces
{
    /// <summary>
    /// Interface for managing walllet  <see cref="IWalletManager"/>
    /// </summary>
    public interface IWalletManager
    {
        //properties declaration
        public double WalletBalance {get;}
        //method declaration
        public double WalletRecharge(double amount);
        public double DeductBalance(double amount);

    }
}