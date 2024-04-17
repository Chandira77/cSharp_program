namespace a_c_interface;

interface IStudent
{
    public void exam();
}
interface ITeacher
{
    public void exam();
}
class College : IStudent, ITeacher
{
    void IStudent.exam()
    //void exam()
    {
        Console.WriteLine("i am a student");
    }
    void ITeacher.exam()
    //void exam()
    {
        Console.WriteLine("i am a teacher");
    }
}
class Program
{
    static void Main(string[] args)
    {
        //College c1 = new College();  = comment gareko walale error aauxa
        IStudent is1 = new College();
        is1.exam();
        ITeacher it1 = new College();
        it1.exam();

    }
}
