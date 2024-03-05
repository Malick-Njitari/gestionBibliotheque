Ajouter Un Nouvau Livre
SOLUTION
	INSERT INTO LIVRE (CODECATALOGUELIVRE, CODETHEMELIVRE, COTELIVRE, TITRELIVRE, NOMAUTEURLIVRE, NOMEDITEURLIVRE) 
	
		VALUES ("LIV003", "TH01", "L100", "BASE DE DONNEES", "KUIKA", "ELOUNDOU");
	
	
Modifier Auteur du Livre Précédemment Ajouté Avec Une Valeur de Votre Choix
SOLUTION
	UPDATE LIVRE SET NOMAUTEURLIVRE = "JE SUIS BETE" WHERE CODECATALOGUELIVRE = "LIV003";
	

Afficher Tous Les Abonnés Qui Ont Prêté Un Livre
SOLUTION
	SELECT A.NOMABONNE, A.TELEPHONEABONNE, P.DATEDEPRET, P.DATEDERETOURPRET
		FROM ABONNE A, PRET P
			WHERE A.MATRICULEABONNE = P.MATRICULEABONNE; 

Afficher Les Abonnés Qui Ont Emprunté Un Livre Dont La Date de Retour du Livre Est Dépassé
SOLUTION
	SELECT A.NOMABONNE, A.TELEPHONEABONNE, P.DATEDEPRET, P.DATEDERETOURPRET, CURDATE() AS DATE_DU_JOUR
		FROM ABONNE A, PRET P
			WHERE A.MATRICULEABONNE = P.MATRICULEABONNE
			AND P.DATEDERETOURPRET < CURDATE();
	

Supprimer Le Livre dont Le Code Catalogue Est CC-0547
SOLUTION
	DELETE FROM LIVRE WHERE CODECATALOGUELIVRE = "CC-0547";
	

