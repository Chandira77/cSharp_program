namespace e_string_interpolation;

class Program
{
    static void Main(string[] args)
    {
        //var name ="Ram";
        //var gratitude = "hello";

        //string greetings = $"{gratitude} kaa xau {name}";
        //Console.WriteLine(greetings);
        
        var a =5;
        var result = $"the square of {5} = {a * a}";
        Console.WriteLine(result);

        // 2. use of string.Format()
       // var name = "Ram";
        //var greetings = string.Format("hello {0}, {1} !", name, "hello");
        //Console.WriteLine(greetings);
    }
}
