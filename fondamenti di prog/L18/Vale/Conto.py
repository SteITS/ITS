from Persona import Persona

class ContoCorrente:
    numconti=0  # variabile di classe
    def __init__(self,saldo):
        self.__saldo=saldo
        self.__proprietari:list[Persona]=[]  #riferimento all'oggetto elenco Persona per l'associaizone
        self.__movim=[]
        ContoCorrente.numconti +=1  
        self.__numconto=ContoCorrente.numconti  #variabile di istanza per conservare il numero di contocorrente

    def getSaldo(self):
        return self.__saldo

    def setSaldo(self, valore):
        self.__saldo=valore
    
    def getNumconto(self):
        return self.__numconto

    def getProprietari(self):
        return self.__proprietari
    
    def setProprietari(self, p:Persona): #associa una persona al conto
        self.__proprietari.append(p)

    def versamento(self,op):
        if op<0:
            #se op è negativo versamento non si può fare e ritorna -1 al main
            return -1
        else:
            self.__saldo +=op
            self.__movim.append("Versamento: "+str(op))
            return 0
    def prelievo(self,op):
        if op<0:
            return -1 #prelievo negativo non si può fare
        else:
            self.__saldo -=op
            self.__movim.append("Prelievo: "+str(-op))
            return 0
    def __str__(self):
        st="ContoCorrente N.: "+str(self.__numconto)+"\nSaldo: "+ str(self.__saldo)+"\n"
        #st += "\n".join(str(m) for m in self.__movim)         
        for m in self.__movim:
            st += str(m)+"\n"
        return st


                            
    