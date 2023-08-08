
int year = int.Parse(Console.ReadLine());
Console.WriteLine(SolutionYear.ReturnCentury(year));

public static class SolutionYear
{
    public static int ReturnCentury(int year)
    {
        int century;

        string ageStr = year.ToString();
        if (ageStr.Length < 4)
        {
            var cont = 4 - ageStr.Length;
            var zeros = "";

            for (int i = 0; i < cont; i++)
            {
                zeros += "0";
            }
            ageStr = zeros + ageStr;
        }

        string firstNums = ageStr.Substring(0, 2);
        string lastNums = ageStr.Substring(2, 2);

        if (lastNums == "00")
        {
            century = int.Parse(firstNums);
        }
        else
        {
            century = int.Parse(firstNums) + 1;
        }

        return century;
    }
}