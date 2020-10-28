BEGIN
	INSERT INTO dbo.tblUser(Id, FirstName, LastName, Email, UserPass)
	VALUES
	--UserPass = Test123
	(NEWID(), 'Matthew', 'Butcher', '300019014@fvtc.edu', 'AB58d9a/LYstwgx2k/0B4sAPGlyvA7QeEyJgTFJsz+23sbSa'),
	(NEWID(), 'Mary Kay', 'Hinkson', 'TestUser@test.com', 'AB58d9a/LYstwgx2k/0B4sAPGlyvA7QeEyJgTFJsz+23sbSa'),
	(NEWID(), 'Joe', 'Wetzel', 'Consumer@FoodProducts.com', 'AB58d9a/LYstwgx2k/0B4sAPGlyvA7QeEyJgTFJsz+23sbSa'),
	(NEWID(), 'Tim', 'Tam', 'email@email.com', 'Lu5VGGuJ2jqn7C2qOayxoQmEApZgacBYzyLQvWjiYY/VctU7')
END