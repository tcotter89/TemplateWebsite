CREATE TABLE [dbo].[ForumsTopics] (
    [TopicID] INT           IDENTITY (1, 1) NOT NULL,
    [ForumID] INT           NOT NULL,
    [Title]   NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_ForumsTopics] PRIMARY KEY CLUSTERED ([TopicID] ASC),
    CONSTRAINT [FK_ForumsTopicsForumsForums] FOREIGN KEY ([ForumID]) REFERENCES [dbo].[ForumsForums] ([ForumID])
);

