namespace a_delgates;
public delegate void MyDel(string name);

class Program
{
    public static void displayName(string name)
    {
        Console.WriteLine("Name =" +name);
    }
    static void Main(string[] args)
    {
       MyDel dl = new MyDel(displayName);
       dl("sanothimi"); 
    }
}
