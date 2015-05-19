CREATE TABLE [dbo].[Updates] (
    [UpdateID]      INT            IDENTITY (1, 1) NOT NULL,
    [VersionNum]    NVARCHAR (50)  NOT NULL,
    [Comment]       NVARCHAR (200) NULL,
    [UpdateNotes]   NVARCHAR (MAX) NULL,
    [CreatedDate]   DATETIME       NOT NULL,
    [EffectiveDate] DATETIME       NULL,
    CONSTRAINT [PK_Updates] PRIMARY KEY CLUSTERED ([UpdateID] ASC)
);

