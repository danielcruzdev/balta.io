--DROP DATABASE Cursos

CREATE DATABASE Cursos

USE Cursos

--DROP TABLE [Categoria]

GO

CREATE TABLE [Categoria] (
    [Id]         INT IDENTITY(1, 1),
    [Nome]       NVARCHAR(80) NOT NULL,

    CONSTRAINT [PK_Categoria] PRIMARY KEY([Id]),
)

GO

INSERT INTO [Categoria] (Nome) VALUES ('Backend');
INSERT INTO [Categoria] (Nome) VALUES ('FrontEnd');
INSERT INTO [Categoria] (Nome) VALUES ('Mobile');
INSERT INTO [Categoria] (Nome) VALUES ('Banco de Dados');

GO

--DROP TABLE [Curso]

CREATE TABLE [Curso] (
    [Id]          INT IDENTITY(1, 1),
    [Nome]        NVARCHAR(80) NOT NULL,
    [CategoriaId] INT NOT NULL

    CONSTRAINT [PK_Curso] PRIMARY KEY([Id]),
    CONSTRAINT [FK_CursoCategoria] FOREIGN KEY([CategoriaId]) REFERENCES [Categoria]([Id])
)

GO

INSERT INTO Curso (Nome, CategoriaId) VALUES ('Fundamentos C#', 1);
INSERT INTO Curso (Nome, CategoriaId) VALUES ('Fundamentos OOP', 1);
INSERT INTO Curso (Nome, CategoriaId) VALUES ('Fundamentos Angular', 2);
INSERT INTO Curso (Nome, CategoriaId) VALUES ('Fundamentos Flutter', 3);
INSERT INTO Curso (Nome, CategoriaId) VALUES ('Fundamentos SQL Server', 4);

GO

--SELECT

SELECT a.Id, a.Nome, a.CategoriaId
  FROM Curso a
--  WHERE a.CategoriaId = 1
ORDER BY a.Nome, a.Id, a.CategoriaId