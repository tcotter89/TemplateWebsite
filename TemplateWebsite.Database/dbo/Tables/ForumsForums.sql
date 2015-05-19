CREATE TABLE [dbo].[ForumsForums] (
    [ForumID]  INT           IDENTITY (1, 1) NOT NULL,
    [Title]    NVARCHAR (50) NOT NULL,
    [SubTitle] NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_ForumsForums] PRIMARY KEY CLUSTERED ([ForumID] ASC)
);

