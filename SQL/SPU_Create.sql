USE [testDB_2]
GO

/****** Object:  StoredProcedure [dbo].[SPU_CreateTable_AD]    Script Date: 3/14/2017 4:57:36 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SPU_CreateTable_SEP]
	-- Add the parameters for the stored procedure here
@TableName varchar(MAX)
--@FilePath varchar(100)
AS
BEGIN
DECLARE @sql NVARCHAR(MAX)
SET @sql  = N'CREATE TABLE '+@TableName+' ([Sequence No ] [varchar](max) NULL,
	[Pattern Date] [varchar](max) NULL,
	[Revision] [varchar](max) NULL,
	[Version] [varchar](max) NULL,
	[Insert Date] [varchar](max) NULL,
	[Time Stamp] [varchar](max) NULL,
	[Client Type] [varchar](max) NULL,
	[Operating System] [varchar](max) NULL,
	[Kernel] [varchar](max) NULL,
	[Client Version] [varchar](max) NULL,
	[Policy Version] [varchar](max) NULL,
	[Policy Serial] [varchar](max) NULL,
	[Policy Checksum] [varchar](max) NULL,
	[IPS Serial NO] [varchar](max) NULL,
	[IPS Checksum] [varchar](max) NULL,
	[HI Status] [varchar](max) NULL,
	[HI Reason] [varchar](max) NULL,
	[HI Description] [varchar](max) NULL,
	[Creation Time] [varchar](max) NULL,
	[Status] [varchar](max) NULL,
	[Last time status changed] [varchar](max) NULL,
	[Site Name] [varchar](max) NULL,
	[Attribute Extension] [varchar](max) NULL,
	[Full Name] [varchar](max) NULL,
	[Email] [varchar](max) NULL,
	[Job Title] [varchar](max) NULL,
	[Department] [varchar](max) NULL,
	[Employee Number] [varchar](max) NULL,
	[Employment Status] [varchar](max) NULL,
	[Office Phone] [varchar](max) NULL,
	[Mobile Phone] [varchar](max) NULL,
	[Home Phone] [varchar](max) NULL,
	[Auto-Protect On] [varchar](max) NULL,
	[Infected] [varchar](max) NULL,
	[Worst Detection] [varchar](max) NULL,
	[Last Scan Time] [varchar](max) NULL,
	[Last Virus Time] [varchar](max) NULL,
	[Accepts Content Update] [varchar](max) NULL,
	[Antivirus engine On] [varchar](max) NULL,
	[Download Insight On] [varchar](max) NULL,
	[SONAR On] [varchar](max) NULL,
	[Tamper Protection On] [varchar](max) NULL,
	[Intrusion Prevention On] [varchar](max) NULL,
	[IE Browser Protection On] [varchar](max) NULL,
	[Firefox Browser Protection On] [varchar](max) NULL,
	[Early Launch Antimalware On] [varchar](max) NULL,
	[Major Version] [varchar](max) NULL,
	[Minor Version] [varchar](max) NULL,
	[Restart Required] [varchar](max) NULL,
	[Restart Reason] [varchar](max) NULL,
	[Computer Name] [varchar](max) NULL,
	[Computer Domain Name] [varchar](max) NULL,
	[Current login domain] [varchar](max) NULL,
	[Last download time] [varchar](max) NULL,
	[Number Of Processors] [varchar](max) NULL,
	[Operating System Language] [varchar](max) NULL,
	[Total disk space] [varchar](max) NULL,
	[Total memory] [varchar](max) NULL,
	[Computer description] [varchar](max) NULL,
	[Service pack] [varchar](max) NULL,
	[Processor Type] [varchar](max) NULL,
	[Processor Clock] [varchar](max) NULL,
	[BIOS version] [varchar](max) NULL,
	[TPM device installed] [varchar](max) NULL,
	[IP Address1] [varchar](max) NULL,
	[IP Address2] [varchar](max) NULL,
	[IP Address3] [varchar](max) NULL,
	[IP Address4] [varchar](max) NULL,
	[Gateway1] [varchar](max) NULL,
	[Gateway2] [varchar](max) NULL,
	[Gateway3] [varchar](max) NULL,
	[Gateway4] [varchar](max) NULL,
	[MAC Address1] [varchar](max) NULL,
	[MAC Address2] [varchar](max) NULL,
	[MAC Address3] [varchar](max) NULL,
	[MAC Address4] [varchar](max) NULL,
	[DNS server 1] [varchar](max) NULL,
	[DNS server 2] [varchar](max) NULL,
	[WINS server 1] [varchar](max) NULL,
	[WINS server 2] [varchar](max) NULL,
	[DHCP server] [varchar](max) NULL,
	[Hardware Key] [varchar](max) NULL,
	[Free memory] [varchar](max) NULL,
	[Free disk space] [varchar](max) NULL,
	[Time zone offset] [varchar](max) NULL,
	[Network Threat Protection On] [varchar](max) NULL,
	[Server Name] [varchar](max) NULL,
	[Group Name] [varchar](max) NULL,
	[Domain Name] [varchar](max) NULL,
	[Current User] [varchar](max) NULL,
	[IPS Version] [varchar](max) NULL,
	[Deployment Status] [varchar](max) NULL,
	[UUID] [varchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]'

	EXEC sys.sp_executesql @sql;


END

GO


