USE [TOOL]
GO
/****** Object:  StoredProcedure [dbo].[sp_CreateSupplier]    Script Date: 10-09-2017 16:25:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Ajay,,Name>
-- Create date: <6/30/2017,>
-- Description:	<Created This SP With Raj kumar References,,>
-- =============================================
ALTER PROCEDURE [dbo].[sp_CreateSupplier]
(
	@SupplierName nvarchar(250),
	@MiddleName nvarchar(250),
	@LastName nvarchar(250),
	@Company nvarchar(500),
	@DisplayName nvarchar(250),
	@Mobile nvarchar(50),
	@Email nvarchar(250),
	@Address nvarchar(max),
	@Phone nvarchar(50),
	@Fax nvarchar(50),
	@AccountNo nvarchar(250),
	@PanNumber nvarchar(250),
	@TaxRegistarNo nvarchar(250),
	@SupplierCode nvarchar(50),
	@City nvarchar(250),
	@State nvarchar(250),
	@Country nvarchar(250),
	@PoastalCode nvarchar(250),
	@Notes nvarchar(max),
	@UserId int
)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

		Insert into tblSuppliers (SupplierName,MiddleName,LastName,Company,DisplayName,Mobile,
	Email,Address,Phone,Fax,AccountNo,PanNumber,TaxRegistrationNo,SupplierCode,City,State,
	Country,PostalCode,Notes,UserId )values(@SupplierName,@MiddleName,@LastName,@Company,@DisplayName,
	@Mobile,@Email,@Address,@Phone,@Fax,@AccountNo,@PanNumber,@TaxRegistarNo,@SupplierCode,@City,@State,@Country,
	@PoastalCode,@Notes,@UserId)

END

