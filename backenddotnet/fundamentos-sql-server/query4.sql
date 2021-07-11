SELECT a.Id   AS Codigo,
       a.Nome AS Nome
  FROM Curso a


--JOINS
SELECT a.Id AS CursoId,
       a.Nome AS Curso,
       b.Id AS CategoriaId,
       b.Nome AS Categoria
  FROM Curso        a
     JOIN Categoria b ON a.CategoriaId = b.Id


--UNION
SELECT a.Id, a.Nome
  FROM Curso a

UNION ALL

SELECT a.Id, a.Nome
  FROM Categoria a


--GROUP BY
SELECT a.Nome, COUNT(b.CategoriaId) AS Qtde
  FROM Categoria a
    JOIN Curso   b ON a.Id = b.CategoriaId
GROUP BY b.CategoriaId, a.Nome

--HAVING
SELECT a.Nome, COUNT(b.CategoriaId) AS Qtde
  FROM Categoria a
    JOIN Curso   b ON a.Id = b.CategoriaId
GROUP BY b.CategoriaId, a.Nome
HAVING COUNT(b.CategoriaId) >= 2


SELECT * FROM  vwContagemCursosPorCategoria