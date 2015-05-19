CREATE TABLE [dbo].[WebsiteUsers] (
    [UserID]         INT            IDENTITY (1, 1) NOT NULL,
    [Username]       NVARCHAR (20)  NOT NULL,
    [Email]          NVARCHAR (50)  NOT NULL,
    [HashedPassword] NVARCHAR (100) NOT NULL,
    [CreatedOnDate]  DATETIME       NOT NULL,
    [LastLoginDate]  DATETIME       NOT NULL,
    CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED ([UserID] ASC)
);

