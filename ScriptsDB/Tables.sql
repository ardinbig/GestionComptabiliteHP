
--  SCRIPT DE TOUTES LES TABLES 

USE master
GO

IF EXISTS (SELECT * FROM sys.databases WHERE name = 'GestionComptabiliteHp_DB')
	DROP DATABASE GestionComptabiliteHp_DB
GO

CREATE DATABASE GestionComptabiliteHp_DB
GO 

USE GestionComptabiliteHp_DB
GO

-- TABLE CATEGORIE tClasse

CREATE TABLE tCategClasse
( 
	id INT ,
	designation NVARCHAR(100) NOT NULL,
	CONSTRAINT PK_CategClasse PRIMARY KEY(id),
	CONSTRAINT UQ_CategClasse UNIQUE (designation)
)
GO

-- TABLE tClasse

CREATE TABLE tClasse
(
	id INT ,
	designation NVARCHAR(100) NOT NULL,
	numero INT NOT NULL ,
	ref_categClasse INT,
	CONSTRAINT PK_Classe PRIMARY KEY(id),
	CONSTRAINT UQ_Classe UNIQUE (designation),
	CONSTRAINT FK_Classe_CategClasse FOREIGN KEY (ref_categClasse) 
		REFERENCES tCategClasse(id)
)
GO

-- TABLE COMPTE

CREATE TABLE tCompte
(
	id INT ,
	designation NVARCHAR(100) NOT NULL,
	numero INT NOT NULL,	
	ref_classe INT,
	CONSTRAINT PK_Compte PRIMARY KEY(id),
	CONSTRAINT UQ_Compte UNIQUE (designation),
	CONSTRAINT FK_Compte_Classe FOREIGN KEY (ref_classe) 
		REFERENCES tClasse(id)
)
GO

-- TABLE SOUS COMPTE

 CREATE TABLE  tSCompte
(
	id INT ,
	designation NVARCHAR(100) NOT NULL,
	numero INT NOT NULL,	
	ref_compte INT,
	CONSTRAINT PK_SCompte PRIMARY KEY(id),
	CONSTRAINT UQ_SCompte UNIQUE (designation),
	CONSTRAINT FK_SCompte_Compte FOREIGN KEY (ref_compte) 
		REFERENCES tCompte(id)
)
GO

-- TABLE SOUS SOUS COMPTE

 CREATE TABLE  tSSCompte
(
	id INT ,
	designation NVARCHAR(100) NOT NULL,
	numero INT NOT NULL,	
	ref_SCompte INT,
	CONSTRAINT PK_SSCompte PRIMARY KEY(id),
	CONSTRAINT UQ_SSCompte UNIQUE (designation),
	CONSTRAINT FK_SSCompte_SCompte FOREIGN KEY (ref_SCompte) 
		REFERENCES tSCompte(id)
)
GO

-- TABLE OPERATION

CREATE TABLE tOperation
(
	id INT,
	date_operation DATETIME NOT NULL,
	libelle NVARCHAR(100) NOT NULL,
	utilisateur NVARCHAR(100),
	CONSTRAINT PK_Operation PRIMARY KEY (id)
)
GO

-- TABLE MOUVEMENT DES OPERATIONS

CREATE TABLE tMouvement
(
	id BIGINT IDENTITY(1,1),
	ref_operation INT,
	ref_sscompte INT,
	montant FLOAT NOT NULL,
	type_operation NVARCHAR(10) NOT NULL,
	CONSTRAINT PK_Mouvement PRIMARY KEY (id),
	CONSTRAINT FK_Mouvement_Operation FOREIGN KEY (ref_operation)
		REFERENCES tOperation(id),
	CONSTRAINT FK_Mouvement_SSCompte FOREIGN KEY (ref_sscompte)
		REFERENCES tSScompte(id)
)
GO
