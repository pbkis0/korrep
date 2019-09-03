# Morze

A következő feladatban morzekódon írt szövegfájl adatainak feldolgozásával kell dolgoznia. A megoldás során vegye figyelembe a következőket:

* A képernyőre írást igénylő részfeladatok eredményének megjelenítése előtt írja a képernyőre a feladat sorszámát (például: 3. feladat:)!
* Az egyes feladatokban a kiírásokat a minta szerint készítse el!
* Az ékezetmentes kiírás is elfogadott.
* A program megírásakor a fájlban lévő adatok helyes szerkezetét nem kell ellenőriznie, feltételezheti, hogy a rendelkezésre álló adatok a leírtaknak megfelelnek.
* Megoldását úgy készítse el, hogy az azonos szerkezetű, de tetszőleges bemeneti adatok mellett is helyes eredményt adjon!

-------


1.	A feladat megoldásához hozzon létre grafikus vagy konzolalkalmazást (projektet) **Morze** azonosítóval!
2.	Két állománnyal kell dolgoznia. Az első állomány tartalmazza a morze-ábécé kódtárát. Az UTF-8 kódolás *morzeabc.txt* állományban szerepelnek a karakterek és a hozzájuk tartozó morzekódok. A fájl soraiban 1-1 karakter és a morzekód szerepel tabulátorral elválasztva egymástól. A fájlban maximum 100 sor lehetséges. Ügyeljen arra, hogy a fájl első sora az adatok fejlécét tartalmazza! Olvassa be a *morzeabc.txt* állományban található adatokat és tárolja el egy megfelelően megválasztott adatszerkezetben!
3.	Határozza meg és írja ki a képernyőre a minta szerint, hogy hány karakter található a *morzeabc.txt* állományban!
4.	Kérjen be a felhasználótól egy karaktert a billentyűzetről és írja ki a képernyőre a minta szerint, hogy mi a morzekódja! Ha a karakter nem található meg a kódtárban, akkor írja ki a „Nem található a kódtárban ilyen karakter!” szöveget!
5. A második UTF-8 kódolású *morze.txt* állomány morzekódban tartalmaz idézeteket különböző szerzőktől. Az állomány sorai két részre tagolódnak. A két részt pontosvessző választja el egymástól. Az első rész a szerzőt, a második rész az idézetet tartalmazza. A fájlban maximum 200 sor lehet. A morzekódban a betűket három, míg a szavakat hét szóköz választja el egymástól. Olvassa be a *morze.txt* állományban található adatokat és tárolja el egy megfelelően megválasztott adatszerkezetben! 
6. Készítsen metódust (függvényt), amely a paraméterként kapott morzekódolású szöveges adatból normál kódolatlan szöveget állít elő! A metódus legyen *Morze2Szöveg*! 
7. A *Morze2Szöveg* metódus segítségével határozza meg és írja ki a képernyőre a minta szerint az első idézet szerzőjének nevét! 
8. Írja ki a képernyőre, hogy melyik idézet szövege a leghosszabb! Az idézetnek jelenjen meg a szerzője is a minta szerint! 
9. Arisztotelésztől több idézet is van a dokumentumban, határozza meg és írja ki a képernyőre a minta szerint mindegyik idézetet! 
10. Készítsen *forditas.txt* néven szövegfájlt, amelyben az összes idézet megjelenik szerzővel együtt! Az idézetek és szerzőik együtt soronként kerüljenek az új állományba! 

## Minta

Képernyő - kimenet

```TXT
3. feladat: A morze abc 49 db karakter kódját tartalmazza.
4. feladat: Kérek egy karaktert: G
A(z) G karakter morze kódja: ––.
7. feladat: Az első ídézet szerzője: ARISZTOTELÉSZ 
8. feladat: A leghosszabb idézet szerzője és az idézet: ARISZTOTELÉSZ : A BARÁTSÁG AZ, AMIKOR EGY LÉLEK KÉT TESTBEN LAKIK. 
9. feladat: Arisztotelész idézetei:
	- A BARÁTSÁG AZ, AMIKOR EGY LÉLEK KÉT TESTBEN LAKIK. 
	- MINDEN EMBERBEN VAN VALAMI JO. 
```


forditas.txt


```TXT
ARISZTOTELÉSZ : A BARÁTSÁG AZ, AMIKOR EGY LÉLEK KÉT TESTBEN LAKIK. 
GRAFFITI : NE AGGODJ AZ EGÉSZSÉGED MIATT! ELMULIK. 
LEONARD COHEN : JÁROD AZ UTAD,JÁROM AZ UTAD ÉN IS. 
KOSZTOLÁNYI DEZSO : CSALODNI CSAK AZ TUD, AKI VALAHA HITT. 
ERNEST HEMINGWAY : MEGÉRTENI ANNYI, MINT MEGBOCSÁTANI. 
FRANCOIS MAURIAC : A FÉLELEM A BÖLCSESSÉG KEZDETE. 
FRANK HERBERT : HA NEM HAJLUNK, AKKOR ELTÖRHETÜNK. 
RAANA RAAS : NEM A CÉL A FONTOS, HANEM AZ UT. 
GUILLAUME MUSSO : TUDNI KELL MEGBOCSÁTANI ÉS FELEJTENI. 
FRIEDRICH NIETZSCHE : ZENE NÉLKÜL AZ ÉLET TÉVEDÉS VOLNA. 
POPPER PÉTER : ÖNTUDATLANUL ELKÖVETETT BUN NINCS. 
STEPHEN KING : A SZERETET NEM ISMER AKADÁLYT. 
VOLTAIRE : MINDEN MUFAJ JO, KIVÉVE AZ UNALMAST. 
ANTON PAVLOVICS CSEHOV : A TELI HAS NEM TANUL SZIVESEN. 
ARISZTOTELÉSZ : MINDEN EMBERBEN VAN VALAMI JO. 
CSI: MIAMI HELYSZINELOK C. FILM : A LEGJOBB VÉDELEM: A BECSÜLET. 
POLAR EXPRESSZ C. FILM : A KARÁCSONYI CSODA A SZIVEDBEN LAKIK. 
JOHN RONALD REUEL TOLKIEN : A HAJNAL MÉGIS AZ EMBEREK ÖRÖK REMÉNYE. 
```
