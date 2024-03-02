namespace A_array;

class Program
{
    static void Main(string[] args)
    {
        int[] myarray = {43,34,54, 65,76};
        Array.Sort(myarray);
        Array.Reverse(myarray);
       // foreach(var item in myarray){
        //    Console.WriteLine(item);
        //}

        Console.WriteLine("The minimum value from the array="+myarray.Min());
        Console.WriteLine("The maximum value from the array="+myarray.Max());
        Console.WriteLine("The Sum of all array="+myarray.Sum());
        Console.WriteLine("The average of all array elements ="+myarray.Average());
    }
}
