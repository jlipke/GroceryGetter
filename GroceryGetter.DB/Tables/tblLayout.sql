﻿CREATE TABLE [dbo].[tblLayout]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [StoreId] UNIQUEIDENTIFIER NOT NULL, 
    [Title] VARCHAR(50) NOT NULL
)