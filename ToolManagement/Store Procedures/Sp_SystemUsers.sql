USE [TOOL]
GO
/****** Object:  StoredProcedure [dbo].[Sp_SystemUsers]    Script Date: 10-09-2017 16:44:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Rajkumar,,Name>
-- Create date: <03/12/2017 Date,,>
-- Description:	<All Item details,,>
-- =============================================
ALTER PROCEDURE [dbo].[Sp_SystemUsers]

AS
BEGIN

SELECT * FROM tblUsers
END
