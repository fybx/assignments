/*
 *          Ferit Yiğit BALABAN <fybalaban@fybx.dev>
 *          032190002
 */


struct dugum {
    int oncelik;
    int deger;
    struct dugum* sonraki;
};
typedef struct dugum Dugum;

struct oncelikliKuyruk {
    struct oncelikliKuyruk* bas;
};
typedef struct oncelikliKuyruk OKuyruk;

/* Düğüme ait pointer'ı typedef'le kullanmıyoruz */
/* https://www.kernel.org/doc/html/v4.10/process/coding-style.html#typedefs */

Dugum* yeniDugum(int, int);
OKuyruk* yeniKuyruk();
int kuyrukBos(OKuyruk*);
void elemanEkle(OKuyruk*, int, int);
int elemanCikart(OKuyruk*);
void kuyrukListele(OKuyruk*);
