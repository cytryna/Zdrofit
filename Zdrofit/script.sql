USE [master]
GO
/****** Object:  Database [fitness]    Script Date: 2015-04-19 21:53:36 ******/
CREATE DATABASE [fitness]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'fitness', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\fitness.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'fitness_log', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\fitness_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [fitness] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [fitness].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [fitness] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [fitness] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [fitness] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [fitness] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [fitness] SET ARITHABORT OFF 
GO
ALTER DATABASE [fitness] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [fitness] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [fitness] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [fitness] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [fitness] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [fitness] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [fitness] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [fitness] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [fitness] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [fitness] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [fitness] SET  DISABLE_BROKER 
GO
ALTER DATABASE [fitness] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [fitness] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [fitness] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [fitness] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [fitness] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [fitness] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [fitness] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [fitness] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [fitness] SET  MULTI_USER 
GO
ALTER DATABASE [fitness] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [fitness] SET DB_CHAINING OFF 
GO
ALTER DATABASE [fitness] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [fitness] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [fitness]
GO
/****** Object:  User [radek]    Script Date: 2015-04-19 21:53:36 ******/
CREATE USER [radek] FOR LOGIN [radek] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [radek]
GO
/****** Object:  StoredProcedure [dbo].[DniDeleteCommand]    Script Date: 2015-04-19 21:53:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DniDeleteCommand]
(
	@Original_id int,
	@Original_dzien_tygodnia nvarchar(50)
)
AS
	SET NOCOUNT OFF;
DELETE FROM [dni_tygodnia] WHERE (([id] = @Original_id) AND ([dzien_tygodnia] = @Original_dzien_tygodnia))
GO
/****** Object:  StoredProcedure [dbo].[DniInsertCommand]    Script Date: 2015-04-19 21:53:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DniInsertCommand]
(
	@id int,
	@dzien_tygodnia nvarchar(50)
)
AS
	SET NOCOUNT OFF;
INSERT INTO [dni_tygodnia] ([id], [dzien_tygodnia]) VALUES (@id, @dzien_tygodnia);
	
SELECT id, dzien_tygodnia FROM dni_tygodnia WHERE (id = @id)
GO
/****** Object:  StoredProcedure [dbo].[DniSelectCommand]    Script Date: 2015-04-19 21:53:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DniSelectCommand]
AS
	SET NOCOUNT ON;
SELECT * from dni_tygodnia
GO
/****** Object:  StoredProcedure [dbo].[DniUpdateCommand]    Script Date: 2015-04-19 21:53:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DniUpdateCommand]
(
	@id int,
	@dzien_tygodnia nvarchar(50),
	@Original_id int,
	@Original_dzien_tygodnia nvarchar(50)
)
AS
	SET NOCOUNT OFF;
UPDATE [dni_tygodnia] SET [id] = @id, [dzien_tygodnia] = @dzien_tygodnia WHERE (([id] = @Original_id) AND ([dzien_tygodnia] = @Original_dzien_tygodnia));
	
SELECT id, dzien_tygodnia FROM dni_tygodnia WHERE (id = @id)
GO
/****** Object:  StoredProcedure [dbo].[GrafikDeleteCommand]    Script Date: 2015-04-19 21:53:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GrafikDeleteCommand]
(
	@Original_id int,
	@Original_dzien_tygodnia int,
	@Original_godzina_od time,
	@Original_godzina_do time,
	@Original_zajecia int,
	@Original_sala int,
	@Original_instruktor_id int
)
AS
	SET NOCOUNT OFF;
DELETE FROM [grafik] WHERE (([id] = @Original_id) AND ([dzien_tygodnia] = @Original_dzien_tygodnia) AND ([godzina_od] = @Original_godzina_od) AND ([godzina_do] = @Original_godzina_do) AND ([zajecia] = @Original_zajecia) AND ([sala] = @Original_sala) AND ([instruktor_id] = @Original_instruktor_id))
GO
/****** Object:  StoredProcedure [dbo].[GrafikInsertCommand]    Script Date: 2015-04-19 21:53:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GrafikInsertCommand]
(
	@dzien_tygodnia int,
	@godzina_od time,
	@godzina_do time,
	@zajecia int,
	@sala int,
	@opis nvarchar(MAX),
	@instruktor_id int
)
AS
	SET NOCOUNT OFF;
INSERT INTO [grafik] ([dzien_tygodnia], [godzina_od], [godzina_do], [zajecia], [sala], [opis], [instruktor_id]) VALUES (@dzien_tygodnia, @godzina_od, @godzina_do, @zajecia, @sala, @opis, @instruktor_id);
	
SELECT id, dzien_tygodnia, godzina_od, godzina_do, zajecia, sala, opis, instruktor_id FROM grafik WHERE (id = SCOPE_IDENTITY())
GO
/****** Object:  StoredProcedure [dbo].[GrafikSelectCommand]    Script Date: 2015-04-19 21:53:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GrafikSelectCommand]
AS
	SET NOCOUNT ON;
SELECT        id, dzien_tygodnia, godzina_od, godzina_do, zajecia, sala, opis, instruktor_id
FROM            grafik
GO
/****** Object:  StoredProcedure [dbo].[GrafikUpdateCommand]    Script Date: 2015-04-19 21:53:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GrafikUpdateCommand]
(
	@dzien_tygodnia int,
	@godzina_od time,
	@godzina_do time,
	@zajecia int,
	@sala int,
	@opis nvarchar(MAX),
	@instruktor_id int,
	@Original_id int,
	@Original_dzien_tygodnia int,
	@Original_godzina_od time,
	@Original_godzina_do time,
	@Original_zajecia int,
	@Original_sala int,
	@Original_instruktor_id int,
	@id int
)
AS
	SET NOCOUNT OFF;
UPDATE [grafik] SET [dzien_tygodnia] = @dzien_tygodnia, [godzina_od] = @godzina_od, [godzina_do] = @godzina_do, [zajecia] = @zajecia, [sala] = @sala, [opis] = @opis, [instruktor_id] = @instruktor_id WHERE (([id] = @Original_id) AND ([dzien_tygodnia] = @Original_dzien_tygodnia) AND ([godzina_od] = @Original_godzina_od) AND ([godzina_do] = @Original_godzina_do) AND ([zajecia] = @Original_zajecia) AND ([sala] = @Original_sala) AND ([instruktor_id] = @Original_instruktor_id));
	
SELECT id, dzien_tygodnia, godzina_od, godzina_do, zajecia, sala, opis, instruktor_id FROM grafik WHERE (id = @id)
GO
/****** Object:  StoredProcedure [dbo].[OsobyDeleteCommand]    Script Date: 2015-04-19 21:53:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[OsobyDeleteCommand]
(
	@Original_id int
)
AS
	SET NOCOUNT OFF;
DELETE FROM osoby WHERE id = @Original_id
GO
/****** Object:  StoredProcedure [dbo].[OsobyInsertCommand]    Script Date: 2015-04-19 21:53:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[OsobyInsertCommand]
(
	@imie varchar(50),
	@nazwisko varchar(50),
	@telefon varchar(50),
	@mail varchar(100),
	@data_ur date,
	@data_rej date,
	@data_zatrudnienia date
)
AS
	SET NOCOUNT OFF;
INSERT INTO [osoby] ([imie], [nazwisko], [telefon], [mail], [data_ur], [data_rej], [data_zatrudnienia]) VALUES (@imie, @nazwisko, @telefon, @mail, @data_ur, @data_rej, @data_zatrudnienia);
	
SELECT imie, nazwisko, telefon, mail, data_ur, data_rej, data_zatrudnienia, id FROM osoby WHERE (id = SCOPE_IDENTITY())
GO
/****** Object:  StoredProcedure [dbo].[OsobyProcownicySelectCommand]    Script Date: 2015-04-19 21:53:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[OsobyProcownicySelectCommand]
AS
	SET NOCOUNT ON;
	
	SELECT imie + ' '+ nazwisko as imienazwisko, id FROM osoby WHERE data_zatrudnienia is not null
	


GO
/****** Object:  StoredProcedure [dbo].[OsobySelectCommand]    Script Date: 2015-04-19 21:53:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[OsobySelectCommand]
AS
	SET NOCOUNT ON;
	SELECT * FROM osoby 

GO
/****** Object:  StoredProcedure [dbo].[OsobySelectLike]    Script Date: 2015-04-19 21:53:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[OsobySelectLike] (@nazwisko varchar(50) )
AS
	SET NOCOUNT ON;
	SELECT * FROM osoby where UPPER(nazwisko) like UPPER('%'+@nazwisko+'%') 



GO
/****** Object:  StoredProcedure [dbo].[OsobyUpdateCommand]    Script Date: 2015-04-19 21:53:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[OsobyUpdateCommand]
(
	@imie varchar(50),
	@nazwisko varchar(50),
	@telefon varchar(50),
	@mail varchar(100),
	@data_ur date,
	@data_rej date,
	@data_zatrudnienia date,
	@IsNull_imie Int,
	@Original_imie varchar(50),
	@Original_nazwisko varchar(50),
	@IsNull_telefon Int,
	@Original_telefon varchar(50),
	@IsNull_mail Int,
	@Original_mail varchar(100),
	@IsNull_data_ur Int,
	@Original_data_ur date,
	@Original_data_rej date,
	@IsNull_data_zatrudnienia Int,
	@Original_data_zatrudnienia date,
	@Original_id int,
	@id int
)
AS
	SET NOCOUNT OFF;
UPDATE [osoby] SET [imie] = @imie, [nazwisko] = @nazwisko, [telefon] = @telefon, [mail] = @mail, [data_ur] = @data_ur, [data_rej] = @data_rej, [data_zatrudnienia] = @data_zatrudnienia WHERE (((@IsNull_imie = 1 AND [imie] IS NULL) OR ([imie] = @Original_imie)) AND ([nazwisko] = @Original_nazwisko) AND ((@IsNull_telefon = 1 AND [telefon] IS NULL) OR ([telefon] = @Original_telefon)) AND ((@IsNull_mail = 1 AND [mail] IS NULL) OR ([mail] = @Original_mail)) AND ((@IsNull_data_ur = 1 AND [data_ur] IS NULL) OR ([data_ur] = @Original_data_ur)) AND ([data_rej] = @Original_data_rej) AND ((@IsNull_data_zatrudnienia = 1 AND [data_zatrudnienia] IS NULL) OR ([data_zatrudnienia] = @Original_data_zatrudnienia)) AND ([id] = @Original_id));
	
SELECT imie, nazwisko, telefon, mail, data_ur, data_rej, data_zatrudnienia, id FROM osoby WHERE (id = @id)
GO
/****** Object:  StoredProcedure [dbo].[RezerwacjaInsertCommand]    Script Date: 2015-04-19 21:53:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RezerwacjaInsertCommand]
(
	@osoba_id int,
	@data datetime,
	@obecnosc char,
	@grafik_id int
)
AS
	SET NOCOUNT OFF;
INSERT INTO [rezerwacje] (osoba_id, data, obecnosc, grafik_id) VALUES (@osoba_id, @data, @obecnosc, @grafik_id);
GO
/****** Object:  StoredProcedure [dbo].[RezerwacjeDeleteCommand]    Script Date: 2015-04-19 21:53:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RezerwacjeDeleteCommand]
(
	@Original_id int,
	@Original_osoba_id int,
	@Original_data datetime,
	@IsNull_obecnosc Int,
	@Original_obecnosc char(1),
	@IsNull_grafik_id Int,
	@Original_grafik_id int
)
AS
	SET NOCOUNT OFF;
DELETE FROM [rezerwacje] WHERE (([id] = @Original_id) AND ([osoba_id] = @Original_osoba_id) AND ([data] = @Original_data) AND ((@IsNull_obecnosc = 1 AND [obecnosc] IS NULL) OR ([obecnosc] = @Original_obecnosc)) AND ((@IsNull_grafik_id = 1 AND [grafik_id] IS NULL) OR ([grafik_id] = @Original_grafik_id)))
GO
/****** Object:  StoredProcedure [dbo].[RezerwacjeInsertCommand]    Script Date: 2015-04-19 21:53:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RezerwacjeInsertCommand]
(
	@osoba_id int,
	@data datetime,
	@obecnosc char(1),
	@grafik_id int
)
AS
	SET NOCOUNT OFF;
INSERT INTO [rezerwacje] ([osoba_id], [data], [obecnosc], [grafik_id]) VALUES (@osoba_id, @data, @obecnosc, @grafik_id);
	
SELECT id, osoba_id, data, obecnosc, grafik_id FROM rezerwacje WHERE (id = SCOPE_IDENTITY())
GO
/****** Object:  StoredProcedure [dbo].[RezerwacjeSelectCommand]    Script Date: 2015-04-19 21:53:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RezerwacjeSelectCommand]
AS
	SET NOCOUNT ON;
SELECT        rezerwacje.*
FROM            rezerwacje
GO
/****** Object:  StoredProcedure [dbo].[RezerwacjeUpdateCommand]    Script Date: 2015-04-19 21:53:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RezerwacjeUpdateCommand]
(
	@osoba_id int,
	@data datetime,
	@obecnosc char(1),
	@grafik_id int,
	@Original_id int,
	@Original_osoba_id int,
	@Original_data datetime,
	@IsNull_obecnosc Int,
	@Original_obecnosc char(1),
	@IsNull_grafik_id Int,
	@Original_grafik_id int,
	@id int
)
AS
	SET NOCOUNT OFF;
UPDATE [rezerwacje] SET [osoba_id] = @osoba_id, [data] = @data, [obecnosc] = @obecnosc, [grafik_id] = @grafik_id WHERE (([id] = @Original_id) AND ([osoba_id] = @Original_osoba_id) AND ([data] = @Original_data) AND ((@IsNull_obecnosc = 1 AND [obecnosc] IS NULL) OR ([obecnosc] = @Original_obecnosc)) AND ((@IsNull_grafik_id = 1 AND [grafik_id] IS NULL) OR ([grafik_id] = @Original_grafik_id)));
	
SELECT id, osoba_id, data, obecnosc, grafik_id FROM rezerwacje WHERE (id = @id)
GO
/****** Object:  StoredProcedure [dbo].[SaleDeleteCommand]    Script Date: 2015-04-19 21:53:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SaleDeleteCommand]
(
	@Original_id int,
	@Original_nazwa varchar(50),
	@Original_ile_osob int,
	@IsNull_rowery Int,
	@Original_rowery char(1)
)
AS
	SET NOCOUNT OFF;
DELETE FROM [sale] WHERE (([id] = @Original_id) AND ([nazwa] = @Original_nazwa) AND ([ile_osob] = @Original_ile_osob) AND ((@IsNull_rowery = 1 AND [rowery] IS NULL) OR ([rowery] = @Original_rowery)))
GO
/****** Object:  StoredProcedure [dbo].[SaleInsertCommand]    Script Date: 2015-04-19 21:53:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SaleInsertCommand]
(
	@nazwa varchar(50),
	@ile_osob int,
	@rowery char(1)
)
AS
	SET NOCOUNT OFF;
INSERT INTO [sale] ([nazwa], [ile_osob], [rowery]) VALUES (@nazwa, @ile_osob, @rowery);
	
SELECT id, nazwa, ile_osob, rowery FROM sale WHERE (nazwa = @nazwa)
GO
/****** Object:  StoredProcedure [dbo].[SaleSelectCommand]    Script Date: 2015-04-19 21:53:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SaleSelectCommand]
AS
	SET NOCOUNT ON;
SELECT        sale.*
FROM            sale
GO
/****** Object:  StoredProcedure [dbo].[SaleUpdateCommand]    Script Date: 2015-04-19 21:53:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SaleUpdateCommand]
(
	@nazwa varchar(50),
	@ile_osob int,
	@rowery char(1),
	@Original_id int,
	@Original_nazwa varchar(50),
	@Original_ile_osob int,
	@IsNull_rowery Int,
	@Original_rowery char(1)
)
AS
	SET NOCOUNT OFF;
UPDATE [sale] SET [nazwa] = @nazwa, [ile_osob] = @ile_osob, [rowery] = @rowery WHERE (([id] = @Original_id) AND ([nazwa] = @Original_nazwa) AND ([ile_osob] = @Original_ile_osob) AND ((@IsNull_rowery = 1 AND [rowery] IS NULL) OR ([rowery] = @Original_rowery)));
	
SELECT id, nazwa, ile_osob, rowery FROM sale WHERE (nazwa = @nazwa)
GO
/****** Object:  StoredProcedure [dbo].[ZajeciansertCommand]    Script Date: 2015-04-19 21:53:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ZajeciansertCommand]
(
	@nazwa varchar(50),
	@opis nvarchar(MAX)
)
AS
	SET NOCOUNT OFF;
INSERT INTO [zajecia] ([nazwa], [opis]) VALUES (@nazwa, @opis)
GO
/****** Object:  StoredProcedure [dbo].[ZajeciaSelectCommand]    Script Date: 2015-04-19 21:53:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ZajeciaSelectCommand]
AS
	SET NOCOUNT ON;
SELECT        zajecia.*
FROM            zajecia
GO
/****** Object:  Table [dbo].[dni_tygodnia]    Script Date: 2015-04-19 21:53:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dni_tygodnia](
	[id] [int] NOT NULL,
	[dzien_tygodnia] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_dni_tygodnia] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[grafik]    Script Date: 2015-04-19 21:53:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[grafik](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[dzien_tygodnia] [int] NOT NULL,
	[godzina_od] [time](0) NOT NULL,
	[godzina_do] [time](0) NOT NULL,
	[zajecia] [int] NOT NULL,
	[sala] [int] NOT NULL,
	[opis] [nvarchar](max) NULL,
	[instruktor_id] [int] NOT NULL,
 CONSTRAINT [PK_Grafik] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[osoby]    Script Date: 2015-04-19 21:53:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[osoby](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[imie] [varchar](50) NULL,
	[nazwisko] [varchar](50) NOT NULL,
	[telefon] [varchar](50) NULL,
	[mail] [varchar](100) NULL,
	[data_ur] [date] NULL,
	[data_rej] [date] NOT NULL,
	[data_zatrudnienia] [date] NULL,
 CONSTRAINT [PK_osoby] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[rezerwacje]    Script Date: 2015-04-19 21:53:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[rezerwacje](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[osoba_id] [int] NOT NULL,
	[data] [datetime] NOT NULL,
	[obecnosc] [char](1) NULL,
	[grafik_id] [int] NULL,
 CONSTRAINT [PK_rezerwacje] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[sale]    Script Date: 2015-04-19 21:53:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[sale](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nazwa] [varchar](50) NOT NULL,
	[ile_osob] [int] NOT NULL,
	[rowery] [char](1) NULL,
 CONSTRAINT [PK_sale] PRIMARY KEY CLUSTERED 
(
	[nazwa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[zajecia]    Script Date: 2015-04-19 21:53:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[zajecia](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nazwa] [varchar](50) NOT NULL,
	[opis] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[dni_tygodnia] ([id], [dzien_tygodnia]) VALUES (1, N'poniedziałek')
INSERT [dbo].[dni_tygodnia] ([id], [dzien_tygodnia]) VALUES (2, N'wtorek')
INSERT [dbo].[dni_tygodnia] ([id], [dzien_tygodnia]) VALUES (3, N'środa')
INSERT [dbo].[dni_tygodnia] ([id], [dzien_tygodnia]) VALUES (4, N'czwartek')
INSERT [dbo].[dni_tygodnia] ([id], [dzien_tygodnia]) VALUES (5, N'piątek')
INSERT [dbo].[dni_tygodnia] ([id], [dzien_tygodnia]) VALUES (6, N'sobota')
INSERT [dbo].[dni_tygodnia] ([id], [dzien_tygodnia]) VALUES (7, N'niedziela')
SET IDENTITY_INSERT [dbo].[grafik] ON 

INSERT [dbo].[grafik] ([id], [dzien_tygodnia], [godzina_od], [godzina_do], [zajecia], [sala], [opis], [instruktor_id]) VALUES (31, 1, CAST(0x00C0A80000000000 AS Time), CAST(0x00D0B60000000000 AS Time), 1, 4, NULL, 4)
INSERT [dbo].[grafik] ([id], [dzien_tygodnia], [godzina_od], [godzina_do], [zajecia], [sala], [opis], [instruktor_id]) VALUES (32, 1, CAST(0x00C0A80000000000 AS Time), CAST(0x00D0B60000000000 AS Time), 2, 1, NULL, 10)
INSERT [dbo].[grafik] ([id], [dzien_tygodnia], [godzina_od], [godzina_do], [zajecia], [sala], [opis], [instruktor_id]) VALUES (33, 1, CAST(0x00D0B60000000000 AS Time), CAST(0x00E0C40000000000 AS Time), 3, 2, NULL, 11)
INSERT [dbo].[grafik] ([id], [dzien_tygodnia], [godzina_od], [godzina_do], [zajecia], [sala], [opis], [instruktor_id]) VALUES (34, 1, CAST(0x00D0B60000000000 AS Time), CAST(0x00E0C40000000000 AS Time), 4, 3, NULL, 4)
INSERT [dbo].[grafik] ([id], [dzien_tygodnia], [godzina_od], [godzina_do], [zajecia], [sala], [opis], [instruktor_id]) VALUES (35, 1, CAST(0x00E0C40000000000 AS Time), CAST(0x00F0D20000000000 AS Time), 5, 4, NULL, 11)
INSERT [dbo].[grafik] ([id], [dzien_tygodnia], [godzina_od], [godzina_do], [zajecia], [sala], [opis], [instruktor_id]) VALUES (36, 1, CAST(0x00E0C40000000000 AS Time), CAST(0x00F0D20000000000 AS Time), 5, 1, NULL, 4)
INSERT [dbo].[grafik] ([id], [dzien_tygodnia], [godzina_od], [godzina_do], [zajecia], [sala], [opis], [instruktor_id]) VALUES (37, 1, CAST(0x00F0D20000000000 AS Time), CAST(0x0000E10000000000 AS Time), 4, 1, NULL, 11)
INSERT [dbo].[grafik] ([id], [dzien_tygodnia], [godzina_od], [godzina_do], [zajecia], [sala], [opis], [instruktor_id]) VALUES (38, 1, CAST(0x00F0D20000000000 AS Time), CAST(0x0000E10000000000 AS Time), 6, 2, NULL, 4)
INSERT [dbo].[grafik] ([id], [dzien_tygodnia], [godzina_od], [godzina_do], [zajecia], [sala], [opis], [instruktor_id]) VALUES (39, 1, CAST(0x0000E10000000000 AS Time), CAST(0x0010EF0000000000 AS Time), 2, 3, NULL, 11)
INSERT [dbo].[grafik] ([id], [dzien_tygodnia], [godzina_od], [godzina_do], [zajecia], [sala], [opis], [instruktor_id]) VALUES (40, 1, CAST(0x0010EF0000000000 AS Time), CAST(0x0020FD0000000000 AS Time), 3, 4, NULL, 4)
INSERT [dbo].[grafik] ([id], [dzien_tygodnia], [godzina_od], [godzina_do], [zajecia], [sala], [opis], [instruktor_id]) VALUES (41, 1, CAST(0x0010EF0000000000 AS Time), CAST(0x0020FD0000000000 AS Time), 8, 1, NULL, 10)
INSERT [dbo].[grafik] ([id], [dzien_tygodnia], [godzina_od], [godzina_do], [zajecia], [sala], [opis], [instruktor_id]) VALUES (42, 1, CAST(0x0020FD0000000000 AS Time), CAST(0x00300B0100000000 AS Time), 1, 4, NULL, 4)
INSERT [dbo].[grafik] ([id], [dzien_tygodnia], [godzina_od], [godzina_do], [zajecia], [sala], [opis], [instruktor_id]) VALUES (43, 2, CAST(0x00C0A80000000000 AS Time), CAST(0x00D0B60000000000 AS Time), 1, 4, NULL, 4)
INSERT [dbo].[grafik] ([id], [dzien_tygodnia], [godzina_od], [godzina_do], [zajecia], [sala], [opis], [instruktor_id]) VALUES (44, 2, CAST(0x00C0A80000000000 AS Time), CAST(0x00D0B60000000000 AS Time), 2, 1, NULL, 10)
INSERT [dbo].[grafik] ([id], [dzien_tygodnia], [godzina_od], [godzina_do], [zajecia], [sala], [opis], [instruktor_id]) VALUES (45, 2, CAST(0x00D0B60000000000 AS Time), CAST(0x00E0C40000000000 AS Time), 3, 2, NULL, 11)
INSERT [dbo].[grafik] ([id], [dzien_tygodnia], [godzina_od], [godzina_do], [zajecia], [sala], [opis], [instruktor_id]) VALUES (46, 2, CAST(0x00D0B60000000000 AS Time), CAST(0x00E0C40000000000 AS Time), 4, 3, NULL, 4)
INSERT [dbo].[grafik] ([id], [dzien_tygodnia], [godzina_od], [godzina_do], [zajecia], [sala], [opis], [instruktor_id]) VALUES (47, 2, CAST(0x00E0C40000000000 AS Time), CAST(0x00F0D20000000000 AS Time), 5, 4, NULL, 11)
INSERT [dbo].[grafik] ([id], [dzien_tygodnia], [godzina_od], [godzina_do], [zajecia], [sala], [opis], [instruktor_id]) VALUES (48, 2, CAST(0x00E0C40000000000 AS Time), CAST(0x00F0D20000000000 AS Time), 5, 1, NULL, 4)
INSERT [dbo].[grafik] ([id], [dzien_tygodnia], [godzina_od], [godzina_do], [zajecia], [sala], [opis], [instruktor_id]) VALUES (49, 2, CAST(0x00F0D20000000000 AS Time), CAST(0x0000E10000000000 AS Time), 4, 1, NULL, 11)
INSERT [dbo].[grafik] ([id], [dzien_tygodnia], [godzina_od], [godzina_do], [zajecia], [sala], [opis], [instruktor_id]) VALUES (50, 2, CAST(0x00F0D20000000000 AS Time), CAST(0x0000E10000000000 AS Time), 6, 2, NULL, 4)
INSERT [dbo].[grafik] ([id], [dzien_tygodnia], [godzina_od], [godzina_do], [zajecia], [sala], [opis], [instruktor_id]) VALUES (51, 2, CAST(0x0000E10000000000 AS Time), CAST(0x0010EF0000000000 AS Time), 2, 3, NULL, 11)
INSERT [dbo].[grafik] ([id], [dzien_tygodnia], [godzina_od], [godzina_do], [zajecia], [sala], [opis], [instruktor_id]) VALUES (52, 2, CAST(0x0010EF0000000000 AS Time), CAST(0x0020FD0000000000 AS Time), 3, 4, NULL, 4)
INSERT [dbo].[grafik] ([id], [dzien_tygodnia], [godzina_od], [godzina_do], [zajecia], [sala], [opis], [instruktor_id]) VALUES (53, 2, CAST(0x0010EF0000000000 AS Time), CAST(0x0020FD0000000000 AS Time), 8, 1, NULL, 10)
INSERT [dbo].[grafik] ([id], [dzien_tygodnia], [godzina_od], [godzina_do], [zajecia], [sala], [opis], [instruktor_id]) VALUES (54, 2, CAST(0x0020FD0000000000 AS Time), CAST(0x00300B0100000000 AS Time), 1, 4, NULL, 4)
INSERT [dbo].[grafik] ([id], [dzien_tygodnia], [godzina_od], [godzina_do], [zajecia], [sala], [opis], [instruktor_id]) VALUES (55, 3, CAST(0x00C0A80000000000 AS Time), CAST(0x00D0B60000000000 AS Time), 1, 4, NULL, 4)
INSERT [dbo].[grafik] ([id], [dzien_tygodnia], [godzina_od], [godzina_do], [zajecia], [sala], [opis], [instruktor_id]) VALUES (56, 3, CAST(0x00C0A80000000000 AS Time), CAST(0x00D0B60000000000 AS Time), 2, 1, NULL, 10)
INSERT [dbo].[grafik] ([id], [dzien_tygodnia], [godzina_od], [godzina_do], [zajecia], [sala], [opis], [instruktor_id]) VALUES (57, 3, CAST(0x00D0B60000000000 AS Time), CAST(0x00E0C40000000000 AS Time), 3, 2, NULL, 11)
INSERT [dbo].[grafik] ([id], [dzien_tygodnia], [godzina_od], [godzina_do], [zajecia], [sala], [opis], [instruktor_id]) VALUES (58, 3, CAST(0x00D0B60000000000 AS Time), CAST(0x00E0C40000000000 AS Time), 4, 3, NULL, 4)
INSERT [dbo].[grafik] ([id], [dzien_tygodnia], [godzina_od], [godzina_do], [zajecia], [sala], [opis], [instruktor_id]) VALUES (59, 3, CAST(0x00E0C40000000000 AS Time), CAST(0x00F0D20000000000 AS Time), 5, 4, NULL, 11)
INSERT [dbo].[grafik] ([id], [dzien_tygodnia], [godzina_od], [godzina_do], [zajecia], [sala], [opis], [instruktor_id]) VALUES (60, 3, CAST(0x00E0C40000000000 AS Time), CAST(0x00F0D20000000000 AS Time), 5, 1, NULL, 4)
INSERT [dbo].[grafik] ([id], [dzien_tygodnia], [godzina_od], [godzina_do], [zajecia], [sala], [opis], [instruktor_id]) VALUES (61, 3, CAST(0x00F0D20000000000 AS Time), CAST(0x0000E10000000000 AS Time), 4, 1, NULL, 11)
INSERT [dbo].[grafik] ([id], [dzien_tygodnia], [godzina_od], [godzina_do], [zajecia], [sala], [opis], [instruktor_id]) VALUES (62, 3, CAST(0x00F0D20000000000 AS Time), CAST(0x0000E10000000000 AS Time), 6, 2, NULL, 4)
INSERT [dbo].[grafik] ([id], [dzien_tygodnia], [godzina_od], [godzina_do], [zajecia], [sala], [opis], [instruktor_id]) VALUES (63, 3, CAST(0x0000E10000000000 AS Time), CAST(0x0010EF0000000000 AS Time), 2, 3, NULL, 11)
INSERT [dbo].[grafik] ([id], [dzien_tygodnia], [godzina_od], [godzina_do], [zajecia], [sala], [opis], [instruktor_id]) VALUES (64, 3, CAST(0x0010EF0000000000 AS Time), CAST(0x0020FD0000000000 AS Time), 3, 4, NULL, 4)
INSERT [dbo].[grafik] ([id], [dzien_tygodnia], [godzina_od], [godzina_do], [zajecia], [sala], [opis], [instruktor_id]) VALUES (65, 3, CAST(0x0010EF0000000000 AS Time), CAST(0x0020FD0000000000 AS Time), 8, 1, NULL, 10)
INSERT [dbo].[grafik] ([id], [dzien_tygodnia], [godzina_od], [godzina_do], [zajecia], [sala], [opis], [instruktor_id]) VALUES (66, 3, CAST(0x0020FD0000000000 AS Time), CAST(0x00300B0100000000 AS Time), 1, 4, NULL, 4)
INSERT [dbo].[grafik] ([id], [dzien_tygodnia], [godzina_od], [godzina_do], [zajecia], [sala], [opis], [instruktor_id]) VALUES (67, 4, CAST(0x00C0A80000000000 AS Time), CAST(0x00D0B60000000000 AS Time), 1, 4, NULL, 4)
INSERT [dbo].[grafik] ([id], [dzien_tygodnia], [godzina_od], [godzina_do], [zajecia], [sala], [opis], [instruktor_id]) VALUES (68, 4, CAST(0x00C0A80000000000 AS Time), CAST(0x00D0B60000000000 AS Time), 2, 1, NULL, 10)
INSERT [dbo].[grafik] ([id], [dzien_tygodnia], [godzina_od], [godzina_do], [zajecia], [sala], [opis], [instruktor_id]) VALUES (69, 4, CAST(0x00D0B60000000000 AS Time), CAST(0x00E0C40000000000 AS Time), 3, 2, NULL, 11)
INSERT [dbo].[grafik] ([id], [dzien_tygodnia], [godzina_od], [godzina_do], [zajecia], [sala], [opis], [instruktor_id]) VALUES (70, 4, CAST(0x00D0B60000000000 AS Time), CAST(0x00E0C40000000000 AS Time), 4, 3, NULL, 4)
INSERT [dbo].[grafik] ([id], [dzien_tygodnia], [godzina_od], [godzina_do], [zajecia], [sala], [opis], [instruktor_id]) VALUES (71, 4, CAST(0x00E0C40000000000 AS Time), CAST(0x00F0D20000000000 AS Time), 5, 4, NULL, 11)
INSERT [dbo].[grafik] ([id], [dzien_tygodnia], [godzina_od], [godzina_do], [zajecia], [sala], [opis], [instruktor_id]) VALUES (72, 4, CAST(0x00E0C40000000000 AS Time), CAST(0x00F0D20000000000 AS Time), 5, 1, NULL, 4)
INSERT [dbo].[grafik] ([id], [dzien_tygodnia], [godzina_od], [godzina_do], [zajecia], [sala], [opis], [instruktor_id]) VALUES (73, 4, CAST(0x00F0D20000000000 AS Time), CAST(0x0000E10000000000 AS Time), 4, 1, NULL, 11)
INSERT [dbo].[grafik] ([id], [dzien_tygodnia], [godzina_od], [godzina_do], [zajecia], [sala], [opis], [instruktor_id]) VALUES (74, 4, CAST(0x00F0D20000000000 AS Time), CAST(0x0000E10000000000 AS Time), 6, 2, NULL, 4)
INSERT [dbo].[grafik] ([id], [dzien_tygodnia], [godzina_od], [godzina_do], [zajecia], [sala], [opis], [instruktor_id]) VALUES (75, 4, CAST(0x0000E10000000000 AS Time), CAST(0x0010EF0000000000 AS Time), 2, 3, NULL, 11)
INSERT [dbo].[grafik] ([id], [dzien_tygodnia], [godzina_od], [godzina_do], [zajecia], [sala], [opis], [instruktor_id]) VALUES (76, 4, CAST(0x0010EF0000000000 AS Time), CAST(0x0020FD0000000000 AS Time), 3, 4, NULL, 4)
INSERT [dbo].[grafik] ([id], [dzien_tygodnia], [godzina_od], [godzina_do], [zajecia], [sala], [opis], [instruktor_id]) VALUES (77, 4, CAST(0x0010EF0000000000 AS Time), CAST(0x0020FD0000000000 AS Time), 8, 1, NULL, 10)
INSERT [dbo].[grafik] ([id], [dzien_tygodnia], [godzina_od], [godzina_do], [zajecia], [sala], [opis], [instruktor_id]) VALUES (78, 4, CAST(0x0020FD0000000000 AS Time), CAST(0x00300B0100000000 AS Time), 1, 4, NULL, 4)
INSERT [dbo].[grafik] ([id], [dzien_tygodnia], [godzina_od], [godzina_do], [zajecia], [sala], [opis], [instruktor_id]) VALUES (79, 5, CAST(0x00C0A80000000000 AS Time), CAST(0x00D0B60000000000 AS Time), 1, 4, NULL, 4)
INSERT [dbo].[grafik] ([id], [dzien_tygodnia], [godzina_od], [godzina_do], [zajecia], [sala], [opis], [instruktor_id]) VALUES (80, 5, CAST(0x00C0A80000000000 AS Time), CAST(0x00D0B60000000000 AS Time), 2, 1, NULL, 10)
INSERT [dbo].[grafik] ([id], [dzien_tygodnia], [godzina_od], [godzina_do], [zajecia], [sala], [opis], [instruktor_id]) VALUES (81, 5, CAST(0x00D0B60000000000 AS Time), CAST(0x00E0C40000000000 AS Time), 3, 2, NULL, 11)
INSERT [dbo].[grafik] ([id], [dzien_tygodnia], [godzina_od], [godzina_do], [zajecia], [sala], [opis], [instruktor_id]) VALUES (82, 5, CAST(0x00D0B60000000000 AS Time), CAST(0x00E0C40000000000 AS Time), 4, 3, NULL, 4)
INSERT [dbo].[grafik] ([id], [dzien_tygodnia], [godzina_od], [godzina_do], [zajecia], [sala], [opis], [instruktor_id]) VALUES (83, 5, CAST(0x00E0C40000000000 AS Time), CAST(0x00F0D20000000000 AS Time), 5, 4, NULL, 11)
INSERT [dbo].[grafik] ([id], [dzien_tygodnia], [godzina_od], [godzina_do], [zajecia], [sala], [opis], [instruktor_id]) VALUES (84, 5, CAST(0x00E0C40000000000 AS Time), CAST(0x00F0D20000000000 AS Time), 5, 1, NULL, 4)
INSERT [dbo].[grafik] ([id], [dzien_tygodnia], [godzina_od], [godzina_do], [zajecia], [sala], [opis], [instruktor_id]) VALUES (85, 5, CAST(0x00F0D20000000000 AS Time), CAST(0x0000E10000000000 AS Time), 4, 1, NULL, 11)
INSERT [dbo].[grafik] ([id], [dzien_tygodnia], [godzina_od], [godzina_do], [zajecia], [sala], [opis], [instruktor_id]) VALUES (86, 5, CAST(0x00F0D20000000000 AS Time), CAST(0x0000E10000000000 AS Time), 6, 2, NULL, 4)
INSERT [dbo].[grafik] ([id], [dzien_tygodnia], [godzina_od], [godzina_do], [zajecia], [sala], [opis], [instruktor_id]) VALUES (87, 5, CAST(0x0000E10000000000 AS Time), CAST(0x0010EF0000000000 AS Time), 2, 3, NULL, 11)
INSERT [dbo].[grafik] ([id], [dzien_tygodnia], [godzina_od], [godzina_do], [zajecia], [sala], [opis], [instruktor_id]) VALUES (88, 5, CAST(0x0010EF0000000000 AS Time), CAST(0x0020FD0000000000 AS Time), 3, 4, NULL, 4)
INSERT [dbo].[grafik] ([id], [dzien_tygodnia], [godzina_od], [godzina_do], [zajecia], [sala], [opis], [instruktor_id]) VALUES (89, 5, CAST(0x0010EF0000000000 AS Time), CAST(0x0020FD0000000000 AS Time), 8, 1, NULL, 10)
INSERT [dbo].[grafik] ([id], [dzien_tygodnia], [godzina_od], [godzina_do], [zajecia], [sala], [opis], [instruktor_id]) VALUES (90, 5, CAST(0x0020FD0000000000 AS Time), CAST(0x00300B0100000000 AS Time), 1, 4, NULL, 4)
INSERT [dbo].[grafik] ([id], [dzien_tygodnia], [godzina_od], [godzina_do], [zajecia], [sala], [opis], [instruktor_id]) VALUES (91, 6, CAST(0x00C0A80000000000 AS Time), CAST(0x00D0B60000000000 AS Time), 1, 4, NULL, 4)
INSERT [dbo].[grafik] ([id], [dzien_tygodnia], [godzina_od], [godzina_do], [zajecia], [sala], [opis], [instruktor_id]) VALUES (92, 6, CAST(0x00C0A80000000000 AS Time), CAST(0x00D0B60000000000 AS Time), 2, 1, NULL, 10)
INSERT [dbo].[grafik] ([id], [dzien_tygodnia], [godzina_od], [godzina_do], [zajecia], [sala], [opis], [instruktor_id]) VALUES (93, 6, CAST(0x00D0B60000000000 AS Time), CAST(0x00E0C40000000000 AS Time), 3, 2, NULL, 11)
INSERT [dbo].[grafik] ([id], [dzien_tygodnia], [godzina_od], [godzina_do], [zajecia], [sala], [opis], [instruktor_id]) VALUES (94, 6, CAST(0x00D0B60000000000 AS Time), CAST(0x00E0C40000000000 AS Time), 4, 3, NULL, 4)
INSERT [dbo].[grafik] ([id], [dzien_tygodnia], [godzina_od], [godzina_do], [zajecia], [sala], [opis], [instruktor_id]) VALUES (95, 6, CAST(0x00E0C40000000000 AS Time), CAST(0x00F0D20000000000 AS Time), 5, 4, NULL, 11)
INSERT [dbo].[grafik] ([id], [dzien_tygodnia], [godzina_od], [godzina_do], [zajecia], [sala], [opis], [instruktor_id]) VALUES (96, 6, CAST(0x00E0C40000000000 AS Time), CAST(0x00F0D20000000000 AS Time), 5, 1, NULL, 4)
INSERT [dbo].[grafik] ([id], [dzien_tygodnia], [godzina_od], [godzina_do], [zajecia], [sala], [opis], [instruktor_id]) VALUES (97, 6, CAST(0x00F0D20000000000 AS Time), CAST(0x0000E10000000000 AS Time), 4, 1, NULL, 11)
INSERT [dbo].[grafik] ([id], [dzien_tygodnia], [godzina_od], [godzina_do], [zajecia], [sala], [opis], [instruktor_id]) VALUES (98, 6, CAST(0x00F0D20000000000 AS Time), CAST(0x0000E10000000000 AS Time), 6, 2, NULL, 4)
INSERT [dbo].[grafik] ([id], [dzien_tygodnia], [godzina_od], [godzina_do], [zajecia], [sala], [opis], [instruktor_id]) VALUES (99, 6, CAST(0x0000E10000000000 AS Time), CAST(0x0010EF0000000000 AS Time), 2, 3, NULL, 11)
INSERT [dbo].[grafik] ([id], [dzien_tygodnia], [godzina_od], [godzina_do], [zajecia], [sala], [opis], [instruktor_id]) VALUES (100, 6, CAST(0x0010EF0000000000 AS Time), CAST(0x0020FD0000000000 AS Time), 3, 4, NULL, 4)
INSERT [dbo].[grafik] ([id], [dzien_tygodnia], [godzina_od], [godzina_do], [zajecia], [sala], [opis], [instruktor_id]) VALUES (101, 6, CAST(0x0010EF0000000000 AS Time), CAST(0x0020FD0000000000 AS Time), 8, 1, NULL, 10)
INSERT [dbo].[grafik] ([id], [dzien_tygodnia], [godzina_od], [godzina_do], [zajecia], [sala], [opis], [instruktor_id]) VALUES (102, 6, CAST(0x0020FD0000000000 AS Time), CAST(0x00300B0100000000 AS Time), 1, 4, NULL, 4)
INSERT [dbo].[grafik] ([id], [dzien_tygodnia], [godzina_od], [godzina_do], [zajecia], [sala], [opis], [instruktor_id]) VALUES (103, 7, CAST(0x00C0A80000000000 AS Time), CAST(0x00D0B60000000000 AS Time), 1, 4, NULL, 4)
INSERT [dbo].[grafik] ([id], [dzien_tygodnia], [godzina_od], [godzina_do], [zajecia], [sala], [opis], [instruktor_id]) VALUES (104, 7, CAST(0x00C0A80000000000 AS Time), CAST(0x00D0B60000000000 AS Time), 2, 1, NULL, 10)
INSERT [dbo].[grafik] ([id], [dzien_tygodnia], [godzina_od], [godzina_do], [zajecia], [sala], [opis], [instruktor_id]) VALUES (105, 7, CAST(0x00D0B60000000000 AS Time), CAST(0x00E0C40000000000 AS Time), 3, 2, NULL, 11)
INSERT [dbo].[grafik] ([id], [dzien_tygodnia], [godzina_od], [godzina_do], [zajecia], [sala], [opis], [instruktor_id]) VALUES (106, 7, CAST(0x00D0B60000000000 AS Time), CAST(0x00E0C40000000000 AS Time), 4, 3, NULL, 4)
INSERT [dbo].[grafik] ([id], [dzien_tygodnia], [godzina_od], [godzina_do], [zajecia], [sala], [opis], [instruktor_id]) VALUES (107, 7, CAST(0x00E0C40000000000 AS Time), CAST(0x00F0D20000000000 AS Time), 5, 4, NULL, 11)
INSERT [dbo].[grafik] ([id], [dzien_tygodnia], [godzina_od], [godzina_do], [zajecia], [sala], [opis], [instruktor_id]) VALUES (108, 7, CAST(0x00E0C40000000000 AS Time), CAST(0x00F0D20000000000 AS Time), 5, 1, NULL, 4)
INSERT [dbo].[grafik] ([id], [dzien_tygodnia], [godzina_od], [godzina_do], [zajecia], [sala], [opis], [instruktor_id]) VALUES (109, 7, CAST(0x00F0D20000000000 AS Time), CAST(0x0000E10000000000 AS Time), 4, 1, NULL, 11)
INSERT [dbo].[grafik] ([id], [dzien_tygodnia], [godzina_od], [godzina_do], [zajecia], [sala], [opis], [instruktor_id]) VALUES (110, 7, CAST(0x00F0D20000000000 AS Time), CAST(0x0000E10000000000 AS Time), 6, 2, NULL, 4)
INSERT [dbo].[grafik] ([id], [dzien_tygodnia], [godzina_od], [godzina_do], [zajecia], [sala], [opis], [instruktor_id]) VALUES (111, 7, CAST(0x0000E10000000000 AS Time), CAST(0x0010EF0000000000 AS Time), 2, 3, NULL, 11)
INSERT [dbo].[grafik] ([id], [dzien_tygodnia], [godzina_od], [godzina_do], [zajecia], [sala], [opis], [instruktor_id]) VALUES (112, 7, CAST(0x0010EF0000000000 AS Time), CAST(0x0020FD0000000000 AS Time), 3, 4, NULL, 4)
INSERT [dbo].[grafik] ([id], [dzien_tygodnia], [godzina_od], [godzina_do], [zajecia], [sala], [opis], [instruktor_id]) VALUES (113, 7, CAST(0x0010EF0000000000 AS Time), CAST(0x0020FD0000000000 AS Time), 8, 1, NULL, 10)
INSERT [dbo].[grafik] ([id], [dzien_tygodnia], [godzina_od], [godzina_do], [zajecia], [sala], [opis], [instruktor_id]) VALUES (114, 7, CAST(0x0020FD0000000000 AS Time), CAST(0x00300B0100000000 AS Time), 1, 4, NULL, 4)
SET IDENTITY_INSERT [dbo].[grafik] OFF
SET IDENTITY_INSERT [dbo].[osoby] ON 

INSERT [dbo].[osoby] ([id], [imie], [nazwisko], [telefon], [mail], [data_ur], [data_rej], [data_zatrudnienia]) VALUES (4, N'Radek', N'Wichrowski', N'884988812', N'radoslaw.wichrowski', CAST(0xEC080B00 AS Date), CAST(0x303B0B00 AS Date), CAST(0x6E390B00 AS Date))
INSERT [dbo].[osoby] ([id], [imie], [nazwisko], [telefon], [mail], [data_ur], [data_rej], [data_zatrudnienia]) VALUES (5, N'Jan ', N'Bielecki', N'887887887', N'dorbaa@wp.pl', CAST(0x6EE90A00 AS Date), CAST(0xC2390B00 AS Date), NULL)
INSERT [dbo].[osoby] ([id], [imie], [nazwisko], [telefon], [mail], [data_ur], [data_rej], [data_zatrudnienia]) VALUES (6, N'Monika', N'Czarnecka', N'834682736', N'monia@buziaczek.pl', CAST(0xA30E0B00 AS Date), CAST(0x4F320B00 AS Date), NULL)
INSERT [dbo].[osoby] ([id], [imie], [nazwisko], [telefon], [mail], [data_ur], [data_rej], [data_zatrudnienia]) VALUES (7, N'Alicja ', N'Olender', N'123123123', N'alicja@gmail.com', CAST(0xE51C0B00 AS Date), CAST(0xD8390B00 AS Date), NULL)
INSERT [dbo].[osoby] ([id], [imie], [nazwisko], [telefon], [mail], [data_ur], [data_rej], [data_zatrudnienia]) VALUES (8, N'Krzysztof', N'Wichrowski', N'954234869', N'jdhjhdjbsdhj@wp.pl', CAST(0xB1DC0A00 AS Date), CAST(0xD8390B00 AS Date), NULL)
INSERT [dbo].[osoby] ([id], [imie], [nazwisko], [telefon], [mail], [data_ur], [data_rej], [data_zatrudnienia]) VALUES (9, N'Matylda ', N'Opolska', N'758756864', N'janina@wp.pl', CAST(0x34340B00 AS Date), CAST(0xB9330B00 AS Date), NULL)
INSERT [dbo].[osoby] ([id], [imie], [nazwisko], [telefon], [mail], [data_ur], [data_rej], [data_zatrudnienia]) VALUES (10, N'Dariusz', N'Majewski', N'951231564', N'opolask@gmail.pl', CAST(0x3C380B00 AS Date), CAST(0xF32C0B00 AS Date), CAST(0x01380B00 AS Date))
INSERT [dbo].[osoby] ([id], [imie], [nazwisko], [telefon], [mail], [data_ur], [data_rej], [data_zatrudnienia]) VALUES (11, N'Natalia', N'Jańkowska', N'888498881', N'janina@fran.eu', CAST(0xA7A30A00 AS Date), CAST(0xD8390B00 AS Date), CAST(0xD8390B00 AS Date))
SET IDENTITY_INSERT [dbo].[osoby] OFF
SET IDENTITY_INSERT [dbo].[rezerwacje] ON 

INSERT [dbo].[rezerwacje] ([id], [osoba_id], [data], [obecnosc], [grafik_id]) VALUES (8, 6, CAST(0x0000A48500000000 AS DateTime), NULL, 101)
INSERT [dbo].[rezerwacje] ([id], [osoba_id], [data], [obecnosc], [grafik_id]) VALUES (9, 8, CAST(0x0000A48500000000 AS DateTime), NULL, 101)
INSERT [dbo].[rezerwacje] ([id], [osoba_id], [data], [obecnosc], [grafik_id]) VALUES (10, 7, CAST(0x0000A48500000000 AS DateTime), NULL, 93)
SET IDENTITY_INSERT [dbo].[rezerwacje] OFF
SET IDENTITY_INSERT [dbo].[sale] ON 

INSERT [dbo].[sale] ([id], [nazwa], [ile_osob], [rowery]) VALUES (1, N'Energia', 30, N'N')
INSERT [dbo].[sale] ([id], [nazwa], [ile_osob], [rowery]) VALUES (2, N'Harmonia', 20, N'N')
INSERT [dbo].[sale] ([id], [nazwa], [ile_osob], [rowery]) VALUES (4, N'Power', 20, N'N')
INSERT [dbo].[sale] ([id], [nazwa], [ile_osob], [rowery]) VALUES (3, N'Spinning', 20, N'T')
SET IDENTITY_INSERT [dbo].[sale] OFF
SET IDENTITY_INSERT [dbo].[zajecia] ON 

INSERT [dbo].[zajecia] ([id], [nazwa], [opis]) VALUES (1, N'TBC', N'Najbardziej uniwersalne ze wszystkich zajęć fitness. Mają na celu globalne wzmocnienie, stabilizację, uelastycznienie mięśni.
Zajęcia mają różnorodną strukturę w zależności od inwencji prowadzącego. Mogą być przeprowadzone z wykorzystaniem wszelkich akcesoriów fitness.
Rozpoczynają się rozgrzewką i kończą kilkuminutowym stretchingiem.
Zajęcia dla wszystkich.')
INSERT [dbo].[zajecia] ([id], [nazwa], [opis]) VALUES (2, N'ABT', N'ABT opis opis opis')
INSERT [dbo].[zajecia] ([id], [nazwa], [opis]) VALUES (3, N'Shape', N'Shape opis opis opis')
INSERT [dbo].[zajecia] ([id], [nazwa], [opis]) VALUES (4, N'Płaski brzuch', N'Płaski brzuch opis opis opis')
INSERT [dbo].[zajecia] ([id], [nazwa], [opis]) VALUES (5, N'Cross Training ', N'Cross Training  opis opis opis')
INSERT [dbo].[zajecia] ([id], [nazwa], [opis]) VALUES (6, N'Tabata Training', N'Tabata Training opis opis opis')
INSERT [dbo].[zajecia] ([id], [nazwa], [opis]) VALUES (7, N'Spinning', N'Trening według techniki Schwinn Cycling lub Spinning. Trening przeznaczony dla każdego, inspirowany zawodowym kolarstwem, oparty na wiedzy o fizjologii wysiłku.  Jest to symulacja jazdy w prawdziwym terenie wykorzystująca 3 pozycje rąk na kierownicy. Każdy trening jedzie się w odpowiedniej strefie tętna w zależności od klasy zajęć (Regeneracja, Wytrzymałość, Siła, Interwał, „Dzień Wyścigu” ) aby wykorzystywać podczas treningu konkretne źródła energii oraz pracować nad polepszeniem pracy układu sercowo-naczyniowego, oddechowego, odpornościowego. Do kontroli bycia w odpowiedniej strefie tętna zaleca się, aby  uczestnik zajęć posiadał pulsometr.  Uwaga: W wybranych klubach posiadamy specjalny system do monitorowania pracy serca – Suunto Fitness Solution.  Na tych zajęciach nie dzielimy uczestników na początkujących i zaawansowanych – jest to unikalny przypadek treningu indywidualnego w grupie. Każdy uczestnik może niezależnie od stopnia wytrenowania w trakcie trwania lekcji dostosowywać ją do swoich potrzeb i możliwości, poprzez zmianę obciążenia i/lub pozycji, nie tracąc przy tym ciągłości treningu i bez wrażenia wypadnięcia z grupy.')
INSERT [dbo].[zajecia] ([id], [nazwa], [opis]) VALUES (8, N'Tomahawk', N'Tomahawk opis opis opis')
SET IDENTITY_INSERT [dbo].[zajecia] OFF
/****** Object:  Index [IX_sale_nazwa_unique]    Script Date: 2015-04-19 21:53:36 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_sale_nazwa_unique] ON [dbo].[sale]
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_zajecia_nazwa_unique]    Script Date: 2015-04-19 21:53:36 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_zajecia_nazwa_unique] ON [dbo].[zajecia]
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[grafik]  WITH CHECK ADD  CONSTRAINT [FK_grafik_dni] FOREIGN KEY([dzien_tygodnia])
REFERENCES [dbo].[dni_tygodnia] ([id])
GO
ALTER TABLE [dbo].[grafik] CHECK CONSTRAINT [FK_grafik_dni]
GO
ALTER TABLE [dbo].[grafik]  WITH CHECK ADD  CONSTRAINT [FK_grafik_instruktor] FOREIGN KEY([instruktor_id])
REFERENCES [dbo].[osoby] ([id])
GO
ALTER TABLE [dbo].[grafik] CHECK CONSTRAINT [FK_grafik_instruktor]
GO
ALTER TABLE [dbo].[grafik]  WITH CHECK ADD  CONSTRAINT [FK_grafik_sale] FOREIGN KEY([sala])
REFERENCES [dbo].[sale] ([id])
GO
ALTER TABLE [dbo].[grafik] CHECK CONSTRAINT [FK_grafik_sale]
GO
ALTER TABLE [dbo].[grafik]  WITH CHECK ADD  CONSTRAINT [FK_grafik_zajecia] FOREIGN KEY([zajecia])
REFERENCES [dbo].[zajecia] ([id])
GO
ALTER TABLE [dbo].[grafik] CHECK CONSTRAINT [FK_grafik_zajecia]
GO
ALTER TABLE [dbo].[rezerwacje]  WITH CHECK ADD  CONSTRAINT [FK_rezerwacje_grafik] FOREIGN KEY([grafik_id])
REFERENCES [dbo].[grafik] ([id])
GO
ALTER TABLE [dbo].[rezerwacje] CHECK CONSTRAINT [FK_rezerwacje_grafik]
GO
ALTER TABLE [dbo].[rezerwacje]  WITH CHECK ADD  CONSTRAINT [FK_rezerwacje_osoba] FOREIGN KEY([osoba_id])
REFERENCES [dbo].[osoby] ([id])
GO
ALTER TABLE [dbo].[rezerwacje] CHECK CONSTRAINT [FK_rezerwacje_osoba]
GO
USE [master]
GO
ALTER DATABASE [fitness] SET  READ_WRITE 
GO
