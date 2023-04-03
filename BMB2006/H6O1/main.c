/*
 *      Ferit Yiğit BALABAN <fybalaban@fybx.dev>
 *      032190002
 */
#include <stdio.h>

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

int main() {
    printf("Hello, World!\n");
    return 0;
}