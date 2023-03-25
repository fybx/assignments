#!/usr/bin/env python3
#
#       Ferit Yigit BALABAN, <fybalaban@fybx.dev>
#       032190002
#       Hedef:
#       List tipi üzerine stack ve queue yapılarının inşa edilmesi


def push(list: [], element):
    """
    Herhangi bir tipteki elemanı alır ve listenin sonuna ekler.
    """
    list += [element]


def pop(list: []):
    """
    Listenin sonundaki elemanı siler ve geri döndürür. 
    Liste boşsa None tipi döner.
    """
    if list:
        # Eğer liste boş değilse
        cache = list[-1]
        del list[-1]
        return cache
    return None


def main():
    print("""1. Boş bir liste oluşturuyoruz, 
2. sırasıyla T, İ, R, E, F karakterlerini push ediyoruz 
3. döngü ile None gelene dek listeyi pop ediyoruz, 
dönen karakterleri ekrana basıyoruz""")
    liste1 = []
    push(liste1, "T")
    push(liste1, "İ")
    push(liste1, "R")
    push(liste1, "E")
    push(liste1, "F")
    ch = pop(liste1)
    while ch is not None:
        print(ch, end="")
        ch = pop(liste1)


if __name__ == "__main__":
    main()
