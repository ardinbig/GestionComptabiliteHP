
-- TOUTES LES VUES

-- Liste de classe avec catégorie

CREATE VIEW v_list_classe AS
SELECT cls.id, cls.designation, categ.designation as categorie, numero FROM tClasse as cls
INNER JOIN tCategClasse as categ ON cls.ref_categClasse = categ.id
GO

-- Liste de compte avec classe

CREATE VIEW v_list_compte AS
SELECT cpt.id, cpt.designation, cpt.numero, cls.designation as classe FROM tCompte as cpt
INNER JOIN tClasse as cls ON cpt.ref_classe = cls.id
GO

-- Liste de sous compte avec compte

CREATE VIEW v_list_scompte AS
SELECT scpt.id, scpt.designation, scpt.numero, cpt.designation as compte FROM tSCompte as scpt
INNER JOIN tCompte as cpt ON scpt.ref_compte = cpt.id
GO

-- Liste de sous sous compte avec sous compte

CREATE VIEW v_list_sscompte AS
SELECT sscpt.id, sscpt.designation, sscpt.numero, scpt.designation as sous_compte FROM tSSCompte as sscpt
INNER JOIN tSCompte as scpt ON sscpt.ref_scompte = scpt.id
GO

-- Liste de sous sous compte avec le numéro du compte en entier

CREATE VIEW v_list_numero_compte AS
SELECT sscpt.id, cpt.numero as compte, scpt.numero as scompte, sscpt.numero as sscompte, sscpt.designation as design,
	CONVERT(NVARCHAR(10), cpt.numero) + '.' + CONVERT(NVARCHAR(10), scpt.numero + sscpt.numero)  + ' : ' + sscpt.designation as vrai_compte
FROM tSSCompte as sscpt
INNER JOIN tSCompte as scpt ON sscpt.ref_SCompte = scpt.id
INNER JOIN tCompte as cpt ON scpt.ref_compte = cpt.id  
GO

-- Liste de opéreations avec mouvement

CREATE VIEW v_list_operation_debit AS 
SELECT opt.id as idOpt, vrai_compte, montant, type_operation FROM tOperation as opt
INNER JOIN tMouvement as mvt ON mvt.ref_operation = opt.id
INNER JOIN v_list_numero_compte as v ON mvt.ref_sscompte = v.id
WHERE type_operation = 'Débit'
GO

CREATE VIEW v_list_operation_credit AS 
SELECT opt.id as idOpt, vrai_compte, montant, type_operation FROM tOperation as opt
INNER JOIN tMouvement as mvt ON mvt.ref_operation = opt.id
INNER JOIN v_list_numero_compte as v ON mvt.ref_sscompte = v.id
WHERE type_operation = 'Crédit'
GO

CREATE VIEW v_list_operations AS
SELECT id, date_operation, libelle, d.vrai_compte as compte_d, d.montant as montant_d, 
	d.type_operation as type_d, c.vrai_compte as compte_c, c.montant as montant_c, 
	c.type_operation as type_c FROM tOperation as opt
INNER JOIN v_list_operation_credit as c ON opt.id = c.idOpt
INNER JOIN v_list_operation_debit as d ON opt.id = d.idOpt

select * from v_list_operations