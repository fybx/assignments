#
#       Ferit Yiğit BALABAN
#       032190002
#

import os
import shlex

MAX_LINE = 80  # Satır başına izin verilen karakter sınırı

def setup(input_buffer):
    """setup() komut satırından gelen girdiyi işler ve tokenlara ayırır.

    Args:
        input_buffer (str): Okunacak girdi tamponu.

    Returns:
        tuple: Argümanların listesini ve arkaplanda çalıştırılıp çalıştırılmayacağını belirten bayrağı içeren bir ikili tuple döndürür.
    """

    background = False  # arkaplanda çalıştırma bayrağı 
    args = []           # parse edilen argümanlar listesi

    for token in shlex.split(input_buffer):  # tokenlara ayırmayı kolaylaştırmak için shlex'ten yararlanıyoruz
        if token == '&': # eğer token "&" ise arkaplanda çalıştırma bayrağını True ayarla
            background = True
        else: # değilse argüman listesine ekle
            args.append(token)

    return args, background # argüman listesi ve arkaplanda çalıştırma bayrağını döndür

def main():
    """Program akışının ana dalı."""

    while True: # Sonsuz döngüde girdi al => işle => çalıştır
        background = 0 # arkaplanda çalıştırma bayrağı
        print("COMMAND->", end="") # ekrana komut satırını yazdır
        input_buffer = input() # kullanıcıdan girdi al ve tampona yaz

        args, background = setup(input_buffer) # setup fonksiyonunu çağırarak girdiyi işle ve argüman listesiyle arkaplan bayrağını al

        # komut satırında verilen programı başlatmak için fork yap, child process için process ID'yi sakla
        pid = os.fork()

        if pid == 0: # child process bu kod bloğunu/dalını çalıştıracak
            # execvp ile komut satırında verilen programı çalıştır
            os.execvp(args[0], args)
        else:  # parent process bu kod bloğunu/dalını çalıştıracak
            if not background: # eğer arkaplanda çalıştırma bayrağı False ise
                os.waitpid(pid, 0) # biraz önce yaratılan ve şu an bir komutu yürüten child process'in bitmesini bekle
        
        # bir döngü tamamlandığında
        # kullanıcıdan girdi alındı
        # girdi setup() ile işlendi
        # komut bulundu ve program olarak çalıştırılmak üzere process forklandı
        # yaratılan child process programı çalıştırmaya başladı
        # arkaplanda çalıştır bayrağı True ise parent process child process'in bitmesini beklemeden döngüye devam etti
        # arkaplanda çalıştır bayrağı False ise parent process child process'in bitmesini bekledi
        # döngü tekrar başa döndü 

if __name__ == "__main__":
    main()
