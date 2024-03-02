namespace E_structure;


struct Student
{
    public int age;

    public void displayAge(int age)
    {
        Console.WriteLine("the age=" +age);

    }
}
class Program
{
    static void Main(string[] args)
    {
        Student s1 = new Student();
        s1.age = 45;
        s1.displayAge(s1.age);
    }
}
