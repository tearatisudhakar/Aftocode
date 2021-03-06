USE [TOOL]
GO
/****** Object:  StoredProcedure [dbo].[Sp_UpdateItemDetails]    Script Date: 10-09-2017 16:44:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Rajkumar,,Name>
-- Create date: <04/16/2017 Date,,>
-- Description:	<insert Item details,,>
-- =============================================
ALTER PROCEDURE [dbo].[Sp_UpdateItemDetails]
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
@ItemId int,
@MOQ int,
@ProductCode nvarchar(100)
)
AS
BEGIN

Begin Tran
	BEGIN TRY
		 update tblIteminfo set Location=@Location,ItemCode=@ItemCode,ItemDescription=@ItemDesc,ItemType=@ItemType,ItemGroup=@ItemGroup,
		 Category=@Category,Supplier=@Supplier,CreatedUserId=@UserId,Quantity=@Quantity,IsActive=1,MOQ=@MOQ,ProductCode=@ProductCode,UpdatedTimestamp=GETDATE() where ItemId=@ItemId
  
		 update tblItemStatus set TotalInInventory=@Quantity,Available=@Quantity where ItemID= @ItemId
 
		 insert into tblitemprocesslog (itemid,Task,Quantity,UserId) values(@ItemId,'Update',@Quantity,@UserId)

		 update tblImage set ImageName=@ImagePath,ImagePath=@ImagePath where ItemID= @ItemId
 
		COMMIT TRAN
	END TRY
	
	BEGIN CATCH
			ROLLBACK TRAN
	END CATCH
END