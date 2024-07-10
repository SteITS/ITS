from platform import platform,machine,processor,system,version
print("Piattaforma: ",platform())
print("PC tipo: ",machine())
print("Processore: ",processor())
print("Sistema: ",system(), "\t Versione: ",version())

from platform import python_implementation,python_version_tuple
print(python_implementation(),python_version_tuple())