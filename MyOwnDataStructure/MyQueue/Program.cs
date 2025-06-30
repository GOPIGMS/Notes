using System;
using System.Collections.Generic;

namespace MyQueue;

class Program
{
    public static void Main(string[] args)
    {
        //creating a custom queue
        CustomQueue<int> queue1 = new CustomQueue<int>();
        //adding the elements in the queue
        queue1.Add(10);
        queue1.Add(20);
        queue1.Add(30);
        queue1.Add(40);
        queue1.Add(50);
        //looping through all the elements in the queue
        foreach(int value in queue1){
            Console.WriteLine($"The value in the custom queue are : {value}");  
        }
        //printing the first element in the queue
        Console.WriteLine($"The first element in the queue is {queue1.Peek()}");
        //removing the elements in the queue
        queue1.Dequeue();
        //printing the first element in the queue
        Console.WriteLine($"The first element in the queue is {queue1.Peek()}");
        queue1.Dequeue();
        Console.WriteLine($"The first element in the queue is {queue1.Peek()}");
    }
}