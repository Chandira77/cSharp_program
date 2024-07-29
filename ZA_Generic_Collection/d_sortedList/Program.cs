namespace d_sortedList;

class Program
{
    static void Main(string[] args)
    {
        SortedList<int, string>rollNames = new SortedList<int, string>();
        rollNames.Add(1, "ram");
        rollNames.Add(3, "hari");
        rollNames.Add(2, "shyam");

        foreach (var item in rollNames)
        {
            Console.WriteLine("key : {0} and value :{1}", item.Key, item.Value);
        }
    }
}
