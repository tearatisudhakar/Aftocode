USE [TOOL]
GO
/****** Object:  StoredProcedure [dbo].[Sp_InsertItemCategory]    Script Date: 10-09-2017 16:30:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[Sp_InsertItemCategory]
(
@ItemCategory nvarchar(100),
@Createduserid int
)
AS
BEGIN

insert into tblItemCategory(ItemCategory,Createduserid)values(@ItemCategory,@Createduserid)

END
