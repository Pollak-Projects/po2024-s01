# Playaorientacio2024Season01

Hogyan tudod megnyitni a fejlesztéshez a kódot 
 - Letöltöd a kódot zipként, kicsomagolod és megnyitod a `Playaorientacio2024Season01.sln` fájlt
 - Visual Studio-ban `Clone a repository` belül bemásolod a `https://github.com/Pollak-Projects/po2024-s01.git` linket
 - Bemásolod a következőt a saját mappádban megnyitott konzolba:

```sh
git clone https://github.com/Pollak-Projects/po2024-s01.git
cd po2024-s01
./Playaorientacio2024Season01.sln
```

## A feladat leírás

### 1. feladat

A _szamok.txt_ fájlban 3000 db 10 jegyű szám szerepel (nem feltétlenül különböző). Minden szám új
sorban található. A számokban csak az 1; 2; 3; 4; 5 számjegyek fordulhatnak elő. A következő
feladatokat a _szamok.txt_ fájlban tárolt adatok felhasználásával kell megoldania.

**a)** A fájlban tárolt számok között hány olyan szerepel, amely a **1310438493** számmal relatív prím?
Két számot relatív prímnek nevezünk, ha legnagyobb közös osztójuk 1.

```
Pl.: a 10 és a 21 relatív prímek (bár egyik sem prímszám).
```
Kiírandó egy szám (a válasz a kérdésre).

---

**b)** Két szóra azt mondjuk, hogy egymás anagrammái, ha pontosan ugyanazokból a betűkből állnak, csak
a betűk eltérő sorrendben szerepelnek a szóban.

```
Pl.: meszel – szemel – szemle – zsemle szavak egymás anagrammái.
```
Ebben az értelemben a _szamok.txt_ fájlban tárolt számok között hány különböző "anagrammája"
szerepel a 2354211341 számnak? Tehát ugyanazok a számjegyek alkotják, de eltérő sorrendben. Az
eredeti számot ne számolja az anagrammák közé! 

Kiírandó egy szám (a válasz a kérdésre).

---

**c)** Egy többjegyű szám két-két egymás utáni számjegyét kétjegyű számnak tekintve, melyik a _szamok.txt_
fájlban tárolt számokban a leggyakrabban előforduló kétjegyű szám?

```
Pl.: a 12345 számban előforduló kétjegyű számok: 12, 23, 34 és 45
```
Kiírandó egy szám (a válasz a kérdésre).


### 2. feladat

Magyarországi települések adatai szereplenek a _telepules.txt_ fájlban. (Az adatok egy részének forrása:
https://webdraft.eu/orszagok_varosok/) Az adatokat helyenként átalakítottuk, kiegészítettük,
leszűkítettük, ...
A feladatban szereplő kérdésekre a választ a _telepules.txt_ fájlban tárolt adatok alapján kell megadni. Az
internetes keresés eltérő eredményt is adhat.

Az _telepules.txt_ fájl felépítése:

Minden település adatai külön sorban szerepelnek. A fájlnak legfeljebb 3500 sora lehet.
Minden sorban 9 db adat szerepel, egymástól szóközzel elválasztva, azonos szerkezetben.

A fájl egy sora például:
`6000 BK 46.9 19.7833 321.36 111428 Kecskemet 0 67`
- A település irányítószáma ( 6000 )
- Megye azonosítója (BK) A megyék azonosítóit és a megyék nevét a _megyek.txt_ fájl tartalmazza. Ezt
    a fájlt használhatja a megoldáshoz.
- A település szélességi GPS koordinátája fok mértékegységben (46.9)
- A település hosszúsági GPS koordinátája fok mértékegységben (19.7833)
- A település területe km^2 - ben (321.36)
- A település lakosainak száma ( 111428 )
- A település neve (Kecskemet) A települések neve nem tartalmaz ékezetes karaktereket, nagy
    betűvel kezdődik és több szót tartalmazó név esetén a szóköz helyett „-” jel szerepel.
- A település távolsága Kecskeméttől kilométerben, egészre kerekítve (0)
- A település távolsága Szegedtől kilométerben, egészre kerekítve (67)

A települések távolságának kiszámításához (lásd a példa utolsó két adata) a GPS koordinátákat
használtuk. A számolást a gömbfelületre érvényes Havershine formulával végeztük. (A részleteket lásd:
https://en.wikipedia.org/wiki/Haversine_formula) Mivel a települések nem pontszerűek és a Föld sem
tökéletes gömb, ezért a fájlban szereplő adatok kis mértékben eltérhetnek a valós értéktől.


**A telepules.txt fájlban szereplő adatokat felhasználva válaszoljon a következő kérdésekre!**

---

**a)** Melyik az a megyénk, amelynek a második legalacsonyabb a népessége? A megye nevét adja meg
válaszként, a _megyek.txt_ fájlban szereplő módon, majd tőle egy "-" jellel elválasztva a fájlban található
adatok alapján a lakosok számát!
```
Pl.: ha eredményül Veszprém megyét kapja és a lakosok száma 312670, akkor a kiírandó válasz:
Veszprem- 312670
```

---

**b)** Melyik a legészakibb település a _telepules.txt_ fájl adatai szerint?
Kiírandó a település neve a fájlban tárolt módon.

---

**c)** Hány olyan település van, amely Kecskemét és Szeged 50 km sugarú körzetében található?
Tehát ha rajzolnánk a fájlban tárolt GPS koordináták alapján Kecskemét és Szeged köré is egy 50 km
sugarú kört, akkor a település mindkét körön belül lenne. 
Kiírandó egy szám (a válasz a kérdésre).

---

**d)** A 47.3 és 47.4 szélességi körök között, ha a hosszúsági koordináták szerint növekvő sorrendben
haladunk a fájlban szereplő településeken keresztül, akkor az egymást követő települések
területkülönbségei közül melyik a legnagyobb?
A választ a két település nevének és területkülönbségnek a megadásával írja ki, az adatokat „-” jellel
elválasztva! A területkülönbséget 2 tizedesjegyre kerekítve adja meg!
```
Pl.: Ha az egymást követő települések nevei és területeik rendre: A-123.12; B-49.55; C-32.1; D-55.
A területkülönbségek: AB=73.57; BC=17.45; CD=23.32 A válasz a két város neve és a legnagyobb
különbség „-” jellel elválasztva: A-B-73.57
```

---

**e)** Sok olyan település van, amelynek nevében szerepel a buda szórészlet. A buda szórészletet
tartalmazó települések közül melyik lesz a harmadik, ha nyugatról kelet felé haladunk? A kicsi és nagy
betűk között ne tegyen különbséget! A település adatbázisban szereplő nevét írja ki!

---

**f)** Egy település nevéről annyit tudunk, hogy előfordulnak benne az alábbi sorrendben a következő
betűk: **a e t** (A kis és nagybetűs változat is megfelelő.) A betűk között bármennyi más betű is
szerepelhet, de a fenti 3 betűt ebben a sorrendben kell tartalmaznia a település nevének.
Hány ilyen település található az adatforrásban? 
Kiírandó egy szám (a válasz a kérdésre).


