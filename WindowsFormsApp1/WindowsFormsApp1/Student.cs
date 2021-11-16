using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Student:Human
    {
        private int Marks;
        public int marks
        {
            set { Marks = value; }
            get { return Marks; }
        }
        public Student (int id, string name, string surname, int age, Address address, int marks ) :base(id, name, surname, age, address)
        {
            Marks = marks;
        }
    }
}
