#!/usr/bin/env python3
#
#       Ferit Yigit BALABAN, <fybalaban@fybx.dev>
#       032190002
#       Hedef:
#       List tipi üzerine stack ve queue yapılarının inşa edilmesi


def enqueue(list: [], element):
    """
    Herhangi bir tipteki elemanı alır ve listenin başına ekler.

    Listenin başındaki eleman son giren elemandır. 
    Bu işlem sıraya alma (enqueue) işlemidir.
    """
    list[:0] = [element]


def dequeue(list: []):
    """
    Listenin sonundaki elemanı siler ve geri döndürür.
    Liste boşsa None tipi döner.

    Listenin sonundaki eleman ilk giren elemandır.
    Bu işlem sıradan çıkarma (dequeue) işlemidir.
    """
    if list:
        cache = list[-1]
        del list[-1]
        return cache
    return None


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
    print("--- Ödev 1: Parça 1: List ile stack gerçeklenmesi ---")
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

    print("\n\n--- Ödev 1: Parça 2: List ile queue gerçeklenmesi ---")
    print("""1. 3 orta, 2 düşük, 1 yüksek öncelikli paket üretiyoruz
2. bunları enqueue ile listeye alıyoruz
3. ana listeden dequeue ederek öncelik alt queue'lara alıyoruz
4. böylece paketleri önceliğe göre sort etmiş oluyoruz""")
    liste2 = []
    paket1 = (1, "realtime audio")
    paket2 = (1, "realtime audio")
    paket3 = (1, "realtime audio")
    paket4 = (2, "game tick update")
    paket5 = (0, "email")
    paket6 = (0, "email")
    enqueue(liste2, paket1)
    enqueue(liste2, paket2)
    enqueue(liste2, paket3)
    enqueue(liste2, paket4)
    enqueue(liste2, paket5)
    enqueue(liste2, paket6)
    low_queue, mid_queue, hig_queue = [], [], []
    paket = dequeue(liste2)
    while paket is not None:
        if paket[0] == 0:
            enqueue(low_queue, paket)
        if paket[0] == 1:
            enqueue(mid_queue, paket)
        if paket[0] == 2:
            enqueue(hig_queue, paket)
        paket = dequeue(liste2)
    for paket in hig_queue:
        print(f"öncelik: {paket[0]}, paket: {paket[1]}")
    for paket in mid_queue:
        print(f"öncelik: {paket[0]}, paket: {paket[1]}")
    for paket in low_queue:
        print(f"öncelik: {paket[0]}, paket: {paket[1]}")


if __name__ == "__main__":
    main()
