USE [TOOL]
GO
/****** Object:  StoredProcedure [dbo].[Sp_login]    Script Date: 10-09-2017 16:39:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Rajkumar,,Name>
-- Create date: <03/12/2017 Date,,>
-- Description:	<login details,,>
-- =============================================
ALTER PROCEDURE [dbo].[Sp_login]
(
@UserName nvarchar(100),
@Password nvarchar(100)
)
AS
BEGIN

Declare @UserId Int

select UserId,ISNULL(IsAdmin,0) as IsAdmin,UserName,ISNULL(FirstName,'') as FirstName ,ISNULL(LastName,'') as LastName  from tblUser where UserName=@UserName and Password=@Password

select @UserId=UserId  from tblUser where UserName=@UserName and Password=@Password

if(@UserId>0)
	Begin
	select AllowGeneral,AllowItemMnagement,AllowInventory,AllowJobs,AllowReports,AllowSupplier,AllowConfiguration from tblUserprivilege where UserId=@UserId
	End
END
