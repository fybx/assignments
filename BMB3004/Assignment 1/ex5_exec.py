#
#       Ferit Yiğit BALABAN
#       032190002
#

from os import execl, fork # fork fonksiyonu, os modülünden import edilir

def main():
    print("Parent does stuff and then calls fork...") # parent process tarafından yazdırılır
    
    if fork() != 0: # process'i forkla (fork1)
        # bu kısım fork1 tarafından açığa çıkarılan parent process için çalışır
        print("... parent do something completely different") # parent process tarafından yazdırılır
    else:
        # bu kısım fork1 tarafından açığa çıkarılan child process için çalışır
        print("Child runs an executable...") # child process tarafından yazdırılır
        execl("/bin/ls", "/bin/ls", "-l", "/etc/apache2/conf.d/") # child process, /bin/ls programını verilen argümanlar ile çalıştırır
    
    exit(code=0) # C'deki return 0'ya karşılık olarak exit(0) ile 0 değeri döndürülürken process sonlandırılır


if __name__ == "__main__":
    main()
