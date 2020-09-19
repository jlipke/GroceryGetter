BEGIN

	DECLARE @LayoutId uniqueidentifier;
	
	-- L_ in the Title denotes Layout instead of Store
	-- -FDP is Festival-De Pere's unique Aisle identifier and will not be displayed in the UI
	-- ** Create the Number in the UI by concatenating two textboxes "tblLayout.Number = txtAisle.Text + "-" + txtStoreIdentifier" 
	-- ** txtStoreIdentifier being a user chosen 3 character code
	SELECT @LayoutId = Id from tblLayout where Title = 'L_Festival-De Pere'
	INSERT INTO dbo.tblAisle(Id, LayoutId, Number, Lineup)
	VALUES
	(NEWID(), @LayoutId, '1', 4),
	(NEWID(), @LayoutId, '2', 5),
	(NEWID(), @LayoutId, '3', 6),
	(NEWID(), @LayoutId, '4', 7),
	(NEWID(), @LayoutId, '5', 8),
	(NEWID(), @LayoutId, '6', 9),
	(NEWID(), @LayoutId, '7', 10),
	(NEWID(), @LayoutId, '8', 11),
	(NEWID(), @LayoutId, '9', 12),
	(NEWID(), @LayoutId, '10', 22),
	(NEWID(), @LayoutId, '11', 21),
	(NEWID(), @LayoutId, '12', 20),
	(NEWID(), @LayoutId, '13', 19),
	(NEWID(), @LayoutId, '14', 18),
	(NEWID(), @LayoutId, 'Front End', 23),
	(NEWID(), @LayoutId, 'Meat', 13),
	(NEWID(), @LayoutId, 'Bakery', 17),
	(NEWID(), @LayoutId, 'Natural', 9997),
	(NEWID(), @LayoutId, 'Dairy', 14),
	(NEWID(), @LayoutId, 'Produce', 1),
	(NEWID(), @LayoutId, 'Frozen', 16),
	(NEWID(), @LayoutId, 'Wine & Spirits', 15),
	(NEWID(), @LayoutId, 'Deli', 3),
	(NEWID(), @LayoutId, 'InCart', 9998),
	(NEWID(), @LayoutId, 'Unassigned', 9999)

	-- -ADP is Aldi-De Pere's unique Aisle identifier and will not be displayed in the UI
	SELECT @LayoutId = Id from tblLayout where Title = 'L_Aldi-De Pere'
	INSERT INTO dbo.tblAisle(Id, LayoutId, Number, Lineup)
	VALUES
	(NEWID(), @LayoutId, 'Pantry', 3),
	(NEWID(), @LayoutId, 'Pets', 7),
	(NEWID(), @LayoutId, 'Cleaning', 6),
	(NEWID(), @LayoutId, 'Meat', 11),
	(NEWID(), @LayoutId, 'Deli', 8),
	(NEWID(), @LayoutId, 'Produce', 1),
	(NEWID(), @LayoutId, 'Frozen', 9),
	(NEWID(), @LayoutId, 'Household', 5),
	(NEWID(), @LayoutId, 'Wine & Spirits', 12),
	(NEWID(), @LayoutId, 'Coffee/Tea/Spreads', 4),
	(NEWID(), @LayoutId, 'Bakery', 2),
	(NEWID(), @LayoutId, 'Dairy', 10),
	(NEWID(), @LayoutId, 'InCart', 9998),
	(NEWID(), @LayoutId, 'Unassigned', 9999)

	--Alphabetical-A-Z
	SELECT @LayoutId = Id from tblLayout where Title = 'L_Alphabetical-A-Z'
	INSERT INTO dbo.tblAisle(Id, LayoutId, Number, Lineup)
	VALUES
	(NEWID(), @LayoutId, 'Alphabetical', 1),
	(NEWID(), @LayoutId, 'InCart', 9998)

END