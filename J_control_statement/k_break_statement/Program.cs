namespace k_break_statement;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 1; i <= 10; i++)
        {
            if (i == 5)
            {
                break;  //continue;
            }
            Console.WriteLine(i);
        }
    }
}
