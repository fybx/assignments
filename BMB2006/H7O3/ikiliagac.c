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

    return NULL;
}

IkiliDugum* ara_rekursif_base(IkiliDugum* dugum, int deger) {
    if (!dugum)
        return NULL;
    if (dugum->deger == deger)
        return dugum;

    if (dugum->deger > deger) {
        return ara_rekursif_base(dugum->sol, deger);
    } else {
        return ara_rekursif_base(dugum->sag, deger);
    }
}

IkiliDugum* ara_rekursif(IkiliAgac* agac, int deger) {
    return ara_rekursif_base(agac->kok, deger);
}

IkiliDugum* ara_min_iteratif(IkiliAgac* agac) {
    IkiliDugum* gezgin = agac->kok;

    while(gezgin->sol)
        gezgin = gezgin->sol;

    return gezgin;
}

IkiliDugum* ara_max_iteratif(IkiliAgac* agac) {
    IkiliDugum* gezgin = agac->kok;

    while(gezgin->sag)
        gezgin = gezgin->sag;

    return gezgin;
}

int ikiliagac_ekle(IkiliAgac* agac, int deger) {
    IkiliDugum* d = yeni_ikilidugum(deger);
    IkiliDugum* g;

    if (!agac)
        return -1;
    if (!(agac->kok)) {
        agac->kok = d;
        return 0;
    }
    g = agac->kok;
    while (g) {
        if (deger == g->deger) {
            free(d);
            return -1;
        }
        else if (deger < g->deger) {
            if (g->sol)
                g = g->sol;
            else {
                g->sol = d;
                return 0;
            }
        }
        else {
            if (g->sag)
                g = g->sag;
            else {
                g->sag = d;
                return 0;
            }
        }
    }
}