CREATE TABLE [dbo].[ForumsPosts] (
    [PostID]     INT            IDENTITY (1, 1) NOT NULL,
    [TopicID]    INT            NOT NULL,
    [Content]    NVARCHAR (MAX) NOT NULL,
    [IsBasePost] BIT            NOT NULL,
    [UserID]     INT            NOT NULL,
    [IP]         NVARCHAR (40)  NOT NULL,
    [PostDate]   DATETIME       NOT NULL,
    [EditDate]   DATETIME       NOT NULL,
    CONSTRAINT [PK_ForumsPosts] PRIMARY KEY CLUSTERED ([PostID] ASC),
    CONSTRAINT [FK_ForumsPostsForumsTopics] FOREIGN KEY ([TopicID]) REFERENCES [dbo].[ForumsTopics] ([TopicID]),
    CONSTRAINT [FK_ForumsPostsUsers] FOREIGN KEY ([UserID]) REFERENCES [dbo].[WebsiteUsers] ([UserID])
);

