﻿CREATE TABLE [dbo].[tblUser]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [FirstName] VARCHAR(20) NOT NULL, 
    [LastName] VARCHAR(25) NOT NULL,
    [Email] VARCHAR(50) NOT NULL, 
    [UserPass] VARCHAR(32) NOT NULL  
)