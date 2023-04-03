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

void tik(Yigin*, int);
int al(Yigin*);

void sirayaKoy(Kuyruk*, int);
int siradanAl(Kuyruk*);

int main() {
    printf("Hello, World!\n");
    return 0;
}

Dugum* dugumYap(int deger) {
    Dugum* d    = (Dugum*)calloc(1, sizeof(Dugum));
    d->deger    = deger;
    d->sonraki  = NULL;
    return d;
}