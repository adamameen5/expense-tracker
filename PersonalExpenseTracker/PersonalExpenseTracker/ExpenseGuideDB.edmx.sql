
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/26/2021 02:45:41
-- Generated from EDMX file: C:\ADAMLK\EAD\EAD_Final_3\expense-tracker\PersonalExpenseTracker\PersonalExpenseTracker\ExpenseGuideDB.edmx
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
IF OBJECT_ID(N'[dbo].[FK_BankAccountDetailUser]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BankAccountDetails] DROP CONSTRAINT [FK_BankAccountDetailUser];
GO
IF OBJECT_ID(N'[dbo].[FK_ContactUser]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Contacts] DROP CONSTRAINT [FK_ContactUser];
GO
IF OBJECT_ID(N'[dbo].[FK_UserTransaction]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Transactions] DROP CONSTRAINT [FK_UserTransaction];
GO
IF OBJECT_ID(N'[dbo].[FK_TransactionContact]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Transactions] DROP CONSTRAINT [FK_TransactionContact];
GO
IF OBJECT_ID(N'[dbo].[FK_EventUser]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Events] DROP CONSTRAINT [FK_EventUser];
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
IF OBJECT_ID(N'[dbo].[BankAccountDetails]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BankAccountDetails];
GO
IF OBJECT_ID(N'[dbo].[Contacts]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Contacts];
GO
IF OBJECT_ID(N'[dbo].[Transactions]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Transactions];
GO
IF OBJECT_ID(N'[dbo].[Events]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Events];
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
    [UserId] int  NOT NULL
);
GO

-- Creating table 'BankAccountDetails'
CREATE TABLE [dbo].[BankAccountDetails] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [BankAccountNumber] nvarchar(max)  NULL,
    [BankAccountBankName] nvarchar(max)  NULL,
    [BankAccountBranchName] nvarchar(max)  NULL,
    [BankAccountNameToDisplay] nvarchar(max)  NULL,
    [UserId] int  NOT NULL
);
GO

-- Creating table 'Contacts'
CREATE TABLE [dbo].[Contacts] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ContactName] nvarchar(max)  NULL,
    [ContactDescription] nvarchar(max)  NULL,
    [ContactType] nvarchar(max)  NULL,
    [ContactTelephoneNumber] nvarchar(max)  NULL,
    [UserId] int  NOT NULL
);
GO

-- Creating table 'Transactions'
CREATE TABLE [dbo].[Transactions] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [TransactionDate] datetime  NULL,
    [TransactionContactName] nvarchar(max)  NULL,
    [TransactionAmount] nvarchar(max)  NULL,
    [TransactionEvent] nvarchar(max)  NULL,
    [TransactionAssociatedAccount] nvarchar(max)  NULL,
    [TransactionType] nvarchar(max)  NULL,
    [TransactionCode] nvarchar(max)  NULL,
    [UserId] int  NOT NULL,
    [ContactId] int  NULL
);
GO

-- Creating table 'Events'
CREATE TABLE [dbo].[Events] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [EventDate] datetime  NULL,
    [EventCode] nvarchar(max)  NULL,
    [EventName] nvarchar(max)  NULL,
    [EventRecurring] nvarchar(max)  NULL,
    [EventType] nvarchar(max)  NULL,
    [EventCategory] nvarchar(max)  NULL,
    [EventAssociatedContact] nvarchar(max)  NULL,
    [UserId] int  NOT NULL
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

-- Creating primary key on [Id] in table 'BankAccountDetails'
ALTER TABLE [dbo].[BankAccountDetails]
ADD CONSTRAINT [PK_BankAccountDetails]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Contacts'
ALTER TABLE [dbo].[Contacts]
ADD CONSTRAINT [PK_Contacts]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Transactions'
ALTER TABLE [dbo].[Transactions]
ADD CONSTRAINT [PK_Transactions]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Events'
ALTER TABLE [dbo].[Events]
ADD CONSTRAINT [PK_Events]
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

-- Creating foreign key on [UserId] in table 'CardDetails'
ALTER TABLE [dbo].[CardDetails]
ADD CONSTRAINT [FK_CardDetailUser]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CardDetailUser'
CREATE INDEX [IX_FK_CardDetailUser]
ON [dbo].[CardDetails]
    ([UserId]);
GO

-- Creating foreign key on [UserId] in table 'BankAccountDetails'
ALTER TABLE [dbo].[BankAccountDetails]
ADD CONSTRAINT [FK_BankAccountDetailUser]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_BankAccountDetailUser'
CREATE INDEX [IX_FK_BankAccountDetailUser]
ON [dbo].[BankAccountDetails]
    ([UserId]);
GO

-- Creating foreign key on [UserId] in table 'Contacts'
ALTER TABLE [dbo].[Contacts]
ADD CONSTRAINT [FK_ContactUser]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ContactUser'
CREATE INDEX [IX_FK_ContactUser]
ON [dbo].[Contacts]
    ([UserId]);
GO

-- Creating foreign key on [UserId] in table 'Transactions'
ALTER TABLE [dbo].[Transactions]
ADD CONSTRAINT [FK_UserTransaction]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserTransaction'
CREATE INDEX [IX_FK_UserTransaction]
ON [dbo].[Transactions]
    ([UserId]);
GO

-- Creating foreign key on [ContactId] in table 'Transactions'
ALTER TABLE [dbo].[Transactions]
ADD CONSTRAINT [FK_TransactionContact]
    FOREIGN KEY ([ContactId])
    REFERENCES [dbo].[Contacts]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TransactionContact'
CREATE INDEX [IX_FK_TransactionContact]
ON [dbo].[Transactions]
    ([ContactId]);
GO

-- Creating foreign key on [UserId] in table 'Events'
ALTER TABLE [dbo].[Events]
ADD CONSTRAINT [FK_EventUser]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EventUser'
CREATE INDEX [IX_FK_EventUser]
ON [dbo].[Events]
    ([UserId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------