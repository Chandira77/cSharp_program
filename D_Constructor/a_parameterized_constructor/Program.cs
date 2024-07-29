namespace a_parameterized_constructor;

class student
{
public int roll;
public string name;
public string address;

 public student(int r, string n, string a)
 {
    roll = r;
    name = n;
    address = a;
 }

public void displayinfo()
{
    Console.WriteLine(name + " lives in " + address + " whose roll number is " + roll + ".");
}
}

class Program
{
    static void Main(string[] args)
    {
       int sr;
       string sn, sa;
       Console.WriteLine("Enter roll number");
       sr = Convert.ToInt32(Console.ReadLine());
       Console.WriteLine("Enter name");
       sn = Console.ReadLine();
       Console.WriteLine("Enter address");
       sa = Console.ReadLine();
       student s1 = new student(sr,sn,sa);
       s1.displayinfo();

    }
}
