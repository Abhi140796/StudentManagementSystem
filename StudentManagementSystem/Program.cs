using System;
using System.Collections.Generic;

namespace StudentManagementSystem
{
    class Student
    {
        private string name;
        private string[] subject;
        private int[] marks;


        public Student(string name, string[] subject, int[] marks)
        {
            this.name = name;
            this.subject = subject;
            this.marks = marks;
        }

        public String studentName { get { return name; } set {name = value; } }
        public string[] subjectName 
        {
            get
            {
                return subject;
            }
            set 
            {
                Console.WriteLine("Enter Number of Subjects: ");
                int numberOfSubjects = Convert.ToInt32(Console.ReadLine());
                subject = new string[numberOfSubjects];
                for(int i = 0; i < subject.Length; i++)
                {
                    Console.WriteLine($"Subject{i} : ");
                    var n = Console.ReadLine();
                    subject[i] = n;
                }
                
                } 
        }

        public int[] SubjectMarks 
        {
            get
            {
                return marks;
            }
            set
            {
                int num;
                for(int i = 0; i < subjectName.Length; i++)
                {
                    Console.WriteLine($"Enter Subject Marks of {subjectName[i]}: ");
                    num = Convert.ToInt32(Console.ReadLine());
                    marks[i] = num;
                }
            } 
        }

        public void StudentData()
        {
            Console.WriteLine("Enter Number Records You want: ");
            int numberOfRecords = Convert.ToInt32(Console.ReadLine());
            List<Student> studentdata = new List<Student>(numberOfRecords);

            for(int i = 0; i < numberOfRecords; i++)
            {
                studentdata.Add(new Student(studentName, subjectName, SubjectMarks));
            }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;
            do
            {
                Console.WriteLine("===============Student Registration System==================");
                Console.WriteLine("[1] Add Student Data \n[2] Show Student Result \n[3] Exit");
                choice = Convert.ToInt32(Console.ReadLine());
                 switch(choice)
                {
                    case '1':
                        StudentData();
                        break;

                    case '2':
                        break;

                    case '3':
                        break;

                    default:
                        Console.WriteLine("[1] Add Student Data \n[2] Show Student Result \n[3] Exit");
                        break;
                }
            }
            while (choice != 3);
        }
    }
}
