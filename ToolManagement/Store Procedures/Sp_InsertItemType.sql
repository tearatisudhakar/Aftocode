USE [TOOL]
GO
/****** Object:  StoredProcedure [dbo].[Sp_InsertItemType]    Script Date: 10-09-2017 16:32:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[Sp_InsertItemType]
(
@ItemGroupId nvarchar(150),
@ItemType nvarchar(100),
@Createduserid int
)
AS
BEGIN

insert into tblItemType(ItemGroupId,ItemType,Createduserid) values(@ItemGroupId,@ItemType,@Createduserid)


END
