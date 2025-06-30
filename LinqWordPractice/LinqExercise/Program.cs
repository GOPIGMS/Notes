using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LinqExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //You can get the trainee details from the GetTraineeDetails() method in TraineeData class
            Console.WriteLine("Enter Menu Number");
            int option = Convert.ToInt32(Console.ReadLine());
            TraineeDetails obj = new TraineeDetails();
            TraineeData ob1 = new TraineeData();
            List<TraineeDetails> b = ob1.GetTraineeDetails();


            switch (option)
            {
                case 1:
                    {
                        //showing the list of the emp
                        Console.WriteLine($"The employee id's are :");
                        var list = (from emp in b
                                    select emp.TraineeId).ToList();
                        foreach (string id in list)
                        {
                            Console.WriteLine(id);
                        }

                        break;
                    }
                case 2:
                    {
                        //showing first 3 employees using the take
                        Console.WriteLine("The first Three trainee details are ");
                        var list = (from emp in b
                                    select emp.TraineeId).Take(3);
                        foreach (string id in list)
                        {
                            Console.WriteLine(id);
                        }

                        break;
                    }
                case 3:
                    {
                        //taking last two trainee details using the skip
                        Console.WriteLine("The last two trainee details are");
                        var list = (from emp in b
                                    select emp.TraineeId).ToList().Skip(b.Count - 2);
                        foreach (string id in list)
                        {
                            Console.WriteLine(id);
                        }

                        break;
                    }
                case 4:
                    {
                        Console.WriteLine($"The count of the trainee is {b.Count}");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine($"The trainee name who are all passed out after 2019 :");
                        var list = (from emp in b
                                    where emp.YearPassedOut >= 2019
                                    select emp.TraineeName).ToList();
                        foreach (string name in list)
                        {
                            Console.WriteLine(name);
                        }

                        break;
                    }
                case 6:
                    {
                        var list = (from emp in b
                                    orderby emp.TraineeName
                                    select new { emp.TraineeId, emp.TraineeName }).ToList();
                        foreach (var emp in list)
                        {
                            Console.WriteLine($" {emp.TraineeId} {emp.TraineeName} ");
                        }

                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("Printing the trainees with the marks greater than 4 in all subject");
                        var list = (from emp in b
                                    where emp.ScoreDetails.All(x => x.Mark >= 4)
                                    select emp).ToList();
                        foreach (var emp in list)
                        {
                            Console.WriteLine($" Trainee ID :{emp.TraineeId} Trainee Name :{emp.TraineeName} ");
                            foreach (var score in emp.ScoreDetails)
                            {
                                Console.WriteLine($"Topic Name :{score.TopicName} Topic Marks :{score.Mark}");
                            }
                        }

                        break;
                    }
                case 8:
                    {
                        Console.WriteLine("The unique passed out year is :");
                        var list = (from emp in b
                                    select emp.YearPassedOut).Distinct();
                        foreach (var emp in list)
                        {
                            Console.WriteLine($" {emp}");
                        }

                        break;
                    }
                case 9:
                    {
                        Console.WriteLine($"Enter the trainee id to show the total marks");
                        string traineeID = Console.ReadLine();
                        var list = (from emp in b
                                    where emp.TraineeId == traineeID
                                    select new { traineeID = emp.TraineeId != null ? emp.TraineeId : "Invalid message", totalMarks = (emp.TraineeId != null ? emp.ScoreDetails.Select(x => x.Mark).Sum() : 0) }).ToList();
                        if( list == null || list.Count <= 0 ){
                            Console.WriteLine($"Invalid");
                            break;
                            
                        }
                        foreach (var val in list)
                        {
                            Console.WriteLine($"Trainee ID :{val.traineeID}, Total Marks : {val.totalMarks}");
                        }
                        break;
                    }
                case 10:
                    {
                        Console.WriteLine("The first trainee id and the trainee name");
                        var list = b.Select(x => new { x.TraineeId, x.TraineeName }).FirstOrDefault();

                        Console.WriteLine($"Trainee ID :{list.TraineeId}, Total Marks : {list.TraineeName}");

                        break;


                    }
                case 11:
                    {
                        Console.WriteLine("The first trainee id and the trainee name");
                        var list = b.Select(x => new { x.TraineeId, x.TraineeName }).LastOrDefault();

                        Console.WriteLine($"Trainee ID :{list.TraineeId}, Total Marks : {list.TraineeName}");

                        break;
                    }
                case 12:
                    {
                        Console.WriteLine($"Trainee with the total marks");
                        var list = (from emp in b
                                    select new { traineeID = emp.TraineeId != null ? emp.TraineeId : "Invalid message", totalMarks = (emp.TraineeId != null ? emp.ScoreDetails.Select(x => x.Mark).Sum() : 0) });
                        foreach (var val in list)
                        {
                            Console.WriteLine($"Trainee ID :{val.traineeID}, Total Marks : {val.totalMarks}");
                        }
                        break;
                    }
                case 13:
                    {
                        var mark = (from emp in b 
                        select emp.ScoreDetails.Select(x=> x.Mark).Sum()) .Max();
                        Console.WriteLine("The maximum total is " + mark);

                        break;
                    }
                case 14:
                    {
                        var mark = (from emp in b 
                        select emp.ScoreDetails.Select(x=> x.Mark).Sum()) .Min();
                        Console.WriteLine("The maximum total is " + mark);

                        break;
                    }
                case 15:
                    {
                        var averageTotal = (from emp in b
                        select emp.ScoreDetails.Select(x=> x.Mark).Sum() ).Average();
                        
                        Console.WriteLine($"The average is {averageTotal}");


                        break;
                    }
                case 16:
                    {
                        var result = (from emp in b
                        select emp.ScoreDetails.Select(x=> x.Mark).Sum() ).Any(x => x >40);
                        Console.WriteLine($"Is anyone has more than 40 score {result}");
                        break;
                    }
                case 17:
                    {
                        var result = (from emp in b
                        select emp.ScoreDetails.Select(x=> x.Mark).Sum() ).All(x => x >20);
                        Console.WriteLine($"Is all the  has score more than 20 {result}");
                        break;
                    }
                case 18:
                    {
                        var list =(from emp in b
                        orderby emp.TraineeName descending , emp.ScoreDetails.OrderByDescending(x => x.Mark)
                        select emp);
                        // var markDescending = (from mark in list
                        //  orderby mark.ScoreDetails.OrderByDescending(x => x.Mark)
                        //  select mark);
                        foreach( var details in list ){
                            Console.WriteLine($" Trainee ID :{details.TraineeId} Trainee Name :{details.TraineeName} ");
                            foreach (var score in details.ScoreDetails)
                            {
                                Console.WriteLine($"Exercise Name :{score.ExerciseName} Topic Marks :{score.Mark}");
                            }

                        }


                        break;
                    }

            }

        }
    }
}
