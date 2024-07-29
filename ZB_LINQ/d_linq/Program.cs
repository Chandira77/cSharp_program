namespace d_linq;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 1,4,7,4,5,8,65,534,33,55};
        int uniqueNums = numbers.Distinct().Count();
        Console.WriteLine("Numeber of unique numbers:" +uniqueNums);
    }
}
