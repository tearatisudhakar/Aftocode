USE [TOOL]
GO
/****** Object:  StoredProcedure [dbo].[Sp_ReturnItemdDetails]    Script Date: 10-09-2017 16:41:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Rajkumar,,Name>
-- Create date: <02/09/2017 Date,,>
-- Description:	<All Item details,,>
-- =============================================
ALTER PROCEDURE [dbo].[Sp_ReturnItemdDetails]

AS
BEGIN
	
	select I.itemid as 'Item Id' ,I.ItemCode as 'Item Code', I.ItemDescription as 'Item Description',
	I.ItemGroup as 'Item Group',I.Category as 'Item SubGroup',I.Supplier as 'Supplier',S.ReturnItems as 'Return Item',
	I.ProductCode as 'Product Code' from tblIteminfo I,tblItemStatus S where I.ItemId=S.ItemID and S.ReturnItems>0	
	
END

