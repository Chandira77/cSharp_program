namespace g_type_conversion_non_compatible_convert_compatible;

class Program
{
    static void Main(string[] args)
    {
        String a = "123";
        int b = Convert.ToInt32(a);
        int c = 567;
        int sum = b+c;
        Console.WriteLine(sum);
    }
}
