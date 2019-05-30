
-- TOUTES LES PROCEDURES

USE GestionComptabiliteHp_DB
GO

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
	@ref_scompte INT
) AS
BEGIN
	IF NOT EXISTS (SELECT * FROM tSSCompte WHERE id=@id)
		BEGIN
			INSERT INTO tSSCompte (id,designation,numero,ref_SCompte) VALUES(@id,@designation,@numero,@ref_scompte)
		END
	ELSE 
		BEGIN
			UPDATE  tSSCompte SET designation =@designation,numero=@numero,ref_SCompte=@ref_scompte WHERE id=@id
		END 
END
GO

CREATE PROCEDURE sp_insert_operation
(
	@id INT, @date DATETIME, @libelle NVARCHAR(100),
	@montant FLOAT,
	@ref_sscompte1 INT, @type1 NVARCHAR(10),
	@ref_sscompte2 INT, @type2 NVARCHAR(10)
)
AS 
BEGIN
	IF NOT EXISTS (SELECT * FROM tOperation WHERE id = @id)
		BEGIN
			INSERT INTO tOperation (id, date_operation, libelle, utilisateur)
				VALUES (@id, @date, @libelle, (SELECT SYSTEM_USER));

			INSERT INTO tMouvement (ref_operation, ref_sscompte, type_operation, montant)
				VALUES	(@id, @ref_sscompte1, @type1, @montant),
						(@id, @ref_sscompte2, @type2, @montant);					
		END
END 
GO

CREATE PROCEDURE sp_update_operation
(
	@id INT, @date DATETIME, @libelle NVARCHAR(100),
	@montant FLOAT,
	@ref_sscompte1 INT, @type1 NVARCHAR(10),
	@ref_sscompte2 INT, @type2 NVARCHAR(10)
)
AS 
BEGIN
	IF EXISTS (SELECT * FROM tOperation WHERE id = @id)
		BEGIN
			UPDATE tOperation SET date_operation = @date, libelle = @libelle, utilisateur = (SELECT SYSTEM_USER)
				WHERE id = @id;

			DELETE FROM tMouvement WHERE ref_operation = @id;

			INSERT INTO tMouvement (ref_operation, ref_sscompte, type_operation, montant)
				VALUES	(@id, @ref_sscompte1, @type1, @montant),
						(@id, @ref_sscompte2, @type2, @montant);					
		END
END 
GO

CREATE PROCEDURE sp_delete_operation
(
	@id INT
)
AS 
BEGIN
	IF EXISTS (SELECT * FROM tOperation WHERE id = @id)
		BEGIN
			DELETE FROM tMouvement WHERE ref_operation = @id;

			DELETE FROM tOperation WHERE id = @id;								
		END
END 
GO

CREATE PROCEDURE sp_journal_operation
(
	@date_debut DATETIME,
	@date_fin DATETIME
)
AS
BEGIN
	SELECT * FROM v_list_operations WHERE date_operation BETWEEN @date_debut AND @date_fin;
END
GO

