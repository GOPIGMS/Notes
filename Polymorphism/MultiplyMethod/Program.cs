using System;
namespace MultiplyMethod;
class Program
{
    //one argument with Square value
    public static long Multiply(int number1)
    {
        return number1 * number1;
    }
    //2 argument with same argument type
    public static double Multiply(double number1, double number2)
    {
        return number1 * number2;
    }
    //3 argument with same argument type
    public static double Multiply(double number1, double number2, double number3)
    {
        return number1 * number2 * number3;
    }
    //2 argument with same argument type
    public static double Multiply(double number1, int number2)
    {
        return number1 * number2;
    }
    //3 argument with same argument type
    public static double Multiply(int number1, double number2, long number3)
    {
        return number1 * number2 * number3;
    }
    //main method
    public static void Main(string[] args)
    {
        //object creation and calling the method
        Console.WriteLine($"The result of 1 argument square : {Multiply(2)}");
        Console.WriteLine($"The result of 2 argument same type : {Multiply(2.0, 3.0)}");
        Console.WriteLine($"The result of 3 argument same type : {Multiply(2.0, 3.0, 4.0)}");
        Console.WriteLine($"The result of 2 argument different type : {Multiply(2, 3.0)}");
        Console.WriteLine($"The result of 3 argument different type : {Multiply(2, 3.0, 10000000)}");


    }
}