/*
 *          Ferit Yiğit BALABAN <fybalaban@fybx.dev>
 *          032190002
 *
 *          dugum.c
 */

#include <stdlib.h>
#include "dugum.h"

Dugum* yeni_dugum(int deger) {
    Dugum *d    = (Dugum *) calloc(1, sizeof(Dugum));
    d->deger    = deger;
    d->sonraki  = NULL;
    return d;
}

int dugum_guncelle(Dugum* dugum, int deger) {
    if (!dugum)
        return -1;

    dugum->deger = deger;
    return deger;
}