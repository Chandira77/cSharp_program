namespace j_foreach_charecter_array;

class Program
{
    static void Main(string[] args)
    {
        char[] myarray = { 'H', 'E', 'L', 'O' };
        foreach (var item in myarray)
        {
            Console.WriteLine(item);
        }

        /*
        for integer array
        int[] myarray = { 23, 45, 67, 89, 90, 45 };
        foreach (var item in myarray)
        {
            Console.WriteLine(item);
        }  */
    }
}
