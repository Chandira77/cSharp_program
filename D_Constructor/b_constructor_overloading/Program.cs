namespace b_constructor_overloading;

class Nums{
    int m, n;
    int p, q, r;

    public Nums(int a, int b){
        m = a;
        n = b;
    }
    public Nums(int x, int y, int z){
        p = x;
        q = y;
        r = z;
    }

    public void displaySum()
    {
        Console.WriteLine("the Sum ="+(m+n));
    }

     public void displayProduct()
    {
        Console.WriteLine("the product ="+(p*q*r));
    }
}
class Program
{
    static void Main(string[] args)
    {
        Nums obj1 = new Nums(5, 6);
        Nums obj2 = new Nums(1,2,3);
        obj1.displaySum();
        obj2.displayProduct();
    }
}
