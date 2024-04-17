// Demonstrate the use of interface for basic arithmetic operation on two numbers.
namespace c_interface_calculator;


interface ISum
{
    int add(int a, int b);
}
interface IDiff
{
    int subt(int c, int d);
}
interface IPro
{
    int mul(int e, int f);
}
interface IDiv
{
    int quo(int g, int h);
}

class Calculator : ISum, IDiff, IPro, IDiv
{
    public int res_add;
    public int add(int a, int b)
    {
        return res_add = a + b;
    }

    public int res_subt;
    public int subt(int c, int d)
    {
        return res_subt = c - d;
    }
    public int res_mul;
    public int mul(int e, int f)
    {
        return res_mul = e * f;
    }
    public int res_quo;
    public int quo(int g, int h)
    {
        return res_quo = g / h;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Calculator obj = new Calculator();
        obj.add(1,2);
        obj.subt(5,3);
        obj.mul(5,4);
        obj.quo(4,2);
        Console.WriteLine(obj.res_add);
        Console.WriteLine(obj.res_subt);
        Console.WriteLine(obj.res_mul);
        Console.WriteLine(obj.res_quo);
    }
}
