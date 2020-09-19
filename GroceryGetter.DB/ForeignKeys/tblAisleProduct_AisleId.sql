ALTER TABLE [dbo].[tblAisleProduct]
	ADD CONSTRAINT [tblAisleProduct_AisleId]
	FOREIGN KEY (AisleId)
	REFERENCES [dbo].[tblAisle] (Id) ON DELETE CASCADE