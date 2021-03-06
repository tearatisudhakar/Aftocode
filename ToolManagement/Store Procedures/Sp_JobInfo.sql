USE [TOOL]
GO
/****** Object:  StoredProcedure [dbo].[Sp_JobInfo]    Script Date: 10-09-2017 16:38:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Rajkumar,,Name>
-- Create date: <04/16/2017 Date,,>
-- Description:	<All Item details,,>
-- =============================================
ALTER PROCEDURE [dbo].[Sp_JobInfo]
(
@userid int,
@Jobid int
)
AS
BEGIN

if(@Jobid=0)
	begin
		select ij.ItemJobId as 'Item Job Id',u.UserName as 'User Name',j.JobName as 'Job Name',inf.ItemCode as 'Item Code',ij.Quantity ,ij.CreateTimestamp as 'Created Time' from tblitemJob ij,tblUser u,tblIteminfo inf,tblJob J 
		where ij.UserId=u.UserId and ij.ItemId=inf.ItemId and ij.JobId=j.Jobid and ij.UserId=@userid
	end
	Else
	BEGIN
	select ij.ItemJobId as 'Item Job Id',u.UserName as 'User Name',j.JobName as 'Job Name',inf.ItemCode as 'Item Code',ij.Quantity,ij.CreateTimestamp as 'Created Time' from tblitemJob ij,tblUser u,tblIteminfo inf,tblJob J 
		where ij.UserId=u.UserId and ij.ItemId=inf.ItemId and ij.JobId=j.Jobid and ij.UserId=@userid and ij.Jobid=@Jobid
	END
	
END
