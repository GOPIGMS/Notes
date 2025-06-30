using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace CafeteriaCard
{
    public class Grid<Type>
    {
        //Displaying the data
        public void ShowTable(CustomList<Type> list)
        {
            if (list != null && list.Count > 0)
            {
                PropertyInfo[] properties = typeof(Type).GetProperties();
                Console.WriteLine(new string('-', properties.Length * 20));
                Console.Write($"|");
                foreach (var property in properties)
                {
                    System.Console.Write($"{property.Name,-18} |");

                }
                Console.WriteLine($"");
                
                Console.WriteLine(new string('-', properties.Length * 20));
                //printing the data
                
                foreach (var data in list)
                {
                    Console.Write($"|");
                    foreach (var property in properties)
                    {
                        if (property.CanRead)
                        {
                            if (property.PropertyType == typeof(DateTime))
                            {
                                var value = ((DateTime)property.GetValue(data)).ToString("dd/MM/yyyy");
                                System.Console.Write($"{value,-18} |");
                            }
                            else
                            {
                                var value = property.GetValue(data);
                                Console.Write($"{value,-18} |");
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