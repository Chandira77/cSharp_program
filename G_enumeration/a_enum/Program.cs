namespace a_enum;

class Program
{
    enum days {Sunday, Monday, Tuesday, Wednesday, thrusday, Friday, Saturday};
    static void Main(string[] args)
    {
        //int lastday = (int)days.Saturday;
        //Console.WriteLine(LastDay);
       /* var wd = (days)5;
        Console.WriteLine(wd);*/

        Console.WriteLine("enter a day");
        Console.ReadLine();
        var today = days.Saturday;

        if(today==days.Friday || today==days.Saturday){
            Console.WriteLine("It's a holiday");
        }
        else{
            Console.WriteLine("today is not holiday");
        }

    }
}
