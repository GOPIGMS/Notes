using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace OnlineTheatreTicketBooking
{
    /// <summary>
    /// Used to display the details for dynamic classes <see cref=" Grid<Type>"/>
    /// </summary>
    /// <typeparam name="Type">Dynamic CustomList</typeparam>
    public class Grid<TKey,TValue>
    {
        public void ShowTables(MyDictionary<TKey,TValue> dict)
        {
            TValue[] list =dict.Values();
            if (list != null )
            {
                PropertyInfo[] properties = typeof(TValue).GetProperties();
                Console.WriteLine(new string('-', properties.Length * 20));
                Console.Write($"|");
                //printing the properties
                foreach (var property in properties)
                {
                    Console.Write($"{property.Name,-15} |");
                }
                Console.WriteLine($"");
                Console.WriteLine(new string('-', properties.Length * 20));
                //printing values
                foreach (var data in list)
                {
                    System.Console.Write("|");
                    foreach (var property in properties)
                    {
                        if (property.CanRead)
                        {
                            //if data time printing format
                            if (property.PropertyType == typeof(DateTime))
                            {
                                var value = ((DateTime)property.GetValue(data)).ToString("dd/MM/yyyy");
                                Console.Write($"{value,-15} |");

                            }
                            //other type format
                            else
                            {
                                var value = property.GetValue(data);
                                Console.Write($"{value,-15} |");
                                
                            }
                        }
                    }
                    Console.WriteLine($"");
                    
                }
                Console.WriteLine(new string('-', properties.Length * 20));
            }
        }
    }
}