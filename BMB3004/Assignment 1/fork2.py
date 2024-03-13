#
#       Ferit Yiğit BALABAN
#       032190002
#

from os import fork # fork fonksiyonu, os modülünden import edilir
from os import getpid # getpid fonksiyonu, os modülünden import edilir

def main():
    
    print(f"process id: {getpid()}") # çalışan process'in id'si yazdırılır
    forkResult = fork() # process'in kopyası oluşturulur ve orijinal process'e kopyanın id'si, kopyaya 0 değeri döndürülür
    print(f"process id: {getpid()} - result: {forkResult}") # çalışan process'in id'si ve fork fonksiyonunun dönüş değeri yazdırılır
    exit(code=0) # C'deki return 0'ya karşılık olarak exit(0) ile 0 değeri döndürülürken process sonlandırılır


if __name__ == "__main__":
    main()
