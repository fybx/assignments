//
// Created by ferit on 10/04/23.
//

#include "stdlib.h"

#include "ikiliagac.h"

IkiliAgac* yeni_ikiliagac() {
    IkiliAgac* a    = (IkiliAgac*)calloc(1, sizeof(IkiliAgac));
    a->kok          = NULL;
    return a;
}