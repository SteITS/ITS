from abc import ABC, abstractmethod

class Veicolo(ABC):
    def __init__(self, marca:str, targa:str, costo:float):
        self.__marca = marca
        self.__targa = targa
        self.__costo = costo
        
    def get_marca(self):
        return self.__marca
    def get_targa(self):
        return self.__targa
    def get_costo(self):
        return self.__costo

    def set_marca(self,marca):
        self.__marca=marca
    def set_targa(self,targa):
        self.__targa=targa
    def set_costo(self,costo):
        self.__costo=costo
        
    def __str__(self):
        return "Marca: "+self.__marca+"\n Targa: "+self.__targa+"\n Costo: "+str(self.__costo)