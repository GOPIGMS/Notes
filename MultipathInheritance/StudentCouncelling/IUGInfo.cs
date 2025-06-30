using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentCounselling
{
    public interface IUGInfo : IPersonalInfo
    {
        public string UGMarkSheetNumber { get; set; }
        public double Sem1 { get; set; }
        public double Sem2 { get; set; }
        public double Sem3 { get; set; }
        public double Sem4 { get; set; }
        public double TotalMarks { get; set; }
        public double PercentageOfMarks { get; set; }
        public double Total();
        public double Percentage();
    }
}