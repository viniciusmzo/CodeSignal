

var param1 = int.Parse(Console.ReadLine());
var param2 = int.Parse(Console.ReadLine());

Console.WriteLine(Solution.Sum(param1, param2).ToString());


public static class Solution 
{
	public static int Sum(int param1, int param2) 
	{
        return param1 + param2;
    }
}