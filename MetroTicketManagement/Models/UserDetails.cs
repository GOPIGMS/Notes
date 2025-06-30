using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MetroTicketManagement.Interfaces;

namespace MetroTicketManagement.Models
{
    public class UserDetails :PersonalDetails,IBalance
    {
        //fields 
        /// <summary>
        ///  Field stores the  s_cardNumber  and auto increment  <see cref="UserDetails"/>
        /// </summary>
        private static int s_cardNumber= 1000;
        /// <summary>
        ///  Field stores the  _balance  and auto increment  <see cref="UserDetails"/>
        /// </summary>
        private double _balance ;
        //properties
        /// <summary>
        /// Property used to store CardNumber <see cref="UserDetails"/>
        /// </summary>
        public string CardNumber {get;set;}
        /// <summary>
        /// Property used to store Balance <see cref="UserDetails"/>
        /// </summary>
        public double Balance {get{return _balance;}}
        //constructor
        /// <summary>
        /// Default constructor  used to initialize the class <see cref="UserDetails"/>
        /// </summary>
        public UserDetails(){}
        //parameterized constructor
        /// <summary>
        /// Parameterized constructor  used to initialize the class <see cref="UserDetails"/>
        /// </summary>
        /// <param name="cardNumber">cardNumber is a string used to initialize the property cardNumber</param>
        /// <param name="balance">balance is a double used to initialize the property balance</param>
        /// <param name="userName">userName is a string used to initialize the property userName</param>
        /// <param name="phoneNumber">phoneNumber is a long used to initialize the property phoneNumber</param>
        public UserDetails(string cardNumber, double balance, string userName, long phoneNumber)
        {
            CardNumber = cardNumber;
            _balance = balance;
            UserName = userName;
            PhoneNumber = phoneNumber;
            ++s_cardNumber;
        }
        /// <summary>
        /// Parameterized  constructor  used to initialize the class with parameter values of <see cref="UserDetails"/>
        /// </summary>
        /// <param name="details">string with values of all property</param>
        public UserDetails(string details)
        {
            string[] values =details.Split(',');
            CardNumber = values[0];
            _balance = Convert.ToDouble(values[1]);
            UserName = values[2];
            PhoneNumber = Convert.ToInt64(values[3]);
            ++s_cardNumber;
        }
        
        //parameterized constructor
        /// <summary>
        /// Parameterized constructor  used to initialize the class <see cref="UserDetails"/>
        /// </summary>
        /// <param name="cardNumber">cardNumber is a string used to initialize the property cardNumber</param>
        /// <param name="balance">balance is a string used to initialize the property balance</param>
        /// <param name="userName">userName is a string used to initialize the property userName</param>
        /// <param name="phoneNumber">phoneNumber is a string used to initialize the property phoneNumber</param>
        public UserDetails( double balance, string userName, long phoneNumber)
        {
            CardNumber = $"CMRL{++s_cardNumber}";
            _balance = balance;
            UserName = userName;
            PhoneNumber = phoneNumber;
        }
        //methods
        /// <summary>
        /// Method to recharge wallet
        /// </summary>
        public double WalletRecharge(double amount){
            _balance+=amount>0?amount:0;
            return Balance;
        }
        /// <summary>
        /// Method to reduce the amount from the wallet
        /// </summary>
        public double DeductBalance(double amount){
            _balance-=amount>0?amount:0;
            return Balance;
        }


    }
}