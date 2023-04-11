/*
 *          Ferit Yiğit BALABAN <fybalaban@fybx.dev>
 *          032190002
 *
 *          main.c
 */

/*
 *          Hedef: Rastgele sayılarla oluşturulan 5 derinliğinde
 *          ağacı inorder, preorder ve postorder yöntemleri ile dolaş.
 */
#include <stdio.h>
#include <stdlib.h>
#include <time.h>

#include "ikiliagac.h"


int main() {
    srand(time(NULL));

    IkiliAgac* agac = yeni_ikiliagac();
    agac->kok = yeni_ikilidugum(rand() % 100);
    int i = 0;
    int v;

    for (; i < 31; i++) {
        v = rand() % 100;
        ikiliagac_ekle(agac, v);
    }

    printf("Inorder dolasma: ");
    ikiliagac_dolas_inorder(agac);
    printf("\n");
    printf("Preorder dolasma: ");
    ikiliagac_dolas_preorder(agac);
    printf("\n");
    printf("Postorder dolasma: ");
    ikiliagac_dolas_postorder(agac);
    printf("\n");

    free(agac);
    return 0;
}