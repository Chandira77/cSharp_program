partial class Cuboid
{
    double length1, breadth1, height1;

    public void mathTsaInput()
    {
        Console.WriteLine("enter the length1:");
        length1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("enter the breadth1:");
        breadth1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("enter the height1:");
        height1 = Convert.ToDouble(Console.ReadLine());
    }

    public void mathTsaOutput()
    {
        double TSA = 2 * (length1 * breadth1 + breadth1 * height1 + height1 * length1);
        Console.WriteLine("the total surface area of cuboid is " +TSA);
    }

}