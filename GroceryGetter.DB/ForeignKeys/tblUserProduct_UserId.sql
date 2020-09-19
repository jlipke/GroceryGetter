ALTER TABLE [dbo].[tblUserProduct]
	ADD CONSTRAINT [tblUserProduct_UserId]
	FOREIGN KEY (UserId)
	REFERENCES [dbo].[tblUser] (Id) ON DELETE CASCADE
