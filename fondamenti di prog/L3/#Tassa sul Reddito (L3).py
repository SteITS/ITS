#Tassa sul Reddito (L3)
def main():
    reddito=float(input("inserisci il reddito: "))
    if(reddito<85528):
        finale=(reddito*0.18)-556.02
    else:
            finale=((reddito-85528)*0.32)+14839.02
    if(finale<=0):
         print("Non hai imposte da pagare")
    else:
        print("L'imposta finale e' di",round(finale),"talleri")
main()