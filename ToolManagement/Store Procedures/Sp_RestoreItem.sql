USE [TOOL]
GO
/****** Object:  StoredProcedure [dbo].[Sp_RestoreItem]    Script Date: 10-09-2017 16:40:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Rajkumar,,Name>
-- Create date: <04/15/2017 Date,,>
-- Description:	<All Item details,,>
-- =============================================
ALTER PROCEDURE [dbo].[Sp_RestoreItem]
(
@ItemId int,
@UserId int,
@Qnty int
)
AS
BEGIN
update tblIteminfo set IsActive=1 where ItemId=@ItemId

insert into tblitemprocesslog (itemid,Task,UserId,Quantity) values(@ItemId,'Restore',@UserId,@Qnty)


--select * from tblitemprocesslog
END
