using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonDetails
{
    public interface IFamilyInfo : IShowData
    {
        //properties of the interface
        string FatherName { get; set; }
        string MotherName { get; set; }
        string HouseAddress { get; set; }
        int NoOfSibling { get; set; }
    }
}