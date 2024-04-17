namespace f_excception;

class Program
{
    static void Main(string[] args)
    {
        string[] names = {"Ram","sita","Gita"};
        try
        {
            Console.WriteLine(names[3]);
        }
        catch (System.Exception e)
        {
            Console.WriteLine("Exception handled" +e);
        }
        
    }
}
