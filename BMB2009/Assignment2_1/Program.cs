﻿/*
 *      Ferit Yiğit BALABAN, <f@fybx.dev>
 *      032190002
 */

// ReSharper disable All
namespace Assignment2_1;

// ReSharper disable once InconsistentNaming
public static class Assignment2_1
{
    public static void Main(string[] args)
    {
        // 1) DispCrown
        // string? input;
        // while (true)
        // {
        //     Console.WriteLine("n gir: ");
        //     input = Console.ReadLine();
        //     if (Convert.ToInt32(input) > 1)
        //     {
        //         DispCrown(Convert.ToInt32(input));
        //     }
        // }
                
        // 2) IsArmstrong
        // int n;
        // while (true)
        // {
        //     Console.Write("n gir: ");
        //     n = Convert.ToInt32(Console.ReadLine()?.Trim());
        //     if (n is 0)
        //         break;
        //     Console.WriteLine("{0} {1}", n, IsArmstrong(n) ? "Armstrong sayısıdır." : "Armstrong sayısı değildir.");
        // }
                
        // 3) DispAllArmstrong
        Console.Write("n gir: ");
        int n = Convert.ToInt32(Console.ReadLine()?.Trim());
        DispAllArmstrong(n);
    }

    public static void DispAllArmstrong(int n)
    {
        for (int i = 1; i <= n; i++)
            Console.Write(IsArmstrong(i) ? $"{i} Armstrong sayısıdır.\n" : "");
    }
    
    public static bool IsArmstrong(int val)
    {
        int n = val, digit, sum = 0;
        do
        {
            digit = n % 10;
            sum += digit * digit * digit;
            n /= 10;
        } while (n != 0);

        return val == sum;
    }
    
    public static void DispCrown(int n)
    {
        int row = 1, j;
        for (; row < n + 1; row++)
        {
            for (j = 1; j < row + 1; j++)
                Console.Write(j);
            for (int ctr = 0; ctr < 2 * (n - row); ctr++)
                Console.Write(" ");
            for (j = row; j > 0; j--)
                Console.Write(j);
            for (j = 2; j <= row; j++)
                Console.Write(j);
            for (int ctr = 0; ctr < 2 * (n - row); ctr++)
                Console.Write(" ");
            for (j = row; j > 0; j--)
                Console.Write(j);
            Console.Write("\n");
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
        int row = 1, j;
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