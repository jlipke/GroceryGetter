BEGIN
	DECLARE @StoreId uniqueidentifier;

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

select * from dbo.tblLayout;