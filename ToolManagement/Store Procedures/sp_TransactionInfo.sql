USE [TOOL]
GO
/****** Object:  StoredProcedure [dbo].[sp_TransactionInfo]    Script Date: 10-09-2017 16:44:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[sp_TransactionInfo]
(
@ItemId int
)
as begin

select ProcessLogId,Task,CreatedTimeStamp,ISNULL(Quantity,0) as Quantity ,ItemID from tblitemprocesslog where ItemId=@ItemId

select  Location as 'Location',ItemId as 'Item id',ItemCode as 'Item Code', ItemDescription as 'Item Description',ItemType as 'Item Type', Barcode as 'Barcode',
ItemGroup as 'Item Group',Category as 'Item category',Supplier as 'Supplier',Quantity as 'Item Quantity' , UserName as 'User Name'  from tbliteminfo join tblUser on tblIteminfo.CreatedUserId=tblUser.UserId   where ItemId=@ItemId
end
