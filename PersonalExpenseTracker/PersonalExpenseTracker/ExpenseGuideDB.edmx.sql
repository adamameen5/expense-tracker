
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/20/2021 07:38:59
-- Generated from EDMX file: C:\ADAMLK\EAD\EAD_Final_2\expense-tracker\PersonalExpenseTracker\PersonalExpenseTracker\ExpenseGuideDB.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [ExpenseGuideDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_CredentialsUser]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Credentials] DROP CONSTRAINT [FK_CredentialsUser];
GO
IF OBJECT_ID(N'[dbo].[FK_CardDetailUser]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CardDetails] DROP CONSTRAINT [FK_CardDetailUser];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Credentials]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Credentials];
GO
IF OBJECT_ID(N'[dbo].[Users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users];
GO
IF OBJECT_ID(N'[dbo].[CardDetails]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CardDetails];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Credentials'
CREATE TABLE [dbo].[Credentials] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [UserName] nvarchar(max)  NULL,
    [Email] nvarchar(max)  NULL,
    [Password] nvarchar(max)  NULL,
    [NIC] nvarchar(max)  NULL,
    [User_Id] int  NOT NULL
);
GO

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FullName] nvarchar(max)  NULL,
    [Contact] nvarchar(max)  NULL,
    [Address] nvarchar(max)  NULL,
    [RecoveryEmailAddress] nvarchar(max)  NULL,
    [DateOfBirth] nvarchar(max)  NULL
);
GO

-- Creating table 'CardDetails'
CREATE TABLE [dbo].[CardDetails] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CardNumber] nvarchar(max)  NULL,
    [CardNameToDisplay] nvarchar(max)  NULL,
    [CardDateOfExpiry] nvarchar(max)  NULL,
    [CardBankName] nvarchar(max)  NULL,
    [User_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Credentials'
ALTER TABLE [dbo].[Credentials]
ADD CONSTRAINT [PK_Credentials]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CardDetails'
ALTER TABLE [dbo].[CardDetails]
ADD CONSTRAINT [PK_CardDetails]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [User_Id] in table 'Credentials'
ALTER TABLE [dbo].[Credentials]
ADD CONSTRAINT [FK_CredentialsUser]
    FOREIGN KEY ([User_Id])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CredentialsUser'
CREATE INDEX [IX_FK_CredentialsUser]
ON [dbo].[Credentials]
    ([User_Id]);
GO

-- Creating foreign key on [User_Id] in table 'CardDetails'
ALTER TABLE [dbo].[CardDetails]
ADD CONSTRAINT [FK_CardDetailUser]
    FOREIGN KEY ([User_Id])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CardDetailUser'
CREATE INDEX [IX_FK_CardDetailUser]
ON [dbo].[CardDetails]
    ([User_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------