
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/19/2019 14:44:22
-- Generated from EDMX file: C:\Users\Sam\source\repos\PersonaCalculator\PersonaCalculator\Personas.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Personas];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Personas'
CREATE TABLE [dbo].[Personas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Level] int  NOT NULL,
    [Arcana_Id] int  NOT NULL
);
GO

-- Creating table 'Arcanas'
CREATE TABLE [dbo].[Arcanas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ArcanaName] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Personas'
ALTER TABLE [dbo].[Personas]
ADD CONSTRAINT [PK_Personas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Arcanas'
ALTER TABLE [dbo].[Arcanas]
ADD CONSTRAINT [PK_Arcanas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Arcana_Id] in table 'Personas'
ALTER TABLE [dbo].[Personas]
ADD CONSTRAINT [FK_PersonaArcana]
    FOREIGN KEY ([Arcana_Id])
    REFERENCES [dbo].[Arcanas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PersonaArcana'
CREATE INDEX [IX_FK_PersonaArcana]
ON [dbo].[Personas]
    ([Arcana_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------