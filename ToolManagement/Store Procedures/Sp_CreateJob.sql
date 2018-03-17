USE [TOOL]
GO
/****** Object:  StoredProcedure [dbo].[Sp_CreateJob]    Script Date: 10-09-2017 16:24:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[Sp_CreateJob]
(
@JobName nvarchar(150),
@JobDescription nvarchar(max),
@Createduserid int
)
AS
BEGIN

insert into tbljob(JobName,JobDescription,UserId) values(@JobName,@JobDescription,@Createduserid)

END
