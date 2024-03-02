namespace B_sort_string;

class Program
{
    static void Main(string[] args)
    {
        string[] names = new string[5]{"Ram", "Sita", "hari","Rita","mita"};
        int Len = names.Length;
        Array.Sort(names);
        Array.Reverse(names);
        for(int i = 0; i< Len; i++)
        {
            Console.WriteLine("Name [{0}] = {1}", i, names[i]);
        }
    }
}
