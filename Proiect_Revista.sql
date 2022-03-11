USE Revista_ProiectBD
GO

INSERT INTO dbo.Revista(Titlu_Revista, Editie, Numar_Revista, Data_Publicare, Numar_Pagini, Numar_Articole)
VALUES ('Vague', 2, 3, '2021-12-25', 35, 7)
select * from Revista

INSERT INTO dbo.Revista(Titlu_Revista, Editie, Numar_Revista, Data_Publicare, Numar_Pagini, Numar_Articole)
VALUES ('Bazaar', 4, 5, '2021-12-30', 27, 4)
select * from Revista

INSERT INTO dbo.Departament(ID_Revista, Nume_Departament, Articole_Propuse)
VALUES (14, 'Fashion', 1)
select * from Departament

INSERT INTO dbo.Redactor (ID_Departament, Titlu_Revista, Titlu_Articol, Nume, Prenume, Sex, Parola, Username)
VALUES (17,'Vague', 'Saptamana Modei', 'Diaconu', 'Mihai', 'M', 'pass1234', 'redactor_1')
select * from Redactor

INSERT INTO dbo.Jurnalist (ID_Redactor, Departament, Nume, Prenume, Sex, Titlu_Articol)
VALUES (18, 'Fashion', 'Ionescu', 'David', 'M', 'Saptamana Modei')
select * from Jurnalist

INSERT INTO dbo.Articol (ID_Departament, Titlu_Articol, Prioritate, Data, Numar_Pagini)
VALUES (17, 'Saptamana Modei', 3 , '2021-12-20', 3)
select * from Articol

DELETE FROM Revista
WHERE ID_Revista=20; 


DELETE FROM Departament
WHERE ID_Departament=18;


DELETE FROM Redactor
WHERE ID_Redactor=19;

DELETE FROM Articol
WHERE ID_Articol=19;
