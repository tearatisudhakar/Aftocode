USE [TOOL]
GO
/****** Object:  StoredProcedure [dbo].[Sp_BindItemType]    Script Date: 10-09-2017 16:19:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<,,Name>
-- Create date: <03/12/2017 Date,,>
-- Description:	<insert item type details,,>
-- =============================================
ALTER PROCEDURE [dbo].[Sp_BindItemType]
(
@itemgroupid int
)
AS
BEGIN
--if(@itemgroupid!=0)
--		begin
--		select ItemTypeId,ItemType from tblitemtype 

--		end
--    else
--		begin
--		select ItemGroupId,ItemGroup  from tblItemGroup 
--		end
  select ItemTypeId,ItemType from tblitemtype where ItemGroupId=@itemgroupid
  
END
