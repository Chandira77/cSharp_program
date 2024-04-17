namespace d_exception;


class Program
{
    static void Main(string[] args)
    {
        try
        {
            int [] nums = new int[4];
            nums[10] = 33;
            Console.WriteLine("nums[10]");
        }
        catch (System.Exception e)
        {
            
            Console.WriteLine("Error found" + e);
        }
    }
}
