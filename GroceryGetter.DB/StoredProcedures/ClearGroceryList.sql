CREATE PROCEDURE [dbo].[ClearGroceryList]
	@userid uniqueidentifier
	
AS
	DELETE FROM tblUserProduct WHERE UserId = userid

RETURN 0
