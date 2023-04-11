/*
 *          Ferit Yiğit BALABAN <fybalaban@fybx.dev>
 *          032190002
 *
 *          ikiliagac.c
 */

#include <stdlib.h>
#include <stdio.h>
#include <math.h>
#include <limits.h>

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
    return 0;
}

void ikiliagac_dolas_inorder_base(IkiliDugum* dugum) {
    if (!dugum)
        return;

    ikiliagac_dolas_inorder_base(dugum->sol);
    printf("%d ", dugum->deger);
    ikiliagac_dolas_inorder_base(dugum->sag);
}

void ikiliagac_dolas_inorder(IkiliAgac* agac) {
    ikiliagac_dolas_inorder_base(agac->kok);
}

void ikiliagac_dolas_preorder_base(IkiliDugum* dugum) {
    if (!dugum)
        return;

    printf("%d ", dugum->deger);
    ikiliagac_dolas_preorder_base(dugum->sol);
    ikiliagac_dolas_preorder_base(dugum->sag);
}

void ikiliagac_dolas_preorder(IkiliAgac* agac) {
    ikiliagac_dolas_preorder_base(agac->kok);
}

void ikiliagac_dolas_postorder_base(IkiliDugum* dugum) {
    if (!dugum)
        return;

    ikiliagac_dolas_postorder_base(dugum->sol);
    ikiliagac_dolas_postorder_base(dugum->sag);
    printf("%d ", dugum->deger);
}

void ikiliagac_dolas_postorder(IkiliAgac* agac) {
    ikiliagac_dolas_postorder_base(agac->kok);
}

int ikiliagac_dogrula(IkiliAgac* agac, int derinlik) {
    if (!agac || !(agac->kok))
        return 1;

    int onceki = INT_MIN;
    IkiliDugum* g = agac->kok;
    int boyut = 0;
    /* https://stackoverflow.com/a/29787467 */
    IkiliDugum* d[(int)(pow(2,derinlik) + 0.5)];

    while (boyut > 0 || g) {
        while (g) {
            d[boyut++] = g;
            g = g->sol;
        }

        g = d[--boyut];

        if (g->deger <= onceki)
            return 0;

        onceki = g->deger;
        g = g->sag;
    }
    return 1;
}