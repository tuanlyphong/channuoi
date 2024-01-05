USE [master]
GO
/****** Object:  Database [channuoi]    Script Date: 1/1/2024 5:35:57 PM ******/
CREATE DATABASE [channuoi]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'channuoi', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\channuoi.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'channuoi_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\channuoi_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [channuoi] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [channuoi].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [channuoi] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [channuoi] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [channuoi] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [channuoi] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [channuoi] SET ARITHABORT OFF 
GO
ALTER DATABASE [channuoi] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [channuoi] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [channuoi] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [channuoi] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [channuoi] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [channuoi] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [channuoi] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [channuoi] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [channuoi] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [channuoi] SET  ENABLE_BROKER 
GO
ALTER DATABASE [channuoi] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [channuoi] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [channuoi] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [channuoi] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [channuoi] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [channuoi] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [channuoi] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [channuoi] SET RECOVERY FULL 
GO
ALTER DATABASE [channuoi] SET  MULTI_USER 
GO
ALTER DATABASE [channuoi] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [channuoi] SET DB_CHAINING OFF 
GO
ALTER DATABASE [channuoi] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [channuoi] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [channuoi] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [channuoi] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'channuoi', N'ON'
GO
ALTER DATABASE [channuoi] SET QUERY_STORE = ON
GO
ALTER DATABASE [channuoi] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [channuoi]
GO
/****** Object:  Table [dbo].[Canhan]    Script Date: 1/1/2024 5:35:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Canhan](
	[IDcanhan] [int] NOT NULL,
	[Tencanhan] [nvarchar](30) NULL,
	[IDtochuc] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IDcanhan] ASC,
	[IDtochuc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cskn]    Script Date: 1/1/2024 5:35:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cskn](
	[TenCS] [nvarchar](30) NULL,
	[ChuCS] [nvarchar](30) NULL,
	[Nthanhlap] [nvarchar](40) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cssx]    Script Date: 1/1/2024 5:35:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cssx](
	[TenCS] [nvarchar](30) NULL,
	[ChuCS] [nvarchar](30) NULL,
	[Nthanhlap] [nvarchar](40) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[login]    Script Date: 1/1/2024 5:35:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[login](
	[username] [nchar](20) NOT NULL,
	[password] [nchar](20) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tochuc]    Script Date: 1/1/2024 5:35:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tochuc](
	[IDtochuc] [int] NOT NULL,
	[Tentochuc] [nvarchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[IDtochuc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Canhan]  WITH CHECK ADD FOREIGN KEY([IDtochuc])
REFERENCES [dbo].[Tochuc] ([IDtochuc])
GO
/****** Object:  StoredProcedure [dbo].[sp_login]    Script Date: 1/1/2024 5:35:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_login]
@username nvarchar(20),
@password nvarchar(20)
AS
Begin 
	Select * from login where username=@username
	and password = @password
END
GO
/****** Object:  StoredProcedure [dbo].[Themcanhan]    Script Date: 1/1/2024 5:35:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Themcanhan]
    @IDcanhan INT,
    @Tencanhan NVARCHAR(30),
    @IDtochuc INT
AS
BEGIN
    SET NOCOUNT ON;

    -- Check if the organization (IDtochuc) exists before adding the individual
    IF NOT EXISTS (SELECT 1 FROM Tochuc WHERE IDtochuc = @IDtochuc)
    BEGIN
        PRINT 'Error: To chuc khong ton tai';
        RETURN;
    END

    -- Check if the individual (IDcanhan) already exists
    IF EXISTS (SELECT 1 FROM Canhan WHERE IDcanhan = @IDcanhan)
    BEGIN
        PRINT 'Error: Da ton tai ID nguoi dung';
        RETURN;
    END

    -- Insert the new individual into the Canhan table
    INSERT INTO Canhan (IDcanhan, Tencanhan, IDtochuc)
    VALUES (@IDcanhan, @Tencanhan, @IDtochuc);

    PRINT 'them thanh cong';
END;
GO
/****** Object:  StoredProcedure [dbo].[themcs]    Script Date: 1/1/2024 5:35:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[themcs]
@TenCS Nvarchar(30),
@ChuCS Nvarchar(30),
@Nthanhlap Nvarchar(40)
AS
BEGIN
INSERT INTO Cssx(
TenCS,ChuCS,Nthanhlap)
VALUES(
@TenCS,@ChuCS,@Nthanhlap)
END
GO
/****** Object:  StoredProcedure [dbo].[themcskn]    Script Date: 1/1/2024 5:35:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[themcskn]
@TenCS Nvarchar(30),
@ChuCS Nvarchar(30),
@Nthanhlap Nvarchar(40)
AS
BEGIN
INSERT INTO Cskn(
TenCS,ChuCS,Nthanhlap)
VALUES(
@TenCS,@ChuCS,@Nthanhlap)
END
GO
/****** Object:  StoredProcedure [dbo].[Themtochuc]    Script Date: 1/1/2024 5:35:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Themtochuc]
@IDtochuc INT,
@Tentochuc Nvarchar(30)
AS
BEGIN
INSERT INTO Tochuc(
IDtochuc,Tentochuc)
VALUES(
@IDtochuc,@Tentochuc)
END
GO
/****** Object:  StoredProcedure [dbo].[Timkiemcanhan]    Script Date: 1/1/2024 5:35:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Timkiemcanhan]
    @IDcanhan INT
AS
BEGIN
    -- Return a single individual based on the specified individual ID
    SELECT *
    FROM Canhan
    WHERE Canhan.IDcanhan = @IDcanhan;
END;
GO
/****** Object:  StoredProcedure [dbo].[Timkiemtochuc]    Script Date: 1/1/2024 5:35:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Timkiemtochuc]
    @IDtochuc INT
AS
BEGIN
    -- Return organization with the specified ID
    SELECT *
    FROM Tochuc
    WHERE IDtochuc = @IDtochuc;
END;
GO
/****** Object:  StoredProcedure [dbo].[Xemcanhancuamottochuc]    Script Date: 1/1/2024 5:35:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Xemcanhancuamottochuc]
    @IDtochuc INT
AS
BEGIN
    -- Return individuals for the selected organization
    SELECT Canhan.*
    FROM Canhan
    WHERE Canhan.IDtochuc = @IDtochuc;
END;
GO
/****** Object:  StoredProcedure [dbo].[Xemcosokn]    Script Date: 1/1/2024 5:35:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Xemcosokn]
@TenCS Nvarchar(30)
AS
BEGIN
	IF (@TenCS = '')
	BEGIN
		Select * from Cskn
	END
	ELSE
	BEGIN
		Select * from Cskn Where TenCS=@TenCS
	END
END
GO
/****** Object:  StoredProcedure [dbo].[Xemcososx]    Script Date: 1/1/2024 5:35:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Xemcososx]
@TenCS Nvarchar(30)
AS
BEGIN
	IF (@TenCS = '')
	BEGIN
		Select * from Cssx
	END
	ELSE
	BEGIN
		Select * from Cssx Where TenCS=@TenCS
	END
END
GO
/****** Object:  StoredProcedure [dbo].[Xemtochuc]    Script Date: 1/1/2024 5:35:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Xemtochuc]
AS
BEGIN
    -- Return the organization table
    SELECT *
    FROM Tochuc;
END;
GO
/****** Object:  StoredProcedure [dbo].[XoaCanhanTheoTochuc]    Script Date: 1/1/2024 5:35:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[XoaCanhanTheoTochuc]
    @IDtochuc INT,
    @IDcanhan INT
AS
BEGIN
    DELETE FROM Canhan
    WHERE IDtochuc = @IDtochuc
      AND IDcanhan = @IDcanhan;
END;
GO
/****** Object:  StoredProcedure [dbo].[Xoacskn]    Script Date: 1/1/2024 5:35:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Xoacskn]
@TenCS Nvarchar(30)
AS
BEGIN
	SET NOCOUNT ON;
	Delete from Cskn Where TenCS=@TenCS
END
GO
/****** Object:  StoredProcedure [dbo].[Xoacssx]    Script Date: 1/1/2024 5:35:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Xoacssx]
@TenCS Nvarchar(30)
AS
BEGIN
	SET NOCOUNT ON;
	Delete from Cssx Where TenCS=@TenCS
END
GO
/****** Object:  StoredProcedure [dbo].[Xoatochuc]    Script Date: 1/1/2024 5:35:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Xoatochuc]
    @IDtochuc INT
AS
BEGIN
    BEGIN TRY
        -- Your delete statement here
        DELETE FROM Tochuc WHERE IDtochuc = @IDtochuc;

        -- Optionally, you can add additional logic or cascade deletion here

        -- Return success message or value if needed
        SELECT 'Delete successful' AS Status;
    END TRY
    BEGIN CATCH
        -- Return error message if an error occurs
        SELECT ERROR_MESSAGE() AS ErrorMessage;
    END CATCH
END;
GO
USE [master]
GO
ALTER DATABASE [channuoi] SET  READ_WRITE 
GO
