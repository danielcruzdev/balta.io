SELECT * FROM Categoria

BEGiN TRANSACTION

UPDATE a
   SET a.Nome = 'Azure33333'
  FROM Categoria a
 WHERE a.Id = 1

ROLLBACK