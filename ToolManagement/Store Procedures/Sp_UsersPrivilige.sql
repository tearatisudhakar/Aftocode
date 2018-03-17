USE [TOOL]
GO
/****** Object:  StoredProcedure [dbo].[Sp_UsersPrivilige]    Script Date: 10-09-2017 16:44:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Rajkumar,,Name>
-- Create date: <23/07/2017 Date,,>
-- Description:	<User Privilige details,,>
-- =============================================
ALTER PROCEDURE [dbo].[Sp_UsersPrivilige]

AS
BEGIN

SELECT u.UserName, Up.AllowGeneral,Up.AllowItemMnagement,Up.AllowInventory,Up.AllowJobs,Up.AllowReports,Up.AllowSupplier,Up.AllowConfiguration 
FROM tblUserprivilege Up,tblUser U where U.UserId=Up.UserId
END
