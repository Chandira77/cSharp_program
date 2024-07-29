namespace e_linq;

class Program
{
    static void Main(string[] args)
    {
        int[] nums = {12,33,55,66};
        int oddNum = nums.Count(n => n % 2 ==1);
        Console.WriteLine("The number of odd number is", oddNum);
    }
}
