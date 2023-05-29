CREATE DATABASE zastita3grupa
GO
USE zastita3grupa;
GO

CREATE TABLE adminnalozi
(
	korime VARCHAR(20) NOT NULL PRIMARY KEY,
	lozinka VARCHAR(20) NOT NULL,
	uloga VARCHAR(20) NOT NULL
);
GO
CREATE TABLE korisnici
(
	korime VARCHAR(20) NOT NULL PRIMARY KEY,
	lozinka VARCHAR(20) NOT NULL,
	email VARCHAR(30) NOT NULL,
	pitanje VARCHAR(20),
	odgovor VARCHAR(20),
	uloga VARCHAR(20) NOT NULL
);
GO

INSERT INTO adminnalozi
VALUES('ana','ana123','admin'),
('emilija','emilija123','admin'),
('lazar','lazar123','admin');
GO
SELECT * FROM adminnalozi;