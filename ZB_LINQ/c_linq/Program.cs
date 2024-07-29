namespace c_linq;

class Program
{
    static void Main(string[] args)
    {
        int[marks1] = new int[] {13,34,56,77,54};
        int[marks2] = new int[] {13,7,6,100,24,89};
        var result = from a in marks1 from b in marks2 where a<b select new {a,b};
        foreach (var item in result)
        {
            Console.WriteLine("{0} is less than {1}", item.a, item.b);
        }
        
    }
}
