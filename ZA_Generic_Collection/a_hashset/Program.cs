namespace a_hashset;

class Program
{
    static void Main(string[] args)
    {
        HashSet<string>names = new HashSet<string> ();
        names.Add("sita");
        names.Add("Ram");
        names.Add("shyam");
        names.Add("gita");
        names.Add("hari");
        names.Add("rita");
        names.Add("mita");

        //to remove an element
        //names.Remove("Gita");

        //to clear HashSet
        Console.WriteLine("Before clear");
        Console.WriteLine("Elements in hashset");
        foreach (var item in names)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("Before clear");
        names.Clear();
        
        Console.WriteLine("Elements in hashset:");
        foreach(var item in names){
            Console.WriteLine(item);
        }
    }
}
