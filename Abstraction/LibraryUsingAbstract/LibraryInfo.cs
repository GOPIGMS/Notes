using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryUsingAbstract
{
    public abstract class LibraryInfo
    {
        //creating the property for abstract library
        private static int s_serialNumber = 1000;
        public string SerialNumber;
        public abstract string AuthorName { get; set; }
        public abstract string BookName { get; set; }
        public abstract string PublisherName { get; set; }
        public abstract int Year { get; set; }
        //creating the abstract methods for library class
        public abstract void SetBookInfo(string authorName, string bookName, string publisherName, int year);
        public abstract void DisplayInfo();
        //creating the constructor for library info
        public LibraryInfo()
        {

        }
        //incrementing serialnumber only if the library info class object
        public LibraryInfo(bool value)
        {
            SerialNumber = $"LIB{++s_serialNumber}";
        }

    }
}