namespace a_static_class;

static class Shape
{
    public static int length = 87;
    //default parametirized
    public static int square()
    {
        return(length * length);
    }
    // parameterized
     public static int cube(int a)
    {
        return(a*a*a);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Shape.length);
        Console.WriteLine(Shape.square());
        Console.WriteLine(Shape.cube(4));
    }
}
