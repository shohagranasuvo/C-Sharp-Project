USE [NewDiagnostic]
GO

/****** Object: Table [dbo].[Accessories] ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Accessories](
	[AccessoriesId] [varchar](20) NOT NULL,
	[AccessoriesName] [varchar](100) NOT NULL,
	[Quantity] [int] NOT NULL,
	[Price] [decimal](10, 2) NOT NULL,
	PRIMARY KEY CLUSTERED
	(
		[AccessoriesId] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object: Table [dbo].[Admin] ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admin](
	[AdminId] [varchar](20) NOT NULL,
	[Name] [varchar](100) NOT NULL,
	[Pass] [varchar](100) NOT NULL,
	[UserId] [varchar](20) NOT NULL,
	PRIMARY KEY CLUSTERED
	(
		[AdminId] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object: Table [dbo].[Bill] ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bill](
	[BillId] [varchar](20) NOT NULL,
	[PatientId] [varchar](20) NOT NULL,
	[BillDate] [date] NULL,
	[TotalAmount] [decimal](10, 2) NULL,
	[PaymentStatus] [varchar](20) NULL,
	CONSTRAINT [PK_Bill_11F2FC6A852784E5] PRIMARY KEY CLUSTERED
	(
		[BillId] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object: Table [dbo].[BillDetails] ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BillDetails](
	[BillDetailsId] [varchar](20) NOT NULL,
	[BillId] [varchar](20) NOT NULL,
	[TestId] [varchar](20) NULL,
	[AccessoriesId] [varchar](20) NULL,
	[Quantity] [int] NULL,
	[Price] [decimal](10, 2) NOT NULL,
	PRIMARY KEY CLUSTERED
	(
		[BillDetailsId] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object: Table [dbo].[Patient] ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Patient](
	[PatientId] [varchar](20) NOT NULL,
	[PatientName] [varchar](100) NOT NULL,
	[Phone] [varchar](20) NULL,
	[Email] [varchar](100) NULL,
	[Gender] [varchar](10) NULL,
	[DateOfBirth] [date] NULL,
	[Address] [varchar](255) NULL,
	[AccessoriesId] [varchar](20) NULL,
	[ReceptionistId] [varchar](20) NULL,
	[TestId] [varchar](20) NULL,
	PRIMARY KEY CLUSTERED
	(
		[PatientId] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object: Table [dbo].[Receptionist] ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Receptionist](
	[ReceptionistId] [varchar](20) NOT NULL,
	[FullName] [varchar](100) NOT NULL,
	[Gender] [varchar](10) NULL,
	[Email] [varchar](100) NULL,
	[Pass] [varchar](100) NOT NULL,
	[JoinDate] [date] NULL,
	[DOB] [date] NULL,
	[Phone] [varchar](20) NULL,
	[Salary] [decimal](10, 2) NULL,
	[Address] [varchar](255) NULL,
	PRIMARY KEY CLUSTERED
	(
		[ReceptionistId] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object: Table [dbo].[Test] ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Test](
	[TestId] [varchar](20) NOT NULL,
	[TestName] [varchar](100) NOT NULL,
	[Diseases] [varchar](100) NULL,
	[Price] [decimal](10, 2) NOT NULL,
	PRIMARY KEY CLUSTERED
	(
		[TestId] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object: Table [dbo].[Users] ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserId] [varchar](20) NOT NULL,
	[Name] [varchar](100) NOT NULL,
	[Password] [varchar](100) NOT NULL,
	[Role] [varchar](100) NOT NULL,
	CONSTRAINT [PK_Users_1788CC4CDD471C49] PRIMARY KEY CLUSTERED
	(
		[UserId] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

-- ==============================
-- Seed data
-- ==============================

INSERT [dbo].[Accessories] ([AccessoriesId], [AccessoriesName], [Quantity], [Price]) VALUES (N'a-001', N'Syringe (5ml)', 421, CAST(5.00 AS Decimal(10, 2)))
INSERT [dbo].[Accessories] ([AccessoriesId], [AccessoriesName], [Quantity], [Price]) VALUES (N'a-002', N'Blood Pressure Monitor', 9, CAST(1500.00 AS Decimal(10, 2)))
INSERT [dbo].[Accessories] ([AccessoriesId], [AccessoriesName], [Quantity], [Price]) VALUES (N'a-003', N'Stethoscope', 15, CAST(1200.00 AS Decimal(10, 2)))
INSERT [dbo].[Accessories] ([AccessoriesId], [AccessoriesName], [Quantity], [Price]) VALUES (N'a-004', N'Digital Thermometer', 33, CAST(250.00 AS Decimal(10, 2)))
INSERT [dbo].[Accessories] ([AccessoriesId], [AccessoriesName], [Quantity], [Price]) VALUES (N'a-005', N'Glucose Meter', 20, CAST(1800.00 AS Decimal(10, 2)))
INSERT [dbo].[Accessories] ([AccessoriesId], [AccessoriesName], [Quantity], [Price]) VALUES (N'a-006', N'X-Ray Film (Pack of 100)', 5, CAST(3000.00 AS Decimal(10, 2)))
INSERT [dbo].[Accessories] ([AccessoriesId], [AccessoriesName], [Quantity], [Price]) VALUES (N'a-007', N'Cotton Rolls (500g)', 25, CAST(150.00 AS Decimal(10, 2)))
INSERT [dbo].[Accessories] ([AccessoriesId], [AccessoriesName], [Quantity], [Price]) VALUES (N'a-008', N'Disposable Gloves (Box of 100)', 40, CAST(500.00 AS Decimal(10, 2)))
INSERT [dbo].[Accessories] ([AccessoriesId], [AccessoriesName], [Quantity], [Price]) VALUES (N'a-009', N'Surgical Face Masks (Box of 50)', 50, CAST(300.00 AS Decimal(10, 2)))
INSERT [dbo].[Accessories] ([AccessoriesId], [AccessoriesName], [Quantity], [Price]) VALUES (N'a-010', N'Hand Sanitizer (500ml)', 120, CAST(200.00 AS Decimal(10, 2)))
GO

INSERT [dbo].[Admin] ([AdminId], [Name], [Pass], [UserId]) VALUES (N'U001', N'Shohag', N'123', N'U001')
INSERT [dbo].[Admin] ([AdminId], [Name], [Pass], [UserId]) VALUES (N'U007', N'Jimel', N'123', N'U007')
INSERT [dbo].[Admin] ([AdminId], [Name], [Pass], [UserId]) VALUES (N'U009', N'Samiha', N'123', N'U009')
INSERT [dbo].[Admin] ([AdminId], [Name], [Pass], [UserId]) VALUES (N'U010', N'Shuvo', N'123', N'U010')
GO

INSERT [dbo].[Bill] ([BillId], [PatientId], [BillDate], [TotalAmount], [PaymentStatus]) VALUES (N'-1', N'10', CAST(N'2025-09-17' AS Date), CAST(5.00 AS Decimal(10, 2)), N'Paid')
INSERT [dbo].[Bill] ([BillId], [PatientId], [BillDate], [TotalAmount], [PaymentStatus]) VALUES (N'10', N'10', CAST(N'2025-09-17' AS Date), CAST(7790.00 AS Decimal(10, 2)), N'Paid')
INSERT [dbo].[Bill] ([BillId], [PatientId], [BillDate], [TotalAmount], [PaymentStatus]) VALUES (N'10604', N'944520', CAST(N'2025-09-17' AS Date), CAST(75.00 AS Decimal(10, 2)), N'Paid')
INSERT [dbo].[Bill] ([BillId], [PatientId], [BillDate], [TotalAmount], [PaymentStatus]) VALUES (N'3', N'2', CAST(N'2025-09-17' AS Date), CAST(500.00 AS Decimal(10, 2)), N'Paid')
INSERT [dbo].[Bill] ([BillId], [PatientId], [BillDate], [TotalAmount], [PaymentStatus]) VALUES (N'37039', N'546904', CAST(N'2025-09-17' AS Date), CAST(25.00 AS Decimal(10, 2)), N'Paid')
INSERT [dbo].[Bill] ([BillId], [PatientId], [BillDate], [TotalAmount], [PaymentStatus]) VALUES (N'4', N'2', CAST(N'2025-09-17' AS Date), CAST(5.00 AS Decimal(10, 2)), N'Paid')
INSERT [dbo].[Bill] ([BillId], [PatientId], [BillDate], [TotalAmount], [PaymentStatus]) VALUES (N'5', N'2', CAST(N'2025-09-17' AS Date), CAST(33550.00 AS Decimal(10, 2)), N'Paid')
INSERT [dbo].[Bill] ([BillId], [PatientId], [BillDate], [TotalAmount], [PaymentStatus]) VALUES (N'6', N'2', CAST(N'2025-09-17' AS Date), CAST(1200.00 AS Decimal(10, 2)), N'Paid')
INSERT [dbo].[Bill] ([BillId], [PatientId], [BillDate], [TotalAmount], [PaymentStatus]) VALUES (N'65108', N'10', CAST(N'2025-09-17' AS Date), CAST(1500.00 AS Decimal(10, 2)), N'Paid')
INSERT [dbo].[Bill] ([BillId], [PatientId], [BillDate], [TotalAmount], [PaymentStatus]) VALUES (N'7', N'2', CAST(N'2025-09-17' AS Date), CAST(70.00 AS Decimal(10, 2)), N'Paid')
INSERT [dbo].[Bill] ([BillId], [PatientId], [BillDate], [TotalAmount], [PaymentStatus]) VALUES (N'8', N'2', CAST(N'2025-09-17' AS Date), CAST(155.00 AS Decimal(10, 2)), N'Paid')
INSERT [dbo].[Bill] ([BillId], [PatientId], [BillDate], [TotalAmount], [PaymentStatus]) VALUES (N'9', N'2', CAST(N'2025-09-17' AS Date), CAST(25.00 AS Decimal(10, 2)), N'Paid')
GO

INSERT [dbo].[Patient] ([PatientId], [PatientName], [Phone], [Email], [Gender], [DateOfBirth], [Address], [AccessoriesId], [ReceptionistId], [TestId]) VALUES (N'10', N'Shohag', N'01985446107', N'suvo', N'Male', CAST(N'2025-09-17' AS Date), N'Dhaka', NULL, NULL, NULL)
GO

INSERT [dbo].[Receptionist] ([ReceptionistId], [FullName], [Gender], [Email], [Pass], [JoinDate], [DOB], [Phone], [Salary], [Address]) VALUES (N'U006', N'Shohag', N'Male', N'sdks', N'123', CAST(N'2025-09-16' AS Date), CAST(N'2025-09-16' AS Date), N'345', CAST(1000.00 AS Decimal(10, 2)), N'Dhaka')
INSERT [dbo].[Receptionist] ([ReceptionistId], [FullName], [Gender], [Email], [Pass], [JoinDate], [DOB], [Phone], [Salary], [Address]) VALUES (N'U008', N'Sapim', N'Male', N'sah', N'123', CAST(N'2025-09-16' AS Date), CAST(N'2025-09-16' AS Date), N'123', CAST(100.00 AS Decimal(10, 2)), N'Rangpur')
GO

INSERT [dbo].[Test] ([TestId], [TestName], [Diseases], [Price]) VALUES (N't-001', N'Complete Blood Count (CBC)', N'Anemia, Infection, General Health Check', CAST(500.00 AS Decimal(10, 2)))
INSERT [dbo].[Test] ([TestId], [TestName], [Diseases], [Price]) VALUES (N't-002', N'Liver Function Test (LFT)', N'Liver Diseases, Jaundice, Hepatitis', CAST(1200.00 AS Decimal(10, 2)))
INSERT [dbo].[Test] ([TestId], [TestName], [Diseases], [Price]) VALUES (N't-003', N'X-Ray Chest', N'Tuberculosis, Pneumonia, Lung Problems', CAST(800.00 AS Decimal(10, 2)))
GO

INSERT [dbo].[Users] ([UserId], [Name], [Password], [Role]) VALUES (N'U001', N'Shohag', N'123', N'Admin')
INSERT [dbo].[Users] ([UserId], [Name], [Password], [Role]) VALUES (N'U006', N'Shohag', N'123', N'Receptionist')
INSERT [dbo].[Users] ([UserId], [Name], [Password], [Role]) VALUES (N'U007', N'Jimel', N'123', N'Admin')
INSERT [dbo].[Users] ([UserId], [Name], [Password], [Role]) VALUES (N'U008', N'Sapim', N'123', N'Receptionist')
INSERT [dbo].[Users] ([UserId], [Name], [Password], [Role]) VALUES (N'U009', N'Samiha', N'123', N'Admin')
INSERT [dbo].[Users] ([UserId], [Name], [Password], [Role]) VALUES (N'U010', N'Shuvo', N'123', N'Admin')
GO

SET ANSI_PADDING ON
GO

-- ==============================
-- Indexes & constraints
-- ==============================

/****** Object: Index [UQ_Receptio_A9D10534849AEF07] ******/
ALTER TABLE [dbo].[Receptionist] ADD UNIQUE NONCLUSTERED
(
	[Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Bill] ADD CONSTRAINT [DF_BillBillDate_49C3F6B7] DEFAULT (getdate()) FOR [BillDate]
GO

ALTER TABLE [dbo].[Bill] ADD CONSTRAINT [DF_Bill_PaymentStatus] DEFAULT ('Paid') FOR [PaymentStatus]
GO

ALTER TABLE [dbo].[BillDetails] ADD DEFAULT ((1)) FOR [Quantity]
GO

ALTER TABLE [dbo].[Admin] WITH CHECK ADD CONSTRAINT [FK_Admin_User] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([UserId])
GO
ALTER TABLE [dbo].[Admin] CHECK CONSTRAINT [FK_Admin_User]
GO

ALTER TABLE [dbo].[BillDetails] WITH CHECK ADD CONSTRAINT [FK_BillDetails_Accessories] FOREIGN KEY([AccessoriesId])
REFERENCES [dbo].[Accessories] ([AccessoriesId])
GO
ALTER TABLE [dbo].[BillDetails] CHECK CONSTRAINT [FK_BillDetails_Accessories]
GO

ALTER TABLE [dbo].[BillDetails] WITH CHECK ADD CONSTRAINT [FK_BillDetails_Bill] FOREIGN KEY([BillId])
REFERENCES [dbo].[Bill] ([BillId])
GO
ALTER TABLE [dbo].[BillDetails] CHECK CONSTRAINT [FK_BillDetails_Bill]
GO

ALTER TABLE [dbo].[BillDetails] WITH CHECK ADD CONSTRAINT [FK_BillDetails_Test] FOREIGN KEY([TestId])
REFERENCES [dbo].[Test] ([TestId])
GO
ALTER TABLE [dbo].[BillDetails] CHECK CONSTRAINT [FK_BillDetails_Test]
GO

ALTER TABLE [dbo].[Patient] WITH CHECK ADD CONSTRAINT [FK_Patient_Accessories] FOREIGN KEY([AccessoriesId])
REFERENCES [dbo].[Accessories] ([AccessoriesId])
GO
ALTER TABLE [dbo].[Patient] CHECK CONSTRAINT [FK_Patient_Accessories]
GO

ALTER TABLE [dbo].[Patient] WITH CHECK ADD CONSTRAINT [FK_Patient_Receptionist] FOREIGN KEY([ReceptionistId])
REFERENCES [dbo].[Receptionist] ([ReceptionistId])
GO
ALTER TABLE [dbo].[Patient] CHECK CONSTRAINT [FK_Patient_Receptionist]
GO

ALTER TABLE [dbo].[Patient] WITH CHECK ADD CONSTRAINT [FK_Patient_Test] FOREIGN KEY([TestId])
REFERENCES [dbo].[Test] ([TestId])
GO
ALTER TABLE [dbo].[Patient] CHECK CONSTRAINT [FK_Patient_Test]
GO

ALTER TABLE [dbo].[Receptionist] WITH CHECK ADD CONSTRAINT [FK_Receptionist_User] FOREIGN KEY([ReceptionistId])
REFERENCES [dbo].[Users] ([UserId])
GO
ALTER TABLE [dbo].[Receptionist] CHECK CONSTRAINT [FK_Receptionist_User]
GO
