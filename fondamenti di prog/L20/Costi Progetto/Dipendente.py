from abc import ABC, abstractmethod


class Dipendente(ABC):
    def __init__(self, nome, cognome, matricola, annoassunz):
        self.__nome = nome
        self.__cognome = cognome
        self.__matricola = matricola
        self.__annoassunz = annoassunz

    def get_nome(self):
        return self.__nome

    def get_cognome(self):
        return self.__cognome

    def get_matricola(self):
        return self.__matricola

    def get_annoassunz(self):
        return self.__annoassunz

    def set_nome(self, nome):
        self.__nome = nome

    def set_cognome(self, cognome):
        self.__cognome = cognome

    def set_matricola(self, matricola):
        self.__matricola = matricola

    def set_annoassunz(self, annoassunz):
        self.__annoassunz = annoassunz

    @abstractmethod
    def getcosto(self, ore):
        pass

    def __str__(self):
        return f"Codice: {self.__matricola}\nCognome: {self.__cognome}\nNome: {self.__nome}\nAnno Assunzione: {self.__annoassunz}\n"
