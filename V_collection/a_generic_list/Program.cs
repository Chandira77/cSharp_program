namespace a_generic_list;

class Program
{
    static void Main(string[] args)
    {
        List<int> nums = new List<int>();
        nums.Add(23);
        nums.Add(4);
        nums.Add(30);
        nums.Add(6);
        nums.Add(7);

        var nums = new List<int>() {54,43,23,12,12};

        nums.Insert(3, 111);
        nums.Remove(67); //removes the particular element
        nums.RemoveAt(4); //removes the item at position
        nums.Clear();
        //nums.ForEach(nums=>Console.WriteLine(nums));

        //Console.WriteLine(nums[0]);
        //Console.WriteLine(nums[1]);
       // Console.WriteLine(nums[2]);
        //Console.WriteLine(nums[3]);
        //Console.WriteLine(nums[4]);

        //for(int i = 0; i < 5; i++)
        for(int i = 0; i < nums.Count; i++)
        {
            Console.WriteLine(nums[i]);
        }
    }
}
