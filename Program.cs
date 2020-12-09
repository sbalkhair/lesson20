using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Text;

namespace lesson20
{

    class MainClass
    {
        public static void Main(string[] args)
        {
            Student obj = new Student();

            while (true)
            {
                Console.WriteLine("1.Add student");
                Console.WriteLine("2.show all students");
                Console.WriteLine("3.show GPA students");
                Console.WriteLine("4.show Max GPA student");
                Console.WriteLine("5.show Min GPA student");
                Console.WriteLine("6.delete student");
                Console.WriteLine("\n");
                Console.WriteLine("Select number from 1 to 6:");
                var input = Console.ReadLine();


                switch (input)
                {
                    case "1":
                        Console.WriteLine("Enter your name");
                        var name = Console.ReadLine();
                        Console.WriteLine("Enter course name");
                        var course = Console.ReadLine();
                        Console.WriteLine("Enter grade 1");
                        var grade1 = Console.ReadLine();
                        Console.WriteLine("Enter grade 2");
                        var grade2 = Console.ReadLine();
                        Console.WriteLine("Enter grade 3");
                        var grade3 = Console.ReadLine();

                        List<int> grades = new List<int>();
                        grades.Add(Convert.ToInt32(grade1));
                        grades.Add(Convert.ToInt32(grade2));
                        grades.Add(Convert.ToInt32(grade3));


                        var student = new Student();
                        student.Name = name;
                        student.Course = course;
                        student.Grades = grades;
                        obj.AddStudent(student);
                        break;
                    case "2":
                        obj.GetAllStudent();
                        obj.MakeLine();
                        break;

                    case "3":
                        obj.GetAllStudentGPA();
                        obj.MakeLine();
                        break;
                    case "4":
                        obj.GetMaxGPA();
                        obj.MakeLine();
                        break;
                    case "5":
                        obj.GetMinGPA();
                        obj.MakeLine();
                        break;
                    case "6":
                        Console.Write("Write Name to delete:");
                        var username = Console.ReadLine();
                        obj.DeleteStudent(username);
                        obj.MakeLine();
                        break;
                    default:
                        break;
                }

            }

        }

    }
}
