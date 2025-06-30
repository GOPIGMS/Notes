using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryUsingAbstract
{
    public class CSELibraryInfo : LibraryInfo
    {
        //creating the properties for CSELibraryInfo 
        public override string AuthorName { get; set; }
        public override string BookName { get; set; }
        public override string PublisherName { get; set; }
        public override int Year { get; set; }
        //creating the global object
        CSELibraryInfo currentObject;
        //override the abstract method and display info
        public override void DisplayInfo()
        {
            Console.WriteLine($"SerialNumber : {currentObject.SerialNumber}, Author Name : {currentObject.AuthorName}, BookName : {currentObject.BookName}, Publisher Name : {currentObject.PublisherName}");
        }
        //creating object using setBooks
        public override void SetBookInfo(string authorName, string bookName, string publisherName, int year)
        {
            currentObject = new CSELibraryInfo(authorName, bookName, publisherName, year);

        }
        //creating  the empty constructor
        public CSELibraryInfo()
        {

        }
        //creating the parameterized constructor
        public CSELibraryInfo(string authorName, string bookName, string publisherName, int year) : base(true)
        {
            AuthorName = authorName;
            BookName = bookName;
            PublisherName = publisherName;
            Year = year;
        }
    }
}