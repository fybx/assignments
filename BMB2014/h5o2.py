#!/usr/bin/env python3
#
#       Ferit Yigit BALABAN, <fybalaban@fybx.dev>
#       032190002
#       Hedef:
#       Sayı tahmin oyunu
import random


def sayi_kiyasla(sayi: int, tahmin: int):
    """
    Asıl sayı ile tahmini kıyaslar ve ipucu string'i üretir
    """
    # Sayı + pozisyon eşleşti => *
    # Sayı eşleşti => +
    # Eşleşme yok => bilgi yok


def sayi_uret():
    """
    Rastgele 4 basamaklı bir sayı üretir.
    Sınırlar dahil olmak üzere 1000 ile 9999 arasındadır.
    """
    return random.randint(1000, 9999)


def main():
    # sayi_uret()
    # oyuncudan tahmin al
    # tahmin vs sayi kıyasla
    # sonuca göre oyunu bitir veya devam et
    deneme = 0
    sayi = sayi_uret()
    oyun = True
    while oyun:
        tahmin = int(input("Tahminini gir: "))
        ipucu = sayi_kiyasla(sayi, tahmin)
        if ipucu == "****":
            # Tümü eşleşti & oyun kazanılır
            oyun = False
            print(deneme, "denemede kazandınız.")
        else:
            # Oyuna devam
            print(ipucu)
            deneme += 1


if __name__ == "__main__":
    main()
