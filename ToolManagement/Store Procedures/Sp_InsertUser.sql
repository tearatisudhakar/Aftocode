USE [TOOL]
GO
/****** Object:  StoredProcedure [dbo].[Sp_InsertUser]    Script Date: 10-09-2017 16:34:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[Sp_InsertUser]
(
@FirstName nvarchar(256),
@LastName nvarchar(256),
@UserName nvarchar(256),
@Password nvarchar(256)
)
AS
BEGIN

insert into tblUser(FirstName,LastName,UserName,Password) values(@FirstName,@LastName,@UserName,@Password)

END
