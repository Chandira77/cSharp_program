﻿namespace d_delegate_singlecast;

class Program
{
    public delegate void DelMethod();
    public class MyClass
    {
        public static void display()
        {
            Console.WriteLine("hi");
        }
        public static void show()
        {
            Console.WriteLine("hello");
        }
        public void print()
        {
            Console.WriteLine("Namastey");
        }
    }
    static void Main(string[] args)
    {
        DelMethod d1 = MyClass.display;
        DelMethod d2 = new DelMethod(MyClass.show);
        MyClass obj = new MyClass();
        DelMethod d3 = obj.print;
        d1();
        d2();
        d3();
    }
}
