#Classe atleta

class Atleta:
    def __init__(self,nome:str,cognome:str,altezza:float,visitamedica=False):
        self.__nome=nome
        self.__cognome=cognome
        self.__altezza=altezza
        self.__squadra= ""
        self.__visitamedica= False
        
    #metodi getter
    def get_nome(self):
        return self.__nome
    def get_cognome(self):
        return self.__cognome
    def get_altezza(self):
        return self.__altezza
    def get_squadra(self):
        return self.__squadra
    def get_visitamedica(self):
        return self.__visitamedica
    
    #metodi setter
    def set_nome(self,nome):
        self.__nome=nome
    def set_cognome(self,cognome):
        self.__cognome=cognome
    def set_altezza(self,altezza):
        self.__altezza=altezza
    def set_squadra(self,squadra):
        self.__squadra=squadra
    def __set_visitamedica(self,visitamedica):
        self.__visitamedica=visitamedica
    
    def assegna_squadra(self,squadra):
        self.__squadra=squadra
    
    def effettua_visita(self,visitamedica):
        self.__set_visitamedica(visitamedica)
        
    def __str__(self):
        return "nome: "+self.__nome+" cognome: "+self.__cognome+" altezza: "+str(self.__altezza)+" squadra: "+self.__squadra+" visita medica: "+ str(self.__visitamedica)