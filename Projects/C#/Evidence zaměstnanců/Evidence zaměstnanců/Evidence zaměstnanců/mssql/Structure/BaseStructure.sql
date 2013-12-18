CREATE TABLE AboutPrograms
(
	id INT CONSTRAINT IndexKey PRIMARY KEY,
	[Version] varchar(10),
	[Date] datetime,
	LastChanged datetime,
)

CREATE TABLE [Login]
(
	username varchar(30) CHECK (username is not null AND username <> ''),
	email varchar(30),
	[password] varchar(255),
	UNIQUE (username)
)

-- Password is root
INSERT INTO dbo.Login values('admin', 'Email@seznam.cz', '1000:fUfSA21iLeLHnvkT2cnTSxgSSx7Vizzq:ZG0HAsIIMwYxtmoYzc1fjYlSP8IQRrZ3')

CREATE TABLE Employee
(
	ID INT CONSTRAINT PrimaryIndex PRIMARY KEY,
	Jmeno varchar(20) CHECK (Jmeno is not null AND Jmeno <> ''),
	Prijemni varchar(20) CHECK (Prijemni is not null AND Prijemni <> ''),
	Email varchar(30),
	RodneCislo varchar(30),
	PracovniPozice varchar(100),
	TelefonPrace varchar(15),
	FaxPrace varchar(15),
	TelefonDomu varchar(15),
	Adresa varchar(255),
	Ulice varchar(255),
	Mesto varchar(100),
	CP int,
	CO int,
	Mzda money,
	Pobocka char(2),
	Utvar char(2),
)