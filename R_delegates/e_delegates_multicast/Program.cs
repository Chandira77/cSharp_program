namespace e_delegates_multicast;
public delegate void MyDel(int a, int b);
class Calc
{
    public void add(int a, int b)
    {
        Console.WriteLine("the sum " + (a+b));
    }
    public void mul(int a, int b)
    {
        Console.WriteLine("the product " +(a*b));
    }
    static void Main(string[] args)
    {
        Calc c1 = new Calc();
        MyDel d1 = new MyDel(c1.add);
        MyDel d2 = new MyDel(c1.mul);
        d1 = d1 + d2;
        d1(22, 2);
    }
}
