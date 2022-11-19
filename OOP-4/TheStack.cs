using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace OOP_4
{
    public class TheStack
    {
        public static void PrintStack()
        {
            Employee jeff = new Employee(1000, "Jeff", "Male", 25300);
            Employee sara = new Employee(1001, "Sara", "Female", 27100);
            Employee casper = new Employee(1002, "Casper", "Male", 21450);
            Employee tom = new Employee(1003, "Tom", "Male", 31700);
            Employee linn = new Employee(1004, "Linn", "Female", 51430);
            Stack q = new Stack();
            q.Push(jeff);
            q.Push(sara);
            q.Push(casper);
            q.Push(tom);
            q.Push(linn);

            foreach (Employee x in q)
            {
                Console.WriteLine(x.ToString());
                Console.WriteLine("Items left in the stack: " + q.Count);
            }
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            for (int i = q.Count; i > 0; i--)
            {
                Console.WriteLine(q.Pop());
                Console.WriteLine("Items left in the stack: " + q.Count);
            }
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            q.Push(jeff);
            q.Push(sara);
            q.Push(casper);
            q.Push(tom);
            q.Push(linn);
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(q.Peek());
                Console.WriteLine("Items left in the stack: " + q.Count);

            }
            if (q.Contains(casper)) Console.WriteLine("Element 3 is in the stack");
            else Console.WriteLine("Element 3 is not in the stack");
        }
    }
}
