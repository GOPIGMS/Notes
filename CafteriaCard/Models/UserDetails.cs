using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CafeteriaCard.Enums;
using CafeteriaCard.Interfaces;

namespace OnlineFoodDeliveryApplication.Models
{
    public class UserDetails : PersonalDetails, IBalance
    {
        //fields
        /// <summary>
        ///  Field stores the  s_customerID  and auto increment  <see cref="UserDetails"/>
        /// </summary>
        private static int s_userID = 1000;
        /// <summary>
        ///  Field stores the  _balance  and auto increment  <see cref="UserDetails"/>
        /// </summary>
        private double _balance;
        //properties
        /// <summary>
        /// Property used to store UserID <see cref="UserDetails"/>
        /// </summary>
        public string UserID { get; set; }
        /// <summary>
        ///  Property used to store WorkStationNumber <see cref="UserDetails"/>
        /// </summary>
        public string WorkStationNumber {get;set;}
        /// <summary>
        /// Property used to store WalletBalance <see cref="UserDetails"/>
        /// </summary>
        public double WalletBalance { get { return _balance; } }
        //constructor
        /// <summary>
        /// Default constructor  used to initialize the class <see cref="UserDetails"/>
        /// </summary>
        public UserDetails() { }
        /// <summary>
        /// Parameterized constructor  used to initialize the class <see cref="UserDetails"/>
        /// </summary>
        /// <param name="customerID">customerID is a string used to initialize the property customerID</param>
        /// <param name="workStationNumber">workStationNumber is a string used to initialize the property WorkStationNumber</param>
        /// <param name="balance">balance is a double used to initialize the property balance</param>
        /// <param name="name">name is a string used to initialize the property name</param>
        /// <param name="fatherName">fatherName is a string used to initialize the property fatherName</param>
        /// <param name="gender">gender is a enum used to initialize the property gender</param>
        /// <param name="mobile">mobile is a long used to initialize the property Mobile</param>
        /// <param name="mailID">mailID is a string used to initialize the property mailID</param>
        public UserDetails(string userID,string workStationNumber, double balance, string name, string fatherName, GenderDetails gender, long mobile,  string mailID)
        {

            UserID = userID;
            WorkStationNumber=workStationNumber;
            _balance = balance;
            Name = name;
            FatherName = fatherName;
            Gender = gender;
            Mobile = mobile;
            MailID = mailID;
            ++s_userID;
        }
        /// <summary>
        /// Parameterized  constructor  used to initialize the class with parameter values of <see cref="FoodDetails"/>
        /// </summary>
        /// <param name="details">string with values of all property</param>
        public UserDetails(string detail)
        {
            string[] values = detail.Split(',');
            UserID = values[0];
            WorkStationNumber =values[1];
            _balance = Convert.ToDouble(values[2]);
            Name = values[3];
            FatherName = values[4];
            Gender = Enum.Parse<GenderDetails>(values[5], true);
            Mobile = Convert.ToInt64(values[6]);
            MailID = values[7];
            ++s_userID;
        }
        /// <summary>
        /// Default constructor  used to initialize the class <see cref="UserDetails"/>
        /// </summary>
        /// <param name="customerID">customerID is a string used to initialize the property customerID</param>
        /// <param name="workStationNumber">workStationNumber is a string used to initialize the property WorkStationNumber</param>
        /// <param name="balance">balance is a double used to initialize the property balance</param>
        /// <param name="name">name is a string used to initialize the property name</param>
        /// <param name="fatherName">fatherName is a string used to initialize the property fatherName</param>
        /// <param name="gender">gender is a enum used to initialize the property gender</param>
        /// <param name="mobile">mobile is a long used to initialize the property Mobile</param>
        /// <param name="mailID">mailID is a string used to initialize the property mailID</param>
        public UserDetails(string workStationNumber,double balance,string name, string fatherName, GenderDetails gender, long mobile, string mailID)
        {

            UserID = $"SF{++s_userID}";
            WorkStationNumber =workStationNumber;
            _balance = balance;
            Name = name;
            FatherName = fatherName;
            Gender = gender;
            Mobile = mobile;
            MailID = mailID;
        }
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