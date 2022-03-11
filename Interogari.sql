 USE Revista_ProiectBD

--Populare tabel de legatura--
DELETE FROM PROPUNERE 
INSERT INTO Propunere (ID_Articol, ID_Jurnalist, Titlu)
SELECT A.ID_Articol, J.ID_Jurnalist, A.Titlu_Articol
FROM Articol A, Jurnalist J
WHERE A.Titlu_Articol=J.Titlu_Articol

UPDATE Propunere
SET
    Propunere.ID_Redactor = J.ID_Redactor
FROM
    Propunere P INNER JOIN Jurnalist J
ON 
    P.ID_Jurnalist = J.ID_Jurnalist;

ALTER TABLE Jurnalist
DROP COLUMN CNP

ALTER TABLE PROPUNERE 
ADD ID_Redactor int

ALTER TABLE REDACTOR
DROP COLUMN Titlu_Articol

ALTER TABLE REDACTOR
ADD Titlu_Departament nvarchar(50)

--Verificare nume articole--
--SELECT J.Titlu_Articol, A.Titlu_Articol,
--  CASE WHEN J.Titlu_Articol=A.Titlu_Articol
--   THEN '1' 
--    ELSE '0' 
--  END 
--  AS MyDesiredResult
--FROM Jurnalist J
--INNER JOIN Articol A ON J.Titlu_Articol = A.Titlu_Articol
--GROUP BY J.Titlu_Articol, A.Titlu_Articol

--1.Cate articole trimise redactorului apartin departamentului x?--
SELECT D.Nume_Departament, COUNT(A.ID_Articol) AS Numar_Articole
FROM Departament D INNER JOIN Articol A ON D.ID_Departament=A.ID_Departament
WHERE D.Nume_Departament='Fotbal'
GROUP BY D.Nume_Departament

--2.Redactorii cu cei mai mult articole trimise de jurnalistii in subordine.-- 
SELECT R.Nume, R.Prenume, COUNT(J.ID_Jurnalist) AS Articole_Jurnalisti_Subordine
FROM Redactor R INNER JOIN Jurnalist J ON R.ID_Redactor=J.ID_Redactor
GROUP BY R.Nume, R.Prenume
ORDER BY R.Nume, R.Prenume DESC

--3.Care sunt jurnalistii care au scris aricole de prioritate X? (prioritate intre 1 si 5)--
SELECT J.Nume, J.Prenume, J.Departament, A.Titlu_Articol, A.Prioritate AS Prioritate_Articole
FROM Articol A INNER JOIN Jurnalist J ON A.Titlu_Articol=J.Titlu_Articol
WHERE A.Prioritate=1  
GROUP BY J.Nume, J.Prenume, J.Departament, A.Titlu_Articol, A.Prioritate

--4.Cate articole are revista X?--
SELECT R.Titlu_Revista, COUNT (A.ID_Articol) AS Numar_Articole
FROM Revista R INNER JOIN Departament D ON R.ID_Revista=D.ID_Revista INNER JOIN Articol A ON A.ID_Departament=D.ID_Departament
WHERE R.Titlu_Revista='Vague'
GROUP BY R.Titlu_Revista

--5.Cate pagini are fiecare revista?--
SELECT R.Titlu_Revista, SUM(A.Numar_Pagini) AS Numar_Pagini
FROM Revista R INNER JOIN Departament D ON R.ID_Revista=D.ID_Revista INNER JOIN Articol A ON A.ID_Departament=D.ID_Departament
GROUP BY R.Titlu_Revista

--6.Top 10 articole prioritare.--
SELECT TOP 10 J.Nume, J.Prenume, J.Departament, A.Titlu_Articol, COUNT(A.ID_Articol) AS Prioritate_Articol
FROM Jurnalist J INNER JOIN Articol A ON A.Titlu_Articol=J.Titlu_Articol
GROUP BY J.Nume, J.Prenume, J.Departament , A.Titlu_Articol, A.Prioritate
ORDER BY A.Prioritate ASC 
--SUBCERERI--

--1. Afisati titlul primelor 10 aricole in functie de numarul de pagini.--
SELECT TOP 10 A.Titlu_Articol, A.Numar_Pagini  
FROM Articol A  
WHERE A.Numar_Pagini >= ANY (select A2.Numar_Pagini   
FROM Articol A2  
GROUP BY A2.Numar_Pagini )  
GROUP BY A.Titlu_Articol, A.Numar_Pagini  
ORDER BY A.Numar_Pagini DESC  

--2.In ce luna s-au scris cele mai multe articole?--
SELECT MONTH(A.Data) AS Luna_Scriere, COUNT(A.ID_Articol) AS Numar_ArticoleScrise
FROM Articol A
GROUP BY MONTH(A.Data)
HAVING COUNT(A.Data) >= (SELECT TOP 1 count (A2.Data) FROM Articol A2 GROUP BY MONTH(A2.Data)  
ORDER BY count(A2.Data) DESC)

--3.Numele si prenumele angajatilor care fac parte din departamentul x.--
SELECT DISTINCT J.Nume, J.Prenume
FROM Jurnalist J, (SELECT J2.ID_Jurnalist
FROM Jurnalist J2
WHERE J2.Departament='Fotbal') AS J3
WHERE J.ID_Jurnalist = J3.ID_Jurnalist;

--4.Numele revistei si cate departamente are REVISTA.-- 
SELECT R.Titlu_Revista,(
SELECT COUNT(*) FROM Departament D
WHERE D.ID_Revista=R.ID_Revista)
AS Revista_Departament
FROM Revista R

SELECT * FROM Jurnalist



































