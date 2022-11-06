/*
 *      Ferit Yiğit BALABAN, <f@fybx.dev>
 *      032190002
 */
namespace Assignment3;

public static class Assignment3
{
    private static void Main(string[] args)
    {
        Console.Write("Bir sayı girin: ");
        int sayi = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(sayi.Oku());
    }
}

public static class Extensions
{
    private static Dictionary<int, string> BasBirler = new()
    {
        {1, "bir"}, {2, "iki"}, {3, "üç"}, {4, "dört"}, {5, "beş"}, {6, "altı"}, {7, "yedi"}, {8, "sekiz"}, {9, "dokuz"}
    };
    
    private static Dictionary<int, string> BasOnlar = new()
    {
        {1, "on"}, {2, "yirmi"}, {3, "otuz"}, {4, "kırk"}, {5, "elli"}, {6, "altmış"}, {7, "yetmiş"}, {8, "seksen"}, {9, "doksan"}
    };

    private static Dictionary<int, string> UcluGrup = new()
    {
        { 0, "" }, { 1, "bin" }, { 2, "milyon" }, { 3, "milyar" }, { 4, "trilyon" }, { 5, "katrilyon" },
        { 6, "kentilyon" }, { 7, "sekstilyon" }, { 8, "septilyon" }, { 9, "oktilyon" }
    };

    public static string Oku(this int deger)
    {
        int ucl = 0;
        int rakam = 0;
        string metin = "";
        do
        {
            int pos = 0;
            do
            {
                rakam = deger % 10;
                metin = pos switch
                {
                    0 => $"{BasBirler[rakam]} {metin}",
                    1 => $"{BasOnlar[rakam]} {metin}",
                    _ => $"{(rakam == 1 ? string.Empty : BasBirler[rakam])} yüz {metin}"
                };
                deger /= 10;
                pos++;
            } while (pos < 3 && deger != 0);
            
            ucl++;
            metin = $"{(rakam == 1 ? string.Empty : UcluGrup[ucl])} {metin}";
        } while (deger != 0);
        
        return metin.Trim();
    }
}