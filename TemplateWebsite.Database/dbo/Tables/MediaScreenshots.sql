CREATE TABLE [dbo].[MediaScreenshots] (
    [ScreenshotID]         INT            IDENTITY (1, 1) NOT NULL,
    [AlternateText]        NVARCHAR (50)  NOT NULL,
    [URL]                  NVARCHAR (MAX) NOT NULL,
    [ResolutionX]          INT            NOT NULL,
    [ResolutionY]          INT            NOT NULL,
    [ThumbnailURL]         NVARCHAR (MAX) NULL,
    [ThumbnailResolutionX] INT            NULL,
    [ThumbnailResolutionY] INT            NULL,
    [CreatedDate]          DATETIME       NULL,
    CONSTRAINT [PK_MediaScreenshots] PRIMARY KEY CLUSTERED ([ScreenshotID] ASC)
);

