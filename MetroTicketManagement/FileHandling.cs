using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Markup;
using System.Reflection;
using System.Collections;

namespace MetroTicketManagement
{
    public static class FileHandling<Type>
    {
        //setting the folder name
        public static string DirectoryName = "MetroTravelDatas";
        //creating the folder
        public static void CreateFolder()
        {
            //checking folder exists

            if (!Directory.Exists(DirectoryName))
            {
                Directory.CreateDirectory(DirectoryName);
            }
            else
            {
                Console.WriteLine($"Direcotry Exists");
            }
        }
        //reading the data from csv
        public static CustomList<Type> ReadFromCSV(CustomList<Type> list)
        {
            //getting the file name
            string fileName = typeof(Type).Name;
            string path = $"{DirectoryName}/{fileName}.csv";
            if (File.Exists(path))
            {
                string[] values = File.ReadAllLines(path);
                foreach (var value in values)
                {
                    //creating object for the class given
                    var obj = Activator.CreateInstance(typeof(Type), value);
                    Type appendObject = (Type)obj;
                    list.Add(appendObject);
                }
                return list;
            }
            return list;
        }
        //writing the datas to the csv
        public static void WriteToCSV(CustomList<Type> list)
        {
            string fileName = typeof(Type).Name;
            string filePath = $"{DirectoryName}/{fileName}.csv";
            //creating folder if not
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
            //list for storing value
            string[] values = new string[list.Count];
            int count = 0;
            PropertyInfo[] properties = typeof(Type).GetProperties();
            foreach (var value in list)
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