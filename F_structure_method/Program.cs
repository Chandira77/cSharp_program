namespace F_structure_method;


struct Student{
    public int roll;
    public string fullname;
    public string email;
    public string faculty;

    public void getdetails(int rn, string fn, string ei, string fa)
    {
        roll = rn;
        fullname =fn;
        email = ei;
        faculty = fa;
    }

    public void displayDetails()
    {
        Console.WriteLine("roll ={0}", roll);
        Console.WriteLine("fullname ={0}", fullname);
        Console.WriteLine("email id ={0}", email);
        Console.WriteLine("faculty ={0}", faculty);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Student s1 = new Student();
        Student s2 = new Student();

        s1.getdetails(12, "Ram", "irahjvjvh@gmail.com", "science");
        s2.getdetails(52, "Hari", "haricha@gmail.com", "mgmt");

        s1.displayDetails();
        Console.WriteLine();
        s2.displayDetails();
    }
}
