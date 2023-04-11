/*
 *          Ferit Yiğit BALABAN <fybalaban@fybx.dev>
 *          032190002
 *
 *          ikiliagac.h
 */

#include "dugum.h"

#ifndef H7O3_IKILIAGAC_H
#define H7O3_IKILIAGAC_H

#endif //H7O3_IKILIAGAC_H

struct agac {
    IkiliDugum* kok;
};
typedef struct agac IkiliAgac;

IkiliAgac* yeni_ikiliagac();
IkiliDugum* ara_iteratif(IkiliAgac*, int);
IkiliDugum* ara_rekursif(IkiliAgac*, int);
IkiliDugum* ara_min_iteratif(IkiliAgac*);
IkiliDugum* ara_max_iteratif(IkiliAgac*);

int ikiliagac_ekle(IkiliAgac*, int);
void ikiliagac_dolas_inorder(IkiliAgac*);
void ikiliagac_dolas_preorder(IkiliAgac*);
void ikiliagac_dolas_postorder(IkiliAgac*);

int ikiliagac_dogrula(IkiliAgac*, int);
void ikiliagac_ciz(IkiliAgac*);