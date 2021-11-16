using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Address
    {
        private string Country;
        private string City;
        private string Street;
        private int House;

        public string country { get { return Country; } set { Country = value; } }
        public string city { get { return City; } set { City = value; } }
        public string street { get { return Street; } set { Street = value; } }
        public int house { get { return House; } set { House = value; } }
        public Address(string country, string city, string street, int house)
        {
            Country = country;
            City = city;
            Street = street;
            House = house;
        }
    }
}
