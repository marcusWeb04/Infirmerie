USE [master]
GO
/****** Object:  Database [Gestion infirmerie]    Script Date: 13/10/2023 10:42:43 ******/
CREATE DATABASE [Gestion infirmerie]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Gestion infirmerie', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Gestion infirmerie.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Gestion infirmerie_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Gestion infirmerie_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Gestion infirmerie] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Gestion infirmerie].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Gestion infirmerie] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Gestion infirmerie] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Gestion infirmerie] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Gestion infirmerie] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Gestion infirmerie] SET ARITHABORT OFF 
GO
ALTER DATABASE [Gestion infirmerie] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Gestion infirmerie] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Gestion infirmerie] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Gestion infirmerie] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Gestion infirmerie] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Gestion infirmerie] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Gestion infirmerie] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Gestion infirmerie] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Gestion infirmerie] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Gestion infirmerie] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Gestion infirmerie] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Gestion infirmerie] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Gestion infirmerie] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Gestion infirmerie] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Gestion infirmerie] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Gestion infirmerie] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Gestion infirmerie] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Gestion infirmerie] SET RECOVERY FULL 
GO
ALTER DATABASE [Gestion infirmerie] SET  MULTI_USER 
GO
ALTER DATABASE [Gestion infirmerie] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Gestion infirmerie] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Gestion infirmerie] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Gestion infirmerie] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Gestion infirmerie] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Gestion infirmerie] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Gestion infirmerie', N'ON'
GO
ALTER DATABASE [Gestion infirmerie] SET QUERY_STORE = OFF
GO
USE [Gestion infirmerie]
GO
/****** Object:  Table [dbo].[classe]    Script Date: 13/10/2023 10:42:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[classe](
	[classe_id] [int] IDENTITY(1,1) NOT NULL,
	[classe_lib] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_classe] PRIMARY KEY CLUSTERED 
(
	[classe_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[eleve]    Script Date: 13/10/2023 10:42:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[eleve](
	[eleve_id] [int] IDENTITY(1,1) NOT NULL,
	[eleve_nom] [nvarchar](50) NOT NULL,
	[eleve_prenom] [nvarchar](50) NOT NULL,
	[eleve_naiss] [date] NOT NULL,
	[eleve_port] [int] NOT NULL,
	[eleve_parent_port] [int] NOT NULL,
	[eleve_classe] [int] NOT NULL,
	[eleve_tier_temps] [bit] NOT NULL,
	[eleve_comm_sante] [nvarchar](50) NULL,
 CONSTRAINT [PK_eleve] PRIMARY KEY CLUSTERED 
(
	[eleve_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[medicament]    Script Date: 13/10/2023 10:42:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[medicament](
	[medic_id] [int] IDENTITY(1,1) NOT NULL,
	[medic_lib] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_medicament] PRIMARY KEY CLUSTERED 
(
	[medic_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[utilisateur]    Script Date: 13/10/2023 10:42:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[utilisateur](
	[utilisateur_login] [nvarchar](50) NOT NULL,
	[utilisateur_mdp] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_utilisateur] PRIMARY KEY CLUSTERED 
(
	[utilisateur_login] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[visite]    Script Date: 13/10/2023 10:42:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[visite](
	[visite_id] [int] IDENTITY(1,1) NOT NULL,
	[visite_eleve] [int] NOT NULL,
	[visite_medic] [int] NULL,
	[visite_medic_qte] [int] NULL,
	[visite_date] [date] NOT NULL,
	[visite_heure_arrivee] [time](7) NOT NULL,
	[visite_heure_depart] [time](7) NOT NULL,
	[visite_motif] [nvarchar](50) NOT NULL,
	[visite_comm] [nvarchar](50) NULL,
	[visite_parents_prev] [bit] NOT NULL,
	[visite_suite] [nvarchar](50) NULL,
	[visite_utilisateur] [nvarchar](50) NULL,
 CONSTRAINT [PK_visite] PRIMARY KEY CLUSTERED 
(
	[visite_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[eleve]  WITH CHECK ADD  CONSTRAINT [FK_eleve_classe] FOREIGN KEY([eleve_classe])
REFERENCES [dbo].[classe] ([classe_id])
GO
ALTER TABLE [dbo].[eleve] CHECK CONSTRAINT [FK_eleve_classe]
GO
ALTER TABLE [dbo].[visite]  WITH CHECK ADD  CONSTRAINT [FK_visite_eleve] FOREIGN KEY([visite_eleve])
REFERENCES [dbo].[eleve] ([eleve_id])
GO
ALTER TABLE [dbo].[visite] CHECK CONSTRAINT [FK_visite_eleve]
GO
ALTER TABLE [dbo].[visite]  WITH CHECK ADD  CONSTRAINT [FK_visite_medic] FOREIGN KEY([visite_medic])
REFERENCES [dbo].[medicament] ([medic_id])
GO
ALTER TABLE [dbo].[visite] CHECK CONSTRAINT [FK_visite_medic]
GO
ALTER TABLE [dbo].[visite]  WITH CHECK ADD  CONSTRAINT [FK_visite_utilisateur] FOREIGN KEY([visite_utilisateur])
REFERENCES [dbo].[utilisateur] ([utilisateur_login])
GO
ALTER TABLE [dbo].[visite] CHECK CONSTRAINT [FK_visite_utilisateur]
GO
USE [master]
GO
ALTER DATABASE [Gestion infirmerie] SET  READ_WRITE 
GO
