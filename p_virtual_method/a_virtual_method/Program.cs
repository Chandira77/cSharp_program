namespace a_virtual_method;

class Superclass
{
    public virtual int add(int a, int b)
    {
        return(a+b);
    }
}
class Subclass : Superclass
{
    public override int add(int a, int b)
    {
        return(a+b+5);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Subclass obj = new Subclass();
        Console.WriteLine("The result =" +obj.add(32,44));
    }
}
