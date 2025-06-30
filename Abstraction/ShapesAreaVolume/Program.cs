using System;

namespace ShapesAreaVolume;

class Program
{
    public static void Main(string[] args)
    {
        try
        {
            //creating the object and set it with null value for global access in main
            bool isLoopContinue = true;
            Cylinders cylinderObject = null;
            Cubes cubeObject = null;
            do
            {
               //getting the input from the user
                Console.WriteLine($"Enter the option to perform operation \n1.Create Cylinder \n2.Create Cube \n3.Calculate Area\n4.Calculate Volume\n5.Exit");
                int option;
                try
                {
                    option = Convert.ToInt32(Console.ReadLine());

                }
                catch (Exception)
                {
                    option = 0;
                }
                //creating the switch case to execute the user entered option block
                switch (option)
                {
                    case 1:
                        {
                            //getting the input for cylinder and creating the object
                            Console.WriteLine($"Enter the Radius");
                            double radius = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine($"Enter the Height");
                            double height = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine($"Enter the Width");
                            double width = Convert.ToDouble(Console.ReadLine());
                            cylinderObject = new Cylinders(radius, height, width);
                            Console.WriteLine($"Cylinder Created");
                            cubeObject=null;

                            break;
                        }
                    case 2:
                        {
                            //getting the input for cube and creating the object
                            Console.WriteLine($"Enter the Side of a cube");
                            double page_a = Convert.ToDouble(Console.ReadLine());
                            cubeObject = new Cubes(page_a);
                            Console.WriteLine($"Cube created");
                            cylinderObject=null;
                            break;
                        }
                    case 3:
                        {
                            //calculating the area of the object
                            if (cylinderObject != null )
                            {
                                Console.WriteLine($"The area of the cylinder is : {cylinderObject.CalculateArea()}");

                            }
                            else if (cubeObject != null)
                            {
                                Console.WriteLine($"The area of the cube is : {cubeObject.CalculateArea()}");
                            }

                            break;
                        }
                    case 4:
                        {
                            //creating the volume for the object
                            if (cylinderObject != null)
                            {
                                Console.WriteLine($"The volume of the cylinder is : {cylinderObject.CalculateVolume()}");

                            }
                            else if (cubeObject != null)
                            {
                                Console.WriteLine($"The volume of the cube is : {cubeObject.CalculateVolume()}");
                            }

                            break;
                        }

                    case 5:
                        {
                            //breaking the loop
                            isLoopContinue = false;
                            break;
                        }
                    default:
                        {
                            //catching the exception and invalid value
                            Console.WriteLine($"Invalid Input");
                            break;
                        }
                }

            } while (isLoopContinue);
        }
        //global error handling catch
        catch (Exception ex)
        {
            Console.WriteLine($"The problem in the program is {ex.Message}");

        }
    }
}