from Dipendente import Dipendente


class FunzionarioJunior(Dipendente):
    pagaoraria = 70

    def __init__(self, nome, cognome, matricola, annoassunz, orelavorate):
        super().__init__(nome, cognome, matricola, annoassunz)
        self.__orelavorate = orelavorate

    def get_orelavorate(self):
        return self.__orelavorate

    def set_orelavorate(self, orelavorate):
        self.__orelavorate = orelavorate

    def getcosto(self, annoassunz=None):
        return self.__orelavorate * self.pagaoraria

    def __str__(self):
        return super().__str__() + "Ore Lavorate: " + str(self.__orelavorate)
