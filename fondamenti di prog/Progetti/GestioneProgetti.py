
from Dirigente import Dirigente
from FunzionarioSenior import FunzionarioSenior
from FunzionarioJunior import FunzionarioJunior
from TecnicoEleAut import TecnicoEleAut
from TecnicoInFTel import TecnicoInfTel

class GestioneProgetti(object):
    def __init__(self):
        self.__elenco=[]
    
    # aggiunta una persona al progetto
    def aggiungiPersona(self,p):
        self.__elenco.append(p)
    

    # elimina una persona dal progetto ricerca per cognome
    def eliminaPersona(self,nominativo):
        trovato=False        
        for p in self.__elenco: 
            if p.getcognome()==nominativo:
                self.__elenco.remove(p)
                trovato=True
                break
        return trovato
    #cerca una persona per cognome e ritorna l'elemento    
    def cercaPersona(self,cognome):
        trovato=False
        for elem in self.__elenco:
            #print(elem.getcognome())
            if elem.getcognome()==cognome:
                trovato=True
                break
        return trovato,elem
    
    def elencoPersone(self):
    # elenco partecipanti al progetto con ruolo
        persone = ""
        for p in self.__elenco:
            persone +=p.getcognome()+" "+p.getnome()+"\t"
            #print(type(p))
            if isinstance(p,Dirigente):
                persone +=" Dirigente         \tMatricola: "+p.getmatricola() #+"\t\t\tCosto: "+str(p.getCostoC())
            if isinstance(p,FunzionarioSenior):
                persone +=" Funzionario senior \tMatricola: "+p.getmatricola() #+"\t\t\tCosto: "+str(p.getCostoC())
            if isinstance(p,FunzionarioJunior):
                persone +=" Funzionario junior \tMatricola: "+p.getmatricola() #+"\t\t\tCosto: "+str(p.getCostoC())
            if isinstance(p,TecnicoInfTel):
                persone +=" Tecnico Informatico \tMatricola: "+p.getmatricola() #+"\t\tCosto: "+str(p.getCostoC())
            if isinstance(p,TecnicoEleAut):
                persone +=" Tecnico Elettronico \tMatricola: "+p.getmatricola() #+"\t\tCosto: "+str(p.getCostoC())
            persone+="\r\n"
        return persone
    
    def getTotalePersone(self):
        return len(self.__elenco)

    # Calcola costi progetto
    def Costiprogetto(self,anno):
        totcosti=0;
        totcosti=sum([pers.getCostoC(anno) for pers in self.__elenco])
        return totcosti;

    def __str__(self):
        return self.elencoPersone()
