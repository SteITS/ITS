class ContoCorrente:
    numconti=-1 #variabile di clasee che indica il num di conti creati
    def __init__(self,saldo=0):
        self.__saldo = saldo;
        ContoCorrente.numconti += 1
        self.__numconto = ContoCorrente.numconti;
        self.__movim=[]
        self.__proprietario = [];


    def get_saldo(self):
        return self.__saldo
    def get_numconto(self):
        return self.__numconto
    def get_movim(self):
        return self.__movim
    def get_proprietario(self):
        return self.__proprietario
    
    def set_saldo(self,valore):
        self.__saldo=valore
    def set_numconto(self,nconto):
        self.__saldo=nconto
    def set_proprietario(self,p):
        self.__proprietario.append(p)
        
    
    
    def versamento(self,op):
        if(op < 0):
            s="Versamento non si può fare se valore negativo"
            #return -1 #versamento non si può fare se valore neg
        else:
            self.__saldo +=op
            self.__movim.append("Versamento: "+str(op))
            s="Versamento effettuato"
        return s
            #return 0;
        
    def prelievo(self,op):
        if(op<0):
            s="prelievo non svolto; valore negativo"
        else:
            if(self.__saldo<op):
                self.__saldo -= op
                self.__movim.append("Prelievo: "+str(-op))
                
                s="Il prelievo è superiore al saldo; lo sconfinamento prevede interessi del 2%"
            else:
                self.__saldo -= op
                self.__movim.append("Prelievo: "+str(-op))
                
                s="prelievo effettuato"
        return s
    
    def __str__(self):
        st="ContoCorrente N.: "+str(self.__numconto)+"\nSaldo: "+str(self.__saldo)+"€\n" 
        for m in self.__movim:
            st += str(m) + "\n"
        for i in self.__proprietario:
            st += str(i) + "\n"
        return st;
        

'''    @property
    def _saldo(self):
        return self.__saldo

    @_saldo.setter
    def _saldo(self, value):
        self.__saldo = value

    @property
    def _movim(self):
        return self.__movim

    @_movim.setter
    def _movim(self, value):
        self.__movim = value

    @property
    def _proprietario(self):
        return self.__proprietario

    @_proprietario.setter
    def _proprietario(self, value):
        self.__proprietario = value'''