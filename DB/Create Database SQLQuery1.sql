USE [master]
GO

/****** Object:  Database [Banking_ApplicationDB]    Script Date: 12/13/2018 14:49:34 ******/
CREATE DATABASE [Banking_ApplicationDB] ON  PRIMARY 
( NAME = N'Banking_ApplicationDB', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\Banking_ApplicationDB.mdf' , SIZE = 2304KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Banking_ApplicationDB_log', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\Banking_ApplicationDB_log.LDF' , SIZE = 504KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

ALTER DATABASE [Banking_ApplicationDB] SET COMPATIBILITY_LEVEL = 100
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Banking_ApplicationDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [Banking_ApplicationDB] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [Banking_ApplicationDB] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [Banking_ApplicationDB] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [Banking_ApplicationDB] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [Banking_ApplicationDB] SET ARITHABORT OFF 
GO

ALTER DATABASE [Banking_ApplicationDB] SET AUTO_CLOSE ON 
GO

ALTER DATABASE [Banking_ApplicationDB] SET AUTO_CREATE_STATISTICS ON 
GO

ALTER DATABASE [Banking_ApplicationDB] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [Banking_ApplicationDB] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [Banking_ApplicationDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [Banking_ApplicationDB] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [Banking_ApplicationDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [Banking_ApplicationDB] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [Banking_ApplicationDB] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [Banking_ApplicationDB] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [Banking_ApplicationDB] SET  ENABLE_BROKER 
GO

ALTER DATABASE [Banking_ApplicationDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [Banking_ApplicationDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [Banking_ApplicationDB] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [Banking_ApplicationDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [Banking_ApplicationDB] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [Banking_ApplicationDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [Banking_ApplicationDB] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [Banking_ApplicationDB] SET  READ_WRITE 
GO

ALTER DATABASE [Banking_ApplicationDB] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [Banking_ApplicationDB] SET  MULTI_USER 
GO

ALTER DATABASE [Banking_ApplicationDB] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [Banking_ApplicationDB] SET DB_CHAINING OFF 
GO


