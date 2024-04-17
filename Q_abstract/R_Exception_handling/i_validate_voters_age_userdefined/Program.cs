namespace i_validate_voters_age_userdefined;

class MyException : Exception
{
    public MyException(string message) : base(message){}
    
}
class Program
{
    static void Main(string[] args)
    {
        
        try
        {
             if (age < 18)
             {
                throw new MyException("you cannot cast your vote");
             }  
        }
        catch (System.Exception e)
        {
            
            
        } 
    }
}
