namespace b_static_class_stu_details;
public class Student
{
    public static string firstname = "Ram";
    public static string lastname = "Thapa";
    public static int marks = 43;
    public static void displayDetails()
    {
        Console.WriteLine("the details of the students");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Student.displayDetails();
        Console.WriteLine("First Name ="+Student.firstname);
        Console.WriteLine("Last Name ="+Student.lastname);
        Console.WriteLine("marks ="+Student.marks);
    }
}
