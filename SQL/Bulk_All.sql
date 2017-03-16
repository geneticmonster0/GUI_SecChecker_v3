Drop Table [dbo].[SEP]



CREATE TABLE [SEP](
	[Sequence No ] [varchar](max) NULL,
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
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]


BULK INSERT [dbo].[SEP]
    FROM 'C:\Users\geneticmonster0\Desktop\temp\proverki\proverki\By_Date\2016-11-15\SZB\SEP\computer_status_export_B5DC7957AECD489B9CF94EE6847998CB.csv'
    WITH
    (
    FIRSTROW = 2,
	
    FIELDTERMINATOR = ',',  --CSV field delimiter
    ROWTERMINATOR = '\n',   --Use to shift the control to next row    
    TABLOCK
    )


Drop Table [dbo].[SCCM]

CREATE TABLE [dbo].[SCCM](
	[Textbox15] [varchar](max) NULL,
	[Textbox7] [varchar](max) NULL,
	[Тербанк] [varchar](max) NULL,
	[Name0] [varchar](max) NULL,
	[Client0] [varchar](max) NULL,
	[Active0] [varchar](max) NULL,
	[Operating_System_Name_and0] [varchar](max) NULL,
	[User_Name0] [varchar](max) NULL,
	[Creation_Date0] [varchar](max) NULL,
	[LastLogon] [varchar](max) NULL,
	[System_OU] [varchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

BULK INSERT [dbo].[SCCM]
    FROM 'C:\Users\geneticmonster0\Desktop\temp\proverki\proverki\By_Date\2016-11-15\SZB\SCCM\Компьютеры без клиента SCCM.csv'
    WITH
    (
    FIRSTROW = 2,
	
    FIELDTERMINATOR = ',',  --CSV field delimiter
    ROWTERMINATOR = '\n',   --Use to shift the control to next row    
    TABLOCK
    )

Drop Table [dbo].[MP]

CREATE TABLE [dbo].[MP](
	[IP1] [varchar](max) NULL,
	[IP2] [varchar](max) NULL,
	[Name] [varchar](max) NULL,
	[Name_Full] [varchar](max) NULL,
	[OS1] [varchar](max) NULL,
	[OS2] [varchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

BULK INSERT [dbo].[MP]
    FROM 'C:\Users\geneticmonster0\Desktop\temp\proverki\proverki\By_Date\2016-11-15\SZB\MP\p3.csv'
    WITH
    (
    FIRSTROW = 1,
	
    FIELDTERMINATOR = ';',  --CSV field delimiter
    ROWTERMINATOR = '\n',   --Use to shift the control to next row
    --ERRORFILE = 'C:\Users\geneticmonster0\Desktop\temp\proverki\proverki\By_Date\2016-11-15\SZB\AD\ErrorRows.csv',
    TABLOCK
    )

Drop Table [dbo].[avpo-06]

CREATE TABLE [dbo].[avpo-06](
	[Имя] [varchar](max) NULL,
	[Тип операционной системы] [varchar](max) NULL,
	[Домен] [varchar](max) NULL,
	[Установлен Агент] [varchar](max) NULL,
	[Функционирует Агент] [varchar](max) NULL,
	[Постоянная защита файловой системы] [varchar](max) NULL,
	[Соединение с Сервером] [varchar](max) NULL,
	[Последнее обновление] [varchar](max) NULL,
	[Статус] [varchar](max) NULL,
	[Описание статуса] [varchar](max) NULL,
	[Обновление информации] [varchar](max) NULL,
	[DNS-имя] [varchar](max) NULL,
	[DNS-домен] [varchar](max) NULL,
	[IP-адрес] [varchar](max) NULL,
	[Видим в сети] [varchar](max) NULL,
	[Проверка по требованию] [varchar](max) NULL,
	[Обнаружено вирусов] [varchar](max) NULL,
	[Статус постоянной защиты] [varchar](max) NULL,
	[IP-адрес соединения] [varchar](max) NULL,
	[Версия Агента администрирования] [varchar](max) NULL,
	[Версия защиты] [varchar](max) NULL,
	[Версия баз] [varchar](max) NULL,
	[Время включения] [varchar](max) NULL,
	[Перезагрузка] [varchar](max) NULL,
	[Агент обновлений] [varchar](max) NULL,
	[Описание] [varchar](max) NULL,
	[Статус шифрования] [varchar](max) NULL,
	[Состояние WUA] [varchar](max) NULL,
	[Разрядность ОС] [varchar](max) NULL,
	[Сервер] [varchar](max) NULL,
	[Родительская группа] [varchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

BULK INSERT [dbo].[avpo-06]
    FROM 'C:\Users\geneticmonster0\Desktop\temp\proverki\proverki\By_Date\2016-11-15\SZB\KSC\sksc-06.csv'
    WITH
    (
    FIRSTROW = 2,
	
    FIELDTERMINATOR = '\t',  --CSV field delimiter
    ROWTERMINATOR = '\n',   --Use to shift the control to next row
    --ERRORFILE = 'C:\Users\geneticmonster0\Desktop\temp\proverki\proverki\By_Date\2016-11-15\SZB\AD\ErrorRows.csv',
    TABLOCK
    )

Drop Table [dbo].[AD]

CREATE TABLE [dbo].[AD](
	["name"] [varchar](255) NULL,
	["description"] [varchar](max) NULL,
	["operatingSystem"] [varchar](255) NULL,
	["DistinguishedName"] [varchar](max) NULL,
	["LastLogonTimeStamp"] [varchar](255) NULL,
	["Enabled"] [varchar](255) NULL
) ON [PRIMARY]

BULK INSERT [dbo].[AD]
    FROM 'C:\Users\geneticmonster0\Desktop\temp\proverki\proverki\By_Date\2016-11-15\SZB\AD\All_Comps_hq.szb.sbrf.ru.csv'
    WITH
    (
    FIRSTROW = 2,
	
    FIELDTERMINATOR = ';',  --CSV field delimiter
    ROWTERMINATOR = '\n',   --Use to shift the control to next row
    --ERRORFILE = 'C:\Users\geneticmonster0\Desktop\temp\proverki\proverki\By_Date\2016-11-15\SZB\AD\ErrorRows.csv',
    TABLOCK
    )