USE [TOOL]
GO
/****** Object:  StoredProcedure [dbo].[Sp_ItemInfo]    Script Date: 10-09-2017 16:35:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Rajkumar,,Name>
-- Create date: <03/12/2017 Date,,>
-- Description:	<All Item details,,>
-- =============================================
ALTER PROCEDURE [dbo].[Sp_ItemInfo]
(
@ItemCode nvarchar(100)
)
AS
BEGIN

--Should not be modified Column names due to column names are hard coded in C# code
select ItemId as 'Item Id', Location as 'Location',ItemCode as 'Item Code', ItemDescription as 'Item Description', Barcode as 'Barcode',
ItemGroup as 'Item Group',Category as 'Item SubGroup',Supplier as 'Supplier',Quantity as 'Item Quantity' ,MOQ,ProductCode as 'Product Code'
from tbliteminfo where ItemCode=@ItemCode


select ImageName,ImagePath from tblImage where ItemID in(select ItemID from tblIteminfo where ItemCode=@ItemCode)

END
