
# Megoldás

# Osztály létrehozása
  - Kétféle mód közül bármelyik
	- Ctrl + .
	- Adjunk hozzá egy osztályt
  - 5 tulajdonság
	- public get, private set
  - 1 konstruktor "?"
	- 1 paraméter ---> string
	- például "Acsalapu;levél;6;8"
	- ';'-vel vannak elválasztva
	- 4 darab adat ---> 5 tulajdonság??
	- átadott, fájlból beolvasott sort:
		- ';' mentén tagoljuk
		- [0] ---> Nev
		- [1] ---> Resz
		- [2] ---> Kezd
		- [3] ---> Veg
		- Idotartam ---> számolás (lásd következő pont)
  - 5. tulajdonság --> időtartam
		- Konstruktorban számoljuk
		- számolása: Vég - Kezdet HA!! Vég > Kezdet
		- Vég > Kezdet Vég - Kezdet + 1
		- Egyébként ---> 12 - Vég + Kezdet + 1

 ##Adatok beolvasása és eltárolása
	- Listában tároljuk az objektum példányokat
	- Olvassuk be:
		- System.IO
		- StreamReader
		- while ciklussal --> amíg tart a fájl
		- Cikluson belül listához hozzáaunk egy új objektum példányt (beolvasott sor a paraméter)


 ## 1. Feladat
	- Hány növény van (lista Count tulajdonság)

 ## 2. Feladat
	- Milyen gyűjthető részek vannak?
	- Hány darab van ezekből?
	- Adatszerkezet: Dictionary<string, int>
	- Milyen gyűjthető részek vannak
		- Foreach "novenyek"
		- Ha a rész nem kulcs ---> akkor adjuk hozzá 0-val
	-[2] Hány darab van ezekből 
		- Foreach "novenyek"
		- Ha "Resz" == Key ---> Value++ 

 ## 3. Feladat
	- Maximum keresés ---> időtartam alapján
	- Növény(ek) amely(ek) a legtöbb ideig szedtek

 ## 4. Feladat
	- Időtartam átlag számítás 
		- szum változó = 0 (double)
		- átlag változo
		- foreach novenyek
		- sum += Idotartam
		- atlag = szum / count