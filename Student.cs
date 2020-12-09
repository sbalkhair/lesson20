using System;
using System.Collections.Generic;
using System.Security.Permissions;

namespace lesson20
{
    public class Student
    {
        public string Name { get; set; }
        public string Course { get; set; }
        public List<int> Grades { get; set; }
        public List<Student> students = new List<Student>();
        public Student()
        {


        }

        public void MakeLine()
        {
            Console.WriteLine("-----------------------------------");
        }
        public void AddStudent(Student student)
        {
            students.Add(student);
            Console.WriteLine("success add user");
        }

        public void DeleteStudent(string name)
        {

            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].Name == name)
                {
                    students.Remove(students[i]);
                }
            }
            Console.WriteLine("success remove user");
            this.GetAllStudent();


        }

        public void GetAllStudent()
        {
            foreach (var student in students)
            {
                Console.WriteLine($"name:{student.Name} course:{student.Course} grades[{student.Grades[0]},{student.Grades[2]},{student.Grades[2]}]");
            }
        }

        public void GetStudent(Student student)
        {
            Console.Write($"name:{student.Name} course:{student.Course} grades[{student.Grades[0]},{student.Grades[2]},{student.Grades[2]}]");
        }

        public void GetMaxGPA()
        {
            var max = students[0];
            foreach (var student in students)
            {
                if (GetGPA(student.Grades) > GetGPA(max.Grades))
                {
                    max = student;
                }

            }
            Console.WriteLine($"Max Grade {max.Name}  GPA:{GetGPA(max.Grades)}");

        }

        private decimal GetGPA(List<int> grades)
        {
            var total = 0;
            foreach (var grade in grades)
            {
                total += grade;
            }

            return total / 3;
        }


        public void GetAllStudentGPA()
        {

            foreach (var student in students)
            {
                Console.WriteLine($"{student.Name} {GetGPA(student.Grades)}");

            }

        }

        public void GetMinGPA()
        {
            var min = students[0];
            foreach (var student in students)
            {
                if (GetGPA(student.Grades) < GetGPA(min.Grades))
                {
                    min = student;
                }

            }
            Console.WriteLine($"Min Grade {min.Name}  GPA:{GetGPA(min.Grades)}");
        }


    }
}
