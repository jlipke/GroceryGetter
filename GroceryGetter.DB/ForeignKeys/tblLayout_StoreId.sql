ALTER TABLE [dbo].[tblLayout]
	ADD CONSTRAINT [tblLayout_StoreId]
	FOREIGN KEY (StoreId)
	REFERENCES [dbo].[tblStore] (Id) ON DELETE CASCADE