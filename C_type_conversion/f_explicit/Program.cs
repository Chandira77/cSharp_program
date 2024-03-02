namespace f_explicit;

class Program
{
    static void Main(string[] args)
    {
        String str1 = "123";
        //int str2 = int.Parse(str1);
        String str3 = "45";
        //int str4 = int.Parse(str3);
       // int sum = str2+ str4;
        int sum = int.Parse(str1) + int.Parse(str3);

        Console.WriteLine("Sum of both string =" +sum);
    }
}
