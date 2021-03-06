USE [TOOL]
GO
/****** Object:  StoredProcedure [dbo].[Sp_ItemStatus]    Script Date: 10-09-2017 16:38:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Rajkumar,,Name>
-- Create date: <03/12/2017 Date,,>
-- Description:	<All Item details,,>
-- =============================================
ALTER PROCEDURE [dbo].[Sp_ItemStatus]
(
@ItemId int
)
AS
BEGIN

select ISNULL(Available,0) as Available,ISNULL(TotalInInventory,0) as TotalInInventory,
ISNULL(Issued,0) as Issued,ISNULL(OnOrder,0) as OnOrder from tblItemStatus where ItemID=@ItemId

select  Location as 'Location',ItemCode as 'Item Code', ItemDescription as 'Item Description', Barcode as 'Barcode',
ItemGroup as 'Item Group',Category as 'Item SubGroup',Supplier as 'Supplier',Quantity as 'Item Quantity' , UserName as 'User Name'  from tbliteminfo join tblUser on tblIteminfo.CreatedUserId=tblUser.UserId   where ItemId=@ItemId


END
