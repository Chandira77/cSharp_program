namespace c_delegate;
delegate int NumberCalc(int num);
class Program
{
    static int num = 10;
    public static int AddNum(int a){
        num+= num;
        return num;
    }
      public static int MulNum(int b)
      {
        num*= num;
        return num;
    }
      public static int GetNum(){
        return num;
    }
    static void Main(string[] args)
    {
        NumberCalc nc1 = new NumberCalc(AddNum);
        NumberCalc nc2 = new NumberCalc(AddNum);
        nc1(20);
        Console.WriteLine("The new value ={0}", GetNum());
        nc1(10);
        Console.WriteLine("The new value ={0}", GetNum());
    }
}
