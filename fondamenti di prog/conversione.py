from roman_arabic_numerals import conv
def arab_rom(num):
   return conv.arab_rom(num)
def rom_arab(rom_arab):
   return conv.rom_arab(rom_arab)
def main():
    print(arab_rom(567))
    print(rom_arab('MCMXCIV'))
main()