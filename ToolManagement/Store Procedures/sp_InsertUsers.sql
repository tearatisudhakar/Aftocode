USE [TOOL]
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertUsers]    Script Date: 10-09-2017 16:35:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


ALTER Procedure [dbo].[sp_InsertUsers]
(
@FirstName [nvarchar](250) ,
@LastName [nvarchar](250) ,
@UserName [nvarchar](250) ,
@Password [nvarchar](100) ,
@Company [nvarchar](100) ,
@Phone [nvarchar](50) ,
@Mobile [nvarchar](50) ,
@Fax [nvarchar](100) ,
@JobTittle [nvarchar](250) ,
@DepartMent [nvarchar](250),
@Address [nvarchar](250)  ,
@Town [nvarchar](100) ,
@State [nvarchar](100) ,
@PostalCode [nvarchar](100)  ,
@Country [nvarchar](100) ,
@Notes [nvarchar](250) ,
@IsAdmin bit 
)
as begin
Insert Into tblUsers (FirstName,LastName,UserName,Password,Company,Phone,Mobile,
Fax,JobTittle,DepartMent,Address,Town,State,PostalCode,Country,Notes,IsAdmin)values(@FirstName,
@LastName,@UserName,@Password,@Company,@Phone,@Mobile,@Fax,@JobTittle,@DepartMent,@Address,
@Town,@State,@PostalCode,@Country,@Notes,@IsAdmin)
end
