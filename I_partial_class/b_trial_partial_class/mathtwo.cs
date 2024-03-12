partial class Cuboid
{
    double length, breadth, height;

    public void mathVolInput()
    {
        Console.WriteLine("enter the length:");
        length = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("enter the breadth:");
        breadth = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("enter the height:");
        height = Convert.ToDouble(Console.ReadLine());
    }

    public void mathVolOutput()
    {
        double Volume = (length * breadth * height);
        Console.WriteLine("the volume of cuboid is " +Volume);
    }

}