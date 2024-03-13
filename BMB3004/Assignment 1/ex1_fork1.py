#
#       Ferit Yiğit BALABAN
#       032190002
#

from os import fork # fork fonksiyonu, os modülünden import edilir

def main():
    print("Message before the fork") # Bu mesaj bir kez yazdırılacak çünkü fork'tan önce geliyor
    fork() # fork'tan sonra, her iki process de aynı kodu çalıştırmaya devam edecek
    print("Message after the fork") # Bu mesaj her iki process tarafından da yazdırılacak
    exit(code=0) # C'deki return 0'ya karşılık olarak exit(0) ile 0 değeri döndürülürken process sonlandırılır


if __name__ == "__main__":
    main()
