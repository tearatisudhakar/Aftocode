USE [TOOL]
GO
/****** Object:  StoredProcedure [dbo].[Sp_BindSupplier]    Script Date: 10-09-2017 16:22:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER  PROCEDURE [dbo].[Sp_BindSupplier]

AS
BEGIN

Select   SupplierId,SupplierName from tblSupplier


END
