using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Teacher:Human
    {
        private List<Student> studentList = new List<Student>();

        public List<Student> StudentList
        {
            set {  }
            get
            {
                return studentList;
            }
           
        }
        public List<Student> GetStudentList()
        {
            return studentList;
        }
        public Teacher(int id, string name, string surname, int age, Address address) 
            : base(id, name, surname, age, address)
        {
            studentList = new List<Student>();
        }
        public void AddStudent(Student std)
        {
            studentList.Add(std);
        }
    }
}
