namespace c_exception;
class MyClass
{
    public int divide(int a , int b)
    {
        int result = a/b;
        return result;
    }
}
class Program
{
    static void Main(string[] args)
    {
        MyClass obj = new MyClass();
        Console.WriteLine("enter dividend.");
        int dividend = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter divisor.");
        int divisor = Convert.ToInt32(Console.ReadLine());
        try{
            //Console.WriteLine("the result = " +obj.divide(10, 4));
            Console.WriteLine("the result = " +obj.divide(dividend, divisor));
        } 
        catch(Exception)
        {
            Console.WriteLine("cannot divide by Zero.");
        }
    }
}
