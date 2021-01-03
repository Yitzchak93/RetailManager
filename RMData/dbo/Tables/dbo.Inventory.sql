CREATE TABLE [dbo].[Inventory] (
    --[Id]            INT           IDENTITY (1, 1) NOT NULL,
    [Id]            INT     NOT NULL PRIMARY KEY      IDENTITY,
	[ProductId]     INT           NOT NULL,
    [Quanity]       INT           DEFAULT ((1)) NOT NULL,
    [PurchasePrice] MONEY         NOT NULL,
    [PurchaseDate]  DATETIME2 (7) DEFAULT (getutcdate()) NOT NULL, 
    CONSTRAINT [FK_Inventory_ToProdcut] FOREIGN KEY ([ProductID]) REFERENCES Product(Id)
    --PRIMARY KEY CLUSTERED ([Id] ASC) 
);

