using System;
using System.Collections.Generic;

namespace MyStack;

class Program
{
    public static void Main(string[] args)
    {
        //creating the object of the custom stack class
        CustomStack<int> stack1 = new CustomStack<int>();
        //adding the elements in the stack
        stack1.Push(10);
        stack1.Push(20);
        stack1.Push(30);
        stack1.Push(40);
        stack1.Push(50);
        //showing the last inserted value to the user
        Console.WriteLine($"The last element is {stack1.Peek()}");
        //remove and return the last inserted value to the user
        Console.WriteLine($"The last element removed is {stack1.Pop()}");
        Console.WriteLine($"The last element removed is {stack1.Pop()}");
        Console.WriteLine($"The last element removed is {stack1.Pop()}");
        Console.WriteLine($"The last element removed is {stack1.Pop()}");
        Console.WriteLine($"The last element removed is {stack1.Pop()}");
        Console.WriteLine($"The last element  is {stack1.Peek()}");
    }


}