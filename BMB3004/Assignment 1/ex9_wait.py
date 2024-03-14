#
#       Ferit Yiğit BALABAN
#       032190002
#

from os import fork, wait # fork fonksiyonu, os modülünden import edilir

def WIFEXITED(status): # C'de sys/wait.h header dosyasında tanımlanan WIFEXITED sembolünün karşılığını tanımlıyoruz
    return status & 0x7f == 0


def WEXITSTATUS(status): # C'de sys/wait.h header dosyasında tanımlanan WEXITSTATUS sembolünün karşılığını tanımlıyoruz
    return status & 0xff00 >> 8


def main():
    numOfChilds = 5 # kaç child process yaratılacağını belirleyen sabit sayı
    
    child_status: int = 0 # izlenen child process'in sona erince bildirdiği status code
    wpid: int = 0; # izlenen child process'in process ID'si
    pid: list[int] = [] # yaratılan child process ID'ler listesi
    
    for i in range(0, numOfChilds): # i: 0'dan numOfChilds-1 değerlerini alır
        pid.append(fork()) # forkla ve dönen process ID'yi listeye ekle
        if pid[i] == 0: # process ID sıfırsa (child process bu dalı çalıştırır)
            exit(100 + i) # child process 100+i status code döndürerek sona erer
            
    # parent process buradan çalışmaya devam eder
    for i in range(0, numOfChilds): # 0'dan numOfChilds-1 
        wpid, child_status = wait() # yaratılan child processler birer birer beklenir
        # wpid'e child process'in ID'si, child_status'e ise child process'in sona ererken döndüğü process ID kaydedilir
        if WIFEXITED(child_status): # eğer child process'in status code'u bitmiş bir process'i kodladıysa
            print(f"Child {wpid} terminated with exit status {child_status}") # child_status koduyla çıkış yapan wpid ID'li child process ekrana yazılır
        else:
            print(f"Child {wpid} terminate abnormally") # eğer child process düzgün sonlanmadıysa wpid yani child process'in ID'si ekrana yazılır
    
    exit(code=0) # C'deki return 0'ya karşılık olarak exit(0) ile 0 değeri döndürülürken parent process sonlandırılır (parent process buraya asla ulaşamaz)


if __name__ == "__main__":
    main()
