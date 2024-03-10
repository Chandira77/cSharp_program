namespace b_interface;

interface Istudent
{
    public void Learn();
}
interface ITeacher
{
    public void Teach();
}
class College : Istudent, ITeacher
{
    public void Learn()
    {
        Console.WriteLine("Student learn");
    }
    public void Teach()
    {
        Console.WriteLine("Teacher teach");
    }
}
class Program
{
    static void Main(string[] args)
    {
        College c2 = new College();
        c2.Learn();
        c2.Teach();
    }
}
