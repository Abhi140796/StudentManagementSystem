using System;
using System.Collections.Generic;

namespace StudentManagementSystem
{
    class Program
    {

        static void Main(string[] args)
        {
            #region Variables
            int studentID;
            string studentName;
            string studentDepartment;
            int numberOfSubjects = 2;
            string[] Subject;
            int[] Marks;
            Student[] studentData = new Student[0];
            #endregion

            #region Console Menu
            int option;
            do
            {
                Console.WriteLine("=================================================");
                Console.WriteLine("[1]. Add Student \n[2]. View Data \n[3]. Exit");
                Console.WriteLine("");
                Console.WriteLine("Choose An Action To Perform: ");
                option = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("=================================================");
                Console.WriteLine("");
                switch(option)
                {
                    case 1:
                        Console.WriteLine("Enter number of records you want: ");
                        int numberOfRecords = Convert.ToInt32(Console.ReadLine());
                        studentData = new Student[numberOfRecords];
                        int numberOfData = studentData.Length;
                        for (int i = 0; i < numberOfData; i++)
                        {
                            studentID = i + 1;

                            Console.WriteLine("Name");
                            studentName = Console.ReadLine();
                            Console.WriteLine("Department: ");
                            studentDepartment = Console.ReadLine();
                            Subject = new string[numberOfSubjects];
                            Marks = new int[numberOfSubjects];
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
                            break;

                    case 2:
                        numberOfData = studentData.Length;
                        for (int i = 0; i < numberOfData; i++)
                        {
                            Console.WriteLine($"Student ID: {Convert.ToString(studentData[i].studentID)}\nStudent Name: {studentData[i].studentName}\nStudent Department: {studentData[i].studentDepartment}");
                            for(int j = 0; j < numberOfSubjects; j++)
                            {
                                Console.WriteLine($"Subject Name: {studentData[i].SubjectName[j]} \t\t\t\tSubject Marks: {studentData[i].SubjectMarks[j]} \t\t\t\tGrade: {Result.GenerateGrade(studentData[i].SubjectMarks[j])}");
                            }
                            Console.WriteLine("======================================================================================================================");
                            Console.WriteLine("\n\n");
                        }
                        break;

                    case 3:
                        break;

                    default:
                        Console.WriteLine("=================================================");
                        Console.WriteLine("[1]. Add Student \n[2]. View Data \n[3]. Exit");
                        Console.WriteLine("");
                        Console.WriteLine("Choose An Action To Perform: ");
                        Console.WriteLine("=================================================");
                        Console.WriteLine("");
                        break;
                }
            }
            while (option != 3);
        }
        #endregion
    }
}
