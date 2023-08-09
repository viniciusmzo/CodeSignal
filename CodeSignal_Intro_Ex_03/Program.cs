var inputStr = Console.ReadLine();
Console.WriteLine(Palindrome.ReturnIsPalindrome(inputStr).ToString());

public static class Palindrome 
{
    public static bool ReturnIsPalindrome(string inputString) 
    {
        return inputString.SequenceEqual(inputString.Reverse());
    }
}