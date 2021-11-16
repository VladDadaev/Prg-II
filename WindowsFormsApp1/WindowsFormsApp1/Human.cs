using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Human
    {
        private int Id ;
        private string Name;
        private string Surname;
        private int Age;
        private Address address;

        public int id { get { return Id; } set { Id = value; } }
        public string name { get { return Name; } set { Name = value; } }
        public string surname { get { return Surname; } set { Surname = value; } }
        public int age { get { return Age; } set { Age = value; } }
        public string country { get { return address.country; } set { address.country = value; } }
        public string city { get { return address.city; } set { address.city = value; } }
        public string street { get { return address.street; } set { address.street = value; } }
        public int house { get { return address.house; } set { address.house = value; } }

        public Human(int id, string name, string surname, int age, Address _address)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Age = age;
            address = _address;
        }

    }
}
