USE [TOOL]
GO
/****** Object:  StoredProcedure [dbo].[Sp_Suplier]    Script Date: 10-09-2017 16:43:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Rajkumar,,Name>
-- Create date: <03/12/2017 Date,,>
-- Description:	<All Item details,,>
-- =============================================
ALTER PROCEDURE [dbo].[Sp_Suplier]

AS
BEGIN

SELECT SupplierName as 'Supplier Name',Address,Phone,Fax,Contact,Notes FROM tblSupplier

END
