/*
 *          Ferit Yiğit BALABAN <fybalaban@fybx.dev>
 *          032190002
 *
 *          main.c
 */

/*
 *          Hedef:
 *          Oluşturulan bir modelin geçerli bir veri ağacı olup
 *          olmadığını test eden fonksiyon.
 */

#include <stdlib.h>
#include <stdio.h>

#include "ikiliagac.h"

int main() {
    IkiliAgac* gecerli_agac = yeni_ikiliagac();
    ikiliagac_ekle(gecerli_agac, 5);
    ikiliagac_ekle(gecerli_agac, 3);
    ikiliagac_ekle(gecerli_agac, 8);
    ikiliagac_ekle(gecerli_agac, 2);
    ikiliagac_ekle(gecerli_agac, 4);
    ikiliagac_ekle(gecerli_agac, 7);
    ikiliagac_ekle(gecerli_agac, 9);

    IkiliAgac* gecersiz_agac = yeni_ikiliagac();
    gecersiz_agac->kok = yeni_ikilidugum(2);
    gecersiz_agac->kok->sol = yeni_ikilidugum(2);
    gecersiz_agac->kok->sol->sol = yeni_ikilidugum(2);
    gecersiz_agac->kok->sol->sol->sol = yeni_ikilidugum(2);
    gecersiz_agac->kok->sol->sol->sol->sol = yeni_ikilidugum(2);

    printf("Test 1: gecerli_agac:\n");
    ikiliagac_dolas_inorder(gecerli_agac);
    if (ikiliagac_dogrula(gecerli_agac, 5))
        printf("\nBu yapı geçerli bir ağaç\n");
    else
        printf("\nBu yapı geçerli bir ağaç değil\n");

    printf("Test 2: gecersiz_agac:\n");
    ikiliagac_dolas_inorder(gecersiz_agac);
    if (ikiliagac_dogrula(gecersiz_agac, 5))
        printf("\nBu yapı geçerli bir ağaç");
    else
        printf("\nBu yapı geçerli bir ağaç değil");

    free(gecerli_agac);
    free(gecersiz_agac);
    return 0;
}
