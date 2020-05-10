/* Create TesisDB */

USE [master]
GO

IF DB_ID('TesisDB') IS NOT NULL
DROP DATABASE TesisDB;
GO

/****** Object:  Database [TesisDB]    Script Date: 18/04/2019 12:46:43 p. m. ******/
CREATE DATABASE [TesisDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TesisDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\TesisDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TesisDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\TesisDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO