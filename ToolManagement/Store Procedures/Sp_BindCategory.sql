USE [TOOL]
GO
/****** Object:  StoredProcedure [dbo].[Sp_BindCategory]    Script Date: 10-09-2017 16:13:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<,,Name>
-- Create date: <03/12/2017 Date,,>
-- Description:	<insert item type details,,>
-- =============================================
ALTER PROCEDURE [dbo].[Sp_BindCategory]

AS
BEGIN

select ItemCategoryId,ItemCategory from tblItemCategory


END
