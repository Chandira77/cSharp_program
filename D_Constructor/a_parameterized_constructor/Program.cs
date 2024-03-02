namespace a_parameterized_constructor;

class student

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
    Console.WriteLine("The roll number is" + roll);
    Console.WriteLine(" name is" +name);
    Console.WriteLine("address is"+address);
}

class Program
{
    static void Main(string[] args)
    {
       int sr;
       string sn, sa;
       Console.WriteLine("Enter roll number");
       sr = Convert.ToInt32()
    }
}
