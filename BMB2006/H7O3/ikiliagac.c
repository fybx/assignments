/*
 *          Ferit Yiğit BALABAN <fybalaban@fybx.dev>
 *          032190002
 *
 *          ikiliagac.c
 */

#include "stdlib.h"

#include "ikiliagac.h"

IkiliAgac* yeni_ikiliagac() {
    IkiliAgac* a    = (IkiliAgac*)calloc(1, sizeof(IkiliAgac));
    a->kok          = NULL;
    return a;
}

IkiliDugum* ara_iteratif(IkiliAgac* agac, int deger) {
    IkiliDugum* gezgin = agac->kok;

    while(gezgin) {
        if (gezgin->deger == deger)
            return gezgin;
        else if (gezgin->deger > deger) {
            gezgin = gezgin->sol;
        } else {
            gezgin = gezgin->sag;
        }
    }
}