USE [TOOL]
GO
/****** Object:  StoredProcedure [dbo].[Sp_BinditemGroup]    Script Date: 10-09-2017 16:15:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[Sp_BinditemGroup]
(
@itemselectedCategory int
)
AS
BEGIN
if(@itemselectedCategory!=0)
	begin
	select ItemGroupId,ItemGroup  from tblItemGroup where ItemCategoryId=@itemselectedCategory;
	end
else
	begin
	select ItemGroupId,ItemGroup  from tblItemGroup 
	end
END
