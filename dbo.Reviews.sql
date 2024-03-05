CREATE TABLE [dbo].[Reviews] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (MAX) NOT NULL,
    [Description] NVARCHAR (MAX) NOT NULL,
    [MovieId]     INT            NOT NULL,
    CONSTRAINT [PK_Reviews] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_MovieReview] FOREIGN KEY ([MovieId]) REFERENCES [dbo].[Movies] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_FK_MovieReview]
    ON [dbo].[Reviews]([MovieId] ASC);

