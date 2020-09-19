/*
 Pre-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be executed before the build script.	
 Use SQLCMD syntax to include a file in the pre-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the pre-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
Drop table if exists [dbo].[tblUserProduct]
Drop table if exists [dbo].[tblAisleProduct]
Drop table if exists [dbo].[tblUser]
Drop table if exists [dbo].[tblProduct]
Drop table if exists [dbo].[tblLayout]
Drop table if exists [dbo].[tblStore]
Drop table if exists [dbo].[tblAisle]