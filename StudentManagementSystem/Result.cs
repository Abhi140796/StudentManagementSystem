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

        public static char GenerateGrade(int subjectMarks)
        {
            if(subjectMarks >= 90)
            {
                return 'A';
            }
            else if(subjectMarks >= 75 && subjectMarks < 90)
            {
                return 'B';
            }
            else if (subjectMarks >= 60 && subjectMarks < 75)
            {
                return 'C';
            }
            else if (subjectMarks >= 45 && subjectMarks < 60)
            {
                return 'D';
            }
            else if (subjectMarks >= 35 && subjectMarks < 45)
            {
                return 'E';
            }
            else
            {
                return 'F';
            }
        }
    }
}
