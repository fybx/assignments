#
#       Ferit Yiğit BALABAN
#       032190002
#

from os import fork # fork fonksiyonu, os modülünden import edilir
from os import getpid # getpid fonksiyonu, os modülünden import edilir

def main():
    print(f"({getpid()}) Parent does something...") # Parent process'in yaptığı işlemler yazdırılır
    if fork() != 0: # fork'un başarılı olup olmadığı parent process tarafından kontrol edilir
        print(f"({getpid()}) Parent do completely different stuff...") # Parent process'in yapmaya devam ettiği işlemler yazdırılır
    else:
        print(f"({getpid()}) Child can do some stuff") # Child process'in yapmaya devam ettiği işlemler yazdırılır
    
    exit(code=0) # C'deki return 0'ya karşılık olarak exit(0) ile 0 değeri döndürülürken process sonlandırılır


if __name__ == "__main__":
    main()
