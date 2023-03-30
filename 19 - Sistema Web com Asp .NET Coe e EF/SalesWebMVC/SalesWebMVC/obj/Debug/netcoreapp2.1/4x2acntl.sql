IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Department] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NULL,
    CONSTRAINT [PK_Department] PRIMARY KEY ([Id])
);

GO

SET IDENTITY_INSERT dbo.Department ON;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20221123035941_Initial', N'2.1.14-servicing-32113');

GO

CREATE TABLE [Sellers] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NULL,
    [Email] nvarchar(max) NULL,
    [BirthDate] datetime2 NOT NULL,
    [BaseSalary] float NOT NULL,
    [DepartmentId] int NULL,
    CONSTRAINT [PK_Sellers] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Sellers_Department_DepartmentId] FOREIGN KEY ([DepartmentId]) REFERENCES [Department] ([Id]) ON DELETE NO ACTION
);

GO

CREATE TABLE [SellersRecord] (
    [Id] int NOT NULL IDENTITY,
    [Date] datetime2 NOT NULL,
    [Amount] float NOT NULL,
    [SaleStatusId] int NULL,
    [SellerId] int NULL,
    CONSTRAINT [PK_SellersRecord] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_SellersRecord_SellersRecord_SaleStatusId] FOREIGN KEY ([SaleStatusId]) REFERENCES [SellersRecord] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_SellersRecord_Sellers_SellerId] FOREIGN KEY ([SellerId]) REFERENCES [Sellers] ([Id]) ON DELETE NO ACTION
);

GO

CREATE INDEX [IX_Sellers_DepartmentId] ON [Sellers] ([DepartmentId]);

GO

CREATE INDEX [IX_SellersRecord_SaleStatusId] ON [SellersRecord] ([SaleStatusId]);

GO

CREATE INDEX [IX_SellersRecord_SellerId] ON [SellersRecord] ([SellerId]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20221123044658_OtherEntities', N'2.1.14-servicing-32113');

GO

