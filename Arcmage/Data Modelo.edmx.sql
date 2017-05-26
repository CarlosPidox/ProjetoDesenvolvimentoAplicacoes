
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/28/2017 09:42:46
-- Generated from EDMX file: C:\Users\2161728\Desktop\Projeto DA\Arcmage\Arcmage\Arcmage\Data Modelo.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [arcmage];
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

-- Creating table 'UtilizadorSet'
CREATE TABLE [dbo].[UtilizadorSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Username] nvarchar(max)  NOT NULL,
    [Password] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'TorneioSet'
CREATE TABLE [dbo].[TorneioSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Data] datetime  NOT NULL,
    [Descricao] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'JogoSet'
CREATE TABLE [dbo].[JogoSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Descricao] nvarchar(max)  NOT NULL,
    [Data] datetime  NOT NULL,
    [Numero] int  NOT NULL,
    [Arbitro_Id] int  NOT NULL,
    [Deck1_Id] int  NOT NULL,
    [Deck2_Id] int  NOT NULL
);
GO

-- Creating table 'DeckSet'
CREATE TABLE [dbo].[DeckSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'CartaSet'
CREATE TABLE [dbo].[CartaSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Facao] nvarchar(max)  NOT NULL,
    [Tipo] nvarchar(max)  NOT NULL,
    [Custo] nvarchar(max)  NOT NULL,
    [Lealdade] int  NOT NULL,
    [Texto] nvarchar(max)  NOT NULL,
    [Ataque] int  NULL,
    [Defesa] int  NULL
);
GO

-- Creating table 'EquipaSet'
CREATE TABLE [dbo].[EquipaSet] (
    [Id] int IDENTITY(1,1) NOT NULL
);
GO

-- Creating table 'JogadorSet'
CREATE TABLE [dbo].[JogadorSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [Nickname] nvarchar(max)  NOT NULL,
    [Idade] int  NOT NULL,
    [Avatar] nvarchar(max)  NOT NULL,
    [JogoNormal1_Id] int  NOT NULL,
    [JogoNormal2_Id] int  NOT NULL
);
GO

-- Creating table 'UtilizadorSet_Arbitro'
CREATE TABLE [dbo].[UtilizadorSet_Arbitro] (
    [Nome] nvarchar(max)  NOT NULL,
    [Avatar] nvarchar(max)  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- Creating table 'JogoSet_JogoEquipa'
CREATE TABLE [dbo].[JogoSet_JogoEquipa] (
    [Id] int  NOT NULL,
    [Equipa1_Id] int  NOT NULL,
    [Equipa2_Id] int  NOT NULL,
    [TorneioEquipa_Id] int  NOT NULL
);
GO

-- Creating table 'JogoSet_JogoNormal'
CREATE TABLE [dbo].[JogoSet_JogoNormal] (
    [Id] int  NOT NULL,
    [TorneioNormal_Id] int  NOT NULL
);
GO

-- Creating table 'TorneioSet_TorneioNormal'
CREATE TABLE [dbo].[TorneioSet_TorneioNormal] (
    [Id] int  NOT NULL
);
GO

-- Creating table 'TorneioSet_TorneioEquipa'
CREATE TABLE [dbo].[TorneioSet_TorneioEquipa] (
    [Id] int  NOT NULL
);
GO

-- Creating table 'UtilizadorSet_Administrador'
CREATE TABLE [dbo].[UtilizadorSet_Administrador] (
    [Email] nvarchar(max)  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- Creating table 'DeckCarta'
CREATE TABLE [dbo].[DeckCarta] (
    [Deck_Id] int  NOT NULL,
    [Carta_Id] int  NOT NULL
);
GO

-- Creating table 'EquipaTorneioEquipa'
CREATE TABLE [dbo].[EquipaTorneioEquipa] (
    [Equipa_Id] int  NOT NULL,
    [TorneioEquipa_Id] int  NOT NULL
);
GO

-- Creating table 'TorneioNormalJogador'
CREATE TABLE [dbo].[TorneioNormalJogador] (
    [TorneioNormal_Id] int  NOT NULL,
    [Jogador_Id] int  NOT NULL
);
GO

-- Creating table 'EquipaJogador'
CREATE TABLE [dbo].[EquipaJogador] (
    [Equipa_Id] int  NOT NULL,
    [Jogador_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'UtilizadorSet'
ALTER TABLE [dbo].[UtilizadorSet]
ADD CONSTRAINT [PK_UtilizadorSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TorneioSet'
ALTER TABLE [dbo].[TorneioSet]
ADD CONSTRAINT [PK_TorneioSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'JogoSet'
ALTER TABLE [dbo].[JogoSet]
ADD CONSTRAINT [PK_JogoSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'DeckSet'
ALTER TABLE [dbo].[DeckSet]
ADD CONSTRAINT [PK_DeckSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CartaSet'
ALTER TABLE [dbo].[CartaSet]
ADD CONSTRAINT [PK_CartaSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'EquipaSet'
ALTER TABLE [dbo].[EquipaSet]
ADD CONSTRAINT [PK_EquipaSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'JogadorSet'
ALTER TABLE [dbo].[JogadorSet]
ADD CONSTRAINT [PK_JogadorSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'UtilizadorSet_Arbitro'
ALTER TABLE [dbo].[UtilizadorSet_Arbitro]
ADD CONSTRAINT [PK_UtilizadorSet_Arbitro]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'JogoSet_JogoEquipa'
ALTER TABLE [dbo].[JogoSet_JogoEquipa]
ADD CONSTRAINT [PK_JogoSet_JogoEquipa]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'JogoSet_JogoNormal'
ALTER TABLE [dbo].[JogoSet_JogoNormal]
ADD CONSTRAINT [PK_JogoSet_JogoNormal]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TorneioSet_TorneioNormal'
ALTER TABLE [dbo].[TorneioSet_TorneioNormal]
ADD CONSTRAINT [PK_TorneioSet_TorneioNormal]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TorneioSet_TorneioEquipa'
ALTER TABLE [dbo].[TorneioSet_TorneioEquipa]
ADD CONSTRAINT [PK_TorneioSet_TorneioEquipa]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'UtilizadorSet_Administrador'
ALTER TABLE [dbo].[UtilizadorSet_Administrador]
ADD CONSTRAINT [PK_UtilizadorSet_Administrador]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Deck_Id], [Carta_Id] in table 'DeckCarta'
ALTER TABLE [dbo].[DeckCarta]
ADD CONSTRAINT [PK_DeckCarta]
    PRIMARY KEY CLUSTERED ([Deck_Id], [Carta_Id] ASC);
GO

-- Creating primary key on [Equipa_Id], [TorneioEquipa_Id] in table 'EquipaTorneioEquipa'
ALTER TABLE [dbo].[EquipaTorneioEquipa]
ADD CONSTRAINT [PK_EquipaTorneioEquipa]
    PRIMARY KEY CLUSTERED ([Equipa_Id], [TorneioEquipa_Id] ASC);
GO

-- Creating primary key on [TorneioNormal_Id], [Jogador_Id] in table 'TorneioNormalJogador'
ALTER TABLE [dbo].[TorneioNormalJogador]
ADD CONSTRAINT [PK_TorneioNormalJogador]
    PRIMARY KEY CLUSTERED ([TorneioNormal_Id], [Jogador_Id] ASC);
GO

-- Creating primary key on [Equipa_Id], [Jogador_Id] in table 'EquipaJogador'
ALTER TABLE [dbo].[EquipaJogador]
ADD CONSTRAINT [PK_EquipaJogador]
    PRIMARY KEY CLUSTERED ([Equipa_Id], [Jogador_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Arbitro_Id] in table 'JogoSet'
ALTER TABLE [dbo].[JogoSet]
ADD CONSTRAINT [FK_ArbitroJogo]
    FOREIGN KEY ([Arbitro_Id])
    REFERENCES [dbo].[UtilizadorSet_Arbitro]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ArbitroJogo'
CREATE INDEX [IX_FK_ArbitroJogo]
ON [dbo].[JogoSet]
    ([Arbitro_Id]);
GO

-- Creating foreign key on [Deck1_Id] in table 'JogoSet'
ALTER TABLE [dbo].[JogoSet]
ADD CONSTRAINT [FK_DeckJogo]
    FOREIGN KEY ([Deck1_Id])
    REFERENCES [dbo].[DeckSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DeckJogo'
CREATE INDEX [IX_FK_DeckJogo]
ON [dbo].[JogoSet]
    ([Deck1_Id]);
GO

-- Creating foreign key on [Deck2_Id] in table 'JogoSet'
ALTER TABLE [dbo].[JogoSet]
ADD CONSTRAINT [FK_DeckJogo1]
    FOREIGN KEY ([Deck2_Id])
    REFERENCES [dbo].[DeckSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DeckJogo1'
CREATE INDEX [IX_FK_DeckJogo1]
ON [dbo].[JogoSet]
    ([Deck2_Id]);
GO

-- Creating foreign key on [Deck_Id] in table 'DeckCarta'
ALTER TABLE [dbo].[DeckCarta]
ADD CONSTRAINT [FK_DeckCarta_Deck]
    FOREIGN KEY ([Deck_Id])
    REFERENCES [dbo].[DeckSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Carta_Id] in table 'DeckCarta'
ALTER TABLE [dbo].[DeckCarta]
ADD CONSTRAINT [FK_DeckCarta_Carta]
    FOREIGN KEY ([Carta_Id])
    REFERENCES [dbo].[CartaSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DeckCarta_Carta'
CREATE INDEX [IX_FK_DeckCarta_Carta]
ON [dbo].[DeckCarta]
    ([Carta_Id]);
GO

-- Creating foreign key on [Equipa1_Id] in table 'JogoSet_JogoEquipa'
ALTER TABLE [dbo].[JogoSet_JogoEquipa]
ADD CONSTRAINT [FK_JogoEquipaEquipa]
    FOREIGN KEY ([Equipa1_Id])
    REFERENCES [dbo].[EquipaSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_JogoEquipaEquipa'
CREATE INDEX [IX_FK_JogoEquipaEquipa]
ON [dbo].[JogoSet_JogoEquipa]
    ([Equipa1_Id]);
GO

-- Creating foreign key on [Equipa2_Id] in table 'JogoSet_JogoEquipa'
ALTER TABLE [dbo].[JogoSet_JogoEquipa]
ADD CONSTRAINT [FK_JogoEquipaEquipa1]
    FOREIGN KEY ([Equipa2_Id])
    REFERENCES [dbo].[EquipaSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_JogoEquipaEquipa1'
CREATE INDEX [IX_FK_JogoEquipaEquipa1]
ON [dbo].[JogoSet_JogoEquipa]
    ([Equipa2_Id]);
GO

-- Creating foreign key on [JogoNormal1_Id] in table 'JogadorSet'
ALTER TABLE [dbo].[JogadorSet]
ADD CONSTRAINT [FK_JogoNormalJogador]
    FOREIGN KEY ([JogoNormal1_Id])
    REFERENCES [dbo].[JogoSet_JogoNormal]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_JogoNormalJogador'
CREATE INDEX [IX_FK_JogoNormalJogador]
ON [dbo].[JogadorSet]
    ([JogoNormal1_Id]);
GO

-- Creating foreign key on [JogoNormal2_Id] in table 'JogadorSet'
ALTER TABLE [dbo].[JogadorSet]
ADD CONSTRAINT [FK_JogoNormalJogador1]
    FOREIGN KEY ([JogoNormal2_Id])
    REFERENCES [dbo].[JogoSet_JogoNormal]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_JogoNormalJogador1'
CREATE INDEX [IX_FK_JogoNormalJogador1]
ON [dbo].[JogadorSet]
    ([JogoNormal2_Id]);
GO

-- Creating foreign key on [TorneioNormal_Id] in table 'JogoSet_JogoNormal'
ALTER TABLE [dbo].[JogoSet_JogoNormal]
ADD CONSTRAINT [FK_JogoNormalTorneioNormal]
    FOREIGN KEY ([TorneioNormal_Id])
    REFERENCES [dbo].[TorneioSet_TorneioNormal]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_JogoNormalTorneioNormal'
CREATE INDEX [IX_FK_JogoNormalTorneioNormal]
ON [dbo].[JogoSet_JogoNormal]
    ([TorneioNormal_Id]);
GO

-- Creating foreign key on [TorneioEquipa_Id] in table 'JogoSet_JogoEquipa'
ALTER TABLE [dbo].[JogoSet_JogoEquipa]
ADD CONSTRAINT [FK_JogoEquipaTorneioEquipa]
    FOREIGN KEY ([TorneioEquipa_Id])
    REFERENCES [dbo].[TorneioSet_TorneioEquipa]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_JogoEquipaTorneioEquipa'
CREATE INDEX [IX_FK_JogoEquipaTorneioEquipa]
ON [dbo].[JogoSet_JogoEquipa]
    ([TorneioEquipa_Id]);
GO

-- Creating foreign key on [Equipa_Id] in table 'EquipaTorneioEquipa'
ALTER TABLE [dbo].[EquipaTorneioEquipa]
ADD CONSTRAINT [FK_EquipaTorneioEquipa_Equipa]
    FOREIGN KEY ([Equipa_Id])
    REFERENCES [dbo].[EquipaSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [TorneioEquipa_Id] in table 'EquipaTorneioEquipa'
ALTER TABLE [dbo].[EquipaTorneioEquipa]
ADD CONSTRAINT [FK_EquipaTorneioEquipa_TorneioEquipa]
    FOREIGN KEY ([TorneioEquipa_Id])
    REFERENCES [dbo].[TorneioSet_TorneioEquipa]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EquipaTorneioEquipa_TorneioEquipa'
CREATE INDEX [IX_FK_EquipaTorneioEquipa_TorneioEquipa]
ON [dbo].[EquipaTorneioEquipa]
    ([TorneioEquipa_Id]);
GO

-- Creating foreign key on [TorneioNormal_Id] in table 'TorneioNormalJogador'
ALTER TABLE [dbo].[TorneioNormalJogador]
ADD CONSTRAINT [FK_TorneioNormalJogador_TorneioNormal]
    FOREIGN KEY ([TorneioNormal_Id])
    REFERENCES [dbo].[TorneioSet_TorneioNormal]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Jogador_Id] in table 'TorneioNormalJogador'
ALTER TABLE [dbo].[TorneioNormalJogador]
ADD CONSTRAINT [FK_TorneioNormalJogador_Jogador]
    FOREIGN KEY ([Jogador_Id])
    REFERENCES [dbo].[JogadorSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TorneioNormalJogador_Jogador'
CREATE INDEX [IX_FK_TorneioNormalJogador_Jogador]
ON [dbo].[TorneioNormalJogador]
    ([Jogador_Id]);
GO

-- Creating foreign key on [Equipa_Id] in table 'EquipaJogador'
ALTER TABLE [dbo].[EquipaJogador]
ADD CONSTRAINT [FK_EquipaJogador_Equipa]
    FOREIGN KEY ([Equipa_Id])
    REFERENCES [dbo].[EquipaSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Jogador_Id] in table 'EquipaJogador'
ALTER TABLE [dbo].[EquipaJogador]
ADD CONSTRAINT [FK_EquipaJogador_Jogador]
    FOREIGN KEY ([Jogador_Id])
    REFERENCES [dbo].[JogadorSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EquipaJogador_Jogador'
CREATE INDEX [IX_FK_EquipaJogador_Jogador]
ON [dbo].[EquipaJogador]
    ([Jogador_Id]);
GO

-- Creating foreign key on [Id] in table 'UtilizadorSet_Arbitro'
ALTER TABLE [dbo].[UtilizadorSet_Arbitro]
ADD CONSTRAINT [FK_Arbitro_inherits_Utilizador]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[UtilizadorSet]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'JogoSet_JogoEquipa'
ALTER TABLE [dbo].[JogoSet_JogoEquipa]
ADD CONSTRAINT [FK_JogoEquipa_inherits_Jogo]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[JogoSet]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'JogoSet_JogoNormal'
ALTER TABLE [dbo].[JogoSet_JogoNormal]
ADD CONSTRAINT [FK_JogoNormal_inherits_Jogo]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[JogoSet]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'TorneioSet_TorneioNormal'
ALTER TABLE [dbo].[TorneioSet_TorneioNormal]
ADD CONSTRAINT [FK_TorneioNormal_inherits_Torneio]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[TorneioSet]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'TorneioSet_TorneioEquipa'
ALTER TABLE [dbo].[TorneioSet_TorneioEquipa]
ADD CONSTRAINT [FK_TorneioEquipa_inherits_Torneio]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[TorneioSet]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'UtilizadorSet_Administrador'
ALTER TABLE [dbo].[UtilizadorSet_Administrador]
ADD CONSTRAINT [FK_Administrador_inherits_Utilizador]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[UtilizadorSet]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------