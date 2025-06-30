using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineHospitalManagement
{
    public class PatientDetails : PersonalDetails, ITransaction
    {
        //fields
        /// <summary>
        ///  Field stores the  _walletBalance  and auto increment  <see cref="PatientDetails"/>
        /// </summary>
        private double _walletBalance;
        /// <summary>
        ///  Field stores the  s_patientID  and auto increment  <see cref="PatientDetails"/>
        /// </summary>
        private static int s_patientID = 1000;
        //properties
        //properties
        /// <summary>
        ///  Property used to store PatientID <see cref="PatientDetails"/>
        /// </summary>
        public string PatientID { get; set; }
        /// <summary>
        ///  Property used to store WalletBlanace <see cref="PatientDetails"/>
        /// </summary>
        public double WalletBalance { get { return _walletBalance; } }
        //constructors
        /// <summary>
        /// Default constructor  used to initialize the class <see cref="PatientDetails"/>
        /// </summary>
        public PatientDetails() { }
        /// <summary>
        ///  Parameterized constructor  used to initialize the class <see cref="PatientDetails"/>
        /// </summary>
        /// <param name="patientID">patientID is a string used to initialize the property patientID</param>
        /// <param name="name">name is a string used to initialize the property name</param>
        /// <param name="fatherName">fatherName is a string used to initialize the property fatherName</param>
        /// <param name="phone">phone is a string used to initialize the property phone</param>
        /// <param name="age">age is a int used to initialize the property age</param>
        /// <param name="gender">gender is a int used to initialize the property gender</param>
        /// <param name="walletBalance">walletBalance is a double used to initialize the property walletBalance</param>
        public PatientDetails(string patientID, string name, string fatherName, long phone, int age, GenderDetails gender, double walletBalance)
        {
            PatientID = patientID;
            Name = name;
            FatherName = fatherName;
            Phone = phone;
            Age = age;
            Gender = gender;
            _walletBalance = walletBalance;
            ++s_patientID;
        }
        /// <summary>
        /// Parameterized  constructor  used to initialize the class with parameter values of <see cref="PatientDetails"/>
        /// </summary>
        /// <param name="data">string with values of all property</param>
        public PatientDetails(string data)
        {
            string[] values = data.Split(',');
            PatientID = values[0];
            _walletBalance = Convert.ToDouble(values[1]);
            Name = values[2];
            FatherName = values[3];
            Gender = Enum.Parse<GenderDetails>(values[4], true);
            Phone = Convert.ToInt64(values[5]);
            Age = Convert.ToInt32(values[6]);

            ++s_patientID;
        }
        /// <summary>
        ///  Parameterized constructor  used to initialize the class <see cref="PatientDetails"/>
        /// </summary>
        /// <param name="patientID">patientID is a string used to initialize the property patientID</param>
        /// <param name="name">name is a string used to initialize the property name</param>
        /// <param name="fatherName">fatherName is a string used to initialize the property fatherName</param>
        /// <param name="phone">phone is a string used to initialize the property phone</param>
        /// <param name="age">age is a int used to initialize the property age</param>
        /// <param name="gender">gender is a int used to initialize the property gender</param>
        /// <param name="walletBalance">walletBalance is a double used to initialize the property walletBalance</param>
        public PatientDetails(string name, string fatherName, long phone, int age, GenderDetails gender, double walletBalance)
        {
            PatientID = $"PID{++s_patientID}";
            Name = name;
            FatherName = fatherName;
            Phone = phone;
            Age = age;
            Gender = gender;
            _walletBalance = walletBalance;
        }
        //methods
        /// <summary>
        /// method user to recharge user wallet <see cref="PatientDetails"/>
        /// </summary>
        public double Recharge(double amount)
        {
            _walletBalance = _walletBalance + (amount > 0 ? amount : 0);
            return _walletBalance;
        }
        /// <summary>
        /// Method that is used to deduct balance from the user account
        /// </summary>
        public double DeductBalance(double amount)
        {
            _walletBalance = _walletBalance - (amount > 0 ? amount : 0);
            return _walletBalance;
        }

    }
}