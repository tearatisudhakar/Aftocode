USE [TOOL]
GO
/****** Object:  StoredProcedure [dbo].[SP_SelectUsers]    Script Date: 10-09-2017 16:43:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER procedure [dbo].[SP_SelectUsers]
(
 @IsAdmin bit

)
as
begin
select UserName,[Password],Company,Phone,Mobile,Fax,JobTittle,DepartMent,[Address],Town,[State],PostalCode,Country,Notes,CreatedTimeStramp from tblUsers where IsAdmin=@IsAdmin
end