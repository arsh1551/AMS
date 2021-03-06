USE [master]
GO
/****** Object:  Database [AMS]    Script Date: 3/10/2018 12:30:33 AM ******/
CREATE DATABASE [AMS] ON  PRIMARY 
( NAME = N'AMS', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\AMS.mdf' , SIZE = 2048KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'AMS_log', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\AMS_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [AMS] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [AMS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [AMS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [AMS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [AMS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [AMS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [AMS] SET ARITHABORT OFF 
GO
ALTER DATABASE [AMS] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [AMS] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [AMS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [AMS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [AMS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [AMS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [AMS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [AMS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [AMS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [AMS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [AMS] SET  DISABLE_BROKER 
GO
ALTER DATABASE [AMS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [AMS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [AMS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [AMS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [AMS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [AMS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [AMS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [AMS] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [AMS] SET  MULTI_USER 
GO
ALTER DATABASE [AMS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [AMS] SET DB_CHAINING OFF 
GO
USE [AMS]
GO
/****** Object:  Table [dbo].[Associate]    Script Date: 3/10/2018 12:30:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Associate](
	[AssociateId] [int] IDENTITY(1,1) NOT NULL,
	[AssociateName] [varchar](50) NULL,
	[AssociatePhone] [varchar](15) NULL,
	[AssociateAddress] [varchar](100) NULL,
 CONSTRAINT [PK_Associate] PRIMARY KEY CLUSTERED 
(
	[AssociateId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[AssociatSpecialization]    Script Date: 3/10/2018 12:30:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AssociatSpecialization](
	[AssociateId] [int] NOT NULL,
	[SpecializationId] [int] NOT NULL,
 CONSTRAINT [PK_AssociatSpecialization_1] PRIMARY KEY CLUSTERED 
(
	[AssociateId] ASC,
	[SpecializationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Specialization]    Script Date: 3/10/2018 12:30:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Specialization](
	[SpecializationId] [int] IDENTITY(1,1) NOT NULL,
	[SpecializationName] [varchar](50) NULL,
 CONSTRAINT [PK_Specialization] PRIMARY KEY CLUSTERED 
(
	[SpecializationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Associate] ON 

INSERT [dbo].[Associate] ([AssociateId], [AssociateName], [AssociatePhone], [AssociateAddress]) VALUES (28, N'Preetinder Singh Dhindsaa', N'7779406814', N'69-C,Professors Colony, Patiala1')
INSERT [dbo].[Associate] ([AssociateId], [AssociateName], [AssociatePhone], [AssociateAddress]) VALUES (29, N'Arshdeep Kaur', N'9779406815', N'Patialaaa')
INSERT [dbo].[Associate] ([AssociateId], [AssociateName], [AssociatePhone], [AssociateAddress]) VALUES (32, N'RoopKamal', N'9779406815', N'Patiala')
SET IDENTITY_INSERT [dbo].[Associate] OFF
INSERT [dbo].[AssociatSpecialization] ([AssociateId], [SpecializationId]) VALUES (28, 2)
INSERT [dbo].[AssociatSpecialization] ([AssociateId], [SpecializationId]) VALUES (28, 3)
INSERT [dbo].[AssociatSpecialization] ([AssociateId], [SpecializationId]) VALUES (28, 4)
INSERT [dbo].[AssociatSpecialization] ([AssociateId], [SpecializationId]) VALUES (28, 5)
INSERT [dbo].[AssociatSpecialization] ([AssociateId], [SpecializationId]) VALUES (28, 6)
INSERT [dbo].[AssociatSpecialization] ([AssociateId], [SpecializationId]) VALUES (28, 7)
INSERT [dbo].[AssociatSpecialization] ([AssociateId], [SpecializationId]) VALUES (29, 1)
INSERT [dbo].[AssociatSpecialization] ([AssociateId], [SpecializationId]) VALUES (29, 2)
INSERT [dbo].[AssociatSpecialization] ([AssociateId], [SpecializationId]) VALUES (29, 3)
INSERT [dbo].[AssociatSpecialization] ([AssociateId], [SpecializationId]) VALUES (29, 4)
INSERT [dbo].[AssociatSpecialization] ([AssociateId], [SpecializationId]) VALUES (29, 5)
INSERT [dbo].[AssociatSpecialization] ([AssociateId], [SpecializationId]) VALUES (32, 1)
INSERT [dbo].[AssociatSpecialization] ([AssociateId], [SpecializationId]) VALUES (32, 4)
INSERT [dbo].[AssociatSpecialization] ([AssociateId], [SpecializationId]) VALUES (32, 8)
SET IDENTITY_INSERT [dbo].[Specialization] ON 

INSERT [dbo].[Specialization] ([SpecializationId], [SpecializationName]) VALUES (1, N'PHP')
INSERT [dbo].[Specialization] ([SpecializationId], [SpecializationName]) VALUES (2, N'C#')
INSERT [dbo].[Specialization] ([SpecializationId], [SpecializationName]) VALUES (3, N'MVC')
INSERT [dbo].[Specialization] ([SpecializationId], [SpecializationName]) VALUES (4, N'OOPS')
INSERT [dbo].[Specialization] ([SpecializationId], [SpecializationName]) VALUES (5, N'JAVA')
INSERT [dbo].[Specialization] ([SpecializationId], [SpecializationName]) VALUES (6, N'JAVASCRIPT')
INSERT [dbo].[Specialization] ([SpecializationId], [SpecializationName]) VALUES (7, N'ASP.NET')
INSERT [dbo].[Specialization] ([SpecializationId], [SpecializationName]) VALUES (8, N'JQUERY')
SET IDENTITY_INSERT [dbo].[Specialization] OFF
ALTER TABLE [dbo].[AssociatSpecialization]  WITH CHECK ADD  CONSTRAINT [FK_AssociatSpecialization_Associate] FOREIGN KEY([AssociateId])
REFERENCES [dbo].[Associate] ([AssociateId])
GO
ALTER TABLE [dbo].[AssociatSpecialization] CHECK CONSTRAINT [FK_AssociatSpecialization_Associate]
GO
ALTER TABLE [dbo].[AssociatSpecialization]  WITH CHECK ADD  CONSTRAINT [FK_AssociatSpecialization_Specialization] FOREIGN KEY([SpecializationId])
REFERENCES [dbo].[Specialization] ([SpecializationId])
GO
ALTER TABLE [dbo].[AssociatSpecialization] CHECK CONSTRAINT [FK_AssociatSpecialization_Specialization]
GO
USE [master]
GO
ALTER DATABASE [AMS] SET  READ_WRITE 
GO
