CREATE TABLE [dbo].[usuarios] (
    [id]       UNIQUEIDENTIFIER CONSTRAINT [DF_usuarios_id] DEFAULT (newid()) NOT NULL,
    [nombre]   NVARCHAR (100)   NOT NULL,
    [apellido] NVARCHAR (100)   NOT NULL,
    [email]    NVARCHAR (100)   NOT NULL,
    [password] NVARCHAR (100)   NOT NULL,
    CONSTRAINT [PK_usuarios] PRIMARY KEY CLUSTERED ([id] ASC)
);

