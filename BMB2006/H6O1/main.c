/*
 *      Ferit Yiğit BALABAN <fybalaban@fybx.dev>
 *      032190002
 */
#include <stdio.h>
#include <stdlib.h>

struct dugum {
    int             deger;
    struct dugum*   sonraki;
};
typedef struct dugum Dugum;

struct yigin {
    Dugum*  bas;
    int     uzunluk;
};
typedef struct yigin Yigin;

struct kuyruk {
    Dugum*  bas;
    int     uzunluk;
};
typedef struct kuyruk Kuyruk;

Dugum* dugumYap(int);

Yigin* yiginYap();
void tik(Yigin*, int);
int al(Yigin*);

Kuyruk* kuyrukYap();
void sirayaKoy(Kuyruk*, int);
int siradanAl(Kuyruk*);

int palindrom(const char*);

int main() {
    char str[11];
    printf("(maks. 10 harf) Kelime girin: ");
    scanf("%s", str);
    if (palindrom(str))
        printf("Kelime %s palindrom.\n", str);
    else
        printf("Kelime %s palindrom degil.\n", str);
    return 0;
}

Dugum* dugumYap(int deger) {
    Dugum* d    = (Dugum*)calloc(1, sizeof(Dugum));
    d->deger    = deger;
    d->sonraki  = NULL;
    return d;
}

Yigin* yiginYap() {
    Yigin* y    = (Yigin*)calloc(1, sizeof(Yigin));
    y->bas      = NULL;
    y->uzunluk  = 0;
    return y;
}

Kuyruk* kuyrukYap() {
    Kuyruk* k   = (Kuyruk*)calloc(1, sizeof(Kuyruk));
    k->bas      = NULL;
    k->uzunluk  = 0;
    return k;
}

void tik(Yigin* yigina, int bunu) {
    Dugum* yeni = dugumYap(bunu);
    if (!(yigina->bas))
        yigina->bas = yeni;
    else {
        /* Yığının başı varmış, başın soluna tak */
        yeni->sonraki = yigina->bas;
        yigina->bas = yeni;
    }
    yigina->uzunluk++;
}

int al (Yigin* yigindan) {
    if ((yigindan->bas)) {
        /* yığının başı varmış, alma yapılabilir */
        int deger = yigindan->bas->deger;
        Dugum* kopartici = yigindan->bas;
        yigindan->bas = yigindan->bas->sonraki;
        free(kopartici);
        yigindan->uzunluk--;
        return deger;
    }
}

void sirayaKoy(Kuyruk* kuyruk, int eleman) {
    Dugum* yeni = dugumYap(eleman);
    Dugum* uc   = kuyruk->bas;
    if (!(kuyruk->bas)) {
        /* kuyruğun başı yok => ilk elemanı ekliyoruz */
        kuyruk->bas = yeni;
    } else {
        /* kuyruğun başı var => en sona ekliyoruz */
        while(uc && uc->sonraki)
            uc = uc->sonraki;
        uc->sonraki = yeni;
    }
    kuyruk->uzunluk++;
}

int siradanAl(Kuyruk* kuyruk) {
    int deger;
    Dugum* kopartici = kuyruk->bas;
    if ((kuyruk->bas)) {
        deger = kuyruk->bas->deger;
        kuyruk->bas = kuyruk->bas->sonraki;
        free(kopartici);
        kuyruk->uzunluk--;
        return deger;
    }
}

int palindrom(const char* kelime) {
    int u;
    int i = 0;
    Kuyruk* k = kuyrukYap();
    Yigin*  y = yiginYap();

    while (*(kelime + i)) {
        sirayaKoy(k, *(kelime + i));
        tik(y, *(kelime + i));
        i++;
    }
    u = k->uzunluk;
    while (k->uzunluk >= u / 2) {
        if (al(y) != siradanAl(k))
            return 0;
    }
    return 1;
}