using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineHospitalManagement
{
    public class SlotDetails
    {   //fields
        //fields
        /// <summary>
        ///  Field stores the  s_slotID  and auto increment  <see cref="SlotDetails"/>
        /// </summary>
        private static int s_slotID = 100;
        //properties
        /// <summary>
        /// Property used to store DoctorID <see cref="SlotDetails"/>
        /// </summary>
        public string DoctorID { get; set; }
        /// <summary>
        /// Property used to store SlotID <see cref="SlotDetails"/>
        /// </summary>
        public string SlotID { get; set; }
        /// <summary>
        /// Property used to store SlotTime <see cref="SlotDetails"/>
        /// </summary>
        public string SlotTime { get; set; }
        /// <summary>
        /// Default constructor  used to initialize the class <see cref="SlotDetails"/>
        /// </summary>
        //constructors
        public SlotDetails() { }
        /// <summary>
        /// Parameterized constructor  used to initialize the class <see cref="SlotDetails"/>
        /// </summary>
        /// <param name="doctorID">doctorID is a string used to initialize the property doctorID</param>
        /// <param name="slotID">slotID is a string used to initialize the property slotID</param>
        /// <param name="slotTime">slotTime is a DateTime used to initialize the property slotTime</param>
        public SlotDetails(string doctorID, string slotID, string slotTime)
        {
            DoctorID = doctorID;
            SlotID = slotID;
            SlotTime = slotTime;
            ++s_slotID;
        }
        /// <summary>
        /// Parameterized constructor  used to initialize the class <see cref="SlotDetails"/>
        /// </summary>
        /// <param name="doctorID">doctorID is a string used to initialize the property doctorID</param>
        /// <param name="slotID">slotID is a string used to initialize the property slotID</param>
        /// <param name="slotTime">slotTime is a DateTime used to initialize the property slotTime</param>
        public SlotDetails(string slotID, string slotTime)
        {
            DoctorID = $"SL{++s_slotID}";
            SlotID = slotID;
            SlotTime = slotTime;
        }
        /// <summary>
        /// Parameterized  constructor  used to initialize the class with parameter values of <see cref="PatientDetails"/>
        /// </summary>
        /// <param name="data">string with values of all property</param>
        public SlotDetails(string details)
        {
            string[] values = details.Split(',');
            DoctorID = values[0];
            SlotID = values[1];
            SlotTime = values[2];
            ++s_slotID;
        }

    }

}