namespace b_linq;

class Program
{
    static void Main(string[] args)
    {
        string[] Students = {"ram", "sita", "gita", "rita"};
        var nameSort = from name in Students orderby name select name;
        foreach (var name in nameSort)
        {
            Console.WriteLine(name);
        }
    }  
}
