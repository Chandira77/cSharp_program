using a_interface;

namespace a_interface;
interface Inepal
{
    public void hi();
}
class Country : Inepal
{
    public void hi()
    {
        Console.WriteLine("Hello nepal");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Country c1 = new Country();
        c1.hi();
    }
}
