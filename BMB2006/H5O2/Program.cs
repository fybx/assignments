/*
 *         Ferit Yiğit BALABAN, <fybalaban@fybx.dev>
 *         032190002
*/

// Ödev 2
// Hedef:
// Rastgele sayılar içeren iki yönlü bağlı listedeki sayının indisinin binary search ile getirilmesi

namespace H5O2;

class Program {
	private static void Main(string[] args) {
		BagliListe liste = new();
		liste.RastgeleOlustur(10);
		liste.Listele();

		Console.WriteLine("Hangi sayıyı bulmak istiyorsunuz: ");
		int arananSayi = Convert.ToInt32(Console.ReadLine());

		int bulunanIndis = liste.İkiliArayici(arananSayi);
		Console.WriteLine($"Aradığınız sayının indisi: {bulunanIndis}");
	}
}