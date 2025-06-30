using System;
using System.Net.WebSockets;

namespace MyList;

class Program
{
    public static void Main(string[] args)
    {
        //creating and adding elements
        CustomList<int> myList1 = new CustomList<int>();
        myList1.Add(10);
        myList1.Add(20);
        myList1.Add(30);
        myList1.Add(40);
        myList1.Add(50);
        //creating the second list to store the elements
        CustomList<int> myList2 = new CustomList<int>();
        myList2.Add(10);
        myList2.Add(20);
        myList2.Add(30);
        myList2.Add(40);
        myList2.Add(50);
        //adding the range of array
        myList1.AddRange(myList2);
        //checking a element in the list
        bool result = myList1.Contains(0);
        Console.WriteLine($"{result}");
        System.Console.WriteLine("---------------");
        //checking the index position
        int position = myList1.IndexOf(0);
        Console.WriteLine($"{position}");
        //inserting the value
        myList1.Insert(2, 12);
        for (int i = 0; i < myList1.Count; i++)
        {
            Console.Write($"{myList1[i]} ");
        }
        Console.WriteLine($"");
        //removing using index
        myList1.RemoveAt(2);
        for (int i = 0; i < myList1.Count; i++)
        {
            Console.Write($"{myList1[i]} ");
        }
        Console.WriteLine($"");
        //removing using remove method
        bool isRemoved = myList1.Remove(10);
        for (int i = 0; i < myList1.Count; i++)
        {
            Console.Write($"{myList1[i]} ");
        }
        Console.WriteLine($"");
        
        //for each creation and execution
        Console.WriteLine("foreach execution");
        foreach (int value in myList1)
        {
            Console.Write($"{value} ");
        }
        Console.WriteLine($"");
        
        //reversing the List
        Console.WriteLine($"Before Reverse");

        for (int i = 0; i < myList1.Count; i++)
        {
            Console.Write($"{myList1[i]} ");
        }
        myList1.Reverse();
        Console.WriteLine($"");
        
        Console.WriteLine($"After Reverse");

        for (int i = 0; i < myList1.Count; i++)
        {
            Console.Write($"{myList1[i]} ");
        }
        //inserting a range of elements
        Console.WriteLine($"");
        
        Console.WriteLine($"My list before inserting");

        for (int i = 0; i < myList1.Count; i++)
        {
            Console.Write($"{myList1[i]} ");
        }
        CustomList<int> insertRange = new CustomList<int>();
        insertRange.Add(21);
        insertRange.Add(22);
        insertRange.Add(23);
        insertRange.Add(24);
        insertRange.Add(25);
        myList1.InsertRange(1, insertRange);
        Console.WriteLine($"");
        
        Console.WriteLine($"My list after inserting");
        for (int i = 0; i < myList1.Count; i++)
        {
            Console.Write($"{myList1[i]} ");
        }
        Console.WriteLine($"");

        //sorting the array
        Console.WriteLine($"Before Sorting");
        for (int i = 0; i < myList1.Count; i++)
        {
            Console.Write($"{myList1[i]} ");
        }
        Console.WriteLine($"");
        myList1.Sort();
        Console.WriteLine($"After Sorting");
        for (int i = 0; i < myList1.Count; i++)
        {
            Console.Write($"{myList1[i]} ");
        }
        Console.WriteLine($"");



    }

}
