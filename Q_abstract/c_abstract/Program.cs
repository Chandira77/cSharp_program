namespace c_abstract;

abstract class Myclass
{
    public abstract void calculate(double x);
}
class SubClassOne : Myclass
{
    public override void calculate(double x)
    {
        Console.WriteLine("Square root = " +Math.sqrt(x));
    }
}
class SubClassTwo : Myclass
{
    public override void calculate(double x)
    {
        Console.WriteLine("Square = " +(x * x));
    }
}
class SubClassThree : Myclass
{
    public override void calculate(double x)
    {
        Console.WriteLine("cube = " +(x * x* x));
    }
}
class Program
{
    static void Main(string[] args)
    {
       SubClassOne obj1 = new SubClassOne();
       SubClassTwo obj2 = new SubClassTwo();
       SubClassThree obj3 = new SubClassThree();
       obj1.calculate(3);
       obj2.calculate(3);
       obj3.calculate(3); 
    }
}
