USE MarijaERP;
GO

DROP TABLE IF EXISTS PrometZaliha;
DROP TABLE IF EXISTS Lotovi;
DROP TABLE IF EXISTS NarudzbenicaStavke;
DROP TABLE IF EXISTS Narudzbenice;
DROP TABLE IF EXISTS Skladista;
DROP TABLE IF EXISTS Artikli;
DROP TABLE IF EXISTS Dobavljaci;
GO

CREATE TABLE Dobavljaci (
    DobavljacID INT IDENTITY(1,1) PRIMARY KEY,
    Sifra NVARCHAR(30) NOT NULL,
    Naziv NVARCHAR(100) NOT NULL,
    OIB NVARCHAR(20),
    Email NVARCHAR(100)
);

CREATE TABLE Artikli (
    ArtiklID INT IDENTITY(1,1) PRIMARY KEY,
    SKU NVARCHAR(30) NOT NULL,
    Naziv NVARCHAR(100) NOT NULL,
    JedinicaMjere NVARCHAR(10) NOT NULL,
    MinimalnaKolicina DECIMAL(18,2) NOT NULL,
    SigurnosnaKolicina DECIMAL(18,2) NOT NULL
);

CREATE TABLE Skladista (
    SkladisteID INT IDENTITY(1,1) PRIMARY KEY,
    Sifra NVARCHAR(30) NOT NULL,
    Naziv NVARCHAR(100) NOT NULL
);

CREATE TABLE Narudzbenice (
    NarudzbenicaID INT IDENTITY(1,1) PRIMARY KEY,
    Broj NVARCHAR(30) NOT NULL,
    DobavljacID INT NOT NULL,
    Datum DATE NOT NULL,
    OcekivaniDatum DATE NULL,
    Status NVARCHAR(30) NOT NULL,
    FOREIGN KEY (DobavljacID) REFERENCES Dobavljaci(DobavljacID)
);

CREATE TABLE NarudzbenicaStavke (
    StavkaID INT IDENTITY(1,1) PRIMARY KEY,
    NarudzbenicaID INT NOT NULL,
    ArtiklID INT NOT NULL,
    Kolicina DECIMAL(18,2) NOT NULL,
    Cijena DECIMAL(18,2) NOT NULL,
    Zaprimljeno DECIMAL(18,2) NOT NULL DEFAULT 0,
    FOREIGN KEY (NarudzbenicaID) REFERENCES Narudzbenice(NarudzbenicaID),
    FOREIGN KEY (ArtiklID) REFERENCES Artikli(ArtiklID)
);

CREATE TABLE Lotovi (
    LotID INT IDENTITY(1,1) PRIMARY KEY,
    LotBroj NVARCHAR(50) NOT NULL,
    ArtiklID INT NOT NULL,
    SkladisteID INT NOT NULL,
    DatumZaprimanja DATE NOT NULL,
    RokTrajanja DATE NULL,
    Kolicina DECIMAL(18,2) NOT NULL,
    NabavnaCijena DECIMAL(18,2) NOT NULL,
    FOREIGN KEY (ArtiklID) REFERENCES Artikli(ArtiklID),
    FOREIGN KEY (SkladisteID) REFERENCES Skladista(SkladisteID)
);

CREATE TABLE PrometZaliha (
    PrometID INT IDENTITY(1,1) PRIMARY KEY,
    LotID INT NOT NULL,
    Datum DATETIME NOT NULL DEFAULT GETDATE(),
    VrstaPrometa NVARCHAR(20) NOT NULL,
    Kolicina DECIMAL(18,2) NOT NULL,
    Napomena NVARCHAR(200),
    FOREIGN KEY (LotID) REFERENCES Lotovi(LotID)
);
IF OBJECT_ID('Zaprimanja', 'U') IS NULL
BEGIN
    CREATE TABLE Zaprimanja (
        ZaprimanjeID INT IDENTITY(1,1) PRIMARY KEY,
        NarudzbenicaID INT NOT NULL,
        StavkaID INT NOT NULL,
        SkladisteID INT NOT NULL,
        LotID INT NOT NULL,
        Otpremnica NVARCHAR(50),
        LotDobavljaca NVARCHAR(50),
        Kolicina DECIMAL(18,2) NOT NULL,
        NabavnaCijena DECIMAL(18,2) NOT NULL,
        Zaprimio NVARCHAR(100),
        DatumZaprimanja DATETIME NOT NULL DEFAULT GETDATE(),
        FOREIGN KEY (NarudzbenicaID) REFERENCES Narudzbenice(NarudzbenicaID),
        FOREIGN KEY (StavkaID) REFERENCES NarudzbenicaStavke(StavkaID),
        FOREIGN KEY (SkladisteID) REFERENCES Skladista(SkladisteID),
        FOREIGN KEY (LotID) REFERENCES Lotovi(LotID)
    );
END
GO

INSERT INTO Dobavljaci (Sifra, Naziv, OIB, Email)
VALUES
('DOB-MED-BREG', 'OPG Medni Breg', 'HR12345678901', 'nabava@mednibreg.example'),
('DOB-ZLAT-DOL', 'Pčelarstvo Zlatna Dolina', 'HR98765432109', 'prodaja@zlatnadolina.example'),
('DOB-STAKLO-ZG', 'Staklo i Ambalaža Zagreb d.o.o.', 'HR10987654321', 'nabava@staklozagreb.example');

INSERT INTO Artikli (SKU, Naziv, JedinicaMjere, MinimalnaKolicina, SigurnosnaKolicina)
VALUES
('MED-BAG-450', 'Bagremov med 450 g', 'kom', 80, 200),
('MED-LIP-450', 'Lipov med 450 g', 'kom', 70, 180),
('PCE-PRO-030', 'Propolis kapi 30 ml', 'kom', 40, 120),
('POK-MED-TRIO', 'Poklon paket Medeni trio', 'kom', 25, 80);

INSERT INTO Skladista (Sifra, Naziv)
VALUES
('ZAG-GLAVNO', 'Glavno skladište Zagreb');

INSERT INTO Narudzbenice (Broj, DobavljacID, Datum, OcekivaniDatum, Status)
VALUES
('PO-2026-0001', 1, '2026-05-02', '2026-05-14', 'Djelomično zaprimljeno'),
('PO-2026-0002', 2, '2026-04-25', '2026-05-07', 'Djelomično zaprimljeno');

INSERT INTO NarudzbenicaStavke (NarudzbenicaID, ArtiklID, Kolicina, Cijena, Zaprimljeno)
VALUES
(1, 1, 100, 4.35, 10),
(1, 2, 160, 4.10, 0),
(2, 3, 120, 5.90, 0);

INSERT INTO Lotovi (LotBroj, ArtiklID, SkladisteID, DatumZaprimanja, RokTrajanja, Kolicina, NabavnaCijena)
VALUES
('BAGREM-2026-A', 1, 1, '2026-04-10', '2027-04-10', 70, 4.35),
('BAGREM-2026-B', 1, 1, '2026-04-28', '2027-04-28', 180, 4.55),
('LIPA-2026-01', 2, 1, '2026-05-01', '2027-05-01', 160, 4.10),
('PROP-2026-05', 3, 1, '2026-05-03', '2027-05-03', 60, 5.90),
('TRIO-2026-04', 4, 1, '2026-04-16', '2027-04-16', 45, 11.80);
GO

USE MarijaERP;
GO

SELECT * FROM Artikli;
SELECT * FROM Dobavljaci;
SELECT * FROM Skladista;
SELECT * FROM Lotovi;