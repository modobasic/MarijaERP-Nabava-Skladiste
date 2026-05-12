# MarijaERP

ERP prototip za nabavu i skladišno poslovanje izrađen u C# WinForms okruženju uz SQL Server bazu podataka.

## Pokretanje projekta

1. Kreirati bazu podataka `MarijaERP` u Microsoft SQL Serveru
2. Pokrenuti SQL skriptu:
   `SQLMarijaERP.sql`
3. Otvoriti `MarijaERP.sln` u Visual Studio okruženju
4. Provjeriti connection string u `Database.cs`
5. Pokrenuti aplikaciju


## Funkcionalnosti

- pregled zaliha
- artikli i dobavljači
- narudžbenice
- zaprimanje robe po LOT-u
- FIFO izdavanje
- poslovni izvještaji
- LOT sljedivost

## Moduli

### Pregled
Praćenje ukupne vrijednosti zaliha, količina, LOT slojeva i upozorenja.

### Artikli
Pregled artikala, minimalnih i sigurnosnih količina te dobavljača.

### Narudžbe
Kreiranje i praćenje otvorenih narudžbenica.

### Zaprimanje
Zaprimanje robe po LOT-u uz evidenciju skladišta, otpremnice i roka trajanja.

### Zalihe
FIFO izdavanje robe iz LOT slojeva.

### Izvještaji
Pregled otvorenih stavki i vrijednosti zaliha.

### LOT sljedivost
Praćenje kompletnog kretanja LOT-a kroz sustav.

## Tehnologije

- C#
- WinForms
- Microsoft SQL Server
- ADO.NET
- GitHub

## Autor

Marija Odobašić
