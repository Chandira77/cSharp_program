namespace h_exception;

class MyException : Exception
{
    public MyException(string str)
    {
        Console.WriteLine(str);
    }
}
class Program
{
    static void Main(string[] args)
    {
        MyException obj = new MyException("the user defined exception handling demo");
        try
        {
            throw obj;
        }
        catch (System.Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
