IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Contas] (
    [IdConta] uniqueidentifier NOT NULL,
    [Nome] nvarchar(max) NULL,
    [Valor] decimal(18,2) NULL,
    [DataHora] datetime2 NULL,
    [Categoria] int NULL,
    CONSTRAINT [PK_Contas] PRIMARY KEY ([IdConta])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20210814182613_Initial', N'5.0.9');
GO

COMMIT;
GO

