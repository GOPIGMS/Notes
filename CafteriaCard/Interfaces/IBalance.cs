using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeteriaCard.Interfaces
{
    public interface IBalance
    {
        //properties
        /// <summary>
        /// Property used to store TheaterName <see cref="IBalance"/>
        /// </summary>
        /// <value></value>
        public double WalletBalance {get;}
        //methods
        /// <summary>
        /// method declaration for wallet balance <see cref="IBalance"/>
        /// </summary>
        public double WalletRecharge(double amount);
        /// <summary>
        /// method declaration for deducting balance <see cref="IBalance"/>
        /// </summary>
        public double DeductBalance(double amount);
    }
}