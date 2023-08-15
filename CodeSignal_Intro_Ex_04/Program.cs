
int[] inputValues = new int[] { 3, 6, -2, -5, 7, 3 };

Console.WriteLine(Solution.Calculate(inputValues).ToString());

public static class Solution
{

    public static int Calculate(int[] inputArray)
    {
        var maxValue = -1000 * 1000;
        var lenghtArray = inputArray.Length - 1;

        for (int i = 0; i < lenghtArray; i++)
        {
            if (inputArray[i] * inputArray[i + 1] >= maxValue)
            {
                maxValue = inputArray[i] * inputArray[i + 1];
            }
        }
        return maxValue;
    }

}