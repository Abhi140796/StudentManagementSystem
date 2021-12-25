using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    class Result
    {
        #region Variables

        /// <summary>
        /// SubjectName is property to acces array Subject with private access modifier
        /// SubjectMarks is property to acces array Marks with private access modifier
        /// </summary>
        private string[] Subject;
        private int[] Marks;
        public string[] SubjectName { get {return Subject; } set {Subject = value; } }
        public int[] SubjectMarks { get { return Marks; } set { Marks = value; } }
        #endregion

        #region Method To find grade

        /// <summary>
        /// GenerateGrade(int subjectMarks) is a function to generate grade
        /// </summary>
        /// <param name="subjectMarks"> it is student marks according to which grade is generated</param>
        /// <returns>it returns a char value which is a grade of student respective to their marks</returns>
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
        #endregion
    }
}
