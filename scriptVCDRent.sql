USE [VCDRent]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 1/14/2019 1:26:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 1/14/2019 1:26:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 1/14/2019 1:26:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 1/14/2019 1:26:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 1/14/2019 1:26:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](450) NOT NULL,
	[ProviderKey] [nvarchar](450) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 1/14/2019 1:26:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 1/14/2019 1:26:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](450) NOT NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
	[HomeRole] [bit] NOT NULL,
	[UserManageRole] [bit] NOT NULL,
	[FirstName] [nvarchar](max) NULL,
	[LastName] [nvarchar](max) NULL,
	[profilePictureUrl] [nvarchar](max) NULL,
	[isSuperAdmin] [bit] NOT NULL,
	[ApplicationUserRole] [bit] NOT NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 1/14/2019 1:26:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](450) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TConfirmContact]    Script Date: 1/14/2019 1:26:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TConfirmContact](
	[confirmcontactID] [int] IDENTITY(1,1) NOT NULL,
	[nameConfirmContact] [nvarchar](max) NOT NULL,
	[phonenumberConfirmContact] [nvarchar](max) NULL,
 CONSTRAINT [PK_TConfirmContact] PRIMARY KEY CLUSTERED 
(
	[confirmcontactID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TKnowThis]    Script Date: 1/14/2019 1:26:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TKnowThis](
	[knowthisID] [int] IDENTITY(1,1) NOT NULL,
	[informationKnowthis] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_TKnowThis] PRIMARY KEY CLUSTERED 
(
	[knowthisID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TMember]    Script Date: 1/14/2019 1:26:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TMember](
	[memberID] [int] IDENTITY(1,1) NOT NULL,
	[registraiondateMember] [datetime2](7) NOT NULL,
	[fullnameMember] [nvarchar](max) NOT NULL,
	[ageMember] [int] NOT NULL,
	[phonenumberMember] [nvarchar](max) NULL,
	[addressMember] [nvarchar](max) NULL,
	[anotherRentalMember] [bit] NOT NULL,
	[statusMember] [bit] NOT NULL,
	[packageID] [int] NOT NULL,
	[knowthisID] [int] NOT NULL,
 CONSTRAINT [PK_TMember] PRIMARY KEY CLUSTERED 
(
	[memberID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TMemberConfirmContact]    Script Date: 1/14/2019 1:26:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TMemberConfirmContact](
	[confirmcontactID] [int] NOT NULL,
	[memberID] [int] NOT NULL,
	[verificationMemberConfirmContact] [bit] NOT NULL,
	[registraiondateMemberConfirm] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_TMemberConfirmContact] PRIMARY KEY CLUSTERED 
(
	[confirmcontactID] ASC,
	[memberID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TPackage]    Script Date: 1/14/2019 1:26:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TPackage](
	[packageID] [int] IDENTITY(1,1) NOT NULL,
	[namePackage] [nvarchar](max) NOT NULL,
	[maxPackage] [int] NOT NULL,
	[costPackage] [float] NOT NULL,
 CONSTRAINT [PK_TPackage] PRIMARY KEY CLUSTERED 
(
	[packageID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20181006231849_OneInitial', N'2.1.4-rtm-31024')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20181009060224_TwoInitial', N'2.1.4-rtm-31024')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190114050728_DateRegistrationMemberConfirm', N'2.1.4-rtm-31024')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'06a3023d-a6e2-4337-a2cb-b2bc71f168a7', N'UserManage', N'USERMANAGE', N'c1d923c1-79af-4b92-9524-4073f85bd9d4')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'0fee6037-bc72-4bde-a255-b2df84f43ffd', N'ApplicationUser', N'APPLICATIONUSER', N'c77d59c9-c68d-4688-a606-8993832f75c8')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'153e97d4-d069-4d9f-9a75-26b6038c5b16', N'Dashboard', N'DASHBOARD', N'733f8881-0595-4d45-915c-63d80cd72d56')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'1a86d03c-28f0-41fd-97f0-7b173c2fb673', N'PackageManage', N'PACKAGEMANAGE', N'1ff757aa-1695-4999-91fa-191443b07e75')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'4b149c8e-cfe6-4391-90f1-4602acd5a779', N'MemberManage', N'MEMBERMANAGE', N'f8da3274-75c1-4229-96e5-e66ce982a48f')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'9f16ff57-da8c-476d-ba39-558e79ccfaec', N'MemberConfirmContactManage', N'MEMBERCONFIRMCONTACTMANAGE', N'20458a19-c277-4b40-bd5d-b433826d5a2f')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'cf29344c-ca50-4642-8610-53877ffa43d6', N'ReportContactPersonManage', N'REPORTCONTACTPERSONMANAGE', N'80cda079-fe99-4ea2-a2f3-552478a55270')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'eb49f188-2921-461e-869e-e7a2aa29020a', N'KnowThisManage', N'KNOWTHISMANAGE', N'e20ea765-5bc2-493f-8402-ba7a3d6c7e8c')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'f2d266db-ab16-4d0e-a542-832fd416daae', N'Home', N'HOME', N'1deace41-66ed-49d4-8232-57752bcfe86a')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'f87225af-bea9-43eb-b3b8-9e62e861a47c', N'ConfirmContactManage', N'CONFIRMCONTACTMANAGE', N'962e0ccf-0731-4b9b-b892-5c61a61cae42')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'a1462106-c52c-45f3-925e-1c0a213dd79e', N'06a3023d-a6e2-4337-a2cb-b2bc71f168a7')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'a1462106-c52c-45f3-925e-1c0a213dd79e', N'0fee6037-bc72-4bde-a255-b2df84f43ffd')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'a1462106-c52c-45f3-925e-1c0a213dd79e', N'153e97d4-d069-4d9f-9a75-26b6038c5b16')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'a1462106-c52c-45f3-925e-1c0a213dd79e', N'1a86d03c-28f0-41fd-97f0-7b173c2fb673')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'a1462106-c52c-45f3-925e-1c0a213dd79e', N'4b149c8e-cfe6-4391-90f1-4602acd5a779')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'a1462106-c52c-45f3-925e-1c0a213dd79e', N'9f16ff57-da8c-476d-ba39-558e79ccfaec')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'a1462106-c52c-45f3-925e-1c0a213dd79e', N'cf29344c-ca50-4642-8610-53877ffa43d6')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'a1462106-c52c-45f3-925e-1c0a213dd79e', N'eb49f188-2921-461e-869e-e7a2aa29020a')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'a1462106-c52c-45f3-925e-1c0a213dd79e', N'f2d266db-ab16-4d0e-a542-832fd416daae')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'a1462106-c52c-45f3-925e-1c0a213dd79e', N'f87225af-bea9-43eb-b3b8-9e62e861a47c')
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [HomeRole], [UserManageRole], [FirstName], [LastName], [profilePictureUrl], [isSuperAdmin], [ApplicationUserRole]) VALUES (N'a1462106-c52c-45f3-925e-1c0a213dd79e', N'bandung@admin.com', N'BANDUNG@ADMIN.COM', N'bandung@admin.com', N'BANDUNG@ADMIN.COM', 1, N'AQAAAAEAACcQAAAAEA3M/jTDqDJ7AacGeoIq5dZQiW3N2CtV/t0aLd99F/Ci/Cf8J9GqGAyLqyuxCo1wSw==', N'BGFEUNHQRQHA5RMLIPKWQIDB6DHWI4G2', N'9329bab9-0fe5-4783-99e6-49ae08b7b4a1', NULL, 0, 0, NULL, 1, 0, 1, 1, N'Bandung', N'Admin', N'/images/admin.png', 1, 1)
SET IDENTITY_INSERT [dbo].[TConfirmContact] ON 

INSERT [dbo].[TConfirmContact] ([confirmcontactID], [nameConfirmContact], [phonenumberConfirmContact]) VALUES (1, N'adi', N'123')
INSERT [dbo].[TConfirmContact] ([confirmcontactID], [nameConfirmContact], [phonenumberConfirmContact]) VALUES (2, N'richad', N'234')
INSERT [dbo].[TConfirmContact] ([confirmcontactID], [nameConfirmContact], [phonenumberConfirmContact]) VALUES (3, N'chris', N'345')
INSERT [dbo].[TConfirmContact] ([confirmcontactID], [nameConfirmContact], [phonenumberConfirmContact]) VALUES (4, N'eve', N'456')
SET IDENTITY_INSERT [dbo].[TConfirmContact] OFF
SET IDENTITY_INSERT [dbo].[TKnowThis] ON 

INSERT [dbo].[TKnowThis] ([knowthisID], [informationKnowthis]) VALUES (1, N'Friend')
INSERT [dbo].[TKnowThis] ([knowthisID], [informationKnowthis]) VALUES (2, N'Newspaper')
INSERT [dbo].[TKnowThis] ([knowthisID], [informationKnowthis]) VALUES (3, N'Broadside')
SET IDENTITY_INSERT [dbo].[TKnowThis] OFF
SET IDENTITY_INSERT [dbo].[TMember] ON 

INSERT [dbo].[TMember] ([memberID], [registraiondateMember], [fullnameMember], [ageMember], [phonenumberMember], [addressMember], [anotherRentalMember], [statusMember], [packageID], [knowthisID]) VALUES (1, CAST(N'2018-10-08T17:00:00.0000000' AS DateTime2), N'tor', 35, N'12345', N'address is tor', 1, 1, 2, 1)
INSERT [dbo].[TMember] ([memberID], [registraiondateMember], [fullnameMember], [ageMember], [phonenumberMember], [addressMember], [anotherRentalMember], [statusMember], [packageID], [knowthisID]) VALUES (2, CAST(N'2018-10-08T17:00:00.0000000' AS DateTime2), N'man', 15, N'55663', N'Address man', 0, 0, 1, 1)
SET IDENTITY_INSERT [dbo].[TMember] OFF
INSERT [dbo].[TMemberConfirmContact] ([confirmcontactID], [memberID], [verificationMemberConfirmContact], [registraiondateMemberConfirm]) VALUES (1, 1, 1, CAST(N'2018-10-08T17:00:00.0000000' AS DateTime2))
INSERT [dbo].[TMemberConfirmContact] ([confirmcontactID], [memberID], [verificationMemberConfirmContact], [registraiondateMemberConfirm]) VALUES (2, 1, 1, CAST(N'2018-10-08T17:00:00.0000000' AS DateTime2))
INSERT [dbo].[TMemberConfirmContact] ([confirmcontactID], [memberID], [verificationMemberConfirmContact], [registraiondateMemberConfirm]) VALUES (2, 2, 0, CAST(N'2018-10-08T17:00:00.0000000' AS DateTime2))
INSERT [dbo].[TMemberConfirmContact] ([confirmcontactID], [memberID], [verificationMemberConfirmContact], [registraiondateMemberConfirm]) VALUES (3, 2, 0, CAST(N'2019-01-14T13:17:03.7533698' AS DateTime2))
SET IDENTITY_INSERT [dbo].[TPackage] ON 

INSERT [dbo].[TPackage] ([packageID], [namePackage], [maxPackage], [costPackage]) VALUES (1, N'Standard', 20, 30000)
INSERT [dbo].[TPackage] ([packageID], [namePackage], [maxPackage], [costPackage]) VALUES (2, N'Premium', 40, 50000)
SET IDENTITY_INSERT [dbo].[TPackage] OFF
ALTER TABLE [dbo].[TMemberConfirmContact] ADD  DEFAULT ('0001-01-01T00:00:00.0000000') FOR [registraiondateMemberConfirm]
GO
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserTokens]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserTokens] CHECK CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[TMember]  WITH CHECK ADD  CONSTRAINT [FK_TMember_TKnowThis_knowthisID] FOREIGN KEY([knowthisID])
REFERENCES [dbo].[TKnowThis] ([knowthisID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TMember] CHECK CONSTRAINT [FK_TMember_TKnowThis_knowthisID]
GO
ALTER TABLE [dbo].[TMember]  WITH CHECK ADD  CONSTRAINT [FK_TMember_TPackage_packageID] FOREIGN KEY([packageID])
REFERENCES [dbo].[TPackage] ([packageID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TMember] CHECK CONSTRAINT [FK_TMember_TPackage_packageID]
GO
ALTER TABLE [dbo].[TMemberConfirmContact]  WITH CHECK ADD  CONSTRAINT [FK_TMemberConfirmContact_TConfirmContact_confirmcontactID] FOREIGN KEY([confirmcontactID])
REFERENCES [dbo].[TConfirmContact] ([confirmcontactID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TMemberConfirmContact] CHECK CONSTRAINT [FK_TMemberConfirmContact_TConfirmContact_confirmcontactID]
GO
ALTER TABLE [dbo].[TMemberConfirmContact]  WITH CHECK ADD  CONSTRAINT [FK_TMemberConfirmContact_TMember_memberID] FOREIGN KEY([memberID])
REFERENCES [dbo].[TMember] ([memberID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TMemberConfirmContact] CHECK CONSTRAINT [FK_TMemberConfirmContact_TMember_memberID]
GO
