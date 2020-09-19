BEGIN
	-- ** Create the Title in the UI by concatenating two textboxes
	-- ** "tblStore.Title = txtStoreName.Text + "-" + txtStoreCity/txtStoreLocation"
	INSERT INTO dbo.tblStore(Id, Title)
	VALUES
	(NEWID(), 'Alphabetical'),
	(NEWID(), 'Festival-De Pere'),
	(NEWID(), 'Aldi-De Pere')
END