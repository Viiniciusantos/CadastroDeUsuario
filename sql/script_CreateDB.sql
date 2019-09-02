CREATE DATABASE TailorIT;
GO

USE [TailorIT]
GO

CREATE TABLE [Sexo] (
    [SexoId] int IDENTITY(1,1),
    [Descricao] varchar(15) NOT NULL,
    CONSTRAINT [PK_Sexo] PRIMARY KEY ([SexoId])
);
GO

CREATE TABLE [Usuarios] (
    [UsuarioId] int IDENTITY(1,1),
    [Nome] varchar(200) NOT NULL,
    [DataNascimento] Datetime NOT NULL,
    [Email] varchar(100),
    [Senha] varchar(30),
    [Ativo] bit,
    [SexoId] int NOT NULL,
    CONSTRAINT [PK_Usuarios] PRIMARY KEY ([UsuarioId]),
	CONSTRAINT [FK_Usuarios_Sexo_SexoId] FOREIGN KEY ([SexoId]) REFERENCES [Sexo] ([SexoId]) ON DELETE NO ACTION
);
GO

CREATE UNIQUE INDEX [IX_Usuarios_UsuarioId] ON [Usuarios] ([UsuarioId]);
GO

CREATE UNIQUE INDEX [IX_Sexo_SexoId] ON [Sexo] ([SexoId]);
GO

INSERT INTO [Sexo] ([Descricao])
VALUES ('Masculino');
GO

INSERT INTO [Sexo] ([Descricao])
VALUES ('Feminino');
GO