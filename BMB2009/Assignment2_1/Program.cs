namespace Assignment2_1;

// ReSharper disable once InconsistentNaming
public static class Assignment2_1
{
    public static void Main(string[] args)
    {
        Console.Write("Soru seç (1 veya 2): ");
        string? input = Console.ReadLine();
        if (Convert.ToInt32(input) == 1)
            while (true)
            {
                Console.WriteLine("n gir: ");
                input = Console.ReadLine();
                if (Convert.ToInt32(input) > 2)
                {
                    // DispCrown(Convert.ToInt32(input));
                }
            }
        else if (Convert.ToInt32(input) == 2)
            while (true)
            {
            }
    }

    /// <summary>
    /// Used to prototype actual DispCrown that is wanted by the instructor.
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public static string _DispCrown(int n)
    {
        string result = "";
        int row = 1, col = 0, j;
        for (; row < n + 1; row++)
        {
            for (j = 1; j < row + 1; j++)
                result += $"{j}";
            for (int ctr = 0; ctr < 2 * (n - row); ctr++)
                result += " ";
            for (j = row; j > 0; j--)
                result += $"{j}";
            for (j = 2; j <= row; j++)
                result += $"{j}";
            for (int ctr = 0; ctr < 2 * (n - row); ctr++)
                result += " ";
            for (j = row; j > 0; j--)
                result += $"{j}";

            result += "\n";
        }
        
        return result.Remove(result.Length - 1);
    }
}