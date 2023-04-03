/*
 *          Ferit Yiğit BALABAN <fybalaban@fybx.dev>
 *          032190002
 */
#include <stdlib.h>
#include <stdio.h>

struct dugum {
    int oncelik;
    int deger;
    struct dugum* sonraki;
};
typedef struct dugum Dugum;

struct oncelikliKuyruk {
    int uzunluk;
    Dugum* bas;
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
    /* Hastaneye gelenlerin yaşlarına göre önceliklendirilmesi */
    /*  0-10 & 60-70: 1 */
    /* 10-20 & 50-60: 2 */
    /* 20-30 & 40-50: 3 */
    /*         30-40: 4 */
    OKuyruk* hastalar = yeniKuyruk();
    elemanEkle(hastalar, 4, 33);
    elemanEkle(hastalar, 3, 25);
    elemanEkle(hastalar, 3, 22);
    elemanEkle(hastalar, 3, 28);
    elemanEkle(hastalar, 2, 52);
    elemanEkle(hastalar, 1, 3);
    printf("Hastalar:\n");
    kuyrukListele(hastalar);
    printf("En öncelikli ile ilgilen\n");
    printf("%d yaşındaki hastaya baktık.\n", elemanCikart(hastalar));
    printf("Sırada kalanlar:\n");
    kuyrukListele(hastalar);
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
    k->uzunluk  = 0;
    return k;
}

int kuyrukBos(OKuyruk* sorgu) {
    /* https://stackoverflow.com/a/3825704 */
    return (!sorgu) ? -1 : sorgu->uzunluk;
}

void elemanEkle(OKuyruk* kuyruk, int oncelik, int deger) {
    Dugum* uc   = kuyruk->bas;
    Dugum* yeni = yeniDugum(oncelik, deger);
    if (!(kuyruk->bas)) {
        kuyruk->bas = yeni;
    } else if (oncelik < kuyruk->bas->oncelik) {
        yeni->sonraki = kuyruk->bas;
        kuyruk->bas = yeni;
    } else {
        while(uc->sonraki && oncelik >= uc->sonraki->oncelik)
            uc = uc->sonraki;
        yeni->sonraki = uc->sonraki;
        uc->sonraki = yeni; 
    }
    kuyruk->uzunluk++;
}

int elemanCikart(OKuyruk* kuyruk) {
    Dugum* bas  = kuyruk->bas;
    int eleman  = bas->deger;
    kuyruk->bas = kuyruk->bas->sonraki;
    kuyruk->uzunluk--;
    free(bas);
    return eleman;
}

void kuyrukListele(OKuyruk* sorgu) {
    Dugum* bas = sorgu->bas;
    while(bas) {
        if (bas->sonraki)
            printf("[%d]->", bas->deger);
        else
            printf("[%d].", bas->deger);
        bas = bas->sonraki;
    }
    printf("\n");
}
