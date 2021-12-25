using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    class Student: Result
    {
        private string Name;
        private string Department;
        private int Id;
        public Result result = new Result();
        public Student(int Id,string name, string depatment, string[] subject, int[] marks)
        {
            this.Name = name;
            this.Department = depatment;
            this.Id = Id;
            this.SubjectName = subject;
            this.SubjectMarks = marks;
        }

        public int studentID { get { return Id; } set { Id = value; } }
        public string studentName { get { return Name; } set { Name = value; } }
        public string studentDepartment { get { return Department; } set { Department = value; } }
    }
}
