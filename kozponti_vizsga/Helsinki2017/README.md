# Műkorcsolya 2017

A feladat során a 2017-es műkorcsolya- és jégtánc-világbajnokság női egyéni versenyszámának eredményeit kell feldolgoznia. A verseny minden induló számára a rövidprogrammal kezdődik. A versenyzők értékelése során a zsűritől technikai és komponens pontszámokat, valamint hibapontokat kapnak. A rövidprogram összpontszámának kiszámításakor a technikai és a komponens pontszámok összegéből vonják le a hibapontokat.
A rövidprogram legjobb 24 versenyzője mutathatja be a kűrjét. A pontozás során a versenyzők itt is technikai és komponens pontokat, valamint hibapontokat kapnak.

A végső sorrend megállapítása során mindkét pontszámot (rövidprogram és kűr) összeadják és ez alapján hirdetnek eredményt.
A rövidprogramban részt vevő versenyzők nevét, országát és pontszámait az UTF-8 kódolású *rovidprogram.csv* állomány tartalmazza:


```TXT
    Név;Ország;Technikai;Komponens;Levonás
    Anne Line GJERSEM;NOR;25.3;21.69;0
    Joshi HELGESSON;SWE;27.85;25.22;1
    Anna KHNYCHENKOVA;UKR;26.3;21.68;1
    Dasa GRM;SLO;25.03;22.6;1
    Anastasia GALUSTYAN;ARM;30.63;24.57;0
    Emmi PELTONEN;FIN;25.18;25.56;0
    Shuran YU;SGP;30.31;22.56;0
    Carolina KOSTNER;ITA;32.44;33.89;0
    Michaela-Lucie HANZLIKOVA;CZE;16.55;19.66;4
```
Az adatok pontosvesszővel vannak elválasztva. Sorrendben a következők:

* Név
* Ország kódja (pl. HUN)
* Technikai pontszám: tizedes ponttal (!)
* Komponens pontszám: tizedes ponttal (!)
* Hibapont (levonás)

A kűrbe továbbjutó 24 versenyző nevét, országát, valamint a kűrben elért pontszámait a szintén UTF-8 kódolású *donto.csv* állomány tartalmazza, amelynek felépítése megegyezik a fent leírtakkal.

A megoldás során vegye figyelembe a következőket:

* Az ékezetmentes kiírás is elfogadott.
* A feladat jobb megértése érdekében tanulmányozza a mintákat is!

Készítsen konzolos vagy grafikus programot Helsinki2017 néven, amely az alábbi feladatokat oldja meg!

1.  Olvassa be és tárolja el a memóriában a *rovidprogram.csv* és a *donto.csv* állomány tartalmát!
2.  Határozza meg és írja ki a képernyőre a rövidprogramban elindult versenyzők számát!
3.  Írja ki a képernyőre, hogy a magyar versenyző bejutott-e a kűrbe!
4.  Készítsen metódust (függvényt) vagy jellemzőt összPontszám azonosítóval, amely egy versenyző rövidprogramban és a kűrben kapott pontszámának összegét adja! Ha valaki nem jutott be a kűrbe, akkor csak a rövidprogram pontszámát kell számolni. (Metódus esetén a paraméter legyen a versenyző neve!)
5.  Kérje be a felhasználótól egy versenyző nevét! Ha a versenyző nem található meg az indulók között, akkor írja ki a képernyőre, hogy *„Ilyen nevű induló nem volt”*!
6.  Írja ki a képernyőre az előző feladatban bekért versenyző összpontszámát (ha indult a versenyen)! Amennyiben nem tudta megoldani az előző feladatot, akkor „Amy LIN" pontszámát írja ki a képernyőre! A megoldás során használja a 4. feladatban elkészített metódust vagy jellemzőt!
7.  Készítsen összesítést arról, hogy országonként hány versenyző jutott tovább a rövidprogram bemutatása után! Írja a ki a képernyőre a minta szerint azon országok kódját és a versenyzők számát, amelyek esetében egynél több versenyző jutott tovább!
8.  Készítsen UTF-8 kódolású állományt *vegeredmeny.csv* néven, amely tartalmazza a verseny végeredményét! A fájlban pontosvesszővel elválasztva a következő adatok szerepeljenek:
    * Helyezés
    * Versenyző neve
    * Ország
    * Összpontszám

A fájlban a versenyzők a helyezésük szerint legyenek sorba rendezve!


## Minta


```TXT
2. feladat
    A rövid programban 37 induló volt.
3. feladat
    A magyar versenyző bejutott a kűrbe.
5. feladat
    Kérem a versenyző nevét: Amy LIN
6. feladat
    A versenyző összpontszáma: 51.86
7. feladat
    USA: 3 versenyző
    CHN: 2 versenyző
    JPN: 3 versenyző
    RUS: 3 versenyző
    CAN: 2 versenyző
```

**vegeredmeny.csv**


```TXT
    Evgenia MEDVEDEVA;RUS;233.41
    Kaetlyn OSMOND;CAN;218.13
    Gabrielle DALEMAN;CAN;213.52
    Karen CHEN;USA;199.29
    Mai MIHARA;JPN;197.88
    Carolina KOSTNER;ITA;196.83
    Ashley WAGNER;USA;193.54
    Maria SOTSKOVA;RUS;192.20
    Elizabet TURSYNBAEVA;KAZ;191.99
    Dabin CHOI;KOR;191.11
```
