ALTER TABLE [dbo].[tblUserProduct]
	ADD CONSTRAINT [tblUserProduct_ProductId]
	FOREIGN KEY (ProductId)
	REFERENCES [dbo].[tblProduct] (Id) ON DELETE CASCADE
