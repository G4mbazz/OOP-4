using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace OOP_4
{
    internal class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public decimal Salary { get; set; }
        public Employee(int _id, string _name, string _gender, decimal _salary)
        {
           ID = _id;
            Name = _name;
            Gender = _gender;
            Salary = _salary;
        }
        public override string ToString()
        {
            return ($"Name: {Name}, Gender: {Gender}, ID: {ID}, Salary: {Salary}Kr");
        }
    }
}
