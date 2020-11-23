CREATE TABLE [dbo].[Users]
(
	[Id]  NVARCHAR(128) NOT NULL, 
	[FirstName] NVARCHAR(50) NULL, 
	[LastName] NVARCHAR(50) NULL, 
	[EmailAddress] NVARCHAR(256) NULL, 
	[CreatedDate] DATETIME2 NULL DEFAULT getdate() 

)
