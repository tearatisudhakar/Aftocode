USE [TOOL]
GO
/****** Object:  StoredProcedure [dbo].[Sp_ReturnItemInfo]    Script Date: 10-09-2017 16:42:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Rajkumar,,Name>
-- Create date: <15/07/2017 Date,,>
-- Description:	<All Item details,,>
-- =============================================
ALTER PROCEDURE [dbo].[Sp_ReturnItemInfo]
(
@ItemCode nvarchar(100)
)
AS
BEGIN


select Itm.ItemCode,U.FirstName,Pl.Quantity,CONVERT(date,PL.CreatedTimeStamp,101) as Date from
 tblItemProcessLog Pl,tblIteminfo Itm,tblUser U where Pl.UserId=U.UserId and Itm.ItemId=Pl.ItemId and Pl.Task='RETURN'

END
