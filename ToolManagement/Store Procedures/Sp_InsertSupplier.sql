USE [TOOL]
GO
/****** Object:  StoredProcedure [dbo].[Sp_InsertSupplier]    Script Date: 10-09-2017 16:32:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[Sp_InsertSupplier]
(
@SupplierName nvarchar(150),
@Address nvarchar(100),
@Phone nvarchar(50),
@Fax nvarchar(100),
@Contact nvarchar(100),
@UserId int,
@Note nvarchar(max)

)
AS
BEGIN

insert into tblSupplier (SupplierName,Address,Phone,Fax,Contact,Notes,UserId) values
(@SupplierName,@Address,@Phone,@Fax,@Contact,@Note,@UserId)

END
