#!/usr/bin/env python3
#
#       Ferit Yigit BALABAN, <fybalaban@fybx.dev>
#       032190002
#       Hedef:
#       Sayı tahmin oyunu
import random


def sayi_bol(sayi: int):
    """
    Aldığı sayıyı rakam rakam liste haline getirir.
    """
    rakamlar = []
    while sayi > 0:
        rakamlar.insert(0, sayi % 10)
        sayi //= 10
    return rakamlar


def sayi_kiyasla(sayi: int, tahmin: int):
    """
    Asıl sayı ile tahmini kıyaslar ve ipucu string'i üretir
    """
    # Sayı + pozisyon eşleşti => *
    # Sayı eşleşti => +
    # Eşleşme yok => bilgi yok
    ipucu = ""

    # Önce sayıların eşleşmesini kontrol et,
    # eşleşen sayı varsa da pozisyonu kontrol et

    # Sayıların incelenmesinde iki yok izlenebilir:
    # 1. Sayılar string'e çevrilerek kıyaslanır
    # 2. Sayılar basamak basamak listeye bölünür ve kıyaslanır
    # ben 2. seçeneği tercih edeceğim
    sayi_l = sayi_bol(sayi)
    tahm_l = sayi_bol(tahmin)

    indis = 0
    for rakam in tahm_l:
        if rakam in sayi_l:
            if rakam == sayi_l[indis]:
                ipucu += "*"
                indis += 1
                continue
            ipucu += "+"
        indis += 1
    return ipucu


def sayi_uret():
    """
    Rastgele 4 basamaklı bir sayı üretir.
    Sınırlar dahil olmak üzere 1000 ile 9999 arasındadır.
    """
    return random.randint(1000, 9999)


def main():
    # Oyun mantığı:
    # 1. sayi_uret()
    # 2. oyuncudan tahmin al
    # 3. tahmin ve sayi'yi kıyasla
    # 4. sonuca göre oyunu bitir veya devam et
    deneme = 0
    sayi = sayi_uret()
    oyun = True
    while oyun:
        tahmin = int(input("Tahminini gir: "))
        ipucu = sayi_kiyasla(sayi, tahmin)
        if ipucu == "****":
            # Tümü eşleşti & oyun kazanılır
            print(deneme, "denemede kazandınız.")
            break
        elif deneme != 15:
            # Oyuna devam
            print("İpucu:", f"\"{ipucu}\".", 15 - deneme, "hakkınız kaldı.")
            deneme += 1
            continue
        print("Kaybettiniz.")
        oyun = False


if __name__ == "__main__":
    main()
