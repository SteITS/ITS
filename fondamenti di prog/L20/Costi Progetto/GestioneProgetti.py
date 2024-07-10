from Dipendente import Dipendente


class GestioneProgetti:
    def __init__(self):
        self.__elenco = []

    def aggiungipersona(self, persona: Dipendente):
        self.__elenco.append(persona)

    def eliminaPersona(self, nome):
        for persona in self.__elenco:
            if persona.get_nome == nome:
                del persona
                return True
        return False

    def cercaPersona(self, nome):
        for persona in self.__elenco:
            if persona.get_nome == nome:
                return True, persona
        return False, None

    def elencoPersone(self):
        strelenco = ""
        for p in self.__elenco:
            strelenco += str(p) + "\n" + "\n"
        return strelenco

    def getTotalePersone(self):
        return len(self.__elenco)

    def costiProgetto(self, tot=None):
        for persona in self.__elenco:
            tot += persona.get_costo()
        return tot
