using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    class Result
    {
        private string[] Subject;
        private int[] Marks;
        public string[] SubjectName { get {return Subject; } set {Subject = value; } }
        public int[] SubjectMarks { get { return Marks; } set { Marks = value; } }

        public static string[] AddSubjects(string[] subjectName)
        {
            int numberOfSubjects = 5;

            return subjectName;
        }
    }
}
