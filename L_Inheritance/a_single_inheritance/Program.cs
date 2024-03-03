namespace a_single_inheritance;
class SuperClass
{
    public void hi()
    {
        Console.WriteLine("hi friends, i'm from superclass");
    }
}
class SubClass : SuperClass
{
    public void hello()
    {
        Console.WriteLine("hi friends, i'm from subclass");
    }
}
class Program
{
    static void Main(string[] args)
    {
        SubClass obj = new SubClass();
        obj.hello();
        obj.hi();
    }
}
