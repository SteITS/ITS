from Veicolo import Veicolo
from Autovettura import AutoVettura
from Furgone import Furgone

class GestioneVeicoli(object):
    def __init__(self):
        self.__elenco=[]
        
    def aggiungi_veicolo(self, v):
        self.__elenco.append(v)
        
    def cerca_veicolo(self,tar):
        for i in range(len(self.__elenco)):
            if(self.__elenco[i].get_targa()==tar):
                return True,i
        return False,-1
    
    def cancella_veicolo(self,tar:str):
        for veicolo in self.__elenco:
            if(veicolo.get_targa()==tar):
                self.__elenco.remove(veicolo)
                return True
        return False
    
    def totale_veicoli(self):
        return len(self.__elenco)
    
    def costo_totale(self):
        tot=0
        for veicolo in self.__elenco:
            tot += veicolo.get_costo()
        return tot

    def stampa_veicoli(self):
        st=""
        for veicolo in self.__elenco:
            print("------------")
            print(veicolo)
            print("-------------")

    def ordina_veicoli(self, chiave:str):
        if chiave.lower()=="targa":
            self.__elenco.sort(key=lambda x:x.get_targa())
        if chiave.lower()=="marca":
            self.__elenco.sort(key=lambda x:x.get_marca())
        if chiave.lower()=="costo":
            self.__elenco.sort(key=lambda x:x.get_costo())
        
                
    