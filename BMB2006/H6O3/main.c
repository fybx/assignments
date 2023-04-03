/*
 *          Ferit Yiğit BALABAN <fybalaban@fybx.dev>
 *          032190002
 */
#include <stdlib.h>


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

int main() {
    return 0;
}

Dugum* yeniDugum(int oncelik, int deger) {
    Dugum* d    = (Dugum*)calloc(1, sizeof(Dugum));
    d->oncelik  = oncelik;
    d->deger    = deger;
    d->sonraki  = NULL;
    return d;
}

OKuyruk* yeniKuyruk() {
    OKuyruk* k  = (OKuyruk*)calloc(1, sizeof(OKuyruk));
    k->bas      = NULL;
    return k;
}
