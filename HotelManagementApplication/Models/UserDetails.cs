using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelManagementApplication.Interfaces;
using HotelManagementApplication.Enums;

namespace HotelManagementApplication.Models
{
    /// <summary>
    /// Class User Detail has all the User Details <see cref="UserDetails"/>
    /// </summary>
    public class UserDetails : PersonalDetails, IWalletManager
    {
        //fields of UserDetails
        private double _balance;
        private static int s_userID = 1000;
        //properties
        public string UserID { get; set; }
        public double WalletBalance
        {
            get
            {
                return _balance;
            }
        }
        //constructors  of UserDetails
        public UserDetails() { }
        //Parameterized constructors  of UserDetails
        public UserDetails(string userID, string userName, long mobileNumber, long aadharNumber, string address, FoodTypeDetails foodType, GenderDetails gender, double walletBalance)
        {
            UserID = userID;
            UserName = userName;
            _balance = walletBalance > 0 ? walletBalance : 0;
            MobileNumber = mobileNumber;
            AadharNumber = aadharNumber;
            Address = address;
            FoodType = foodType;
            Gender = gender;
            ++s_userID;
        }
        public UserDetails(string details)
        {
            string[] values =details.Split();
            UserID = values[0];
            UserName = values[1];
            _balance = Convert.ToDouble(values[2]);
            MobileNumber = Convert.ToInt64(values[3]);
            AadharNumber =  Convert.ToInt64(values[4]);
            Address = values[5];
            FoodType = Enum.Parse<FoodTypeDetails>(values[6],true);
            Gender = Enum.Parse<GenderDetails>(values[6],true);
            ++s_userID;
        }
        public UserDetails(string userName, long mobileNumber, long aadharNumber, string address, FoodTypeDetails foodType, GenderDetails gender, double walletBalance)
        {
            UserID = $"SF{++s_userID}";
            _balance = walletBalance > 0 ? walletBalance : 0;
            UserName = userName;
            MobileNumber = mobileNumber;
            AadharNumber = aadharNumber;
            Address = address;
            FoodType = foodType;
            Gender = gender;
        }
        //Methods of interface
        public double WalletRecharge(double amount)
        {
            _balance += amount > 0 ? amount : 0;
            return WalletBalance;
        }
        public double DeductBalance(double amount)
        {
            _balance -= amount > 0 ? amount : 0;
            return WalletBalance;
        }

    }
}