#numeroPrimo(L8)
#un numero maggiore di 1 è primo se non ha divisori diversi da 1 e da se stesso
def is_primo(num):
    r=True
    for i in range(2,num):
        if num%i==0:
            r=False
            break
            #return False
    return r
        
def divisori(num):
    r=True
    divisori=[]
    for i in range(2,num):
        if num%i==0:
            r=False
            divisori.append(i)
        divisori.append(num)
        return r,divisori

def main():
    for i in range(1,20):
        if is_primo(i+1):
            print("numero ", i+1," è primo ")
        else:
            r,div=divisori(i+1)
            if(r==True):
                print("numero ",i+1," non primo: ","divisori: ",div)

            

main()