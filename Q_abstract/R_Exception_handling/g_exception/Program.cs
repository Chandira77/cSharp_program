﻿namespace g_exception;

class Program
{
    static void Main(string[] args)
    {
        string value = null;
        try
        {
            //if (value.Length == 0)
            if (value.Length != 0)
        {
            Console.WriteLine(value);
        } 
        }
        catch (System.Exception e)
        {
            Console.WriteLine("Exception found " +e);
            
        }
       
        
    }
}
