
class Persona:
    def __init__(self,nome:str,cognome: str):
        self.__nome=nome
        self.__cognome=cognome

    def getNome(self):
        return self.__nome
    def setNome(self,nome): 
        self.__nome=nome

    def getCognome(self):
        return self.__cognome
    def setCognome(self,cognome): 
        self.__nome=cognome
                            
    def __str__(self):
        return "Nome: "+self.__nome+" Cognome: "+self.__cognome    