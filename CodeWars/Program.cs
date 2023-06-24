public class RomanLetter
{
    public string Letter { get; set; }
    public int Value { get; set; }
}

class Program
{
    //Input: nums = [2,7,11,15], target = 9
    //Output: [0,1]
    static void Main(string[] args)
    {
        bool isPalindrome(int x)
        {
            string reverseInput = "";
            string input = x.ToString();
            for(int i = input.Length -1; i >= 0; i--)
            {
                char SingleChar = input[i];
                reverseInput += SingleChar;
            }
            Console.WriteLine(reverseInput);
            if (input == reverseInput)
            {
                return true;
            }
            else
            {
                return false;
            }
         
        }
        Console.WriteLine(isPalindrome(101));
        
    }

}
