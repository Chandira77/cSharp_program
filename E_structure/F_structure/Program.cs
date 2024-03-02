namespace F_structure;


struct Student{
    public int roll;
    public string name;
    public  int age;
    public string address;
    public string phone;

}
class Program
{
    static void Main(string[] args)
    {
        Student s1;
        Student s2;

        s1.roll = 43;
        s1.name = "Ira";
        s1.age = 65;
        s1.address = "Lokanthali";
        s1.phone = "09876453232";

        s2.roll = 23;
        s2.name = "Gita";
        s2.age = 75;
        s2.address = "Bhaktapur";
        s2.phone = "78433453232";

        Console.WriteLine("Roll =" +s1.roll);
        Console.WriteLine("name =" +s1.name);
        Console.WriteLine("age =" +s1.age);
        Console.WriteLine(" address =" +s1.address);
        Console.WriteLine("phone =" +s1.phone);
        Console.WriteLine(" ");


        Console.WriteLine("Roll =" +s2.roll);
        Console.WriteLine("name =" +s2.name);
        Console.WriteLine("age =" +s2.age);
        Console.WriteLine(" address =" +s2.address);
        Console.WriteLine("phone =" +s2.phone);
        Console.WriteLine(" ");



        
    }
}
