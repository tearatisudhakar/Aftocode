USE [TOOL]
GO
/****** Object:  StoredProcedure [dbo].[Sp_GetLocations]    Script Date: 10-09-2017 16:29:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Rajkumar,,Name>
-- Create date: <13/08/2017 Date,,>
-- Description:	<All location names,,>
-- =============================================
ALTER PROCEDURE [dbo].[Sp_GetLocations]

AS
BEGIN

select SUBSTRING(Location,9,LEN(Location)-8) as Location from tblIteminfo

END
