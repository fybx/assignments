/*
 *         Ferit Yiğit BALABAN, <fybalaban@fybx.dev>
 *         032190002
*/

namespace H5O2;

public class Dugum {
	public int deger;
	public Dugum sonrakiDugum;
	public Dugum oncekiDugum;

	public Dugum(int d) {
		deger = d;
		sonrakiDugum = null;
		oncekiDugum = null;
	}
}