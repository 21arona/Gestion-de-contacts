use bdContacts
DROP DATABASE bdContacts

CREATE TABLE contacts (
    ID int PRIMARY KEY  NOT NULL,
    Nom varchar(30) NOT NULL,
    Prenom varchar(50) NOT NULL,
    Adresse varchar(255) NOT NULL,
    City varchar(30) NOT NULL,
    Email varchar(50) NULL,
    CodePostal varchar(30) NOT NULL,
    Telephone varchar(50) NULL,
    DateNaissance varchar(50) NOT NULL  DEFAULT (getdate()),
	nomUtilisateur varchar(30) FOREIGN KEY REFERENCES  utilisateurs(nomUtilisateur)
);

--la liste des contacts enregistres
USE bdContacts
INSERT INTO contacts VALUES (1708, 'Robert', 'Jean' , '1200 Avenue Viau' ,'Quebec','jeanrobert7@gmail.com', 'H1T2V7','438-127-7451', '2001/06/15','arona123')

INSERT INTO contacts VALUES (1709, 'Bruan', 'Axel' , '2100 Rue Cedres' ,'Toronto','bruanaxel00@gmail.com', 'R1T2Q6','514-227-6485', '1999/12/27','khadija123')

INSERT INTO contacts VALUES (1710, 'Jasmin', 'Pauline' , '4060 Avenue Ontario' ,'Vancouver','jasminepauline17@gmail.com', 'S1T2P5','438-327-2589', '2000/08/23','arona123')

INSERT INTO contacts VALUES (1711, 'Billot', 'Paul' , '3680 Rue Sherbrooke' ,'Ottawa','paulbillot89@gmail.com', 'T1T2O4','514-427-6447', '1997/11/24','khadija123')

INSERT INTO contacts VALUES (1712, 'Fredo', 'Marc' , '5500 Avenue Papineau' ,'Calgary','fredomarc7@gmail.com', 'H1U2N3','438-527-3648', '2003/09/27','arona123')

INSERT INTO contacts VALUES (1713, 'Torat', 'Maxime' , '7090 Rue Cedres' ,'Winnipeg','maximetorat58@gmail.com', 'V1T2M2','514-627-6879', '1996/10/19','khadija123')

INSERT INTO contacts VALUES (1714, 'Hakim', 'Patrick' , '6089 Avenue Coubertin' ,'Edmonton','hakimpatrick26@gmail.com', 'W1T2L1','438-727-6975', '1995/08/17','arona123')

INSERT INTO contacts VALUES (1715, 'Bilza', 'Sophie' , '5340 Rue Belchasse' ,'Hamilton','bilzasophie73@gmail.com', 'X1T2K0','514-827-5624', '2004/11/23','khadija123')

INSERT INTO contacts VALUES (1716, 'Carat', 'Claire' , '9890 Avenue Brucy' ,'Trois-Rivieres','caratclaire54@gmail.com ', 'Y1T2J2','438-927-6462', '1994/06/12','arona123')

INSERT INTO contacts VALUES (1717, 'Balao', 'Caroline' , '4340 Rue Drullettes' ,'Halifax','carolinebalao67@gmail.com', 'Z1T2I4','514-107-3445', '2003/12/09','khadija123')

INSERT INTO contacts VALUES (1718, 'Morand', 'Christine' , '5460 Avenue Pontoise' ,'Brampton','morandchristine90@gmail.com', 'A1T2H6','514-117-8764', '1991/05/09','arona123')

INSERT INTO contacts VALUES (1719, 'Dumony', 'Max' , '6877 Rue Lacordaire' ,'Moncton','maxdumony13@gmail.com', 'B1T2G9','438-127-8900', '1993/02/11','khadija123')

INSERT INTO contacts VALUES (1720, 'Pamer', 'Pierre' , '8500 Avenue Blondin' ,'Regina','pierrepamer34@gmail.com', 'C1T2F5','514-137-5432', '1990/03/28','arona123')

INSERT INTO contacts VALUES (1721, 'Ashtang', 'Jean' , '7450 Rue Noue' ,'Gatineau','jeanashtang27@gmail.com', 'D1T2E3','438-147-2100', '1992/09/18','khadija123')

go
CREATE TABLE utilisateurs (
   Nom varchar(30) NOT NULL,
   Prenom varchar(50) NOT NULL,
   nomUtilisateur varchar(30) PRIMARY KEY NOT NULL,
   motDePasse varchar(30) NOT NULL
)

go

INSERT INTO utilisateurs VALUES ('Diop','Arona','arona123','ron999')
INSERT INTO utilisateurs VALUES ('Elaogdi','Khadija','khadija123','kdj456')

go

--DROP TABLE contacts 
--DROP TABLE utilisateurs
SELECT * FROM utilisateurs
SELECT * FROM contacts