SELECT * FROM Categoria

BEGIN TRANSACTION

UPDATE a
   SET a.Nome = 'Azure33333'
  FROM Categoria a
 WHERE a.Id = 1

ROLLBACK

BEGIN TRANSACTION
    DELETE a
    FROM Categoria a
    WHERE a.Id = 3
ROLLBACK


SELECT MIN(a.Id) AS MinId
  FROM Categoria a

SELECT MAX(a.Id) AS MaxId
  FROM Categoria a

SELECT COUNT(*) AS Qtde
  FROM Categoria a

SELECT AVG(a.Id) AS Media
  FROM Categoria a

SELECT SUM(a.Id) AS Soma
  FROM Categoria a