from Impiegato import *
def main():
    imp=Impiegato("Mario Rossi",25,1500,500)
    print("Impiegato: \n",imp)
    print("Stipendio annuale: ",imp.total_sal())
    print("Stipendio: ",imp.get_salario().get_stipendio())
    stip=int(input("Inserisci stipendio: "))
    imp.get_salario().set_stipendio(stip)
    print("Impiegato: \n",imp)
    print(" stipendio: ",imp.get_salario().get_stipendio())


main()
