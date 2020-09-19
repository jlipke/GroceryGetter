BEGIN

	DECLARE @AisleId uniqueidentifier;

	-- AISLE 1 - Festival De Pere
	-- -FDP is Festival-De Pere's unique store aisle identifier
	SELECT @AisleId = a.Id from tblAisle a join tblLayout l on a.LayoutId = l.Id where a.Number = '1' and l.Title = 'L_Festival-De Pere'

	--@ProductId already declared in the UserProducts
	--DECLARE @ProductId uniqueidentifier; 
	SELECT @ProductId = Id from tblProduct where Title = 'Applesauce'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Bacon Bits'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Barbecue Sauce'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Canning Supplies'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Chili Sauce (Sriracha)'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Chutney'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Cocktail Sauce'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Cooking Wines'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Cranberry Sauce'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)

	SELECT @ProductId = Id from tblProduct where Title = 'Fruit (Canned)'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Horseradish Sauce'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Jam/Jelly'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Ketchup'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Marschino Cherries'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Marinades (Liquid)'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Mayonnaise'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Miracle Whip'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Nutella'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Olives'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Peanut Butter'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Pickles'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Pimientos'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Relish'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Salad Dressings'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Steak Sauce'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Sure Jell'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Tabasco Sauce'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Tahini'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Tartar Sauce'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Vinegar'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Worcestershire Sauce'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)


	-- AISLE 2 - Festival De Pere
	SELECT @AisleId = a.Id from tblAisle a join tblLayout l on a.LayoutId = l.Id where a.Number = '2' and l.Title = 'L_Festival-De Pere'

	SELECT @ProductId = Id from tblProduct where Title = 'Baked Beans'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Beans (Dried)'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Chili (Canned)'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Crabmeat (Canned)'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Dry Seasoning Packets'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Fish (Canned)'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'French Fried Onions'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Garlic (Minced)'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Gravy (Jar & Dry Pack)'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Instant Potatoes'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Kidney Beans'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Lima Beans'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Manwich'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Meat (Canned)'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Oysters (Canned)'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Pesto'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Pine Nuts'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Pinto Beans'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Pizza Crust (Boxed)'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Pizza Sauce'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Pizza Mix'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Potatoes (Dry)'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Sauerkraut (Canned)'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Shrimp (Canned)'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Soy Sauce'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Spam'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Stew (Canned)'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Stuffing'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Tomato Paste'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Tomato Sauce'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Vegetables (Canned)'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Tuna'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Water Chestnuts'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Yams'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	
	-- AISLE 3 - Festival De Pere
	SELECT @AisleId = a.Id from tblAisle a join tblLayout l on a.LayoutId = l.Id where a.Number = '3' and l.Title = 'L_Festival-De Pere'

	SELECT @ProductId = Id from tblProduct where Title = 'Boxed Dinners'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Hispanic Foods'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Lasagna Noodles (Dry)'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Noodles'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Pasta (Dried)'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Pasta Sauce'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Pesto'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Rice'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Rice-A-Roni'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Salsa'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Spaghetti'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Taco Shells'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)


	-- AISLE 4 - Festival De Pere
	SELECT @AisleId = a.Id from tblAisle a join tblLayout l on a.LayoutId = l.Id where a.Number = '4' and l.Title = 'L_Festival-De Pere'

	SELECT @ProductId = Id from tblProduct where Title = 'Barley'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Bread Sticks'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Cookies'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Crackers'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Pita Chips'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Ramen Noodles'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Soup'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)


	-- AISLE 5 - Festival De Pere
	SELECT @AisleId = a.Id from tblAisle a join tblLayout l on a.LayoutId = l.Id where a.Number = '5' and l.Title = 'L_Festival-De Pere'

	SELECT @ProductId = Id from tblProduct where Title = 'Baking Chocolate'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Baking Soda'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Bread Crumbs'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Cake Mixes'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Candied Fruit'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Candles (Birthday)'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Coconut Oil'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Coconut'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Cocoa (Baking)'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Condensed Milk'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Cornstarch'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Cupcake Liners'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Dates'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Evaporated Milk'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Flour'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Frosting'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Fruit (Dried)'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Gelatin'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Jell-O (Boxed)'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Marshmallows'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Milk (Powdered)'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Molasses'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Nuts (Baking)'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Oil (Cooking)'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Pepper'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Pie Crust'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Pie Filling'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Prunes'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Pudding'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Pumpkin (Canned)'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Raisins'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Salt (Table/Sea)'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Shortening'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Spices'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Sugar'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Vegetable Oil'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Yeast (Dry)'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)


	-- AISLE 6 - Festival De Pere
	SELECT @AisleId = a.Id from tblAisle a join tblLayout l on a.LayoutId = l.Id where a.Number = '6' and l.Title = 'L_Festival-De Pere'

	SELECT @ProductId = Id from tblProduct where Title = 'Bird Seed'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Cat Food'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Cat Litter'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Dog Food/Treats'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Rawhide'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	

	-- AISLE 7 - Festival De Pere
	SELECT @AisleId = a.Id from tblAisle a join tblLayout l on a.LayoutId = l.Id where a.Number = '7' and l.Title = 'L_Festival-De Pere'

	SELECT @ProductId = Id from tblProduct where Title = 'Beef Stick (Snacks)'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Candies'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Candy Bags'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Candy Single Bars'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Fruit Snacks'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Gatorade'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Ice Cream Cones'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Ice Cream Toppings'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Iced Tea'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Nuts (Snacks)'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Popcorn (Microwave)'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Sports Drinks'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Tea (Bottles & Jugs)'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	

	-- AISLE 8 - Festival De Pere
	SELECT @AisleId = a.Id from tblAisle a join tblLayout l on a.LayoutId = l.Id where a.Number = '8' and l.Title = 'L_Festival-De Pere'

	SELECT @ProductId = Id from tblProduct where Title = 'Apple Juice'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Coffee Creamer'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Coffee Filters'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Coffee'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Cranberry Juice'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Hot Cocoa'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Juice'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Kool Aid'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Lemon Juice'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Tang'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Tea (Packets/Bags)'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	

	-- AISLE 9 - Festival De Pere
	SELECT @AisleId = a.Id from tblAisle a join tblLayout l on a.LayoutId = l.Id where a.Number = '9' and l.Title = 'L_Festival-De Pere'

	SELECT @ProductId = Id from tblProduct where Title = 'Cereal (Hot/Cold)'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Diabetic & Diet Needs'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Granola Bars'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Grits'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Oatmeal'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Pancake Mix'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Pancake Syrup'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Pop Tarts'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Rice Cakes'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Slim Fast'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	

	-- AISLE 10 - Festival De Pere
	SELECT @AisleId = a.Id from tblAisle a join tblLayout l on a.LayoutId = l.Id where a.Number = '10' and l.Title = 'L_Festival-De Pere'

	SELECT @ProductId = Id from tblProduct where Title = 'Aluminum Foil'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Bakeware'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Bath Tissue'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Cheesecloth'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Cling Wrap'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Cooking Bags'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Dinner Napkins'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Facial Tissues'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Foil Baking Pans'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Freezer Paper'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Garbage Bags'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Handi Wipes'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Handi-Wrap'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Housewares'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Kitchen Gadgets'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Kleenex'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Lunch Bags'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Napkins (Paper)'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Paper Cups'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Paper Plates'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Paper Towels'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Plastic Flatware'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Plastic Wrap'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Sandwich Bags'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Storage Bags'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Straws'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Toilet Paper'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Toothpicks'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Wax Paper'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	

	--AISLE 11 - Festival De Pere
	SELECT @AisleId = a.Id from tblAisle a join tblLayout l on a.LayoutId = l.Id where a.Number = '11' and l.Title = 'L_Festival-De Pere'

	SELECT @ProductId = Id from tblProduct where Title = 'After Shave'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)

	SELECT @ProductId = Id from tblProduct where Title = 'Aspirin'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Baby Formula'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Band-Aids'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)

	SELECT @ProductId = Id from tblProduct where Title = 'Cotton Balls'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Deodorant'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Diapers'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Hand Lotion'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Laxatives'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Nail Care'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Shampoo'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Skin Care'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Toothpaste'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)

	
	--AISLE 12 - Festival De Pere
	SELECT @AisleId = a.Id from tblAisle a join tblLayout l on a.LayoutId = l.Id where a.Number = '12' and l.Title = 'L_Festival-De Pere'

	SELECT @ProductId = Id from tblProduct where Title = 'Air Fresheners'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Ammonia'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Automotive'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Bar Soap'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Clothes Line'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Dish Detergent'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Distilled Water'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Electrical Needs'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Fabric Softener'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Floor Cleaner'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Furniture Polish'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Glass Cleaner'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Gloves'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Hardware'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Hosiery'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Household Cleaners'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Laundry Detergent'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Light Bulbs'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Mops'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Moth Balls'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Oven Cleaner'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Rubber Gloves'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'School Supplies'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Shoe Laces'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Sponges'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Stain Remover'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Starch (Spray)'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Super Glue'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Water (Distilled)'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Windex'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	

	--AISLE 13 - Festival De Pere
	SELECT @AisleId = a.Id from tblAisle a join tblLayout l on a.LayoutId = l.Id where a.Number = '13' and l.Title = 'L_Festival-De Pere'

	SELECT @ProductId = Id from tblProduct where Title = 'Club Soda'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Drink Enhancers (Flavoring)'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Energy Drinks'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Seltzer Water'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Soda'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Tonic Water'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Water (Drinking)'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Water Refill'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	

	--AISLE 14 - Festival De Pere
	SELECT @AisleId = a.Id from tblAisle a join tblLayout l on a.LayoutId = l.Id where a.Number = '14' and l.Title = 'L_Festival-De Pere'

	SELECT @ProductId = Id from tblProduct where Title = 'Bread (Commercial)'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Hamburger Buns'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Hotdog Buns'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Popcorn (Bagged)'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Potato Chips'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Snacks'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Tortilla Chips'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	
	----AISLE Natural - Festival De Pere
	--SELECT @AisleId = a.Id from tblAisle a join tblLayout l on a.LayoutId = l.Id where a.Number = 'Natural' and l.Title = 'L_Festival-De Pere'

	--SELECT @ProductId = Id from tblProduct where Title = 'Applejuice Organic'
	--INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	--VALUES
	--(NEWID(), @AisleId, @ProductId)
	
	--SELECT @ProductId = Id from tblProduct where Title = 'Apple Sauce Organic'
	--INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	--VALUES
	--(NEWID(), @AisleId, @ProductId)
	
	--SELECT @ProductId = Id from tblProduct where Title = 'Baby Food Organic'
	--INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	--VALUES
	--(NEWID(), @AisleId, @ProductId)
	
	--SELECT @ProductId = Id from tblProduct where Title = 'Baking Chocolate Organic'
	--INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	--VALUES
	--(NEWID(), @AisleId, @ProductId)
	
	--SELECT @ProductId = Id from tblProduct where Title = 'Bar Soap Organic'
	--INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	--VALUES
	--(NEWID(), @AisleId, @ProductId)
	
	--SELECT @ProductId = Id from tblProduct where Title = 'Boxed Dinners Organic'
	--INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	--VALUES
	--(NEWID(), @AisleId, @ProductId)
	
	--SELECT @ProductId = Id from tblProduct where Title = 'Bulk Spice Organic'
	--INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	--VALUES
	--(NEWID(), @AisleId, @ProductId)
	
	--SELECT @ProductId = Id from tblProduct where Title = 'Cake Mixes Organic'
	--INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	--VALUES
	--(NEWID(), @AisleId, @ProductId)
	
	--SELECT @ProductId = Id from tblProduct where Title = 'Candies Organic'
	--INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	--VALUES
	--(NEWID(), @AisleId, @ProductId)
	
	--SELECT @ProductId = Id from tblProduct where Title = 'Candied Fruit Organic'
	--INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	--VALUES
	--(NEWID(), @AisleId, @ProductId)
	
	--SELECT @ProductId = Id from tblProduct where Title = 'Candy Single Bars Organic'
	--INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	--VALUES
	--(NEWID(), @AisleId, @ProductId)
	
	--SELECT @ProductId = Id from tblProduct where Title = 'Cereal (Hot/Cold) Organic'
	--INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	--VALUES
	--(NEWID(), @AisleId, @ProductId)
	
	--SELECT @ProductId = Id from tblProduct where Title = 'Coconut Oil Organic'
	--INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	--VALUES
	--(NEWID(), @AisleId, @ProductId)
	
	--SELECT @ProductId = Id from tblProduct where Title = 'Coconut Organic'
	--INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	--VALUES
	--(NEWID(), @AisleId, @ProductId)
	
	--SELECT @ProductId = Id from tblProduct where Title = 'Cocoa (Baking) Organic'
	--INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	--VALUES
	--(NEWID(), @AisleId, @ProductId)
	
	--SELECT @ProductId = Id from tblProduct where Title = 'Coffee Organic'
	--INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	--VALUES
	--(NEWID(), @AisleId, @ProductId)
	
	--SELECT @ProductId = Id from tblProduct where Title = 'CoffeeFilters'
	--INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	--VALUES
	--(NEWID(), @AisleId, @ProductId)
	
	--SELECT @ProductId = Id from tblProduct where Title = 'Cookies Organic'
	--INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	--VALUES
	--(NEWID(), @AisleId, @ProductId)
	
	--SELECT @ProductId = Id from tblProduct where Title = 'Crackers Organic'
	--INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	--VALUES
	--(NEWID(), @AisleId, @ProductId)
	
	--SELECT @ProductId = Id from tblProduct where Title = 'Cranberry Juice Organic'
	--INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	--VALUES
	--(NEWID(), @AisleId, @ProductId)
	
	--SELECT @ProductId = Id from tblProduct where Title = 'Croutons Organic'
	--INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	--VALUES
	--(NEWID(), @AisleId, @ProductId)
	
	--SELECT @ProductId = Id from tblProduct where Title = 'Dates Organic'
	--INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	--VALUES
	--(NEWID(), @AisleId, @ProductId)
	
	----SELECT @ProductId = Id from tblProduct where Title = 'Deoderant'
	----INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	----VALUES
	----(NEWID(), @AisleId, @ProductId)
	
	----SELECT @ProductId = Id from tblProduct where Title = 'Diabetic & Dietary Needs'
	----INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	----VALUES
	----(NEWID(), @AisleId, @ProductId)
	
	--SELECT @ProductId = Id from tblProduct where Title = 'Dish Detergent Organic'
	--INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	--VALUES
	--(NEWID(), @AisleId, @ProductId)
	
	--SELECT @ProductId = Id from tblProduct where Title = 'Energy Bars Organic'
	--INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	--VALUES
	--(NEWID(), @AisleId, @ProductId)
	
	--SELECT @ProductId = Id from tblProduct where Title = 'Flour Organic'
	--INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	--VALUES
	--(NEWID(), @AisleId, @ProductId)
	
	--SELECT @ProductId = Id from tblProduct where Title = 'Fruit (Dried) Organic'
	--INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	--VALUES
	--(NEWID(), @AisleId, @ProductId)
	
	--SELECT @ProductId = Id from tblProduct where Title = 'Fruit Snacks Organic'
	--INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	--VALUES
	--(NEWID(), @AisleId, @ProductId)
	
	--SELECT @ProductId = Id from tblProduct where Title = 'Granola Bars Organic'
	--INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	--VALUES
	--(NEWID(), @AisleId, @ProductId)
	
	--SELECT @ProductId = Id from tblProduct where Title = 'Gravy (Jar & Dry Pack) Organic'
	--INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	--VALUES
	--(NEWID(), @AisleId, @ProductId)
	
	--SELECT @ProductId = Id from tblProduct where Title = 'Hair Care Organic'
	--INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	--VALUES
	--(NEWID(), @AisleId, @ProductId)
	
	--SELECT @ProductId = Id from tblProduct where Title = 'Honey Organic'
	--INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	--VALUES
	--(NEWID(), @AisleId, @ProductId)
	
	--SELECT @ProductId = Id from tblProduct where Title = 'Household Cleaners Organic'
	--INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	--VALUES
	--(NEWID(), @AisleId, @ProductId)
	
	--SELECT @ProductId = Id from tblProduct where Title = 'Iced Tea Organic'
	--INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	--VALUES
	--(NEWID(), @AisleId, @ProductId)
	
	--SELECT @ProductId = Id from tblProduct where Title = 'Jam/Jelly Organic'
	--INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	--VALUES
	--(NEWID(), @AisleId, @ProductId)
	
	--SELECT @ProductId = Id from tblProduct where Title = 'Juice Organic'
	--INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	--VALUES
	--(NEWID(), @AisleId, @ProductId)
	
	--SELECT @ProductId = Id from tblProduct where Title = 'Ketchup Organic'
	--INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	--VALUES
	--(NEWID(), @AisleId, @ProductId)
	
	--SELECT @ProductId = Id from tblProduct where Title = 'Lasagna Noodles (Dry) Organic'
	--INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	--VALUES
	--(NEWID(), @AisleId, @ProductId)
	
	--SELECT @ProductId = Id from tblProduct where Title = 'Marshmallows Organic'
	--INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	--VALUES
	--(NEWID(), @AisleId, @ProductId)
	
	--SELECT @ProductId = Id from tblProduct where Title = 'Mayonnaise Organic'
	--INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	--VALUES
	--(NEWID(), @AisleId, @ProductId)
	
	--SELECT @ProductId = Id from tblProduct where Title = 'Molasses Organic'
	--INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	--VALUES
	--(NEWID(), @AisleId, @ProductId)
	
	--SELECT @ProductId = Id from tblProduct where Title = 'Nail Care Organic'
	--INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	--VALUES
	--(NEWID(), @AisleId, @ProductId)
	
	--SELECT @ProductId = Id from tblProduct where Title = 'Noodles Organic'
	--INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	--VALUES
	--(NEWID(), @AisleId, @ProductId)
	
	--SELECT @ProductId = Id from tblProduct where Title = 'Nuts (Baking) Organic'
	--INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	--VALUES
	--(NEWID(), @AisleId, @ProductId)
	
	--SELECT @ProductId = Id from tblProduct where Title = 'Nuts (Snacks) Organic'
	--INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	--VALUES
	--(NEWID(), @AisleId, @ProductId)
	
	--SELECT @ProductId = Id from tblProduct where Title = 'Oatmeal Organic'
	--INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	--VALUES
	--(NEWID(), @AisleId, @ProductId)
	
	--SELECT @ProductId = Id from tblProduct where Title = 'Oil (Cooking) Organic'
	--INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	--VALUES
	--(NEWID(), @AisleId, @ProductId)
	
	--SELECT @ProductId = Id from tblProduct where Title = 'Pancake Mix Organic'
	--INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	--VALUES
	--(NEWID(), @AisleId, @ProductId)
	
	--SELECT @ProductId = Id from tblProduct where Title = 'Pancake Syrup Organic'
	--INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	--VALUES
	--(NEWID(), @AisleId, @ProductId)
	
	--SELECT @ProductId = Id from tblProduct where Title = 'Pasta (Dried) Organic'
	--INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	--VALUES
	--(NEWID(), @AisleId, @ProductId)
	
	--SELECT @ProductId = Id from tblProduct where Title = 'Pasta Sauce Organic'
	--INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	--VALUES
	--(NEWID(), @AisleId, @ProductId)
	
	--SELECT @ProductId = Id from tblProduct where Title = 'Peanut Butter Organic'
	--INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	--VALUES
	--(NEWID(), @AisleId, @ProductId)
	
	--SELECT @ProductId = Id from tblProduct where Title = 'Pita Chips Organic'
	--INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	--VALUES
	--(NEWID(), @AisleId, @ProductId)
	
	--SELECT @ProductId = Id from tblProduct where Title = 'Pizza Mix Organic'
	--INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	--VALUES
	--(NEWID(), @AisleId, @ProductId)
	
	--SELECT @ProductId = Id from tblProduct where Title = 'Popcorn (Bagged) Organic'
	--INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	--VALUES
	--(NEWID(), @AisleId, @ProductId)
	
	--SELECT @ProductId = Id from tblProduct where Title = 'Popcorn (Microwave) Organic'
	--INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	--VALUES
	--(NEWID(), @AisleId, @ProductId)
	
	--SELECT @ProductId = Id from tblProduct where Title = 'Protein Bars Organic'
	--INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	--VALUES
	--(NEWID(), @AisleId, @ProductId)
	
	--SELECT @ProductId = Id from tblProduct where Title = 'Rice Organic'
	--INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	--VALUES
	--(NEWID(), @AisleId, @ProductId)
	
	--SELECT @ProductId = Id from tblProduct where Title = 'Salsa Organic'
	--INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	--VALUES
	--(NEWID(), @AisleId, @ProductId)
	
	--SELECT @ProductId = Id from tblProduct where Title = 'Salt (Table/Sea) Organic'
	--INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	--VALUES
	--(NEWID(), @AisleId, @ProductId)
	
	--SELECT @ProductId = Id from tblProduct where Title = 'Shampoo Organic'
	--INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	--VALUES
	--(NEWID(), @AisleId, @ProductId)
	
	--SELECT @ProductId = Id from tblProduct where Title = 'Soup Organic'
	--INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	--VALUES
	--(NEWID(), @AisleId, @ProductId)
	
	--SELECT @ProductId = Id from tblProduct where Title = 'Spaghetti Organic'
	--INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	--VALUES
	--(NEWID(), @AisleId, @ProductId)
	
	--SELECT @ProductId = Id from tblProduct where Title = 'Spices Organic'
	--INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	--VALUES
	--(NEWID(), @AisleId, @ProductId)
	
	--SELECT @ProductId = Id from tblProduct where Title = 'Sugar Organic'
	--INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	--VALUES
	--(NEWID(), @AisleId, @ProductId)
	
	--SELECT @ProductId = Id from tblProduct where Title = 'Tahini Organic'
	--INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	--VALUES
	--(NEWID(), @AisleId, @ProductId)
	
	--SELECT @ProductId = Id from tblProduct where Title = 'Tea (Packets/Bags) Organic'
	--INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	--VALUES
	--(NEWID(), @AisleId, @ProductId)
	
	--SELECT @ProductId = Id from tblProduct where Title = 'Tomato Paste Organic'
	--INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	--VALUES
	--(NEWID(), @AisleId, @ProductId)
	
	--SELECT @ProductId = Id from tblProduct where Title = 'Tomato Sauce Organic'
	--INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	--VALUES
	--(NEWID(), @AisleId, @ProductId)
	
	--SELECT @ProductId = Id from tblProduct where Title = 'Toothpaste Organic'
	--INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	--VALUES
	--(NEWID(), @AisleId, @ProductId)
	
	--SELECT @ProductId = Id from tblProduct where Title = 'Tortilla Chips Organic'
	--INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	--VALUES
	--(NEWID(), @AisleId, @ProductId)
	
	--SELECT @ProductId = Id from tblProduct where Title = 'Tuna Organic'
	--INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	--VALUES
	--(NEWID(), @AisleId, @ProductId)
	
	--SELECT @ProductId = Id from tblProduct where Title = 'Vegetable Oil Organic'
	--INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	--VALUES
	--(NEWID(), @AisleId, @ProductId)
	
	--SELECT @ProductId = Id from tblProduct where Title = 'Vitamins Organic'
	--INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	--VALUES
	--(NEWID(), @AisleId, @ProductId)
	
	--SELECT @ProductId = Id from tblProduct where Title = 'Yeast (Dry) Organic'
	--INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	--VALUES
	--(NEWID(), @AisleId, @ProductId)
	

	--AISLE Front End - Festival De Pere
	SELECT @AisleId = a.Id from tblAisle a join tblLayout l on a.LayoutId = l.Id where a.Number = 'Front End' and l.Title = 'L_Festival-De Pere'

	SELECT @ProductId = Id from tblProduct where Title = 'Automotive'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Batteries'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Books'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Candy Single Bars'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Charcoal/Logs'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Cigarettes'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Envelopes'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Firewood Bundle'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Greeting Cards'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Insecticides'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Magazines'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Matches'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Rug Doctor Rental'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Salt (Sidewalk)'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Salt (Water Softener)'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	
	--AISLE Meat - Festival De Pere
	SELECT @AisleId = a.Id from tblAisle a join tblLayout l on a.LayoutId = l.Id where a.Number = 'Meat' and l.Title = 'L_Festival-De Pere'

	SELECT @ProductId = Id from tblProduct where Title = 'Beef Stick (Snacks)'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Sauerkraut (Bag)'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	

	--AISLE Bakery - Festival De Pere
	SELECT @AisleId = a.Id from tblAisle a join tblLayout l on a.LayoutId = l.Id where a.Number = 'Bakery' and l.Title = 'L_Festival-De Pere'

	SELECT @ProductId = Id from tblProduct where Title = 'Bread (Bakery Fresh)'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Candles (Birthday)'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Cake'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Donuts'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)


	--AISLE Dairy - Festival De Pere
	SELECT @AisleId = a.Id from tblAisle a join tblLayout l on a.LayoutId = l.Id where a.Number = 'Dairy' and l.Title = 'L_Festival-De Pere'

	SELECT @ProductId = Id from tblProduct where Title = 'Coffee Creamer'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Jell-O (Cups)'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Pesto'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Pie Crust'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Pasta (Refridgerated Premade)'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Tea (Bottles & Jugs)'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Velveeta'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Cheese'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Cheese (Shredded)'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Yeast Cakes'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Milk'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Eggs'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	
	--AISLE Produce - Festival De Pere
	SELECT @AisleId = a.Id from tblAisle a join tblLayout l on a.LayoutId = l.Id where a.Number = 'Produce' and l.Title = 'L_Festival-De Pere'

	SELECT @ProductId = Id from tblProduct where Title = 'Garlic (Minced)'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Pine Nuts'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	

	--AISLE Frozen - Festival De Pere
	SELECT @AisleId = a.Id from tblAisle a join tblLayout l on a.LayoutId = l.Id where a.Number = 'Frozen' and l.Title = 'L_Festival-De Pere'

	SELECT @ProductId = Id from tblProduct where Title = 'Lemonade (Frozen)'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	

	--AISLE Wine & Spirits - Festival De Pere
	SELECT @AisleId = a.Id from tblAisle a join tblLayout l on a.LayoutId = l.Id where a.Number = 'Wine & Spirits' and l.Title = 'L_Festival-De Pere'

	SELECT @ProductId = Id from tblProduct where Title = 'Club Soda'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Cooking Wines'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Liquor'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Beer'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Seltzer Water'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Tonic Water'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)


	--AISLE Deli - Festival De Pere
	SELECT @AisleId = a.Id from tblAisle a join tblLayout l on a.LayoutId = l.Id where a.Number = 'Deli' and l.Title = 'L_Aldi-De Pere'

	SELECT @ProductId = Id from tblProduct where Title = 'Pita Chips'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)

	
	-- -ADP is Aldi-De Pere's unique store aisle identifier
	--AISLE Produce - Aldi De Pere
	SELECT @AisleId = a.Id from tblAisle a join tblLayout l on a.LayoutId = l.Id where a.Number = 'Produce' and l.Title = 'L_Aldi-De Pere'

	SELECT @ProductId = Id from tblProduct where Title = 'Carrots'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Potatos'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	

	--AISLE Pantry - Aldi De Pere
	SELECT @AisleId = a.Id from tblAisle a join tblLayout l on a.LayoutId = l.Id where a.Number = 'Pantry' and l.Title = 'L_Aldi-De Pere'

	SELECT @ProductId = Id from tblProduct where Title = 'Flour'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Vegetable Oil'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Salsa'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)

	SELECT @ProductId = Id from tblProduct where Title = 'Tortilla Chips'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	--AISLE Pets - Aldi De Pere
	SELECT @AisleId = a.Id from tblAisle a join tblLayout l on a.LayoutId = l.Id where a.Number = 'Pets' and l.Title = 'L_Aldi-De Pere'

	SELECT @ProductId = Id from tblProduct where Title = 'Cat Food'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Dog Food/Treats'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	

		--AISLE Cleaning - Aldi De Pere
	SELECT @AisleId = a.Id from tblAisle a join tblLayout l on a.LayoutId = l.Id where a.Number = 'Cleaning' and l.Title = 'L_Aldi-De Pere'

	SELECT @ProductId = Id from tblProduct where Title = 'Floor Cleaner'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Gloves'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	

		--AISLE Meat - Aldi De Pere
	SELECT @AisleId = a.Id from tblAisle a join tblLayout l on a.LayoutId = l.Id where a.Number = 'Meat' and l.Title = 'L_Aldi-De Pere'

	SELECT @ProductId = Id from tblProduct where Title = 'Chicken'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Beef'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	

		--AISLE Deli - Aldi De Pere
	SELECT @AisleId = a.Id from tblAisle a join tblLayout l on a.LayoutId = l.Id where a.Number = 'Deli' and l.Title = 'L_Aldi-De Pere'

	SELECT @ProductId = Id from tblProduct where Title = 'Lunch Meat'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	
		--AISLE Frozen - Aldi De Pere
	SELECT @AisleId = a.Id from tblAisle a join tblLayout l on a.LayoutId = l.Id where a.Number = 'Frozen' and l.Title = 'L_Aldi-De Pere'

	SELECT @ProductId = Id from tblProduct where Title = 'Bread (Frozen)'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Carrots'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	

		--AISLE Household - Aldi De Pere
	SELECT @AisleId = a.Id from tblAisle a join tblLayout l on a.LayoutId = l.Id where a.Number = 'Household' and l.Title = 'L_Aldi-De Pere'

	SELECT @ProductId = Id from tblProduct where Title = 'Hosiery'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	

		--AISLE Wine & Spirits - Aldi De Pere
	SELECT @AisleId = a.Id from tblAisle a join tblLayout l on a.LayoutId = l.Id where a.Number = 'Wine & Spirits' and l.Title = 'L_Aldi-De Pere'

	SELECT @ProductId = Id from tblProduct where Title = 'Wine'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Beer'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)

	SELECT @ProductId = Id from tblProduct where Title = 'Liquor'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	
		--AISLE Coffee/Tea/Spreads - Aldi De Pere
	SELECT @AisleId = a.Id from tblAisle a join tblLayout l on a.LayoutId = l.Id where a.Number = 'Coffee/Tea/Spreads' and l.Title = 'L_Aldi-De Pere'

	SELECT @ProductId = Id from tblProduct where Title = 'Coffee'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Tea (Packets/Bags)'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	

		--AISLE Bakery - Aldi De Pere
	SELECT @AisleId = a.Id from tblAisle a join tblLayout l on a.LayoutId = l.Id where a.Number = 'Bakery' and l.Title = 'L_Aldi-De Pere'

	SELECT @ProductId = Id from tblProduct where Title = 'Bread (Bakery Fresh)'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Cake'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Donuts'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	

		--AISLE Dairy - Aldi De Pere
	SELECT @AisleId = a.Id from tblAisle a join tblLayout l on a.LayoutId = l.Id where a.Number = 'Dairy' and l.Title = 'L_Aldi-De Pere'

	SELECT @ProductId = Id from tblProduct where Title = 'Milk'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Eggs'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)
	
	SELECT @ProductId = Id from tblProduct where Title = 'Cheese'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)

	SELECT @ProductId = Id from tblProduct where Title = 'Cheese (Shredded)'
	INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	VALUES
	(NEWID(), @AisleId, @ProductId)

	--Find Seed for Alphabetical in ShoppingList.xaml.cs Window_Loaded
	--AISLE Alphabetical - Alphabetical-A-Z
	--SELECT @AisleId = a.Id from tblAisle a join tblLayout l on a.LayoutId = l.Id where a.Number = 'Alphabetical' and l.Title = 'L_Alphabetical-A-Z'

	--SELECT @ProductId = Id from tblProduct where Title = 'Carrots'
	--INSERT INTO dbo.tblAisleProduct(Id, AisleId, ProductId)
	--VALUES
	--(NEWID(), @AisleId, @ProductId)
	
END