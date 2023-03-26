/*
 *         Ferit Yiğit BALABAN, <fybalaban@fybx.dev>
 *         032190002
*/

namespace H5O2;

public class BagliListe {
	private Dugum basDugum;
	private int boyut;

	public BagliListe() {
		this.basDugum = null;
		this.boyut = 0;
	}

	public void BasaEkle(int deger) {
		Dugum yeni = new(deger);

		if(this.basDugum == null)
			this.basDugum = yeni;
		else {
			yeni.sonrakiDugum = this.basDugum;
			this.basDugum.oncekiDugum = yeni;
			this.basDugum = yeni;
		}

		this.boyut++;
	}

	public void SonaEkle(int deger) {
		Dugum yeni = new(deger);

		if(this.basDugum == null)
			this.basDugum = yeni;
		else {
			Dugum curr = this.basDugum;

			while(curr.sonrakiDugum != null)
				curr = curr.sonrakiDugum;

			curr.sonrakiDugum = yeni;
			yeni.oncekiDugum = curr;
		}

		this.boyut++;
	}

	public void Listele() {
		Dugum gezginUc = this.basDugum;

		while(gezginUc != null) {
			Console.Write(gezginUc.sonrakiDugum is null ? $"({gezginUc.deger})" : $"({gezginUc.deger})->");
			gezginUc = gezginUc.sonrakiDugum;
		}

		Console.WriteLine();
	}

	public void RastgeleOlustur(int boyut) {
		Random r = new();

		for (int i = 0; i < boyut; i++) {
			int deger = r.Next(10, 101);
			SonaEkle(deger);
		}
	}

	private int IndistekiDeger(int indis) {
		Dugum gezginUc = basDugum;
		int i = 0;

		while(gezginUc != null && i < indis) {
			gezginUc = gezginUc.sonrakiDugum;
			i++;
		}

		if(gezginUc == null) {
			throw new IndexOutOfRangeException();
		}

		return gezginUc.deger;
	}

	public int İkiliArayici(int deger) {
		int solDeger = 0;
		int sagDeger = this.boyut - 1;

		while(solDeger <= sagDeger) {
			int ortaIndis = (solDeger + sagDeger) / 2;
			int ortaDeger = IndistekiDeger(ortaIndis);

			if(ortaDeger == deger)
				return ortaIndis;

			if(ortaDeger < deger)
				solDeger = ortaIndis + 1;
			else
				sagDeger = ortaIndis - 1;
		}

		return -1;
	}
}