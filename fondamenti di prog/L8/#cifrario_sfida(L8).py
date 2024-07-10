#cifrario_sfida(L8)
from input_dati import *

def has_numbers(inputString):
    return any(char.isdigit() for char in inputString)

def user():
    while True:
        username=input("Inserisci Username senza numeri: ")
        username=username.upper()
        if has_numbers(username) == False:
            return username
        else:
            print("Inserisci Username senza numeri: ")
def psw():
        while True:
            psw=input("Inserisci password senza numeri: ")
            psw=psw.upper()
            if has_numbers(psw) == False:
                return psw
            else:
                print("Inserisci password senza numeri: ")

def cifrario(username,password):
    userC=""
    k=0
    for i in range(len(username)):
        password=password+password[i]
    password=password[:len(username)]
    for char in username:
        #print(char)
        diff=ord(username[k])+(ord(password[k])-64)
        #print(diff)
        userC+=chr(diff)
        k=k+1
    return userC

def decifrario(final,password):
    userC=""
    k=0
    for i in range(len(final)):
        password=password+password[i]
    password=password[:len(final)]
    for char in final:
        #print(char)
        diff=ord(final[k])-(ord(password[k])-64)
        #print(diff)
        userC+=chr(diff)
        k=k+1
    return userC

def main():
    username=user()
    password=psw()
    final=cifrario(username,password)
    print(final)
    base=decifrario(final,password)
    print(base)
main()