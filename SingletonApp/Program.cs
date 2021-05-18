using System;

namespace SingletonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Одиночка - порождающий паттерн проктирования - отвечает за то, что класс будет только один.

            //Singleton singleton = new Singleton();

            //Singleton sin_1 = Singleton.GetInstance();
            //Singleton sin_2 = Singleton.GetInstance();
            //Singleton sin_3 = Singleton.GetInstance();
            //Singleton sin_4 = Singleton.GetInstance();

            //if (Object.ReferenceEquals(sin_1, sin_2))
            //{
            //    Console.WriteLine("Same objects");
            //}
            //else
            //{
            //    Console.WriteLine("Not the same objects");
            //}




            //Singleton.x = 10;
            //Console.WriteLine(Singleton.x); // static
            //Console.WriteLine(sin_1.y); // non static


            ////Math.Sqrt(9);// static

            //Random r = new Random();
            //r.Next(); //  non static

            Student s1 = Student.CreateStudent("zdg");
            Student s2 = Student.CreateStudent("aaa");
            Student s3 = Student.CreateStudent("aaa"); // null

            Console.WriteLine(s2.Name);
            Console.WriteLine(Student.Count);
        }
    }
}
