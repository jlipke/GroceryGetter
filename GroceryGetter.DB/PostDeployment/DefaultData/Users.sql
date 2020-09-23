BEGIN
	INSERT INTO dbo.tblUser(Id, FirstName, LastName, Email, UserPass)
	VALUES
	--UserPass = Test123
	(NEWID(), 'Matthew', 'Butcher', '300019014@fvtc.edu', 'gwhlGAT6y3ua+P/FOjOiLWocisI='),
	(NEWID(), 'Mary Kay', 'Hinkson', 'TestUser@test.com', 'gwhlGAT6y3ua+P/FOjOiLWocisI='),
	(NEWID(), 'Joe', 'Wetzel', 'Consumer@FoodProducts.com', 'gwhlGAT6y3ua+P/FOjOiLWocisI=')
END