USE [TOOL]
GO
/****** Object:  StoredProcedure [dbo].[sp_ProcesslogInfo]    Script Date: 10-09-2017 16:40:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[sp_ProcesslogInfo]
(
@LogId int
)
as begin

select ProcessLogId,Task,CreatedTimeStamp,Quantity,ItemID from tblitemprocesslog where ProcessLogId=@LogId
end
