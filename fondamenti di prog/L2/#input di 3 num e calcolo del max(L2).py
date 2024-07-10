#input di 3 num e calcolo del max
def main():
    a=int(input("inserisci il primo num:"))
    b=int(input("inserisci il secondo num:"))
    c=int(input("inserisci il terzo num:"))
    print("il max è:", max(a,b,c))
    if(c>b and c>=a):
        print("max e' ",c)
    if(b>a and b>=c):
        print("max e' ",b)
    if(a>b and a>=c):
        print("max e' ",a)
        
main()