namespace b_exception;

class Program
{
    static void Main(string[] args)
    {
        int a = 20, b = 0, result = 0;
        try
        {
             result = a/b;
             Console.WriteLine("the reuslt =" +result);
        }
        catch (Exception e)
        {
            
            Console.WriteLine(e + " divisor cannot be zero");
        }
      
    }
}
