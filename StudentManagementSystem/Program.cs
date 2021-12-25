using System;
using System.Collections.Generic;

namespace StudentManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentName;
            string studentDepartment;
            int numberOfSubjects = 5;
            string[] Subject = new string[numberOfSubjects]; ;
            int[] Marks = new int[numberOfSubjects];

            Console.WriteLine("Enter number of records you want: ");
            int numberOfRecords = Convert.ToInt32(Console.ReadLine());
            Student[] studentData = new Student[numberOfRecords];
            int numberOfData = studentData.Length;
            for (int i = 0; i < numberOfData; i++) 
            {
                int studentID = 0;
                ++studentID;
                Console.WriteLine("Name");
                studentName = Console.ReadLine();
                Console.WriteLine("Department: ");
                studentDepartment = Console.ReadLine();

                for (int j = 0; j < numberOfSubjects; j++)
                {
                    Console.WriteLine("Enter Subject Name: ");
                    Subject[j] = Console.ReadLine();
                    Console.WriteLine("Enter Subject Marks: ");
                    Marks[j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
                Console.WriteLine();
                studentData[i] = new Student(studentID, studentName, studentDepartment, Subject, Marks);
            }
            
            for(int i = 0; i < numberOfData; i++)
            {
                Console.WriteLine($"Student ID: {studentData[i].studentID} \nStudent Name: {studentData[i].studentName} \nStudent Department: {studentData[i].studentDepartment}");
                for(int j = 0; j < numberOfSubjects; j++)
                {
                    Console.WriteLine($"Subject Name: {studentData[i].SubjectName[j]} \t\tSubject Marks: \t{studentData[i].SubjectMarks[j]}");
                }
                Console.WriteLine("======================================================================================================");
            }
        }
    }
}
