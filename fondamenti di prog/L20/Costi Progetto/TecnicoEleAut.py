from Dipendente import Dipendente
from datetime import datetime


class TecnicoEleAut(Dipendente):
    pagaoraria = 50

    def __init__(self, nome, cognome, matricola, annoassunz, orelavorate, interno):
        super().__init__(nome, cognome, matricola, annoassunz)
        self.__orelavorate = orelavorate
        self.__interno = interno

    def get_orelavorate(self):
        return self.__orelavorate

    def get_interno(self):
        return self.__interno

    def set_orelavorate(self, orelavorate):
        self.__orelavorate = orelavorate

    def set_interno(self, interno):
        self.__interno = interno

    def getcosto(self, annoassunz):
        pagaorariaT = self.pagaoraria + (2024 - annoassunz)
        return self.__orelavorate * pagaorariaT

    def __str__(self):
        return super().__str__() + "Ore Lavorate: " + str(self.__orelavorate)
