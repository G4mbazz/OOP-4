using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_4
{
    internal class TheList
    {
        public static void PrintList()
        {
            Employee jeff = new Employee(1000, "Jeff", "Male", 25300);
            Employee sara = new Employee(1001, "Sara", "Female", 27100);
            Employee casper = new Employee(1002, "Casper", "Male", 21450);
            Employee tom = new Employee(1003, "Tom", "Male", 31700);
            Employee linn = new Employee(1004, "Linn", "Female", 51430);
            List<Employee> list = new List<Employee>
            {
                jeff,
                sara,
                casper,
                tom,
                linn
            };
            
            if (list.Contains(list[1])) Console.WriteLine("Element 2 exists in the List");
            else Console.WriteLine("Element 2 does not exist in the List");

            Console.WriteLine("\nFirst male in the list\n" + list.Find(x => x.Gender.Contains("Male")));

            Console.WriteLine("~~~~~~~~~~All The Males~~~~~~~~");
            foreach (var item in list.FindAll(y => y.Gender.Contains("Male")))
            {
                Console.WriteLine(item);

            }
        }
    }
}
