class Persona:
    def __init__(self,nome,cognome):
        self.__nome=nome
        self.__cognome=cognome
        self.__conto=None
    def get_nome(self):
        return self.__nome
    def get_cognome(self):
        return self.__cognome
    def get_conto(self):
        return self.__conto
    
    def set_nome(self,nome):
        self.__nome=nome
    def set_cognome(self,cognome):
        self.__cognome=cognome
    def set_conto(self,conto):
        self.__conto=conto
        
    def __str__(self):
        st="Nome: "+self.__nome+" Cognome: "+self.__cognome
        return st

from ContoCorrente import *
  
p=Persona("Antonio","Rossi")
print(p)
print(p.get_nome(),p.get_cognome(),p.get_conto())
p.set_cognome("Verdi")
p.set_nome("Marco")
conto=ContoCorrente(100)
p.set_conto(conto)
print(p)
print(p.get_nome(),p.get_cognome(),p.get_conto())