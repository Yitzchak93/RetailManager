﻿CREATE TABLE [dbo].[Product] (
    [Id]           INT    NOT NULL   PRIMARY KEY      IDENTITY ,
	--[Id] INT                IDENTITY(1,1) NOT NULL,
    [ProductName]  NVARCHAR (100) NOT NULL,
    [Description]  NVARCHAR (MAX) NOT NULL,
    [RetailPrice]  MONEY          NOT NULL,
	[QuantityInStock] INT NOT NULL DEFAULT 1,
    [CreateDate]   DATETIME2 (7)  DEFAULT (getutcdate()) NOT NULL,
    [LastModified] DATETIME2 (7)  DEFAULT (getutcdate()) NOT NULL, 
    [IsTaxable] BIT NOT NULL DEFAULT 1,
    --PRIMARY KEY CLUSTERED ([Id] ASC)
); 

