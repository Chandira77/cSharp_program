namespace b_abstract;

abstract class Myclass
{
    public int calc(int a, int b)
    {
        return(a+b);
    }
}

class Yourclass : Myclass
{
    public int mul(int a, int b)
    //public int calc(int a, int b)
    {
        return(a*b);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Yourclass obj = new Yourclass();
        int result = obj.calc(20,3);
        Console.WriteLine("the result = {0}", result);
    }
}
