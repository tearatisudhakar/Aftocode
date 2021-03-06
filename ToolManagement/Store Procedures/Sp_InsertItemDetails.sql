USE [TOOL]
GO
/****** Object:  StoredProcedure [dbo].[Sp_InsertItemDetails]    Script Date: 10-09-2017 16:31:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Rajkumar,,Name>
-- Create date: <03/18/2017 Date,,>
-- Description:	<insert Item details,,>
-- =============================================
ALTER PROCEDURE [dbo].[Sp_InsertItemDetails]
(
@Location nvarchar(100),
@ItemCode nvarchar(150),
@ItemDesc nvarchar(500),
@ItemType nvarchar(100),
--@Barcode nvarchar(250),
@ItemGroup nvarchar(100),
@Category nvarchar(100),
@Supplier nvarchar(100),
@ImagePath nvarchar(500),
@Quantity int,
@UserId int,
@MOQ int,
@ProductCode nvarchar(100)
)
AS
BEGIN

declare @ItemId int
Begin Tran
	BEGIN TRY

		 insert into tblIteminfo (Location,ItemCode,ItemDescription,ItemType,ItemGroup,Category,Supplier,CreatedUserId,Quantity,IsActive,MOQ,ProductCode)
		 values(@Location,@ItemCode,@ItemDesc,@ItemType,@ItemGroup,@Category,@Supplier,@UserId,@Quantity,1,@MOQ,@ProductCode)
 
		 set @ItemId= SCOPE_IDENTITY()
 
		 insert into tblItemStatus (itemid,TotalInInventory,Available) values(@ItemId,@Quantity,@Quantity)
 

		 insert into tblitemprocesslog (itemid,Task,Quantity,UserId) values(@ItemId,'Load',@Quantity,@UserId)

		 insert into tblImage(ImageName,ImagePath,ItemID)values(@ImagePath,@ImagePath,@ItemId)

 
		COMMIT TRAN
	END TRY
	
	BEGIN CATCH
			ROLLBACK TRAN
	END CATCH
END
