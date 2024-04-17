namespace b_interface_inherit_interface;
interface IOne
{
    public void methodOne();
}

interface ITwo
{
    public void methodTwo();
}
interface IThree : IOne, ITwo
{
    public void methodThree();
}
class Program : IThree
{
    void IOne.methodOne()
    {
        Console.WriteLine("i am the body of method from interface one");
    }
     void ITwo.methodTwo()
    {
        Console.WriteLine("i am the body of method from interface two");
    }
     void IThree.methodThree()
    {
        Console.WriteLine("i am the body of method from interface Three");
    }
    static void Main(string[] args)
    {
       IThree it1 = new Program();
       it1.methodOne();
       it1.methodTwo();
       it1.methodThree();
    }
}
