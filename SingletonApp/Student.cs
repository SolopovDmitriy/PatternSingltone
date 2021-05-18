using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonApp
{
    class Student
    {
        public static int Count = 0;
        public string Name { get; set; }

        private Student(string name)
        {
            Name = name;
            Count++;
        }

        public static Student CreateStudent(string name)
        {
            if (Count == 2)
            {
                Console.WriteLine("error");
                return null;
            }
            else
            {                
                return new Student(name);
            }
           
        }


    }
}
