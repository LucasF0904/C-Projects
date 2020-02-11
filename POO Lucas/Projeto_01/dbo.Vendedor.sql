CREATE TABLE [dbo].[Vendedor] (
    [Codigo]         INT        NOT NULL,
    [Nome]           NCHAR (50) NULL,
    [Rua]            NCHAR (10) NULL,
    [Numero]         INT NULL,
    [Telefone]       NCHAR (10) NULL,
    [Bairro]         NCHAR (10) NULL,
    [Logradouro]     NCHAR (10) NULL,
    [Cidade]         NCHAR (10) NULL,
    [Estado]         NCHAR (10) NULL,
    [DataNascimento] NVARCHAR(50)       NULL,
    [Comissao]       MONEY      NULL,
    PRIMARY KEY CLUSTERED ([Codigo] ASC)
);

