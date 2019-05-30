
-- SCRIPT DE LA BASE DE DONNEES  

USE master
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
	CONSTRAINT PK_CategtClasse PRIMARY KEY(id)
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
	CONSTRAINT FK_Scompte_Compte FOREIGN KEY (ref_compte) 
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
	CONSTRAINT FK_SSCompte_SCompte FOREIGN KEY (ref_SCompte) 
		REFERENCES tSCompte(id)
)
GO

-- TOUTES LES PROCEDURES

CREATE PROCEDURE sp_insert_update_categClasse 
(
	@id INT,
	@designation NVARCHAR(100)
) AS
BEGIN
	IF NOT EXISTS(SELECT * FROM tCategClasse WHERE id=@id ) 
		BEGIN
			INSERT INTO tCategClasse (id,designation) VALUES (@id ,@designation )
		END
	ELSE 
		BEGIN 
			UPDATE tCategClasse SET designation=@designation WHERE id=@id
		END 
END
GO

CREATE PROCEDURE sp_insert_update_classe 
(
	@id INT ,
	@designation NVARCHAR(100),
	@numero INT,
	@ref_categClasse INT
) AS
BEGIN
	IF NOT EXISTS (SELECT * FROM tClasse WHERE id=@id)
		BEGIN
			INSERT INTO tClasse (id,designation,numero,ref_categClasse) VALUES(@id,@designation,@numero,@ref_categClasse)
		END
	ELSE 
		BEGIN
			UPDATE tClasse SET designation =@designation,numero=@numero,ref_categClasse=@ref_categClasse WHERE id=@id
		END 
END
GO

CREATE PROCEDURE sp_insert_update_compte 
(
	@id INT ,
	@designation NVARCHAR(100),
	@numero INT,
	@ref_classe INT
) AS
BEGIN
	IF NOT EXISTS (SELECT * FROM tCompte WHERE id=@id)
		BEGIN
			INSERT INTO tCompte (id,designation,numero,ref_classe) VALUES(@id,@designation,@numero,@ref_classe)
		END
	ELSE 
		BEGIN
			UPDATE  tCompte SET designation =@designation,numero=@numero,ref_classe=@ref_classe WHERE id=@id
		END 
END
GO

CREATE PROCEDURE sp_insert_update_sCompte
(
	@id INT ,
	@designation NVARCHAR(100),
	@numero INT,
	@ref_compte INT
) AS
BEGIN
	IF NOT EXISTS (SELECT * FROM tSCompte WHERE id=@id)
		BEGIN
			INSERT INTO tSCompte (id,designation,numero,ref_compte) VALUES(@id,@designation,@numero,@ref_compte)
		END
	ELSE 
		BEGIN
			UPDATE  tSCompte SET designation =@designation,numero=@numero,ref_compte=@ref_compte WHERE id=@id
		END 
END
GO

CREATE PROCEDURE sp_insert_update_ssCompte 
(
	@id INT ,
	@designation NVARCHAR(100),
	@numero INT,
	@ref_SCompte INT
) AS
BEGIN
	IF NOT EXISTS (SELECT * FROM tSSCompte)
		BEGIN
			INSERT INTO tSSCompte (id,designation,numero,ref_SCompte) VALUES(@id,@designation,@numero,@ref_SCompte)
		END
	ELSE 
		BEGIN
			UPDATE  tSSCompte SET designation =@designation,numero=@numero,ref_SCompte=@ref_SCompte WHERE id=@id
		END 
END
GO

--TOUTES LES SUPPRESSIONS DES TABLES 

CREATE PROCEDURE SP_DELETE_tCategClasse
(
@id INT 

)
AS
BEGIN
IF NOT EXISTS (SELECT * FROM tCategClasse)
BEGIN
DELETE FROM tCategClasse WHERE id=@id
END
END
GO


CREATE PROCEDURE SP_DELETE_tClasse
(
@id INT 

)
AS
BEGIN
IF NOT EXISTS (SELECT * FROM tClasse)
BEGIN
DELETE FROM tClasse WHERE id=@id
END
END
GO

CREATE PROCEDURE SP_DELETE_tCompte
(
@id INT 

)
AS
BEGIN
IF NOT EXISTS (SELECT * FROM tCompte)
BEGIN
DELETE FROM tCompte WHERE id=@id
END
END
GO

CREATE PROCEDURE SP_DELETE_tSCompte
(
@id INT 

)
AS
BEGIN
IF NOT EXISTS (SELECT * FROM tSCompte)
BEGIN
DELETE FROM tSCompte WHERE id=@id
END
END
GO

CREATE PROCEDURE SP_DELETE_StSCompte
(
@id INT 

)
AS
BEGIN
IF NOT EXISTS (SELECT * FROM StSCompte)
BEGIN
DELETE FROM StSCompte WHERE id=@id
END
END
GO
