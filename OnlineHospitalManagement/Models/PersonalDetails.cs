using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineHospitalManagement
{
    public class PersonalDetails
    {
        //properties
        //properties
        /// <summary>
        /// Property used to store Name <see cref="PersonalDetails"/>
        /// </summary>
        /// <value></value>
        public string Name { get; set; }
        /// <summary>
        /// Property used to store Father Name <see cref="PersonalDetails"/>
        /// </summary>
        /// <value></value>
        public string FatherName { get; set; }
        /// <summary>
        /// Property used to store Gender <see cref="PersonalDetails"/>
        /// </summary>
        /// <value></value>
        public GenderDetails Gender { get; set; }
        /// <summary>
        /// Property used to store Phone Number <see cref="PersonalDetails"/>
        /// </summary>
        /// <value></value>
        public long Phone { get; set; }
        /// <summary>
        /// Property used to store Age <see cref="PersonalDetails"/>
        /// </summary>
        /// <value></value>
        public int Age { get; set; }
        //constructors
        //constructor
        /// <summary>
        /// Default constructor  used to initialize the class <see cref="PersonalDetails"/>
        /// </summary>
        public PersonalDetails() { }
               /// <summary>
        /// Parameterized  constructor  used to initialize the class with parameter values <see cref="PersonalDetails"/>
        /// </summary>
        /// <param name="name">name is a string used to initialize the property Name</param>
        /// <param name="fatherName">fathername is a string used to initialize the property Father Name</param>
        /// <param name="gender">gender is a Enum used to initialize the property Gender</param>
        /// <param name="phone">phoneNumber is a string used to initialize the property phoneNumber</param>
        /// <param name="age">age is a date time used to initialize the property Age</param>
        //parameterized constructor
        public PersonalDetails(string name, string fatherName, GenderDetails gender, long phone, int age)
        {
            Name = name;
            FatherName = fatherName;
            Gender = gender;
            Phone = phone;
            Age = age;
        }
    }
}