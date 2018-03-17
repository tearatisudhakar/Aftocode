USE [TOOL]
GO
/****** Object:  StoredProcedure [dbo].[Sp_AllItemInfo]    Script Date: 10-09-2017 16:07:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Rajkumar,,Name>
-- Create date: <03/12/2017 Date,,>
-- Description:	<All Item details,,>
-- =============================================
ALTER PROCEDURE [dbo].[Sp_AllItemInfo]

AS
BEGIN

select itemid as 'Item Id' ,ItemCode as 'Item Code', ItemDescription as 'Item Description',
ItemGroup as 'Item Group',Category as 'Item SubGroup',Supplier as 'Supplier',Quantity as 'Item Quantity',MOQ,ProductCode as 'Product Code'
 from tbliteminfo where IsActive=1

END
