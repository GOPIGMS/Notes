using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineTheatreTicketBooking.Enums;
using OnlineTheatreTicketBooking.Interfaces;

namespace OnlineTheatreTicketBooking.Models
{
    /// <summary>
    /// UserDetails class stores the data of the user <see cref="UserDetails"/>
    /// </summary>
    public class UserDetails :PersonalDetails,IWallet
    {
        //fields
        /// <summary>
        /// s_userID field used to auto increment the UserID <see cref="UserDetails"/>
        /// </summary>
        private static int s_userID = 1000;
        /// <summary>
        /// _balance field used to auto increment the balance <see cref="UserDetails"/>
        /// </summary>
        private double _balance;
        //properties
        /// <summary>
        /// Property used to store UserID  <see cref="UserDetails"/>
        /// </summary>
        public string UserID { get; set; }
        /// <summary>
        /// Property used to store WalletBalance <see cref="UserDetails"/>
        /// </summary>
        public double WalletBalance
        {
            get
            {
                return _balance;
            }
        }
        //constructors
        /// <summary>
        /// Default constructor  used to initialize the class <see cref="UserDetails"/>
        /// </summary>
        public UserDetails(){}
        /// <summary>
        /// Parameterized  constructor  used to initialize the class with parameter values <see cref="UserDetails"/>
        /// </summary>
        /// <param name="userID">userID is a string used to initialize the property UserID</param>
        /// <param name="balance">balance is a double used to initialize the property Balance</param>
        /// <param name="name">name is a string used to initialize the property Name</param>
        /// <param name="age">age is a int used to initialize the property Age</param>
        /// <param name="phoneNumber">phoneNumber is a string used to initialize the property PhoneNumber</param>
        /// <param name="gender">gender is a string used to initialize the property Gender</param>
        public UserDetails(string userID, double balance, string name, int age, long phoneNumber, GenderDetails gender)
        {
            UserID = userID;
            _balance = balance;
            Name = name;
            Age = age;
            PhoneNumber = phoneNumber;
            Gender = gender;
            ++s_userID;
        }
        /// <summary>
        /// Parameterized  constructor  used to initialize the class with parameter values <see cref="TheatreDetails"/>
        /// </summary>
        /// <param name="details">string value for files</param>
        public UserDetails(string details)
        {
            string[] values =details.Split(',');
            UserID = values[0];
            _balance = Convert.ToDouble(values[1]);
            Name = values[2];
            Age = Convert.ToInt32(values[3]);
            PhoneNumber =Convert.ToInt64(values[4]);
            Gender = Enum.Parse<GenderDetails>(values[5],true);
            ++s_userID;
        }
        /// <summary>
        /// Parameterized  constructor  used to initialize the class with parameter values <see cref="UserDetails"/>
        /// </summary>
        /// <param name="balance">balance is a double used to initialize the property Balance</param>
        /// <param name="name">name is a string used to initialize the property Name</param>
        /// <param name="age">age is a int used to initialize the property Age</param>
        /// <param name="phoneNumber">phoneNumber is a string used to initialize the property PhoneNumber</param>
        /// <param name="gender">gender is a Enum used to initialize the property Gender</param>
        public UserDetails( double balance, string name, int age, long phoneNumber, GenderDetails gender)
        {
            UserID = $"UID{++s_userID}";
            _balance = balance;
            Name = name;
            Age = age;
            PhoneNumber = phoneNumber;
            Gender = gender;
        }
        //methods
        /// <summary>
        /// Increment the user wallet balance with the given amount
        /// </summary>
        public double RechargeWallet(double amount){
            _balance +=amount>0? amount:0;
            return WalletBalance;
        }
        /// <summary>
        /// Dectement the user wallet balance with the given amount
        /// </summary>
        public double DeductBalance(double amount){
            _balance -=amount>0? amount:0;
            return WalletBalance;
        }
    }
}