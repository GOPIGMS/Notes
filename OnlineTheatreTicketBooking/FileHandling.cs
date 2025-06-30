using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace OnlineTheatreTicketBooking
{
    public class FileHandling<TKey,TValue>
    {
        //providing the directory name
         public static string DirectoryName = "MovieBookingData";
        //creating the folder
        public static void CreateFolder()
        {

            if (!Directory.Exists(DirectoryName))
            {
                Directory.CreateDirectory(DirectoryName);
            }
            else
            {
                Console.WriteLine($"Direcotry Exists");
            }
        }
        //reading the file
        public static MyDictionary<TKey,TValue> ReadFromCSV(MyDictionary<TKey,TValue> list,string primaryKey)
        {
            PropertyInfo property =typeof(TValue).GetProperty(primaryKey);
            string fileName = typeof(TValue).Name;
            string path = $"{DirectoryName}/{fileName}.csv";
            if (File.Exists(path))
            {
                string[] values = File.ReadAllLines(path);
                foreach (var value in values)
                {
                    //creating object for the class given
                    
                    var obj = Activator.CreateInstance(typeof(TValue), value);
                    TValue appendObject = (TValue)obj;
                    var keyvalue =property.GetValue(appendObject);
                    TKey key =(TKey) keyvalue;
                    list.Add(key,appendObject);
                }
                return list;
            }
            return list;
        }
        //writing the file
        public static void WriteToCSV( MyDictionary<TKey,TValue> list)
        {
            string fileName = typeof(TValue).Name;
            string filePath = $"{DirectoryName}/{fileName}.csv";
            CreateFolder();
            if (!File.Exists(filePath))
            {
                Console.WriteLine($"Creating the file {fileName}");
                File.Create(filePath).Close();
            }
            else
            {
                Console.WriteLine($"{fileName} already exists");
            }
            string[] values = new string[list.Count];
            int count = 0;
            PropertyInfo[] properties = typeof(TValue).GetProperties();
            foreach (var value in list.Values())
            {
                string addValue = "";
                foreach (var property in properties)
                {
                    if (property.CanRead)
                    {
                        if (property.PropertyType == typeof(DateTime))
                        {
                            var getValue = ((DateTime)property.GetValue(value)).ToString("dd/MM/yyyy");
                            addValue += $"{getValue},";
                        }
                        else
                        {
                            var getValue = property.GetValue(value).ToString();
                            addValue += $"{getValue},";
                        }
                    }
                }
                string finalValue = addValue.Substring(0, addValue.Length - 1);
                values[count] = finalValue;
                count += 1;
            }
            File.WriteAllLines(filePath, values);
        }

    }
}