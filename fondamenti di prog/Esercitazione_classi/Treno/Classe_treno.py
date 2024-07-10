class Treno:
    def __init__(self, vagoni:int):
        self.__passeggerimax= 0
        self.__vagoni = vagoni
        self.__passeggeri = 0

    def get_passeggeri(self):
        return self.__passeggeri

    def set_passeggeri(self, passeggeri):
        self.__passeggeri = passeggeri
        
    def get_passeggerimax(self):
        return self.__passeggerimax

    def set_passeggerimax(self,passeggerimax):
        self.__passeggerimax = passeggerimax

    def get_vagoni(self):
        return self.__vagoni

    def set_vagoni(self, vagoni):
        self.__vagoni = vagoni


    def salgono_passeggeri(self,su):
        self.set_passeggeri(self.get_passeggeri()+su)
    
    def scendono_passeggeri(self,giu):
        self.set_passeggeri(self.get_passeggeri()-giu)
        
    def __str__(self):
        return "passeggeri max: "+str(self.__passeggerimax)+"\n passeggeri al momento: "+str(self.__passeggeri)+"\n vagoni presenti: "+str(self.__vagoni)