USE [TOOL]
GO
/****** Object:  StoredProcedure [dbo].[Sp_ItemisssuedDetails_Sandeep2]    Script Date: 10-09-2017 16:36:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[Sp_ItemisssuedDetails_Sandeep2]
(
@UserId int,
@IsAdmin int,
@FromDateCreateTimestamp datetime,
@ToDateCreateTimestamp datetime
)
AS
BEGIN
	
	if(@IsAdmin=1 and @FromDateCreateTimestamp='' and @ToDateCreateTimestamp='' )
		Begin		
			select i.IssuId,inf.ItemCode,i.ItemId,u.UserName as [Issued By],i.IssueItemQnt as [Issued Count],convert(date,i.CreateTimestamp,101) as IssuedDate from tblItemIssue i,tblUser u,tblIteminfo inf
			where i.IssueUserId=u.UserId and i.ItemId=inf.ItemId order by i.CreateTimestamp
		End
	else if(@FromDateCreateTimestamp='' and @ToDateCreateTimestamp='' )
		Begin
			select i.IssuId,inf.ItemCode,i.ItemId,u.UserName as [Issued By],i.IssueItemQnt as [Issued Count],convert(date,i.CreateTimestamp,101) as IssuedDate from tblItemIssue i,tblUser u,tblIteminfo inf
			where i.IssueUserId=u.UserId and i.ItemId=inf.ItemId and u.UserId=@UserId order by i.CreateTimestamp
		End

		if(@FromDateCreateTimestamp!='' and  @ToDateCreateTimestamp!='')
		Begin
				select i.IssuId,inf.ItemCode,i.ItemId,u.UserName as [Issued By],i.IssueItemQnt as [Issued Count],convert(date,i.CreateTimestamp,101) as IssuedDate from tblItemIssue i,tblUser u,tblIteminfo inf
			    where  i.CreateTimestamp between CONVERT(datetime,@FromDateCreateTimestamp) and CONVERT(datetime,@ToDateCreateTimestamp) and i.IssueUserId=u.UserId and i.ItemId=inf.ItemId and u.UserId=@UserId

				End
END