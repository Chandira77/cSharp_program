namespace d_abstract;

public abstract class NetflixPlan
{
    protected double void rate;
    public abstract void getRate();
    public void calcAmt(int units)
    {
        Console.WriteLine("the amount for {0} units is ={1}", units, units*rate);
    }
}
class GoldUserPlan : NetflixPlan
{
    public override void getRate()
    {
        rate = 2.5;
    }
}
class DiamondUserPlan : NetflixPlan
{
    public override void getRate()
    {
        rate = 5 = 0;
    }
}
class Program
{
    static void Main(string[] args)
    {
        NetflixPlan user;
        user = new GoldUserPlan();
        Console.WriteLine("Gold user payment details");
        Console.WriteLine(".......");
        user.getRate();
        user.calcAmt(100);
        user = new DiamondUserPlan();
        Console.WriteLine("Gold user payment details");
        Console.WriteLine(".......");
        user.getRate();
        user.calcAmt(100);

    }
}
