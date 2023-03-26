/*
 *         Ferit Yiğit BALABAN, <fybalaban@fybx.dev>
 *         032190002
*/

namespace H5O1;

public class BagliListe {
	private Dugum basDugum;

	public BagliListe() {
		this.basDugum = null;
	}

	public void BasaEkle(int deger) {
		Dugum yeni = new(deger);

		if(this.basDugum == null) {
			this.basDugum = yeni;
		}
		else {
			yeni.sonrakiDugum = this.basDugum;
			this.basDugum.oncekiDugum = yeni;
			this.basDugum = yeni;
		}
	}

	public void SonaEkle(int deger) {
		Dugum yeni = new(deger);

		if(this.basDugum == null) {
			this.basDugum = yeni;
		}
		else {
			Dugum curr = this.basDugum;

			while(curr.sonrakiDugum != null) {
				curr = curr.sonrakiDugum;
			}

			curr.sonrakiDugum = yeni;
			yeni.oncekiDugum = curr;
		}
	}

	public void Listele() {
		Dugum gezginUc = this.basDugum;

		while(gezginUc != null) {
			Console.Write(gezginUc.sonrakiDugum is null ? $"({gezginUc.deger})" : $"({gezginUc.deger})->");
			gezginUc = gezginUc.sonrakiDugum;
		}

		Console.WriteLine();
	}
}