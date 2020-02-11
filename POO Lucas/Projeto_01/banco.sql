CREATE TABLE [dbo].[Cliente] (
    [ID Cliente] INT        NOT NULL,
    [Nome]       NCHAR (50) NULL,
    [Identidade] INT        NULL,
    [CPF]        INT        NULL,
    [Rua]        NCHAR (50) NULL,
    [Numero]     INT        NULL,
    [Bairro]     NCHAR (50) NULL,
    [Cidade]     NCHAR (42) NULL,
    [Estado]     NCHAR (50) NULL,
    [Telefone]   INT        NULL,
    PRIMARY KEY CLUSTERED ([ID Cliente] ASC)
);

CREATE TABLE [dbo].[Produto] (
    [Codigo Produto] INT          NOT NULL,
    [Nome]           NCHAR (50)   NULL,
    [Quantidade]     DECIMAL (18) NULL,
    [Preco]          REAL         NULL,
    PRIMARY KEY CLUSTERED ([Codigo Produto] ASC)
);

CREATE TABLE [dbo].[Venda] (
    [Codigo Venda] INT        NOT NULL,
    [DataVenda]    DATE       NULL,
    [DataIntrega]  DATE       NULL,
    [Total]        MONEY      NULL,
    [Status]       NCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Codigo Venda] ASC)
);

CREATE TABLE [dbo].[Vendedor] (
    [Codigo]         INT        NOT NULL,
    [Nome]           NCHAR (50) NULL,
    [Rua]            NCHAR (10) NULL,
    [Numero]         NCHAR (10) NULL,
    [Telefone]       NCHAR (10) NULL,
    [Bairro]         NCHAR (10) NULL,
    [Logradouro]     NCHAR (10) NULL,
    [Cidade]         NCHAR (10) NULL,
    [Estado]         NCHAR (10) NULL,
    [DataNascimento] DATE       NULL,
    [Comissao]       MONEY      NULL,
    PRIMARY KEY CLUSTERED ([Codigo] ASC)
);


CREATE TABLE [dbo].[Item] (
    [Id]        INT NOT NULL,
    [cod_venda] INT NOT NULL,
    [iditem]    INT NULL,
    [qtditem]   INT NULL,
    [valoritem] INT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Item_Venda] FOREIGN KEY ([cod_venda]) REFERENCES [dbo].[Venda] ([Codigo Venda])
);

