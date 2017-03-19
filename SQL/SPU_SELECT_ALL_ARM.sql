-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE SPU_SELECT_ALL_ARM

@TerBankName nvarchar(MAX), @TimeStamp nvarchar(MAX)
AS
BEGIN
DECLARE @sql NVARCHAR(MAX)
-- =============================================
-- Description:	Получение всех АРМ из AD (Windows 7)
-- =============================================

SET @sql  = N'SELECT [name]
      ,[description]
      ,[operatingSystem]
      ,[DistinguishedName]
      ,[LastLogonTimeStamp]
      ,[Enabled]
  INTO '+@TerBankName+'_All_ARM_'+@TimeStamp+'
  FROM [dbo].[SZB_AD_2017_03_17T17_27_14]
  WHERE [operatingSystem] LIKE ''Windows 7%'''

EXEC sys.sp_executesql @sql




END
GO
