/*
 *      Ferit Yiğit BALABAN, <f@fybx.dev>
 *      032190002
 *
 *      Goal: Write name of any entered number between 1 to 2147483647 (inclusive).
 */
// ReSharper disable All
namespace Assignment3;

public static class Assignment3
{
    private static void Main(string[] args)
    {
        bool @break = false;
        while (!@break)
        {
            Console.Write("Bir sayı girin: ");
            string? input = Console.ReadLine();
            @break = string.IsNullOrEmpty(input?.Replace(" ", ""));
            if (!@break)
            {
                int sayi = Convert.ToInt32(input);
                Console.WriteLine(sayi.Oku());   
            }
        }
    }
}

public static class Extensions
{
    private static Dictionary<int, string> BasBir = new()
    {
        {1, "bir"}, {2, "iki"}, {3, "üç"}, {4, "dört"}, {5, "beş"}, {6, "altı"}, {7, "yedi"}, {8, "sekiz"}, {9, "dokuz"}
    };
    
    private static Dictionary<int, string> BasOn = new()
    {
        {1, "on"}, {2, "yirmi"}, {3, "otuz"}, {4, "kırk"}, {5, "elli"}, {6, "altmış"}, {7, "yetmiş"}, {8, "seksen"}, {9, "doksan"}
    };

    private static Dictionary<int, string> Binlik = new()
    {
        { 0, "" }, { 1, "bin" }, { 2, "milyon" }, { 3, "milyar" }
    };

    public static string Oku(this int deger)
    {
        int bin = 0, dig = 0, peek = 0, dgr = deger;
        string txt = "";
        do
        {
            int pos = 0;
            txt = bin == 0 ? "" : $"{(Binlik[bin])} {txt.Trim()}";
            do
            {
                dig = dgr % 10;
                peek = (dgr / 10) % 10;
                txt = pos switch
                {
                    0 => $"{(bin == 1 && pos == 1 && peek == 0 ? "" : BasBir[dig])} {txt}".Trim(),
                    1 => $"{BasOn[dig]} {txt}",
                    _ => $"{(dig == 1 ? "" : BasBir[dig])} yüz {txt}"
                };
                dgr /= 10;
                pos++;
            } while (pos < 3 && dgr != 0);
            bin++;
        } while (dgr != 0);
        return txt.Trim();
    }
}