USE [TOOL]
GO
/****** Object:  StoredProcedure [dbo].[Sp_ItemReturn]    Script Date: 10-09-2017 16:37:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Rajkumar,,Name>
-- Create date: <03/12/2017 Date,,>
-- Description:	<Issue Item details,,>
-- =============================================
ALTER PROCEDURE [dbo].[Sp_ItemReturn]
(
@ItemReturnQnty int,
@ItemId int,
@UserId int,
@ItemType bit
)
AS
BEGIN

declare @issue int
declare @tmpissue int
declare @AvlQnt int
declare @TempAvlQnt int

Begin Tran
	BEGIN TRY
		
		select @issue= ISNULL(issued,0) from tblItemStatus where ItemID=@ItemId;
		set @tmpissue=@issue-@ItemReturnQnty
		
		select @AvlQnt=ISNULL(Available,0) from tblItemStatus where ItemID=@ItemId;
		set @TempAvlQnt=@AvlQnt+@ItemReturnQnty
		
		IF(@ItemType='Used')
		BEGIN
		 
			UPDATE tbliteminfo set Quantity=@TempAvlQnt,UpdatedTimestamp=GETDATE() where itemid=@ItemId 		
			UPDATE tblItemStatus set Issued=@tmpissue,ReturnItems=@ItemReturnQnty,UpdatedTimestamp=GETDATE() where ItemID=@ItemId
			INSERT into tblitemprocesslog (itemid,Task,Quantity,UserId) values(@ItemId,'Return as Used',@ItemReturnQnty,@UserId)

		END
		ELSE
		BEGIN
		
			UPDATE tbliteminfo set Quantity=@TempAvlQnt,UpdatedTimestamp=GETDATE() where itemid=@ItemId 		
			UPDATE tblItemStatus set Available=@TempAvlQnt,Issued=@tmpissue,UpdatedTimestamp=GETDATE() where ItemID=@ItemId
			INSERT into tblitemprocesslog (itemid,Task,Quantity,UserId) values(@ItemId,'Return as Unused',@ItemReturnQnty,@UserId)
		 
		END
	
		COMMIT TRAN
	END TRY
	
	BEGIN CATCH
			ROLLBACK TRAN
	END CATCH
END
