#crea una calcolatrice
def main():
    from math import sqrt
    a=int(input("inserisci il primo num: "))
    op=str(input("inserisci un operazione tra +,-,*,/,sqrt: "))
    '''if(op=="+"):
        ris=a+c
    if(op=="-"):
        ris=a-c
    if(op=="*"):
        ris=a*c
    if(op=="/"):
        ris=a/c
    if(op=="sqrt"):
        ris=sqrt(a,c)'''
    if(op!="sqrt"):
        c=int(input("inserisci il terzo num: "))
        match op:
            case "+":
                ris=a+c
            case "-":
                ris=a-c
            case "*":
                ris=a*c
            case "/":
                ris=a/c
                print(ris)
    else:
        print(sqrt(a))


main()