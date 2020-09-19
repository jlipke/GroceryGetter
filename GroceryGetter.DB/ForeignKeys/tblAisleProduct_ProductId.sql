ALTER TABLE [dbo].[tblAisleProduct]
	ADD CONSTRAINT [tblAisleProduct_ProductId]
	FOREIGN KEY (ProductId)
	REFERENCES [dbo].[tblProduct] (Id) ON DELETE CASCADE
