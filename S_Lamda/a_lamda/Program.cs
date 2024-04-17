namespace a_lamda;
delegate int MyDel(int a);
class Program
{
    static void Main(string[] args)
    {
        MyDel d = a => a*a;
        int value = d(5);
        Console.WriteLine("The value =" +value);
    }
}
