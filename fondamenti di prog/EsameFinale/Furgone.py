from Veicolo import Veicolo

class Furgone(Veicolo):
    def __init__(self, marca: str, targa: str, costo: float, capacita:int):
        super().__init__(marca, targa, costo,capacita)
        self.__capacita=capacita
        
    def get_capacita(self):
        return self.__capacita
    
    def set_capacita(self,capacita):
        self.__capacita=capacita
        
    def __str__(self):
        return "*Furgone* \n"+super().__str__()+"\n Capacita: "+str(self.__capacita)