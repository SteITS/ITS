def input_gen(st,tipo):
    while True:
        try:
            x=tipo(input(st))
            if tipo==str:
                if(x==""):
                    raise Exception()
            break
        except:
            print("Errore!!Input errato...")    
    return x
#controlla numero > m
def input_maggiore(st,tipo,m=0):
    while True:
        n=input_gen(st,tipo)
        if not (n>m):
            print("Input errato: Inserisci numero maggiore di "+str(m)+"!")
        else:
            break
    return n

def input_range(st,tipo,m1,m2):
    while True:
        n=input_gen(st,tipo)
        if not (n>=m1 and n<=m2):
            print("Input errato: Inserisci numero compreso tra "+str(m1)+" e "+str(m2)+"!")
        else:
            break
    return n    

def input_data(st):
    from datetime import datetime
    while True:
        stdata=input(st)
        try:
            d=datetime.strptime(stdata,'%d/%m/%Y')
            break
        except:
            print("Errore!!Data errata...")    
    return d
 