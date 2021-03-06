USE [TOOL]
GO
/****** Object:  StoredProcedure [dbo].[Sp_Location]    Script Date: 10-09-2017 16:39:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Rajkumar,,Name>
-- Create date: <19/08/2017 Date,,>
-- Description:	<Bind Locations,,>
-- =============================================
ALTER  PROCEDURE [dbo].[Sp_Location]
(
@DrawerId int
)
AS
BEGIN


select  (C.CabinetCode+'-'+D.DrawerCode+'-'+ B.BinCode) as Code,B.BinCode from tblBin B,tblDrawer D,tblCabinet C 
where B.DrawerId=D.DrawerId and D.CabinetId=C.CabinetId and D.DrawerId=@DrawerId and B.IsActive=1

END