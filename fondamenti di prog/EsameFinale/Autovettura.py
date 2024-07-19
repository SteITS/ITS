from Veicolo import Veicolo

class AutoVettura(Veicolo):
    def __init__(self, marca: str, targa: str, costo: float,posti:int):
        super().__init__(marca, targa, costo)
        self.__posti=posti
        
    def get_posti(self):
        return self.__posti
    
    def set_posti(self,posti):
        self._posti=posti
        
    def __str__(self):
        return "*AutoVettura* \n "+super().__str__()+"\n Posti: "+str(self.__posti)