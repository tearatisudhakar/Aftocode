USE [TOOL]
GO
/****** Object:  StoredProcedure [dbo].[Sp_DeleteItemInfo]    Script Date: 10-09-2017 16:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Rajkumar,,Name>
-- Create date: <03/12/2017 Date,,>
-- Description:	<All Item details,,>
-- =============================================
ALTER PROCEDURE [dbo].[Sp_DeleteItemInfo]

AS
BEGIN

select ItemId as 'Item Id', Location as 'Location',ItemCode as 'Item Code', ItemDescription as 'Item Description',Quantity,ItemType as 'Item Type',
ItemGroup as 'Item Group',Category as 'Item category',Supplier as 'Supplier'from tbliteminfo where IsActive=0

END
