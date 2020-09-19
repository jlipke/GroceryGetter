BEGIN
	INSERT INTO dbo.tblUser(Id, FirstName, LastName, Email, UserPass)
	VALUES
	--UserPass = Test123
	(NEWID(), 'Matthew', 'Butcher', '300019014@fvtc.edu', 'gwhlGAT6y3ua+P/FOjOiLWocisI='),
	(NEWID(), 'Vincent', 'Morrill', 'Morrill9941@fvtc.edu', 'gwhlGAT6y3ua+P/FOjOiLWocisI='),
	(NEWID(), 'Brian', 'Foote', 'test@fvtc.edu', 'gwhlGAT6y3ua+P/FOjOiLWocisI=')
END