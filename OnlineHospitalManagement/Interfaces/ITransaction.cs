using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineHospitalManagement
{
    public interface ITransaction
    {

        //properties
        public double WalletBalance {get;}
        //methods
        double Recharge(double amount);
        double DeductBalance(double amount);

        
    }
}