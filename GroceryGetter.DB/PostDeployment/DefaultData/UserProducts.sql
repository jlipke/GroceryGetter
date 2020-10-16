BEGIN

	DECLARE @UserId uniqueidentifier;
	SELECT @UserId = Id from tblUser where Email = '300019014@fvtc.edu'
	DECLARE @ProductId uniqueidentifier;
	SELECT @ProductId = Id from tblProduct where Title = 'Milk'
	INSERT INTO tblUserProduct(Id, UserId, ProductId, InCart, Amount, Notes)
	VALUES
	(NEWID(), @UserId, @ProductId, 1, 1, NULL)

	--SELECT @UserId = Id from tblUser where Email = '300019014@fvtc.edu'
	SELECT @ProductId = Id from tblProduct where Title = 'Beer'
	INSERT INTO tblUserProduct(Id, UserId, ProductId, InCart, Amount, Notes)
	VALUES
	(NEWID(), @UserId, @ProductId, 0, 2, 'Milk Stout - Left Hand Brewing')

	--SELECT @UserId = Id from tblUser where Email = '300019014@fvtc.edu'
	SELECT @ProductId = Id from tblProduct where Title = 'Coffee'
	INSERT INTO tblUserProduct(Id, UserId, ProductId, InCart, Amount, Notes)
	VALUES
	(NEWID(), @UserId, @ProductId, 0, 1, NULL)

	--SELECT @UserId = Id from tblUser where Email = '300019014@fvtc.edu'
	SELECT @ProductId = Id from tblProduct where Title = 'Tortilla Chips'
	INSERT INTO tblUserProduct(Id, UserId, ProductId, InCart, Amount, Notes)
	VALUES
	(NEWID(), @UserId, @ProductId, 0, 1, NULL)
	
	--SELECT @UserId = Id from tblUser where Email = '300019014@fvtc.edu'
	SELECT @ProductId = Id from tblProduct where Title = 'Salsa'
	INSERT INTO tblUserProduct(Id, UserId, ProductId, InCart, Amount, Notes)
	VALUES
	(NEWID(), @UserId, @ProductId, 0, 1, NULL)

		--SELECT @UserId = Id from tblUser where Email = '300019014@fvtc.edu'
	SELECT @ProductId = Id from tblProduct where Title = 'Donuts'
	INSERT INTO tblUserProduct(Id, UserId, ProductId, InCart, Amount, Notes)
	VALUES
	(NEWID(), @UserId, @ProductId, 0, 1, NULL)

		--SELECT @UserId = Id from tblUser where Email = '300019014@fvtc.edu'
	SELECT @ProductId = Id from tblProduct where Title = 'Eggs'
	INSERT INTO tblUserProduct(Id, UserId, ProductId, InCart, Amount, Notes)
	VALUES
	(NEWID(), @UserId, @ProductId, 0, 1, NULL)


	SELECT @UserId = Id from tblUser where Email = 'TestUser@test.com'
	SELECT @ProductId = Id from tblProduct where Title = 'Apple Juice'
	INSERT INTO tblUserProduct(Id, UserId, ProductId, InCart, Amount, Notes)
	VALUES
	(NEWID(), @UserId, @ProductId, 1, 2, NULL)

	--SELECT @UserId = Id from tblUser where Email = 'TestUser@test.com'
	SELECT @ProductId = Id from tblProduct where Title = 'Beef'
	INSERT INTO tblUserProduct(Id, UserId, ProductId, InCart, Amount, Notes)
	VALUES
	(NEWID(), @UserId, @ProductId, 0, 2, 'Angus Steak')

	--SELECT @UserId = Id from tblUser where Email = 'TestUser@test.com'
	SELECT @ProductId = Id from tblProduct where Title = 'Milk'
	INSERT INTO tblUserProduct(Id, UserId, ProductId, InCart, Amount, Notes)
	VALUES
	(NEWID(), @UserId, @ProductId, 0, 1, '1%')

	SELECT @UserId = Id from tblUser where Email = 'Consumer@FoodProducts.com'
	SELECT @ProductId = Id from tblProduct where Title = 'Carrots'
	INSERT INTO tblUserProduct(Id, UserId, ProductId, InCart, Amount, Notes)
	VALUES
	(NEWID(), @UserId, @ProductId, 1, 1, 'Baby')

	--SELECT @UserId = Id from tblUser where Email = 'Consumer@FoodProducts.com'
	SELECT @ProductId = Id from tblProduct where Title = 'Bread (Bakery Fresh)'
	INSERT INTO tblUserProduct(Id, UserId, ProductId, InCart, Amount, Notes)
	VALUES
	(NEWID(), @UserId, @ProductId, 0, 1, 'French')

	SELECT @UserId = Id from tblUser where Email = 'email@email.com'
	SELECT @ProductId = Id from tblProduct where Title = 'Carrots'
	INSERT INTO tblUserProduct(Id, UserId, ProductId, InCart, Amount, Notes)
	VALUES
	(NEWID(), @UserId, @ProductId, 1, 1, 'and knuckles')

END