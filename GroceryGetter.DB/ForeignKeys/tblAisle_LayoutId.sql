ALTER TABLE [dbo].[tblAisle]
	ADD CONSTRAINT [tblAisle_LayoutId]
	FOREIGN KEY (LayoutId)
	REFERENCES [dbo].[tblLayout] (Id) ON DELETE CASCADE
