USE [TOOL]
GO
/****** Object:  StoredProcedure [dbo].[Sp_BindJob]    Script Date: 10-09-2017 16:21:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Rajkumar>
-- Create date: <04/15/2017 Date,,>
-- Description:	<insert item type details,,>
-- =============================================
ALTER PROCEDURE [dbo].[Sp_BindJob]
(
@userid  int
)
AS
BEGIN

select JobId,JobName from tbljob where isactive=1 and userid=@userid


END
