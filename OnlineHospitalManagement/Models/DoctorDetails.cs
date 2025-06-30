using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineHospitalManagement
{
    public class DoctorDetails : PersonalDetails
    {
        //fields
        /// <summary>
        ///  Field stores the  s_doctorID  and auto increment  <see cref="DoctorDetails"/>
        /// </summary>
        private static int s_doctorID = 300;
        //properties
        /// <summary>
        ///  Property used to store DoctorID <see cref="DoctorDetails"/>
        /// </summary>
        public string DoctorID { get; set; }
        /// <summary>
        ///  Property used to store Experience <see cref="DoctorDetails"/>
        /// </summary>
        public double Experience { get; set; }
        /// <summary>
        /// Property used to store Specialization <see cref="DoctorDetails"/>
        /// </summary>
        /// <value></value>
        public string Specialization { get; set; }
        /// <summary>
        /// Property used to store Fees <see cref="DoctorDetails"/>
        /// </summary>
        /// <value></value>
        public double Fees { get; set; }
        //constructors
        /// <summary>
        /// Default constructor  used to initialize the class <see cref="DoctorDetails"/>
        /// </summary>
        public DoctorDetails() { }
        //parameterized constructor
        /// <summary>
        /// Parameterized constructor  used to initialize the class <see cref="DoctorDetails"/>
        /// </summary>
        /// <param name="doctorID">doctorID is a string used to initialize the property doctorID</param>
        /// <param name="name">name is a string used to initialize the property name</param>
        /// <param name="fatherName">fatherName is a string used to initialize the property fatherName</param>
        /// <param name="gender">gender is a enum used to initialize the property gender</param>
        /// <param name="phone">phone is a int used to initialize the property phone</param>
        /// <param name="age">age is a int used to initialize the property age</param>
        /// <param name="experience">experience is a int used to initialize the property experience</param>
        /// <param name="specialization">specification is a string used to initialize the property specification</param>
        /// <param name="fees">fees is a double used to initialize the property fees</param>
        public DoctorDetails(string doctorID, string name, string fatherName, GenderDetails gender, long phone, int age, double experience, string specialization, double fees)
        {
            DoctorID = doctorID;
            Name = name;
            FatherName = fatherName;
            Gender = gender;
            Phone = phone;
            Age = age;
            Experience = experience;
            Specialization = specialization;
            Fees = fees;
            ++s_doctorID;

        }

        //parameterized constructor
        /// <summary>
        /// Parameterized constructor  used to initialize the class <see cref="DoctorDetails"/>
        /// </summary>
        /// <param name="doctorID">doctorID is a string used to initialize the property doctorID</param>
        /// <param name="name">name is a string used to initialize the property name</param>
        /// <param name="fatherName">fatherName is a string used to initialize the property fatherName</param>
        /// <param name="gender">gender is a enum used to initialize the property gender</param>
        /// <param name="phone">phone is a int used to initialize the property phone</param>
        /// <param name="age">age is a int used to initialize the property age</param>
        /// <param name="experience">experience is a int used to initialize the property experience</param>
        /// <param name="specialization">specification is a string used to initialize the property specification</param>
        /// <param name="fees">fees is a double used to initialize the property fees</param>
        public DoctorDetails(string name, string fatherName, GenderDetails gender, long phone, int age, double experience, string specialization, double fees)
        {
            DoctorID = $"DID{++s_doctorID}";
            Name = name;
            FatherName = fatherName;
            Gender = gender;
            Phone = phone;
            Age = age;
            Experience = experience;
            Specialization = specialization;
            Fees = fees;
        }
        //to create object using the data from file 
        /// <summary>
        /// Parameterized  constructor  used to initialize the class with parameter values of <see cref="FoodDetails"/>
        /// </summary>
        /// <param name="details">string with values of all property</param>
        public DoctorDetails(string details)
        {
            string[] values = details.Split(',');
            DoctorID = values[0];
            Experience = Convert.ToDouble(values[1]);
            Specialization = values[2];
            Fees = Convert.ToDouble(values[3]);
            Name = values[4];
            FatherName = values[5];
            Gender = Enum.Parse<GenderDetails>(values[6], true);
            Phone = Convert.ToInt64(values[7]);
            Age = Convert.ToInt32(values[8]);
            ++s_doctorID;

        }

    }
}