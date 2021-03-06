USE [TOOL]
GO
/****** Object:  StoredProcedure [dbo].[Sp_ItemisssuedDetails]    Script Date: 10-09-2017 16:36:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Rajkumar,,Name>
-- Create date: <03/12/2017 Date,,>
-- Description:	<All Item details,,>
-- =============================================
ALTER PROCEDURE [dbo].[Sp_ItemisssuedDetails]
(
@UserId int,
@IsAdmin int
)
AS
BEGIN
	
	if(@IsAdmin=1)
		Begin		
			select i.IssuId,inf.ItemCode,i.ItemId,u.UserName as [Issued By],i.IssueItemQnt as [Issued Count],convert(date,i.CreateTimestamp,101) as IssuedDate from tblItemIssue i,tblUser u,tblIteminfo inf
			where i.IssueUserId=u.UserId and i.ItemId=inf.ItemId order by i.CreateTimestamp
		End
	else
		Begin
			select i.IssuId,inf.ItemCode,i.ItemId,u.UserName as [Issued By],i.IssueItemQnt as [Issued Count],convert(date,i.CreateTimestamp,101) as IssuedDate from tblItemIssue i,tblUser u,tblIteminfo inf
			where i.IssueUserId=u.UserId and i.ItemId=inf.ItemId and u.UserId=@UserId order by i.CreateTimestamp

		End
	
END

