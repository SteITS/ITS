from Salario import *

class Impiegato:
    def __init__(self,nome,eta,stipendio,bonus):
        self.__nome=nome
        self.__eta=eta
        self.__miosalario=Salario(stipendio,bonus)
        
    def get_nome(self):
        return self.__nome
    def get_eta(self):
        return self.__eta
    def get_salario(self):
        return self.__miosalario
    def set_nome(self,nome):
        self.__nome=nome
    def set_eta(self,eta):
        self.__eta=eta
    def set_salario(self,stipendio,bonus):
        self.__miosalario=Salario(stipendio,bonus)
    def total_sal(self):
        return self.__miosalario.stipendio_annuale()
    def __str__(self):
        st="Nome: "+self.__nome+" "+str(self.__miosalario)
        return st