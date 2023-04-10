/*
 *          Ferit Yiğit BALABAN <fybalaban@fybx.dev>
 *          032190002
 *
 *          dugum.c
 */

#include <stdlib.h>
#include "dugum.h"

Dugum* yeni_dugum(int deger) {
    Dugum* d    = (Dugum*)calloc(1, sizeof(Dugum));
    d->deger    = deger;
    d->sonraki  = NULL;
    return d;
}

int dugum_guncelle(Dugum* dugum, int deger) {
    if (!dugum)
        return -1;

    dugum->deger = deger;
    return 0;
}

IkiliDugum* yeni_ikilidugum(int deger) {
    IkiliDugum* d   = (IkiliDugum*)calloc(1, sizeof(IkiliDugum));
    d->deger        = deger;
    d->sag          = NULL;
    d->sol          = NULL;
    return d;
}

int ikilidugum_guncelle(IkiliDugum* dugum, int deger) {
    if (!dugum)
        return -1;

    dugum->deger = deger;
    return 0;
}