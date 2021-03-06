USE [Z:\DROPBOX\PROJECTS\WINDOWS\C#_UB\GUI_SECCHECKER_V3\GUI_SECCHECKER_V3\GUI_SECCHECKER_V3\DATABASES\DB_SECCHECKER.MDF]
GO
/****** Object:  StoredProcedure [dbo].[SPU_SELECT_PROBLEM_HOSTS]    Script Date: 3/17/2017 5:15:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[SPU_SELECT_PROBLEM_HOSTS]
@TerBankName nvarchar(MAX), @TimeStamp nvarchar(MAX)
AS
BEGIN

DECLARE @sql NVARCHAR(MAX)

--DROP TABLE SZB_Hosts_Without_AD_TB_2017_03_17T17_27_14, 
--SZB_Hosts_Without_AVPO_2017_03_17T17_27_14, 
--SZB_Hosts_Without_KES_2017_03_17T17_27_14, 
--SZB_Hosts_Without_SEP_2017_03_17T17_27_14, 
--SZB_KES_Agent_Client_ON_2017_03_17T17_27_14,
--SZB_Hosts_Without_AD_OMEGA_2017_03_17T17_27_14,
--SZB_Hosts_Without_AD_ALL_2017_03_17T17_27_14,
--SZB_Hosts_With_KES_Old_Base_2017_03_17T17_27_14,
--SZB_Hosts_With_KES_Old_Client_2017_03_17T17_27_14,
--SZB_Hosts_With_SEP_Old_Base_2017_03_17T17_27_14,
--SZB_Hosts_With_SEP_Old_Client_2017_03_17T17_27_14

-- =============================================
-- Description:	Удаление не актуальных данных из таблицы AD TB
-- =============================================

SET @sql  = N'DELETE FROM ['+@TerBankName+'_AD_'+@TimeStamp+']
        WHERE CASE WHEN isdate([LastLogonTimeStamp]) = 1
                       THEN Convert(nvarchar(20), 
                             Cast([LastLogonTimeStamp] as datetime),120) 
                  END < DATEADD(dd, -30, GETDATE()) OR [Enabled] = ''False'' OR [LastLogonTimeStamp] IS NULL'

EXEC sys.sp_executesql @sql

-- =============================================
-- Description:	Удаление не актуальных данных из таблицы AD OMEGA
-- =============================================

SET @sql  = N'DELETE FROM [OMEGA_AD_'+@TimeStamp+']
        WHERE CASE WHEN isdate([LastLogonTimeStamp]) = 1
                       THEN Convert(nvarchar(20), 
                             Cast([LastLogonTimeStamp] as datetime),120) 
                  END < DATEADD(dd, -30, GETDATE()) OR [Enabled] = ''False'' OR [LastLogonTimeStamp] IS NULL'

EXEC sys.sp_executesql @sql

-- =============================================
-- Description:	Удаление не актуальных данных из таблицы MP
-- =============================================

SET @sql  = N'  DELETE FROM ['+@TerBankName+'_MP_'+@TimeStamp+']
         WHERE [Name] IS NULL'

EXEC sys.sp_executesql @sql

SET @sql  = N'  DELETE FROM ['+@TerBankName+'_MP_'+@TimeStamp+']
         WHERE [OS1] NOT LIKE ''%Microsoft Windows%'''

EXEC sys.sp_executesql @sql


-- =============================================
-- Description:	Создание таблицы с хостами со статусом ОК в KES
-- =============================================

SET @sql  = N'SELECT [Name]
      ,[OS]
      ,[Domain]
      ,[AgentInstall]
      ,[AgentRun]
      ,[FSProtect]
      ,[ServerConnect]
      ,[LastUpdate]
      ,[Status]
      ,[StatusDesc]
      ,[UpdateInformation]
      ,[DNS-Name]
      ,[DNS-Domain]
      ,[IP-address]
      ,[LastOnline]
      ,[ScanDemand]
      ,[VirusDetected]
      ,[ProtectionStatus]
      ,[IP-addressConnection]
      ,[AgentVersion]
      ,[ClientVersion]
      ,[Base]
      ,[PowerOnTime]
      ,[Reboot]
      ,[AgentUpdate]
      ,[Desc]
      ,[StatusCrypto]
      ,[StatusWUA]
      ,[OSBit]
      ,[Server]
      ,[Group]
	  INTO '+@TerBankName+'_KES_Agent_Client_ON_'+@TimeStamp+'
  FROM ['+@TerBankName+'_KES_' +@TimeStamp+']'

	EXEC sys.sp_executesql @sql

-- =============================================
-- Description:	Создание таблицы с хостами без KES
-- =============================================

	SET @sql  = N'SELECT A.[name]
      ,[description]
      ,[operatingSystem]
      ,[DistinguishedName]
      ,[LastLogonTimeStamp]
      ,[Enabled]
	  INTO '+@TerBankName+'_Hosts_Without_KES_'+@TimeStamp+'
  FROM ['+@TerBankName+'_AD_'+@TimeStamp+'] A
LEFT JOIN ['+@TerBankName+'_KES_Agent_Client_ON_'+@TimeStamp+'] B
ON A.name = B.Name
WHERE B.Name IS NULL'

	EXEC sys.sp_executesql @sql


-- =============================================
-- Description:	Создание таблицы с хостами без SEP
-- =============================================

SET @sql  = N'SELECT A.[name]
      ,[description]
      ,[operatingSystem]
      ,[DistinguishedName]
      ,[LastLogonTimeStamp]
      ,[Enabled]
	  INTO '+@TerBankName+'_Hosts_Without_SEP_'+@TimeStamp+'
FROM ['+@TerBankName+'_AD_'+@TimeStamp+'] A
LEFT JOIN ['+@TerBankName+'_SEP_'+@TimeStamp+'] B
ON A.name = B.[Computer Name]
WHERE B.[Computer Name] IS NULL'

	EXEC sys.sp_executesql @sql

-- =============================================
-- Description:	Создание таблицы с хостами без АВПО
-- =============================================

SET @sql  = N'SELECT A.[name]
      ,A.[description]
      ,A.[operatingSystem]
      ,A.[DistinguishedName]
	  ,A.[LastLogonTimeStamp]
      ,A.[Enabled]
	  INTO '+@TerBankName+'_Hosts_Without_AVPO_'+@TimeStamp+'
FROM ['+@TerBankName+'_Hosts_Without_KES_'+@TimeStamp+'] A
INNER JOIN ['+@TerBankName+'_Hosts_Without_SEP_'+@TimeStamp+'] B
ON A.Name = B.Name'

	EXEC sys.sp_executesql @sql

-- =============================================
-- Description:	Создание таблицы с хостами не в AD TB
-- =============================================

SET @sql  = N'SELECT [IP1],[IP2],A.[Name],[Name_Full],[OS1], [OS2]
INTO '+@TerBankName+'_Hosts_Without_AD_TB_'+@TimeStamp+'
FROM ['+@TerBankName+'_MP_'+@TimeStamp+'] A
LEFT JOIN ['+@TerBankName+'_AD_'+@TimeStamp+'] B
ON A.Name = B.name
WHERE B.name IS NULL'

	EXEC sys.sp_executesql @sql

-- =============================================
-- Description:	Создание таблицы с хостами не в AD OMEGA
-- =============================================

SET @sql  = N'SELECT [IP1],[IP2],A.[Name],[Name_Full],[OS1], [OS2]
INTO '+@TerBankName+'_Hosts_Without_AD_OMEGA_'+@TimeStamp+'
FROM ['+@TerBankName+'_MP_'+@TimeStamp+'] A
LEFT JOIN [OMEGA_AD_'+@TimeStamp+'] B
ON A.Name = B.name
WHERE B.name IS NULL'

	EXEC sys.sp_executesql @sql

-- =============================================
-- Description:	Создание таблицы с хостами не в AD TB и OMEGA
-- =============================================

SET @sql  = N'SELECT A.[IP1],A.[IP2],A.[Name],A.[Name_Full],A.[OS1], A.[OS2]
INTO '+@TerBankName+'_Hosts_Without_AD_ALL_'+@TimeStamp+'
FROM ['+@TerBankName+'_Hosts_Without_AD_TB_'+@TimeStamp+'] A
INNER JOIN ['+@TerBankName+'_Hosts_Without_AD_OMEGA_'+@TimeStamp+'] B
ON A.Name = B.name'

	EXEC sys.sp_executesql @sql

-- =============================================
-- Description:	Создание таблицы с хостами со старыми базами KES
-- =============================================

SET @sql  = N'SELECT [Name]
      ,[OS]
      ,[Domain]
      ,[AgentInstall]
      ,[AgentRun]
      ,[FSProtect]
      ,[ServerConnect]
      ,[LastUpdate]
      ,[Status]
      ,[StatusDesc]
      ,[UpdateInformation]
      ,[DNS-Name]
      ,[DNS-Domain]
      ,[IP-address]
      ,[LastOnline]
      ,[ScanDemand]
      ,[VirusDetected]
      ,[ProtectionStatus]
      ,[IP-addressConnection]
      ,[AgentVersion]
      ,[ClientVersion]
      ,[Base]
      ,[PowerOnTime]
      ,[Reboot]
      ,[AgentUpdate]
      ,[Desc]
      ,[StatusCrypto]
      ,[StatusWUA]
      ,[OSBit]
      ,[Server]
      ,[Group]
  INTO '+@TerBankName+'_Hosts_With_KES_Old_Base_'+@TimeStamp+'
  FROM ['+@TerBankName+'_KES_Agent_Client_ON_'+@TimeStamp+']
  WHERE CASE WHEN isdate([Base]) = 1
                       THEN Convert(nvarchar(20), 
                             Cast([Base] as datetime),120) 
                  END < DATEADD(dd, -10, GETDATE())'

	EXEC sys.sp_executesql @sql

-- =============================================
-- Description:	Создание таблицы с хостами со старыми клиентами KES
-- =============================================

SET @sql  = N'SELECT [Name]
      ,[OS]
      ,[Domain]
      ,[AgentInstall]
      ,[AgentRun]
      ,[FSProtect]
      ,[ServerConnect]
      ,[LastUpdate]
      ,[Status]
      ,[StatusDesc]
      ,[UpdateInformation]
      ,[DNS-Name]
      ,[DNS-Domain]
      ,[IP-address]
      ,[LastOnline]
      ,[ScanDemand]
      ,[VirusDetected]
      ,[ProtectionStatus]
      ,[IP-addressConnection]
      ,[AgentVersion]
      ,[ClientVersion]
      ,[Base]
      ,[PowerOnTime]
      ,[Reboot]
      ,[AgentUpdate]
      ,[Desc]
      ,[StatusCrypto]
      ,[StatusWUA]
      ,[OSBit]
      ,[Server]
      ,[Group]
  INTO '+@TerBankName+'_Hosts_With_KES_Old_Client_'+@TimeStamp+'
  FROM ['+@TerBankName+'_KES_Agent_Client_ON_'+@TimeStamp+']
  WHERE [ClientVersion] NOT LIKE ''10.2.5%'''

	EXEC sys.sp_executesql @sql

-- =============================================
-- Description:	Создание таблицы с хостами со старыми базами SEP
-- =============================================

SET @sql  = N'SELECT [Sequence No ]
      ,[Pattern Date]
      ,[Revision]
      ,[Version]
      ,[Insert Date]
      ,[Time Stamp]
      ,[Client Type]
      ,[Operating System]
      ,[Kernel]
      ,[Client Version]
      ,[Policy Version]
      ,[Policy Serial]
      ,[Policy Checksum]
      ,[IPS Serial NO]
      ,[IPS Checksum]
      ,[HI Status]
      ,[HI Reason]
      ,[HI Description]
      ,[Creation Time]
      ,[Status]
      ,[Last time status changed]
      ,[Site Name]
      ,[Attribute Extension]
      ,[Full Name]
      ,[Email]
      ,[Job Title]
      ,[Department]
      ,[Employee Number]
      ,[Employment Status]
      ,[Office Phone]
      ,[Mobile Phone]
      ,[Home Phone]
      ,[Auto-Protect On]
      ,[Infected]
      ,[Worst Detection]
      ,[Last Scan Time]
      ,[Last Virus Time]
      ,[Accepts Content Update]
      ,[Antivirus engine On]
      ,[Download Insight On]
      ,[SONAR On]
      ,[Tamper Protection On]
      ,[Intrusion Prevention On]
      ,[IE Browser Protection On]
      ,[Firefox Browser Protection On]
      ,[Early Launch Antimalware On]
      ,[Major Version]
      ,[Minor Version]
      ,[Restart Required]
      ,[Restart Reason]
      ,[Computer Name]
      ,[Computer Domain Name]
      ,[Current login domain]
      ,[Last download time]
      ,[Number Of Processors]
      ,[Operating System Language]
      ,[Total disk space]
      ,[Total memory]
      ,[Computer description]
      ,[Service pack]
      ,[Processor Type]
      ,[Processor Clock]
      ,[BIOS version]
      ,[TPM device installed]
      ,[IP Address1]
      ,[IP Address2]
      ,[IP Address3]
      ,[IP Address4]
      ,[Gateway1]
      ,[Gateway2]
      ,[Gateway3]
      ,[Gateway4]
      ,[MAC Address1]
      ,[MAC Address2]
      ,[MAC Address3]
      ,[MAC Address4]
      ,[DNS server 1]
      ,[DNS server 2]
      ,[WINS server 1]
      ,[WINS server 2]
      ,[DHCP server]
      ,[Hardware Key]
      ,[Free memory]
      ,[Free disk space]
      ,[Time zone offset]
      ,[Network Threat Protection On]
      ,[Server Name]
      ,[Group Name]
      ,[Domain Name]
      ,[Current User]
      ,[IPS Version]
      ,[Deployment Status]
      ,[UUID]
  INTO '+@TerBankName+'_Hosts_With_SEP_Old_Base_'+@TimeStamp+'
  FROM ['+@TerBankName+'_SEP_'+@TimeStamp+']
  WHERE CASE WHEN isdate([Pattern Date]) = 1
                       THEN Convert(nvarchar(20), 
                             Cast([Pattern Date] as datetime),120) 
                  END < DATEADD(dd, -10, GETDATE())'

	EXEC sys.sp_executesql @sql

-- =============================================
-- Description:	Создание таблицы с хостами со старыми клиентами SEP
-- =============================================

SET @sql  = N'SELECT [Sequence No ]
      ,[Pattern Date]
      ,[Revision]
      ,[Version]
      ,[Insert Date]
      ,[Time Stamp]
      ,[Client Type]
      ,[Operating System]
      ,[Kernel]
      ,[Client Version]
      ,[Policy Version]
      ,[Policy Serial]
      ,[Policy Checksum]
      ,[IPS Serial NO]
      ,[IPS Checksum]
      ,[HI Status]
      ,[HI Reason]
      ,[HI Description]
      ,[Creation Time]
      ,[Status]
      ,[Last time status changed]
      ,[Site Name]
      ,[Attribute Extension]
      ,[Full Name]
      ,[Email]
      ,[Job Title]
      ,[Department]
      ,[Employee Number]
      ,[Employment Status]
      ,[Office Phone]
      ,[Mobile Phone]
      ,[Home Phone]
      ,[Auto-Protect On]
      ,[Infected]
      ,[Worst Detection]
      ,[Last Scan Time]
      ,[Last Virus Time]
      ,[Accepts Content Update]
      ,[Antivirus engine On]
      ,[Download Insight On]
      ,[SONAR On]
      ,[Tamper Protection On]
      ,[Intrusion Prevention On]
      ,[IE Browser Protection On]
      ,[Firefox Browser Protection On]
      ,[Early Launch Antimalware On]
      ,[Major Version]
      ,[Minor Version]
      ,[Restart Required]
      ,[Restart Reason]
      ,[Computer Name]
      ,[Computer Domain Name]
      ,[Current login domain]
      ,[Last download time]
      ,[Number Of Processors]
      ,[Operating System Language]
      ,[Total disk space]
      ,[Total memory]
      ,[Computer description]
      ,[Service pack]
      ,[Processor Type]
      ,[Processor Clock]
      ,[BIOS version]
      ,[TPM device installed]
      ,[IP Address1]
      ,[IP Address2]
      ,[IP Address3]
      ,[IP Address4]
      ,[Gateway1]
      ,[Gateway2]
      ,[Gateway3]
      ,[Gateway4]
      ,[MAC Address1]
      ,[MAC Address2]
      ,[MAC Address3]
      ,[MAC Address4]
      ,[DNS server 1]
      ,[DNS server 2]
      ,[WINS server 1]
      ,[WINS server 2]
      ,[DHCP server]
      ,[Hardware Key]
      ,[Free memory]
      ,[Free disk space]
      ,[Time zone offset]
      ,[Network Threat Protection On]
      ,[Server Name]
      ,[Group Name]
      ,[Domain Name]
      ,[Current User]
      ,[IPS Version]
      ,[Deployment Status]
      ,[UUID]
  INTO '+@TerBankName+'_Hosts_With_SEP_Old_Client_'+@TimeStamp+'
  FROM ['+@TerBankName+'_SEP_'+@TimeStamp+']
  WHERE [Client Version] != ''12.1.7004.6500'''

	EXEC sys.sp_executesql @sql



END
