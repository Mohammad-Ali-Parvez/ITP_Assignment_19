using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS19
{
    internal class Student
    {
        //Constructor

        public Student(string name, string address, DateTime dateOfBirth)
        {
            Name = name;
            Address = address;
            DateOfBirth = dateOfBirth;
        }

        //Properties
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }

        //Method

        public override string ToString()
        {
            return "Name: " + Name + ", Address: " + Address +
  ", Date of Birth: " + DateOfBirth;
        }

    }
}
