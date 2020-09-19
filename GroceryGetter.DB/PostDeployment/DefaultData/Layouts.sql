BEGIN
	DECLARE @StoreId uniqueidentifier;
	

	-- ** Create the Title in the UI by concatenating two textboxes "tblStore.Title = txtStoreName.Text + "-" + txtStoreCity/txtStoreLocation"
	SELECT @StoreId = Id from tblStore where Title = 'Alphabetical'
	INSERT INTO dbo.tblLayout(Id, StoreId, Title)
	VALUES
	(NEWID(), @StoreId, 'L_Alphabetical-A-Z')

	-- -De Pere in Title is the unique location identifier. 
	SELECT @StoreId = Id from tblStore where Title = 'Festival-De Pere'
	INSERT INTO dbo.tblLayout(Id, StoreId, Title)
	VALUES
	(NEWID(), @StoreId, 'L_Festival-De Pere')

	SELECT @StoreId = Id from tblStore where Title = 'Aldi-De Pere'
	INSERT INTO dbo.tblLayout(Id, StoreId, Title)
	VALUES
	(NEWID(), @StoreId, 'L_Aldi-De Pere')
END