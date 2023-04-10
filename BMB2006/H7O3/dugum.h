/*
 *          Ferit Yiğit BALABAN <fybalaban@fybx.dev>
 *          032190002
 *
 *          dugum.h
 */

#ifndef H7O3_DUGUM_H
#define H7O3_DUGUM_H

#endif //H7O3_DUGUM_H

struct dugum {
    int             deger;
    struct dugum*   sonraki;
};
typedef struct dugum Dugum;

struct ikili_dugum {
    int                     deger;
    struct ikili_dugum*     sag;
    struct ikili_dugum*     sol;
};
typedef struct ikili_dugum IkiliDugum;

Dugum* yeni_dugum(int);
int dugum_guncelle(Dugum*, int);