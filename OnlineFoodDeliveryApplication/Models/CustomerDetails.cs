using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineFoodDeliveryApplication.Interfaces;
using OnlineFoodDeliveryApplication.Enums;

namespace OnlineFoodDeliveryApplication.Models
{
    public class CustomerDetails : PersonalDetails, IBalance
    {
        //fields
        /// <summary>
        ///  Field stores the  s_customerID  and auto increment  <see cref="CustomerDetails"/>
        /// </summary>
        private static int s_customerID = 1000;
        /// <summary>
        ///  Field stores the  _balance  and auto increment  <see cref="CustomerDetails"/>
        /// </summary>
        private double _balance;
        //properties
        /// <summary>
        /// Property used to store CustomerID <see cref="CustomerDetails"/>
        /// </summary>
        public string CustomerID { get; set; }
        /// <summary>
        /// Property used to store WalletBalance <see cref="CustomerDetails"/>
        /// </summary>
        public double WalletBalance { get { return _balance; } }
        //constructor
        /// <summary>
        /// Default constructor  used to initialize the class <see cref="CustomerDetails"/>
        /// </summary>
        public CustomerDetails() { }
        /// <summary>
        /// Parameterized constructor  used to initialize the class <see cref="CustomerDetails"/>
        /// </summary>
        /// <param name="customerID">customerID is a string used to initialize the property customerID</param>
        /// <param name="balance">balance is a double used to initialize the property balance</param>
        /// <param name="name">name is a string used to initialize the property name</param>
        /// <param name="fatherName">fatherName is a string used to initialize the property fatherName</param>
        /// <param name="gender">gender is a enum used to initialize the property gender</param>
        /// <param name="mobile">mobile is a long used to initialize the property Mobile</param>
        /// <param name="dob">dob is a DateTime used to initialize the property dob</param>
        /// <param name="mailID">mailID is a string used to initialize the property mailID</param>
        /// <param name="location">location is a string used to initialize the property location</param>
        public CustomerDetails(string customerID, double balance, string name, string fatherName, GenderDetails gender, long mobile, DateTime dob, string mailID, string location)
        {

            CustomerID = customerID;
            _balance = balance;
            Name = name;
            FatherName = fatherName;
            Gender = gender;
            Mobile = mobile;
            DOB = dob;
            MailID = mailID;
            Location = location;
            ++s_customerID;
        }
        /// <summary>
        /// Parameterized  constructor  used to initialize the class with parameter values of <see cref="FoodDetails"/>
        /// </summary>
        /// <param name="details">string with values of all property</param>
        public CustomerDetails(string detail)
        {
            string[] values = detail.Split(',');
            CustomerID = values[0];
            _balance = Convert.ToDouble(values[1]);
            Name = values[2];
            FatherName = values[3];
            Gender = Enum.Parse<GenderDetails>(values[4], true);
            Mobile = Convert.ToInt64(values[5]);
            DOB = DateTime.ParseExact(values[6], "dd/MM/yyyy", null);
            MailID = values[7];
            Location = values[8];
            ++s_customerID;
        }
        /// <summary>
        /// Default constructor  used to initialize the class <see cref="CustomerDetails"/>
        /// </summary>
        /// <param name="customerID">customerID is a string used to initialize the property customerID</param>
        /// <param name="balance">balance is a double used to initialize the property balance</param>
        /// <param name="name">name is a string used to initialize the property name</param>
        /// <param name="fatherName">fatherName is a string used to initialize the property fatherName</param>
        /// <param name="gender">gender is a enum used to initialize the property gender</param>
        /// <param name="mobile">mobile is a long used to initialize the property Mobile</param>
        /// <param name="dob">dob is a DateTime used to initialize the property dob</param>
        /// <param name="mailID">mailID is a string used to initialize the property mailID</param>
        /// <param name="location">location is a string used to initialize the property location</param>
        public CustomerDetails(string name, string fatherName, GenderDetails gender, long mobile, DateTime dob, string mailID)
        {

            CustomerID = $"CID{++s_customerID}";
            _balance = 0;
            Name = name;
            FatherName = fatherName;
            Gender = gender;
            Mobile = mobile;
            DOB = dob;
            MailID = mailID;
            Location = "";
        }
        //methods
        /// <summary>
        /// method user to recharge user wallet <see cref="PatientDetails"/>
        /// </summary>
        public double WalletRecharge(double amount)
        {
            _balance += amount > 0 ? amount : 0;
            return WalletBalance;
        }
        /// <summary>
        /// Method that is used to deduct balance from the user account
        /// </summary>
        public double DeductBalance(double amount)
        {
            _balance -= amount > 0 ? amount : 0;
            return WalletBalance;
        }
    }
}