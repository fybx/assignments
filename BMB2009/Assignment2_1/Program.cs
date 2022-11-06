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
}