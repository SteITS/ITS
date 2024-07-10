class GestioneConti:
    def __init__(self):
        self.__elencoconti=[]
        
        
    def aggiungiconto(self,persone,conto):
        #conto =  ContoCorrente(saldo)
        for p in persone:
            #print(p,nome,cognome)
            #print(p.getNome(),p.getCognome())
            conto.setProprietari(p)
        self.__elencoconti.append(conto)    
    # persone_oggetti.append(oggetto)
        return True
    
    def prelievo(self,nconto,valore):
        trovato=False
        for c in  self.__elencoconti:
            if c.getNumconto()==nconto:
                res=c.prelievo(valore)
                trovato =True
                if res==0:  #versamento effettuato
                    return 0
                else:
                    return -1 #versamento non effettuato
        print(trovato)            
        if trovato==False:
            return -2	#conto non trovato
        
    def cercaconto(self,nconto):
        conto=None;
        for c in self.__elencoconti:
            if c.get_numconto()==nconto:
                conto=c                           
        return conto
    
    def versamento(self,nconto,valore):
        c=self.cercaconto(nconto)
        if c!=None:
            res=c.versamento(valore)
            if res==0:
                rit=0
            else:
                rit=-1
        return rit
        
        '''trovato=False
        rit=-2
        for c in  self.__elencoconti:
            if c.get_numconto()==nconto:
                res=c.versamento(valore)
                trovato =True            
                if res==0:  #versamento effettuato
                    rit = 0
                    break
                else:
                   rit -1 #versamento non effettuato
            return rit
        '''

    def get_elencoconti(self):
        return self.__elencoconti
    
    def bonifico(self,nconto1,nconto2,valore):
        conto1=self.cercaconto(nconto1)
        if conto1!=None:
            conto2=self.cercaconto(nconto2)
            if conto2!=None:
                pre=conto1.prelievo(valore)
                if pre == 0:
                    ver=conto2.versamento(valore)
                    if ver==0:
                        rit=0
                    else:
                        rit=-4
                        conto1.versamento(valore)
                else:
                    rit=-3
            else:
                rit=-2
        else:
            rit=-1
        return rit
    
    def stampaElencoContiProp(self,n,c):
        for conto in self.__elencoconti:
            for p in c.get_proprietari():
                nome=p.get_nome()
                cognome=p.get_cognome()
                if nome==n and cognome==c:
                    print(conto)
                    print("--------")
        print("** fine elenco **")
        
    def stampaElencoConti(self):
        for c in self.__elencoconti:
            print("Proprietari: ")
            for p in c.getProprietari():
                print(p)
            print(c)            
        print("------------")
        
    def ordinamento(self,ordine):
        self.__elencoconti.sort(key=lambda x:x.get_saldo())
        self.__elencoconti.sort(key=lambda x:x.get_numconto())