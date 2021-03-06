USE [TOOL]
GO
/****** Object:  StoredProcedure [dbo].[Sp_AllItemStatus]    Script Date: 10-09-2017 16:11:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Rajkumar,,Name>
-- Create date: <03/12/2017 Date,,>
-- Description:	<All Item details,,>
-- =============================================
ALTER PROCEDURE [dbo].[Sp_AllItemStatus]
(
@ItemId nvarchar(250)
)
AS
BEGIN

if(len(@ItemId)=0)
begin
select c.ItemCode,ISNULL(i.Available,0) as Available,ISNULL(i.TotalInInventory,0) as TotalInInventory,
ISNULL(i.Issued,0) as Issued,ISNULL(i.OnOrder,0) as OnOrder from tblItemStatus i,tblIteminfo c
 where c.ItemId=i.ItemID
 end
 else
 begin
 
select c.ItemCode,ISNULL(i.Available,0) as Available,ISNULL(i.TotalInInventory,0) as TotalInInventory,
ISNULL(i.Issued,0) as Issued,ISNULL(i.OnOrder,0) as OnOrder from tblItemStatus i,tblIteminfo c
 where c.ItemId=i.ItemID and c.ItemCode=@ItemId
 end

END
