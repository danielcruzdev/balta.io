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