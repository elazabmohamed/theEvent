if not exists (SELECT* FROM sys.databases WHERE name = 'THEVENT2') 
BEGIN 
Create database [THEVENT2] 
END
GO
USE [THEVENT2] 
GO
if not exists (SELECT* FROM sys.objects WHERE name = 'tblPerson')
BEGIN 
CREATE TABLE [dbo].[tblPerson](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[type] [nvarchar](10) NOT NULL,
	[fname] [nvarchar](50) NOT NULL,
	[lname] [nvarchar](50) NOT NULL,
	[email] [nvarchar](100) UNIQUE NOT NULL,
	[password] [nvarchar](100) NOT NULL,
	[location] [nvarchar](50) NOT NULL,
	[birthdate] [date] NULL,
	[registration] [smalldatetime] NULL,
 CONSTRAINT [PK_tblPerson] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
SET IDENTITY_INSERT [dbo].[tblPerson] ON 
INSERT [dbo].[tblPerson] ([id], [type], [fname], [lname], [email], [password], [location], [birthdate], [registration]) VALUES (1, N'Admin', N'Mohamed', N'Elazab', N'm@elazab.com', N'muhamed', N'Istanbul', NULL, NULL)

INSERT [dbo].[tblPerson] ([id], [type], [fname], [lname], [email], [password], [location], [birthdate], [registration]) VALUES (2, N'Admin', N'Muhammed Nafiz', N'Canitez', N'nafiz@canitez.com', N'nafiz', N'Kayseri', CAST(N'1998-03-04' AS Date), NULL)

INSERT [dbo].[tblPerson] ([id], [type], [fname], [lname], [email], [password], [location], [birthdate], [registration]) VALUES (3, N'Admin', N'Erdem', N'Demir', N'erdem@demir.com', N'erdem', N'Istanbul', NULL, CAST(N'2020-12-06T17:31:00' AS SmallDateTime))

INSERT [dbo].[tblPerson] ([id], [type], [fname], [lname], [email], [password], [location], [birthdate], [registration]) VALUES (4, N'Member', N'Yusuf', N'Uslu', N'yusuf@uslu.com', N'yusuf', N'Batman', CAST(N'1999-01-07' AS Date), CAST(N'2020-12-06T17:48:00' AS SmallDateTime))

INSERT [dbo].[tblPerson] ([id], [type], [fname], [lname], [email], [password], [location], [birthdate], [registration]) VALUES (5, N'Admin', N'Tayyib', N'Bayram', N'tayyib@bayram.com', N'tayyib', N'Trabzon', CAST(N'1999-08-06' AS Date), CAST(N'2020-12-10T23:49:00' AS SmallDateTime))

INSERT [dbo].[tblPerson] ([id], [type], [fname], [lname], [email], [password], [location], [birthdate], [registration]) VALUES (6, N'Member', N'Abdullah', N'Turgut', N'abdullah@turgut.com', N'abdullah', N'Sivas', CAST(N'1999-12-10' AS Date), CAST(N'2020-12-10T23:50:00' AS SmallDateTime))

INSERT [dbo].[tblPerson] ([id], [type], [fname], [lname], [email], [password], [location], [birthdate], [registration]) VALUES (10, N'Member', N'Nurettin Resul', N'TANYILDIZI', N'resul@tanyildizi.com', N'resul', N'Elazig', CAST(N'1999-11-18' AS Date), CAST(N'2020-12-13T22:07:00' AS SmallDateTime))

INSERT [dbo].[tblPerson] ([id], [type], [fname], [lname], [email], [password], [location], [birthdate], [registration]) VALUES (11, N'Member', N'Dogan Dinçer', N'DEMIRCI', N'dogan@demirci.com', N'dogan', N'Amasya', CAST(N'2002-12-22' AS Date), CAST(N'2020-12-16T16:22:00' AS SmallDateTime))
SET IDENTITY_INSERT [dbo].[tblPerson] OFF 
END

if not exists (SELECT* FROM sys.objects WHERE name = 'tblEvent')
BEGIN 
CREATE TABLE [dbo].[tblEvent](
	[eventid] [int] IDENTITY(1,1) NOT NULL,
	[makerEmail] [nvarchar](100) NOT NULL,
	[eventName] [nvarchar](50) NULL,
	[eventType] [nvarchar](50) NULL,
	[eventLocation] [nvarchar](50) NULL,
	[eventDate] [smalldatetime] NULL,
	[invitedMembers] [nvarchar](max) NULL,
	[eventNote] [nvarchar](max) NULL,
 CONSTRAINT [PK_tblEvent] PRIMARY KEY CLUSTERED 
(
	[eventid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
SET IDENTITY_INSERT [dbo].[tblEvent] ON 
INSERT [dbo].[tblEvent] ([eventid], [makerEmail], [eventName], [eventType], [eventLocation], [eventDate], [invitedMembers], [eventNote]) VALUES (5, N'nafiz@canitez.com', N'Football Match', N'Social', N'Çanakkale', CAST(N'2019-12-20T08:30:00' AS SmallDateTime), N'
Erdem Demir.
Yusuf Uslu.
', N'bring food')
SET IDENTITY_INSERT [dbo].[tblEvent] OFF 
END

if not exists (SELECT* FROM sys.objects WHERE name = 'tblMessage')
BEGIN 
CREATE TABLE [dbo].[tblMessage](
	[messageid] [int] IDENTITY(1,1) NOT NULL,
	[senderid] [int] NOT NULL,
	[recieverid] [int] NOT NULL,
	[message] [nvarchar](max) NULL,
	[messagedate] [datetime] NULL,
 CONSTRAINT [PK_tblMessage] PRIMARY KEY CLUSTERED 
(
	[messageid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

SET IDENTITY_INSERT [dbo].[tblMessage] ON 

INSERT [dbo].[tblMessage] ([messageid], [senderid], [recieverid], [message], [messagedate]) VALUES (1, 2, 1, N'Ben Nafiz', CAST(N'2020-12-08T19:10:02.057' AS DateTime))

INSERT [dbo].[tblMessage] ([messageid], [senderid], [recieverid], [message], [messagedate]) VALUES (2, 1, 2, N'Ben de Elazab', CAST(N'2020-12-08T19:11:02.057' AS DateTime))

INSERT [dbo].[tblMessage] ([messageid], [senderid], [recieverid], [message], [messagedate]) VALUES (3, 3, 4, N'Ben Erdem', CAST(N'2020-12-08T19:12:02.057' AS DateTime))

INSERT [dbo].[tblMessage] ([messageid], [senderid], [recieverid], [message], [messagedate]) VALUES (4, 2, 1, N'Nas?ls?n Elazab?', CAST(N'2020-12-08T19:13:02.057' AS DateTime))

INSERT [dbo].[tblMessage] ([messageid], [senderid], [recieverid], [message], [messagedate]) VALUES (7, 2, 3, N'Erdem merhaba ben Nafiz', CAST(N'2020-12-08T19:16:02.057' AS DateTime))

INSERT [dbo].[tblMessage] ([messageid], [senderid], [recieverid], [message], [messagedate]) VALUES (8, 2, 4, N'Yusuf merhaba ben Nafiz', CAST(N'2020-12-08T19:16:12.883' AS DateTime))

INSERT [dbo].[tblMessage] ([messageid], [senderid], [recieverid], [message], [messagedate]) VALUES (10, 3, 2, N'erdem denem 123', CAST(N'2020-12-08T21:39:32.083' AS DateTime))

INSERT [dbo].[tblMessage] ([messageid], [senderid], [recieverid], [message], [messagedate]) VALUES (11, 11, 2, N'Merhaba Nafiz ben Do?an', CAST(N'2020-12-16T17:08:22.897' AS DateTime))

INSERT [dbo].[tblMessage] ([messageid], [senderid], [recieverid], [message], [messagedate]) VALUES (12, 2, 3, N'Nas?ls?n Erdem?', CAST(N'2020-12-19T21:39:42.353' AS DateTime))

SET IDENTITY_INSERT [dbo].[tblMessage] OFF

END
if not exists (SELECT* FROM sys.objects WHERE name = 'tblReview')
BEGIN 
CREATE TABLE [dbo].[tblReview](
	[reviewId] [int] IDENTITY(1,1) NOT NULL,
	[reviewerId] [int] NOT NULL,
	[review] [nvarchar](max) NULL,
	[reviewedEventId] [int] NOT NULL,
 CONSTRAINT [PK_tblReview] PRIMARY KEY CLUSTERED 
(
	[reviewId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
SET IDENTITY_INSERT [dbo].[tblReview] ON 

INSERT [dbo].[tblReview] ([reviewId], [reviewerId], [review], [reviewedEventId]) VALUES (2, 1, N'It was fun', 5)

INSERT [dbo].[tblReview] ([reviewId], [reviewerId], [review], [reviewedEventId]) VALUES (3, 2, N'i didnt like it', 5)

INSERT [dbo].[tblReview] ([reviewId], [reviewerId], [review], [reviewedEventId]) VALUES (7, 4, N'Nice', 5)

SET IDENTITY_INSERT [dbo].[tblReview] OFF 


END


if not exists (SELECT* FROM sys.objects WHERE name = 'tblCity')
BEGIN 
CREATE TABLE [dbo].[tblCity](
	[city] [nvarchar](50) NULL
) ON [PRIMARY]

INSERT [dbo].[tblCity] ([city]) VALUES (N'Adana')

INSERT [dbo].[tblCity] ([city]) VALUES (N'Ad?yaman')

INSERT [dbo].[tblCity] ([city]) VALUES (N'Afyonkarahisar')

INSERT [dbo].[tblCity] ([city]) VALUES (N'A?r?')

INSERT [dbo].[tblCity] ([city]) VALUES (N'Aksaray')

INSERT [dbo].[tblCity] ([city]) VALUES (N'Amasya')

INSERT [dbo].[tblCity] ([city]) VALUES (N'Ankara')

INSERT [dbo].[tblCity] ([city]) VALUES (N'Antalya')

INSERT [dbo].[tblCity] ([city]) VALUES (N'Ardahan')

INSERT [dbo].[tblCity] ([city]) VALUES (N'Artvin')

INSERT [dbo].[tblCity] ([city]) VALUES (N'Ayd?n')

INSERT [dbo].[tblCity] ([city]) VALUES (N'Bal?kesir')

INSERT [dbo].[tblCity] ([city]) VALUES (N'Bart?n')

INSERT [dbo].[tblCity] ([city]) VALUES (N'Batman')

INSERT [dbo].[tblCity] ([city]) VALUES (N'Bayburt')

INSERT [dbo].[tblCity] ([city]) VALUES (N'Bilecik')

INSERT [dbo].[tblCity] ([city]) VALUES (N'Bingöl')

INSERT [dbo].[tblCity] ([city]) VALUES (N'Bitlis')

INSERT [dbo].[tblCity] ([city]) VALUES (N'Bolu')

INSERT [dbo].[tblCity] ([city]) VALUES (N'Burdur')

INSERT [dbo].[tblCity] ([city]) VALUES (N'Bursa')

INSERT [dbo].[tblCity] ([city]) VALUES (N'Çanakkale')

INSERT [dbo].[tblCity] ([city]) VALUES (N'Çank?r?')

INSERT [dbo].[tblCity] ([city]) VALUES (N'Çorum')

INSERT [dbo].[tblCity] ([city]) VALUES (N'Denizli')

INSERT [dbo].[tblCity] ([city]) VALUES (N'Diyarbak?r')

INSERT [dbo].[tblCity] ([city]) VALUES (N'Düzce')

INSERT [dbo].[tblCity] ([city]) VALUES (N'Edirne')

INSERT [dbo].[tblCity] ([city]) VALUES (N'Elaz??')

INSERT [dbo].[tblCity] ([city]) VALUES (N'Erzincan')

INSERT [dbo].[tblCity] ([city]) VALUES (N'Erzurum')

INSERT [dbo].[tblCity] ([city]) VALUES (N'Eski?ehir')

INSERT [dbo].[tblCity] ([city]) VALUES (N'Gaziantep')

INSERT [dbo].[tblCity] ([city]) VALUES (N'Giresun')

INSERT [dbo].[tblCity] ([city]) VALUES (N'Gümü?hane')

INSERT [dbo].[tblCity] ([city]) VALUES (N'Hakkâri')

INSERT [dbo].[tblCity] ([city]) VALUES (N'Hatay')

INSERT [dbo].[tblCity] ([city]) VALUES (N'I?d?r')

INSERT [dbo].[tblCity] ([city]) VALUES (N'Isparta')

INSERT [dbo].[tblCity] ([city]) VALUES (N'Istanbul')

INSERT [dbo].[tblCity] ([city]) VALUES (N'Izmir')

INSERT [dbo].[tblCity] ([city]) VALUES (N'Kahramanmara?')

INSERT [dbo].[tblCity] ([city]) VALUES (N'Karabük')
INSERT [dbo].[tblCity] ([city]) VALUES (N'Karaman')
INSERT [dbo].[tblCity] ([city]) VALUES (N'Kars')
INSERT [dbo].[tblCity] ([city]) VALUES (N'Kastamonu')
INSERT [dbo].[tblCity] ([city]) VALUES (N'Kayseri')
INSERT [dbo].[tblCity] ([city]) VALUES (N'Kilis')
INSERT [dbo].[tblCity] ([city]) VALUES (N'K?r?kkale')
INSERT [dbo].[tblCity] ([city]) VALUES (N'K?rklareli')
INSERT [dbo].[tblCity] ([city]) VALUES (N'K?r?ehir')
INSERT [dbo].[tblCity] ([city]) VALUES (N'Kocaeli')
INSERT [dbo].[tblCity] ([city]) VALUES (N'Konya')
INSERT [dbo].[tblCity] ([city]) VALUES (N'Kütahya')
INSERT [dbo].[tblCity] ([city]) VALUES (N'Malatya')
INSERT [dbo].[tblCity] ([city]) VALUES (N'Manisa')
INSERT [dbo].[tblCity] ([city]) VALUES (N'Mardin')
INSERT [dbo].[tblCity] ([city]) VALUES (N'Mersin')
INSERT [dbo].[tblCity] ([city]) VALUES (N'Mu?la')
INSERT [dbo].[tblCity] ([city]) VALUES (N'Mu?')
INSERT [dbo].[tblCity] ([city]) VALUES (N'Nev?ehir')
INSERT [dbo].[tblCity] ([city]) VALUES (N'Ni?de')
INSERT [dbo].[tblCity] ([city]) VALUES (N'Ordu')
INSERT [dbo].[tblCity] ([city]) VALUES (N'Osmaniye')
INSERT [dbo].[tblCity] ([city]) VALUES (N'Rize')
INSERT [dbo].[tblCity] ([city]) VALUES (N'Sakarya')
INSERT [dbo].[tblCity] ([city]) VALUES (N'Samsun')
INSERT [dbo].[tblCity] ([city]) VALUES (N'?anl?urfa')
INSERT [dbo].[tblCity] ([city]) VALUES (N'Siirt')
INSERT [dbo].[tblCity] ([city]) VALUES (N'Sinop')
INSERT [dbo].[tblCity] ([city]) VALUES (N'??rnak')
INSERT [dbo].[tblCity] ([city]) VALUES (N'Sivas')
INSERT [dbo].[tblCity] ([city]) VALUES (N'Tekirda?')
INSERT [dbo].[tblCity] ([city]) VALUES (N'Tokat')
INSERT [dbo].[tblCity] ([city]) VALUES (N'Trabzon')
INSERT [dbo].[tblCity] ([city]) VALUES (N'Tunceli')
INSERT [dbo].[tblCity] ([city]) VALUES (N'U?ak')
INSERT [dbo].[tblCity] ([city]) VALUES (N'Van')
INSERT [dbo].[tblCity] ([city]) VALUES (N'Yalova')
INSERT [dbo].[tblCity] ([city]) VALUES (N'Yozgat')
INSERT [dbo].[tblCity] ([city]) VALUES (N'Zonguldak')

ALTER TABLE [dbo].[tblEvent]  WITH CHECK ADD FOREIGN KEY([makerEmail])
REFERENCES [dbo].[tblPerson] ([email])

ALTER TABLE [dbo].[tblMessage]  WITH CHECK ADD FOREIGN KEY([recieverid])
REFERENCES [dbo].[tblPerson] ([id])

ALTER TABLE [dbo].[tblMessage]  WITH CHECK ADD FOREIGN KEY([senderid])
REFERENCES [dbo].[tblPerson] ([id])

ALTER TABLE [dbo].[tblReview]  WITH CHECK ADD FOREIGN KEY([reviewerId])
REFERENCES [dbo].[tblPerson] ([id])

ALTER TABLE [dbo].[tblReview]  WITH CHECK ADD  CONSTRAINT [FK_tblReview_tblEvent] FOREIGN KEY([reviewedEventId])
REFERENCES [dbo].[tblEvent] ([eventid])

ALTER TABLE [dbo].[tblReview] CHECK CONSTRAINT [FK_tblReview_tblEvent]

END
