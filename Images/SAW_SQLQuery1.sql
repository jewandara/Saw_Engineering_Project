----========================================================================----
CREATE TABLE dbo.saw_User
(
	UserID					UNIQUEIDENTIFIER			UNIQUE		 NONCLUSTERED 			NOT NULL	DEFAULT (NEWID()),
	UserName				NVARCHAR(15)													NOT NULL,
	UserPass				NVARCHAR(50)													NOT NULL,
	ConactNo				NVARCHAR(15)													NOT NULL,
	LoginDate				DATETIME														NOT NULL	DEFAULT (getdate()),
	PRIMARY KEY (UserID)
);
INSERT INTO dbo.saw_User VALUES (NewID(),'sedawatha','sedawatha@123','0771234567',getdate());
INSERT INTO dbo.saw_User VALUES (NewID(),'gampaha','gampaha@123','0771234567',getdate());
INSERT INTO dbo.saw_User VALUES (NewID(),'nittambuwa','nittambuwa@123','0771234567',getdate());
SELECT * FROM saw_User
----========================================================================----
CREATE TABLE dbo.saw_Item
(
	ItemID					UNIQUEIDENTIFIER			UNIQUE		 NONCLUSTERED 			NOT NULL	DEFAULT (NEWID()),
	UserID					UNIQUEIDENTIFIER												NOT NULL    REFERENCES saw_User(UserID),
	ItemSawID				NVARCHAR(10)													NOT NULL,
	ItemSawName				NVARCHAR(500)													NOT NULL,
	ItemSawQtyValue			DECIMAL(10,2)													NOT NULL,
	ItemSawQtyType			NVARCHAR(20)													NOT NULL	DEFAULT ('NOS'),
	ItemSawQtyMinLimite		DECIMAL(10,2)													NOT NULL,
	ItemDescription			NVARCHAR(2000)													NULL,
	InsertDate				DATETIME														NOT NULL	DEFAULT (getdate()),
	PRIMARY KEY (ItemID)
);
SELECT * FROM saw_Item
----========================================================================----
CREATE TABLE dbo.saw_access
(
	AccID					UNIQUEIDENTIFIER			UNIQUE		 NONCLUSTERED 			NOT NULL	DEFAULT (NEWID()),
	UserID					UNIQUEIDENTIFIER												NOT NULL    REFERENCES saw_User(UserID),
	AccDescription			NVARCHAR(500)													NULL,
	InsertDate				DATETIME														NOT NULL	DEFAULT (getdate()),
	PRIMARY KEY (AccID)
);


--------------------------------------------------------------------------------
ALTER PROCEDURE dbo._sp_saw_NewItem
	@UserName				NVARCHAR(15),
	@ItemSawID				NVARCHAR(10),	
	@ItemSawName			NVARCHAR(500),
	@ItemSawQtyValue		DECIMAL(10,2),
	@ItemSawQtyType			NVARCHAR(20),
	@ItemSawQtyMinLimite	DECIMAL(10,2),
	@ItemDescription		NVARCHAR(2000)
AS
BEGIN
    SET NOCOUNT ON;
    IF EXISTS(SELECT UserID FROM dbo.saw_User WHERE UserName = @UserName)
	BEGIN
		DECLARE @UserID	UNIQUEIDENTIFIER SET @UserID = (SELECT UserID FROM dbo.saw_User WHERE UserName = @UserName);
		DECLARE @NewID	UNIQUEIDENTIFIER SET @NewID = NEWID();
		INSERT INTO dbo.saw_Item VALUES (@NewID,@UserID,@ItemSawID,@ItemSawName,@ItemSawQtyValue,@ItemSawQtyType,@ItemSawQtyMinLimite,@ItemDescription,getdate());
		INSERT INTO dbo.saw_access VALUES (NEWID(),@UserID,'>NEW :' + @ItemSawID + '; >NAME :' + @ItemSawName + '; >QTY :' + convert(nvarchar(50),@ItemSawQtyValue) + '-' + @ItemSawQtyType + '-' + convert(nvarchar(50),@ItemSawQtyMinLimite) + '; >DES :' + @ItemDescription,getdate());
		SELECT 'TRUE' AS 'MSG';
	END
	ELSE
	BEGIN
		SELECT 'FALSE' AS 'MSG';
	END			
END

EXECUTE dbo._sp_saw_NewItem
	@UserName				= 'gampaha',
	@ItemSawID				= 'SAW00011',	
	@ItemSawName			= 'REarth Wire',
	@ItemSawQtyValue		=  3453546,
	@ItemSawQtyType			= 'm',
	@ItemSawQtyMinLimite	= 12,
	@ItemDescription		= 'Square mili meters 2.5'
SELECT * FROM saw_Item
SELECT * FROM saw_User
SELECT * FROM saw_access



--------------------------------------------------------------------------------
ALTER PROCEDURE dbo._sp_saw_DeleteItem
	@UserName				NVARCHAR(15),
	@ItemID					UNIQUEIDENTIFIER
AS
BEGIN
    SET NOCOUNT ON;
    IF EXISTS(SELECT ItemID FROM dbo.saw_Item WHERE ItemID = @ItemID AND UserID = (SELECT UserID FROM dbo.saw_User WHERE UserName = @UserName))
	BEGIN
		DECLARE @UserID	UNIQUEIDENTIFIER SET @UserID = (SELECT UserID FROM dbo.saw_User WHERE UserName = @UserName);
		DECLARE @ITEMDATA NVARCHAR(500);
		SET @ITEMDATA = (SELECT ItemSawID FROM dbo.saw_Item WHERE ItemID = @ItemID);
		SET @ITEMDATA = @ITEMDATA + '; >NAME :' + (SELECT ItemSawNAME FROM dbo.saw_Item WHERE ItemID = @ItemID);
		SET @ITEMDATA = @ITEMDATA + '; >QTY :' + convert(nvarchar(50),(SELECT ItemSawQtyValue FROM dbo.saw_Item WHERE ItemID = @ItemID));
		DELETE FROM dbo.saw_Item WHERE ItemID = (SELECT ItemID FROM dbo.saw_Item WHERE ItemID = @ItemID) AND UserID = (SELECT UserID FROM dbo.saw_User WHERE UserName = @UserName);
		INSERT INTO dbo.saw_access VALUES (NEWID(),@UserID,'>DELETE: ' + @ITEMDATA + ';',getdate());
		SELECT 'TRUE' AS 'MSG';
	END
	ELSE
	BEGIN
		SELECT 'FALSE' AS 'MSG';
	END			
END



EXECUTE dbo._sp_saw_DeleteItem
	@UserName				= 'gampaha',
	@ItemID				= 'B3FD4489-9C69-45C5-B770-46E5A5E21E7B'
SELECT * FROM saw_Item
SELECT * FROM saw_Item
SELECT * FROM saw_User
SELECT * FROM saw_access


--------------------------------------------------------------------------------
ALTER PROCEDURE dbo._sp_saw_UpdateItem
	@UserName				NVARCHAR(15),
	@ItemID					UNIQUEIDENTIFIER,
	@ItemSawQtyValue		DECIMAL(10,2),
	@ItemSawQtyType			NVARCHAR(20),
	@ItemSawQtyMinLimite	DECIMAL(10,2),
	@ItemDescription		NVARCHAR(2000)
AS
BEGIN
    SET NOCOUNT ON;
    IF EXISTS(SELECT ItemID FROM dbo.saw_Item WHERE ItemID = @ItemID AND UserID = (SELECT UserID FROM dbo.saw_User WHERE UserName = @UserName))
	BEGIN
		DECLARE @UserID	UNIQUEIDENTIFIER SET @UserID = (SELECT UserID FROM dbo.saw_User WHERE UserName = @UserName);
		DECLARE @ITEMDATA NVARCHAR(500);
		SET @ITEMDATA = (SELECT ItemSawID FROM dbo.saw_Item WHERE ItemID = @ItemID);
		SET @ITEMDATA = @ITEMDATA + '; >NAME :' + (SELECT ItemSawNAME FROM dbo.saw_Item WHERE ItemID = @ItemID);
		SET @ITEMDATA = @ITEMDATA + '; >QTY :' + convert(nvarchar(50),@ItemSawQtyValue);
		SET @ITEMDATA = @ITEMDATA + '; >QTYTYPE :' + @ItemSawQtyType;
		SET @ITEMDATA = @ITEMDATA + '; >MINQTY :' + convert(nvarchar(50),@ItemSawQtyMinLimite);
		SET @ITEMDATA = @ITEMDATA + '; >DES :' + @ItemDescription;
		UPDATE dbo.saw_Item SET ItemSawQtyValue = @ItemSawQtyValue, ItemSawQtyType = @ItemSawQtyType, ItemSawQtyMinLimite = @ItemSawQtyMinLimite, ItemDescription = @ItemDescription WHERE ItemID = (SELECT ItemID FROM dbo.saw_Item WHERE ItemID = @ItemID) AND UserID = (SELECT UserID FROM dbo.saw_User WHERE UserName = @UserName);
		INSERT INTO dbo.saw_access VALUES (NEWID(),@UserID,'>UPDATE: ' + @ITEMDATA + ';',getdate());
		SELECT 'TRUE' AS 'MSG';
	END
	ELSE
	BEGIN
		SELECT 'FALSE' AS 'MSG';
	END			
END

EXECUTE dbo._sp_saw_UpdateItem
	@UserName				= 'gampaha',
	@ItemID				= 'C5D33876-1307-428B-BBFB-FA1428D6BC45',
	@ItemSawQtyValue	= 878,
	@ItemSawQtyType		= 'jhggjh',
	@ItemSawQtyMinLimite	= 9,
	@ItemDescription		= 'gfg'


--------------------------------------------------------------------------------
ALTER PROCEDURE dbo._sp_saw_UpdateItemBYID
	@UserName				NVARCHAR(15),
	@ItemID					UNIQUEIDENTIFIER,
	@ItemSawQtyValue		DECIMAL(10,2)
AS
BEGIN
    SET NOCOUNT ON;
    IF EXISTS(SELECT ItemID FROM dbo.saw_Item WHERE ItemID = @ItemID AND UserID = (SELECT UserID FROM dbo.saw_User WHERE UserName = @UserName))
	BEGIN
		DECLARE @UserID	UNIQUEIDENTIFIER SET @UserID = (SELECT UserID FROM dbo.saw_User WHERE UserName = @UserName);
		DECLARE @ITEMDATA NVARCHAR(500);
		SET @ITEMDATA = (SELECT ItemSawID FROM dbo.saw_Item WHERE ItemID = @ItemID);
		SET @ITEMDATA = @ITEMDATA + '; >NAME :' + (SELECT ItemSawNAME FROM dbo.saw_Item WHERE ItemID = @ItemID);
		SET @ITEMDATA = @ITEMDATA + '; >QTY :' + convert(nvarchar(50),(SELECT ItemSawQtyValue FROM dbo.saw_Item WHERE ItemID = @ItemID));
		SET @ITEMDATA = @ITEMDATA + '; >NEWQTY :' + convert(nvarchar(50),@ItemSawQtyValue);
		UPDATE dbo.saw_Item SET ItemSawQtyValue = @ItemSawQtyValue WHERE ItemID = (SELECT ItemID FROM dbo.saw_Item WHERE ItemID = @ItemID) AND UserID = (SELECT UserID FROM dbo.saw_User WHERE UserName = @UserName);
		INSERT INTO dbo.saw_access VALUES (NEWID(),@UserID,'>UPDATEBYID: ' + @ITEMDATA + ';',getdate());
		SELECT 'TRUE' AS 'MSG';
	END
	ELSE
	BEGIN
		SELECT 'FALSE' AS 'MSG';
	END			
END


EXECUTE dbo._sp_saw_UpdateItemBYID
	@UserName				= 'gampaha',
	@ItemID				= 'C5D33876-1307-428B-BBFB-FA1428D6BC45',
	@ItemSawQtyValue	= 111113
SELECT * FROM saw_Item
SELECT * FROM saw_User
SELECT * FROM saw_access
	
	
	
	
	
	
	
	
	
	
	
	
	
--------------------------------------------------------------------------------
ALTER PROCEDURE dbo._sp_saw_ViewItem
	@UserName				NVARCHAR(15)
AS
BEGIN
    SET NOCOUNT ON;
    IF EXISTS(SELECT UserID FROM dbo.saw_User WHERE UserName = @UserName)
	BEGIN
		SELECT *, 'TRUE' AS 'MSG' 
		FROM dbo.saw_Item 
		WHERE UserID = (SELECT UserID FROM dbo.saw_User WHERE UserName = @UserName)
		ORDER BY ItemSawID ASC,ItemSawQtyValue DESC;
	END
	ELSE
	BEGIN
		SELECT 'FALSE' AS 'MSG';
	END			
END
	
--------------------------------------------------------------------------------
CREATE PROCEDURE dbo._sp_saw_ViewItemByID
	@UserName				NVARCHAR(15),
	@ItemID					UNIQUEIDENTIFIER
AS
BEGIN
    SET NOCOUNT ON;
    IF EXISTS(SELECT UserID FROM dbo.saw_User WHERE UserName = @UserName)
	BEGIN
		SELECT *, 'TRUE' AS 'MSG' 
		FROM dbo.saw_Item 
		WHERE UserID = (SELECT UserID FROM dbo.saw_User WHERE UserName = @UserName) AND ItemID = @ItemID
		ORDER BY ItemSawName ASC,ItemSawQtyValue DESC;
	END
	ELSE
	BEGIN
		SELECT 'FALSE' AS 'MSG';
	END			
END

--------------------------------------------------------------------------------
CREATE PROCEDURE dbo._sp_saw_ViewItemSearch
	@UserName				NVARCHAR(15),
	@Type					NVARCHAR(5),
	@Data					NVARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;
    IF EXISTS(SELECT UserID FROM dbo.saw_User WHERE UserName = @UserName)
	BEGIN
	    IF @Type = 'ID'
		BEGIN
			SELECT TOP 5 *, 'TRUE' AS 'MSG' 
			FROM dbo.saw_Item 
			WHERE UserID = (SELECT UserID FROM dbo.saw_User WHERE UserName = @UserName)
			AND ItemSawID LIKE @Data + '%'
			ORDER BY ItemSawID ASC,InsertDate DESC;
		END
		ELSE IF @Type = 'NAME'
		BEGIN
			SELECT TOP 5 *, 'TRUE' AS 'MSG' 
			FROM dbo.saw_Item 
			WHERE UserID = (SELECT UserID FROM dbo.saw_User WHERE UserName = @UserName)
			AND ItemSawName LIKE @Data + '%'
			ORDER BY ItemSawName ASC,InsertDate DESC;
		END
		ELSE
		BEGIN
			SELECT 'ERROR' AS 'MSG';
		END	
	END
	ELSE
	BEGIN
		SELECT 'FALSE' AS 'MSG';
	END			
END

EXECUTE dbo._sp_saw_ViewItemByID
	@UserName				= 'gampaha', @ItemID = '1314FE21-AAC1-42A4-8321-401134BFAB3B'




--------------------------------------------------------------------------------
ALTER PROCEDURE dbo._sp_saw_ViewAccess
	@UserName				NVARCHAR(15),
	@Y						NVARCHAR(5),
	@M						NVARCHAR(15)
AS
BEGIN
    SET NOCOUNT ON;
    IF EXISTS(SELECT UserID FROM dbo.saw_User WHERE UserName = @UserName)
	BEGIN
		SELECT *, @UserName AS 'UserName', 'TRUE' AS 'MSG' 
		FROM dbo.saw_access
		WHERE UserID = (SELECT UserID FROM dbo.saw_User WHERE UserName = @UserName)
		AND DATEPART(yyyy,InsertDate) = @Y AND  DATEPART(mm,InsertDate) = @M 
		ORDER BY InsertDate DESC;
	END
	ELSE
	BEGIN
		SELECT 'FALSE' AS 'MSG';
	END			
END

EXECUTE dbo._sp_saw_ViewAccess
	@UserName		= 'gampaha',
	@Y	=	'2016',@M	=	'1'
	
	
	
SELECT DATEPART(yyyy,GETDATE())



--------------------------------------------------------------------------------
CREATE PROCEDURE dbo._sp_saw_ChangePass
	@UserName				NVARCHAR(15),
	@OldPass				NVARCHAR(50),
	@NewPass				NVARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;
    IF EXISTS(SELECT UserID FROM dbo.saw_User WHERE UserName = @UserName)
	BEGIN
	    IF EXISTS(SELECT UserID FROM dbo.saw_User WHERE UserName = @UserName AND UserPass = @OldPass )
		BEGIN
			DECLARE @UserID	UNIQUEIDENTIFIER SET @UserID = (SELECT UserID FROM dbo.saw_User WHERE UserName = @UserName);
			UPDATE dbo.saw_User SET UserPass = @NewPass WHERE UserName = @UserName;
			INSERT INTO dbo.saw_access VALUES (NEWID(),@UserID,'>CHANGEPASS;',getdate());
			SELECT 'TRUE' AS 'MSG';
		END
		ELSE
		BEGIN
			SELECT 'ERROR' AS 'MSG';
		END				
	END
	ELSE
	BEGIN
		SELECT 'FALSE' AS 'MSG';
	END			
END

EXECUTE dbo._sp_saw_ChangePass
	@UserName				= 'gampaha',
	@OldPass				= 'gampaha@123',
	@NewPass				= 'gampaha12'
	



--------------------------------------------------------------------------------
CREATE PROCEDURE dbo._sp_saw_LoginUser
	@UserName				NVARCHAR(15),
	@LogPass				NVARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;
    IF EXISTS(SELECT UserID FROM dbo.saw_User WHERE UserName = @UserName)
	BEGIN
	    IF EXISTS(SELECT UserID FROM dbo.saw_User WHERE UserName = @UserName AND UserPass = @LogPass )
		BEGIN
			DECLARE @UserID	UNIQUEIDENTIFIER SET @UserID = (SELECT UserID FROM dbo.saw_User WHERE UserName = @UserName);
			INSERT INTO dbo.saw_access VALUES (NEWID(),@UserID,'>LOGIN;',getdate());
			SELECT 'TRUE' AS 'MSG';
		END
		ELSE
		BEGIN
			SELECT 'ERROR' AS 'MSG';
		END				
	END
	ELSE
	BEGIN
		SELECT 'FALSE' AS 'MSG';
	END			
END





--------------------------------------------------------------------------------
ALTER PROCEDURE dbo._sp_saw_CountQty
	@UserName				NVARCHAR(15)
AS
BEGIN
    SET NOCOUNT ON;
    IF EXISTS(SELECT UserID FROM dbo.saw_User WHERE UserName = @UserName)
	BEGIN
		DECLARE @UserID	UNIQUEIDENTIFIER SET @UserID = (SELECT UserID FROM dbo.saw_User WHERE UserName = @UserName);
		INSERT INTO dbo.saw_access VALUES (NEWID(),@UserID,'>COUNT_LIMIT_ITEM;',getdate());	
		SELECT COUNT(*) AS 'COUNT', 'TRUE' AS 'MSG' FROM  saw_Item WHERE ItemSawQtyValue < ItemSawQtyMinLimite AND UserID = @UserID;
	END
	ELSE
	BEGIN
		SELECT 'FALSE' AS 'MSG';
	END			
END

--------------------------------------------------------------------------------
CREATE PROCEDURE dbo._sp_saw_ViewCountQty
	@UserName				NVARCHAR(15)
AS
BEGIN
    SET NOCOUNT ON;
    IF EXISTS(SELECT UserID FROM dbo.saw_User WHERE UserName = @UserName)
	BEGIN
		SELECT *
		FROM  saw_Item 
		WHERE ItemSawQtyValue < ItemSawQtyMinLimite
		ORDER BY InsertDate DESC;
		DECLARE @UserID	UNIQUEIDENTIFIER SET @UserID = (SELECT UserID FROM dbo.saw_User WHERE UserName = @UserName);
		INSERT INTO dbo.saw_access VALUES (NEWID(),@UserID,'>VIEW_LIMIT_ITEM;',getdate());		
	END
	ELSE
	BEGIN
		SELECT 'FALSE' AS 'MSG';
	END			
END