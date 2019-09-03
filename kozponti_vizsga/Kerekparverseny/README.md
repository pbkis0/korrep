# KERÉKPÁRVERSENY

2016 nyarán egy Balaton körüli kerékpárversenyt szerveztek, ahol az egyes állomások között három
versenyszakaszt alakítottak ki. Ennek a versenynek az adatait kell feldolgoznia ebben a feladatban.

A megoldás során vegye figyelembe a következőket:

- *A képernyőre írást igénylő részfeladatok eredményének megjelenítése előtt írja a képernyőre a feladat sorszámát* (*például 2/1. részfeladat:, 2/2. részfeladat:, 2/3.részfeladat:*)!
- *Az egyes feladatokban a kiírásokat a minta szerint készítse el!*
- *Az ékezetmentes kiírás is elfogadott.*
- *A program megírásakor a fájlban lévő adatok helyes szerkezetét nem kell ellenőriznie, feltételezheti, hogy a rendelkezésre álló adatok a leírtaknak megfelelnek.*
- *A megoldását úgy készítse el, hogy az azonos szerkezetű, de tetszőleges input adatok mellett is helyes eredményt adjon!*

A *kerekpar.csv* állomány első sora a résztvevők összesített számát (és semmi mást) tartalmazza. A további sorok egy-egy versenyállomás nevét (városát) és az 1., 2. és 3. szakaszok hosszát tartalmazza egészre kerekített km-ben. Példa egy adatsorra:

```txt
Csopak;8;10;
```
Készítsen programot *balatonkor* néven a következő részfeladatok megoldására!

1. Olvassa be a *kerekpar.csv* állományban lévő adatokat és tárolja el úgy, hogy a további feladatok megoldására alkalmasak legyenek! A fájlban legfeljebb 20 sor lehet. (8 pont)
2. Határozza meg. és írja ki a képernyőre a mintának megfelelően, hogy hány helyszínből állt a verseny! (4 pont)
3. Írja ki a minta szerint, hogy hány km volt a teljes versenysorozat hossza! (5 pont)
4. Kérjen be egy balatoni városnevet a felhasználótól. Írja ki a képernyőre az adott városban lévő szakaszok hosszát a minta szerint. Amennyiben a megadott város nem szerepel az állomások között, jelenjen meg a „Ez a város nem szerepel a verseny állomásai között!” üzenet! (4 pont)
5. Írja ki a minta szerint, hogy melyik helyszínen volt a leghosszabb a teljes versenytáv (1., 2. és 3. szakaszok összes hossza alapján). (5 pont)
6. Írja ki a minta szerint az első szakaszok átlagos hosszúságát! (5 pont)
7. Készítsen egy *statisztika.txt* nevű állományt a program segítségével, amely tartalmazza az állomások nevét, és egy százalékos értéket, amely megadja, hogy hány százaléka az adott állomáshoz tartozó teljes útszakasz (azaz a három szakasz hosszának összege) az egész verseny hosszának. (5 pont)
8. Írja ki a minta szerint, hogy átlagosan hány versenyző vett részt a versenysorozat versenyein (létszám/versenyek száma)! (4 pont)

**Minta** *(csak formai segítség, tartalmilag eltérhet a helyes megoldástól)*:

```txt
2/1 részfeladat: Teljesítve, a fájl beolvasva.
2/2 részfeladat: A helyszínek száma: 8 db.
2/3 részfeladat: A versenysorozat teljes hossza: 206 km.
2/4 részfeladat:
Adjon meg egy (balatoni) városnevet: Badacsonytomaj
Az adott város versenyszakaszai: 8 km, 7 km és 6 km.
2/5 részfeladat:
A leghosszabb versenytávot adó település: Balatonkenese
2/6 részfeladat: Az első szakaszok átlagos hossz: 8,6 km.
2/7 részfeladat: A fájl létrehozva.
2/8 részfeladat: Az átlagos versenyzőszám: 122,
```





