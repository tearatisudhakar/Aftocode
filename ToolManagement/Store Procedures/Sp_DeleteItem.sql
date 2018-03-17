USE [TOOL]
GO
/****** Object:  StoredProcedure [dbo].[Sp_DeleteItem]    Script Date: 10-09-2017 16:26:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Rajkumar,,Name>
-- Create date: <03/12/2017 Date,,>
-- Description:	<All Item details,,>
-- =============================================
ALTER PROCEDURE [dbo].[Sp_DeleteItem]
(
@ItemId int,
@UserId int
)
AS
BEGIN
update tblIteminfo set IsActive=0 where ItemId=@ItemId

insert into tblitemprocesslog (itemid,Task,UserId) values(@ItemId,'Removed',@UserId)

END
