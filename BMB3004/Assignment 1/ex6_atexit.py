#
#       Ferit Yiğit BALABAN
#       032190002
#

from atexit import register as atexit # atexit modülünden register fonksiyonu import edilir, adı atexit olarak değiştirilir
from os import fork, getpid # fork fonksiyonu, os modülünden import edilir

def parentCleaner():
    print("cleaning up parent...")

def main():
    if fork() != 0:
        # bu kısım fork1 tarafından açığa çıkarılan parent process için çalışır
        atexit(parentCleaner) # parent process'in sonlandırılmasından önce parentCleaner fonksiyonu çağrılır
        print(f"this is parent {getpid()}") # parent process tarafından yazdırılır
    else:
        print(f"this is child {getpid()}") # child process tarafından yazdırılır
    
    exit(code=0) # C'deki return 0'ya karşılık olarak exit(0) ile 0 değeri döndürülürken process sonlandırılır


if __name__ == "__main__":
    main()
