USE [TOOL]
GO
/****** Object:  StoredProcedure [dbo].[Sp_ItemIssue]    Script Date: 10-09-2017 16:37:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Rajkumar,,Name>
-- Create date: <03/12/2017 Date,,>
-- Description:	<Issue Item details,,>
-- =============================================
ALTER PROCEDURE [dbo].[Sp_ItemIssue]
(
@ItemissueQnty int,
@ItemId int,
@UserId int,
@AvlQnt int,
@Jobid int
)
AS
BEGIN

declare @issue int
declare @tmpissue int

Begin Tran
	BEGIN TRY
		select @issue= ISNULL(issued,0) from tblItemStatus where ItemID=@ItemId;
		set @tmpissue=@issue+@ItemissueQnty
		
		update tbliteminfo set Quantity=@AvlQnt,UpdatedTimestamp=GETDATE() where itemid=@ItemId 

		insert into tblitemissue (ItemId,IssueItemQnt,IssueUserId) values(@ItemId,@ItemissueQnty,@UserId)

		update tblItemStatus set Available=@AvlQnt,Issued=@tmpissue,UpdatedTimestamp=GETDATE() where ItemID=@ItemId

		insert into tblitemprocesslog (itemid,Task,Quantity,UserId) values(@ItemId,'Issue',@ItemissueQnty,@UserId)

		insert into tblitemjob (UserId,JobId,ItemId,Quantity)values(@UserId,@Jobid,@ItemId,@ItemissueQnty)
	
		COMMIT TRAN
	END TRY
	
	BEGIN CATCH
			ROLLBACK TRAN
	END CATCH
END
