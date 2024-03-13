#
#       Ferit Yiğit BALABAN
#       032190002
#

from os import fork, getpid # fork fonksiyonu, os modülünden import edilir

def main():
    if fork() != 0: # process'i forkla (fork1)
        # bu kısım fork1 tarafından açığa çıkarılan parent process için çalışır
        if fork() == 0: # process'i forkla (fork2)
            # bu kısım fork2 tarafından açığa çıkarılan child process için çalışır
            fork() # process'i forkla (fork3)
            print("1 ", end="") # fork3'ün hem parent hem de child process'leri tarafından yazdırılır
        else:
            # bu kısım fork2 tarafından açığa çıkarılan parent process için çalışır
            print("2 ", end="") # fork2'nin parent process'i tarafından yazdırılır
    else:
        # bu kısım fork1 tarafından açığa çıkarılan child process için çalışır
        print("3 ", end="") # fork1'in child process'i tarafından yazdırılır
    print("4 ", end="") # tüm forklar (1, 2 ve 3) tarafından açığa çıkarılan process'ler tarafından yazdırılır
    
    exit(code=0) # C'deki return 0'ya karşılık olarak exit(0) ile 0 değeri döndürülürken process sonlandırılır


if __name__ == "__main__":
    main()
