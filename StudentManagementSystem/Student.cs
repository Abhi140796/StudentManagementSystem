using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    class Student
    {
        private string name;
        private string subject;
        private int marks;

        public string studentName { get{ return name;} set{name = value;} }
        public string subjectName { get { return subject; } set { subject = value; } }
        public int subjectMarks { get { return marks; } set { marks = value; } }

        public List<string> storeData()
        {
            Console.WriteLine("Enter Number of students");
            int numberOfRecords = Convert.ToInt32(Console.ReadLine());
            List<string> studentData = new List<string>(numberOfRecords);
            for(int i = 0; i < studentData.Count; i++)
            {
                Console.WriteLine("Enter Student Name:");
            }

            return studentData;
        }

    }
}
