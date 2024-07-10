class Salario:
    def __init__(self, stipendio, bonus):
        self.__stipendio=stipendio
        self.__bonus=bonus
    
    def get_stipendio(self):
        return self.__stipendio
    def get_bonus(self):
        return self.__bonus
    def set_stipendio(self,stipendio):
        self.__stipendio=stipendio
    def set_bonus(self,bonus):
        self.__bonus=bonus
        
    def stipendio_annuale(self):
        return self.__stipendio*12 + self.__bonus
    
    def __str__(self):
        return "Stipendio: "+str(self.__stipendio)+" bonus "+str(self.__bonus)
    
    
        