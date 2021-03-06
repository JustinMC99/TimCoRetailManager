﻿CREATE TABLE [dbo].[Product]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
	[ProductName] NVARCHAR(100) NOT NULL, 
	[RetailPrice] MONEY NOT NULL, 
	[Description] NVARCHAR(MAX) NOT NULL, 
	[CreatedDate] DATETIME2 NOT NULL DEFAULT getutcdate(), 
	[LastModifed] DATETIME2 NOT NULL DEFAULT getutcdate()
)
