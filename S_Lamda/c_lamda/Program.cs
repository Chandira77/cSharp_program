namespace c_lamda;
delegate void MyDel(int a, int b);
class Program
{
    static void Main(string[] args)
    {
        MyDel d = (a, b) =>
        {
            Console.WriteLine(a * b);
            Console.WriteLine("end of the program");
        };
        d(10,20);
        
    }
}
