import os
curr_dir=os.getcwd()
print(curr_dir)

for nome in os.listdir():
    print(nome)

os.mkdir("miacartella")
list=os.listdir()
print(list)