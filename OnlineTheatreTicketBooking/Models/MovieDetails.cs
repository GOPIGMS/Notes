using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTheatreTicketBooking.Models
{
    /// <summary>
    /// MovieDetails class stores the data of the movies <see cref="MovieDetails"/>
    /// </summary>
    public class MovieDetails
    {
        //fields
        /// <summary>
        /// s_movieID field used to auto increment the movie id <see cref="MovieDetails"/>
        /// </summary>
        private static int s_movieID = 3000;
        //fields
        /// <summary>
        /// Property used to store MovieID <see cref="MovieDetails"/>
        /// </summary>
        public string MovieID { get; set; }
        /// <summary>
        /// Property used to store MovieName <see cref="MovieDetails"/>
        /// </summary>
        public string MovieName { get; set; }
        /// <summary>
        /// Property used to store Language <see cref="MovieDetails"/>
        /// </summary>
        /// <value></value>
        public string Language { get; set; }
        //constructor
        /// <summary>
        /// Default constructor used to initailize the class <see cref="MovieDetails"/>
        /// </summary>
        public MovieDetails() { }
        /// <summary>
        /// Parametrized constructor used to initailize the class <see cref="MovieDetails"/>
        /// </summary>
        /// <param name="movieID">Parameter string  used  to assign property movie id</param>
        /// <param name="movieName">Parameter string  used  to assign property movie name</param>
        /// <param name="language">Parameter string  used  to assign property movie language</param>
        public MovieDetails(string movieID, string movieName, string language)
        {
            MovieID = movieID;
            MovieName = movieName;
            Language = language;
            ++s_movieID;
        }/// <summary>
         /// Parametrized constructor used to initailize the class <see cref="MovieDetails"/>
         /// </summary>
         /// <param name="details">string value used to initialize the constructor during the file handling</param>
        public MovieDetails(string details)
        {
            string[] values = details.Split(',');
            MovieID = values[0];
            MovieName = values[1];
            Language = values[2];
            ++s_movieID;
        }
        /// <summary>
        /// Parametrized constructor used to initailize the class <see cref="MovieDetails"/>
        /// </summary>
        /// <param name="movieName">Parameter string  used  to assign property movie name</param>
        /// <param name="language">Parameter string  used  to assign property movie language</param>
        public MovieDetails(string movieName, string language)
        {
            MovieID = $"MID{++s_movieID}";
            MovieName = movieName;
            Language = language;

        }
    }
}