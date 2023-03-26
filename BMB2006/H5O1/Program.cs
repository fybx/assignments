/*
 *         Ferit Yiğit BALABAN, <fybalaban@fybx.dev>
 *         032190002
*/

// Ödev 1
// Hedef:
// İki yönlü bağlı liste yapısının bir array olarak kullanıcıya sunulması

namespace H5O1;

class Program {
	private static void Main(string[] args) {
		BagliListe liste = new();
		Console.WriteLine("Diziye ekleyeceğiniz sayıları virgülle ayırarak giriniz.");
		string[] sayilar = Console.ReadLine()
			.Split(",", StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);

		foreach (string sayi in sayilar) {
			liste.SonaEkle(Convert.ToInt32(sayi));
		}

		liste.Listele();
	}
}