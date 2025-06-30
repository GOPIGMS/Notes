using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentCounselling
{
    public interface IHSCInfo : IPersonalInfo
    {

        public string HSCMarkSheetNumber { get; set; }
        public int Physics { get; set; }
        public int Chemistry { get; set; }
        public int Maths { get; set; }
        public double HSCTotalMarks { get; set; }
        public double HSCPercentageOfMarks { get; set; }
        public double HSCTotal();
        public double HSCPercentage();

    }
}