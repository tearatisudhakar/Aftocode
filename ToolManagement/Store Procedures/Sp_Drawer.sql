USE [TOOL]
GO
/****** Object:  StoredProcedure [dbo].[Sp_Drawer]    Script Date: 10-09-2017 16:28:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Rajkumar,,Name>
-- Create date: <19/08/2017 Date,,>
-- Description:	<Bind Drawer,,>
-- =============================================
ALTER  PROCEDURE [dbo].[Sp_Drawer]

AS
BEGIN

Select DrawerId, DrawerCode from tblDrawer


END
