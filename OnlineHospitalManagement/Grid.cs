using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Reflection;

namespace OnlineHospitalManagement
{
    public class Grid<Type>
    {
        //display the data in grid
        public void ShowTable(CustomList<Type> list)
        {
            if (list != null && list.Count > 0)
            {
                PropertyInfo[] properties = typeof(Type).GetProperties();
                Console.WriteLine(new string('-', properties.Length * 20));
                System.Console.Write("|");
                //traversing property
                foreach (var property in properties)
                {
                    System.Console.Write($"{property.Name,-15} |");
                }
                Console.WriteLine($"");
                Console.WriteLine(new string('-', properties.Length * 20));
                //traversing data
                foreach (var data in list)
                {
                    Console.Write($"|");
                    foreach (var property in properties)
                    {
                        if (property.CanRead)
                        {
                            if (property.PropertyType == typeof(DateTime))
                            {
                                var value = ((DateTime)property.GetValue(data)).ToString("dd/MM/yyyyy");
                                Console.Write($"{value,-15} |");
                            }
                            else{
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