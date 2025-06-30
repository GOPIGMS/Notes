using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarModels
{
    public interface IBrand
    {
        //properties declaration of Interface
        string BrandName { get; set; }
        string ModelName { get; set; }
        //method declaration
        string ShowDetails();
    }
}