CREATE TABLE [dbo].[Libros] (
    [Id]         INT           NOT NULL IDENTITY,
    [Titulo]     NCHAR (100)   NULL,
    [Idioma]     NCHAR (20)    NULL,
    [Finalizado] BIT           NULL,
    [Fecha]      DATETIME2 (7) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);