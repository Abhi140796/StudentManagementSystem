using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    /// <summary>
    /// Class Student inherit Class Result to access SubjectName and SubjectMarks property
    /// </summary>
    class Student: Result
    {
        private string Name;
        private string Department;
        private int Id;

        /// <summary>
        /// Student class constructer
        /// </summary>
        /// <param name="Id">Student ID</param>
        /// <param name="name">Student Name</param>
        /// <param name="depatment">Student Department</param>
        /// <param name="subject">Subject Name</param>
        /// <param name="marks">Subject Marks</param>
        public Student(int Id,string name, string depatment, string[] subject, int[] marks)
        {
            this.Name = name;
            this.Department = depatment;
            this.Id = Id;
            this.SubjectName = subject;
            this.SubjectMarks = marks;
        }

        /// <summary>
        /// Property to access private variables
        /// </summary>
        /// <param name="studentID">Student ID</param>
        /// <param name="studentName"> Student Name</param>
        /// <param name="studentDepartment"> Student Department</param>

        public int studentID { get { return Id; } set { Id = value; } }
        public string studentName { get { return Name; } set { Name = value; } }
        public string studentDepartment { get { return Department; } set { Department = value; } }
    }
}
