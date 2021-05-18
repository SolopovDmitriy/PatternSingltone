using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonApp
{
    sealed class Singleton // не может иметь наследников, от него нельзя наследоваться
    {

        public static int x;
        public int y;


        private static Singleton _instance; //empty

        private Singleton() //конструктор долджен быть приватным
        {

        }

        public static Singleton GetInstance()
        {
            if(_instance == null)
            {
                _instance = new Singleton();
            }

            return _instance;
        }
    }
}
