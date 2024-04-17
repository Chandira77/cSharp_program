namespace b_lamda;
delegate int MyDel(int a, int b);
class Program
{
    static void Main(string[] args)
    {
        MyDel d = (a, b) => a + b;
        int result = d(2,5);
        Console.WriteLine(result);
    }
}
