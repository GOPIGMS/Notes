using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultilevelOnlineLibrary
{
    public class BookInfo : RackInfo
    {
        //getting the properties of BookInfo class
        private static int s_bookID = 0;
        public int BookID { get; set; }
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public double Price { get; set; }
        //creating the default constructor for bookinfo
        public BookInfo() { }
        //creating the parameterized constructor for bookinfo
        public BookInfo(string bookName, string authorName, double price, int rackNumber, int columnNumber, string departmentDetails, string degree) : base(rackNumber, columnNumber, departmentDetails, degree)
        {
            BookID = ++s_bookID;
            BookName = bookName;
            AuthorName = authorName;
            Price = price;
        }
        //displaying the detatils 
        public string DisplayInfo()
        {
            return $"Book ID : {BookID}, Book Name : {BookName}, AuthorName : {AuthorName}, Price : {Price}, Rack Number : {RackNumber}, Column Number : {ColumnNumber}, DepartmentName : {DepartmentName}, Degree {Degree}";
        }

    }
}