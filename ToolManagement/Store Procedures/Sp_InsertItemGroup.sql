USE [TOOL]
GO
/****** Object:  StoredProcedure [dbo].[Sp_InsertItemGroup]    Script Date: 10-09-2017 16:31:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[Sp_InsertItemGroup]
(
@ItemCategoryId int,
@ItemNewGroup nvarchar(100),
@Createduserid int
)
AS
BEGIN

insert into tblItemGroup(ItemCategoryId,ItemGroup,Createduserid)values(@ItemCategoryId,@ItemNewGroup,@Createduserid)

END
