#
#       Ferit Yiğit BALABAN
#       032190002
#

from os import fork, getpid # fork fonksiyonu, os modülünden import edilir

def main():
    if fork() != 0: # process'i forkla
        # bu kısım (dal) parent process tarafından çalıştırılacak
        print(f"Running parent, pid: {getpid()}") # parent process ekrana process ID'sini yazdırır
        while 1: # parent process sonsuz döngüye girer
            pass # Python'da "while 1:" kendi başına kullanılamaz, bu yüzden "hiçbir işlem yapma" manasına gelen (assembly'de nop/noop) pass ifadesi eklendi
    else:
        # bu kısım fork'un child process'inde çalışır
        print(f"Terminating child, pid: {getpid()}") # child process ekrana process ID'sini yazar
        exit(code=0) # C'deki return 0'ya karşılık olarak exit(0) ile 0 değeri döndürülürken child process sonlandırılır
    
    exit(code=0) # C'deki return 0'ya karşılık olarak exit(0) ile 0 değeri döndürülürken parent process sonlandırılır (parent process buraya asla ulaşamaz)


if __name__ == "__main__":
    main()
