USE [WebsiteDatabase]

IF  NOT EXISTS (SELECT * FROM sys.objects 
				WHERE object_id = OBJECT_ID(N'[dbo].[Updates]') AND type in (N'U'))
					BEGIN
						CREATE TABLE Updates (
							UpdateID INT IDENTITY(1,1) NOT NULL,
							VersionNum NVARCHAR(50) NOT NULL,
							Comment NVARCHAR(200),
							UpdateNotes NVARCHAR(MAX),
							CreatedDate DATETIME NOT NULL,
							EffectiveDate DATETIME
							CONSTRAINT PK_Updates PRIMARY KEY (UpdateID)
						);
					END
GO

--INSERT INTO Updates (VersionNum,   Comment, CreatedDate, EffectiveDate, UpdateNotes)
--              VALUES(   '1.0.0', 'Release', '2015-04-08 13:48:34.953', '2015-04-08 13:48:34.953', 'This update is the release of the game to the public. Users are now able to create characters on the servers and begin playing immediately. For general tips and information on how the game works, see the "Game Guide" on the main website meun. Sincerely, The Staff')

--SELECT * FROM Updates

IF  NOT EXISTS (SELECT * FROM sys.objects 
				WHERE object_id = OBJECT_ID(N'[dbo].[MediaScreenshots]') AND type in (N'U'))
					BEGIN
						CREATE TABLE MediaScreenshots (
							ScreenshotID INT IDENTITY(1,1) NOT NULL,
							AlternateText NVARCHAR(50) NOT NULL,
							URL NVARCHAR(MAX) NOT NULL,
							ResolutionX INT NOT NULL,
							ResolutionY INT NOT NULL,
							ThumbnailURL NVARCHAR(MAX),
							ThumbnailResolutionX INT,
							ThumbnailResolutionY INT,
							CreatedDate DATETIME
							CONSTRAINT PK_MediaScreenshots PRIMARY KEY (ScreenshotID)
						);
					END
GO

--INSERT INTO MediaScreenshots (AlternateText,                                         URL, ResolutionX, ResolutionY,                              ThumbnailURL, ThumbnailResolutionX, ThumbnailResolutionY,   CreatedDate)
--                      VALUES (      'Zurich', '/Images/Screenshots/Zurich-1920.1080.jpg',        1920,        1080,  '/Images/Screenshots/Zurich-380.213.jpg',                  380,                  213, SYSDATETIME())

IF  NOT EXISTS (SELECT * FROM sys.objects 
				WHERE object_id = OBJECT_ID(N'[dbo].[WebsiteUsers]') AND type in (N'U'))
					BEGIN
						CREATE TABLE WebsiteUsers (
							UserID INT IDENTITY(1,1) NOT NULL,
							Username NVARCHAR(20) NOT NULL,
							Email NVARCHAR(50) NOT NULL,
							HashedPassword NVARCHAR(100) NOT NULL,
							CreatedOnDate DATETIME NOT NULL,
							LastLoginDate DATETIME NOT NULL,
							CONSTRAINT PK_Users PRIMARY KEY (UserID)
						);
					END
GO

INSERT INTO WebsiteUsers (Username,               Email, HashedPassword, CreatedOnDate, LastLoginDate)
                  VALUES ('Thomas', 'tcotter@gmail.com',   'morrowind0', SYSDATETIME(), SYSDATETIME())

IF  NOT EXISTS (SELECT * FROM sys.objects 
				WHERE object_id = OBJECT_ID(N'[dbo].[ForumsForums]') AND type in (N'U'))
					BEGIN
						CREATE TABLE ForumsForums (
							ForumID INT IDENTITY(1,1) NOT NULL,
							Title NVARCHAR(50) NOT NULL,
							SubTitle NVARCHAR(50) NOT NULL,
							CONSTRAINT PK_ForumsForums PRIMARY KEY (ForumID)
						);
					END
GO

INSERT INTO ForumsForums ( Title,                                        SubTitle)
                  VALUES ('News', 'Announcements and other important information')

IF  NOT EXISTS (SELECT * FROM sys.objects 
				WHERE object_id = OBJECT_ID(N'[dbo].[ForumsTopics]') AND type in (N'U'))
					BEGIN
						CREATE TABLE ForumsTopics (
							TopicID INT IDENTITY(1,1) NOT NULL,
							ForumID INT NOT NULL,
							Title NVARCHAR(50) NOT NULL
							CONSTRAINT PK_ForumsTopics PRIMARY KEY (TopicID),
							CONSTRAINT FK_ForumsTopicsForumsForums FOREIGN KEY (ForumID) REFERENCES ForumsForums(ForumID)
						);
					END
GO

INSERT INTO ForumsTopics (ForumID,                        Title)
                  VALUES (      1, 'Welcome to TemplateWebsite')

IF  NOT EXISTS (SELECT * FROM sys.objects 
				WHERE object_id = OBJECT_ID(N'[dbo].[ForumsPosts]') AND type in (N'U'))
					BEGIN
						CREATE TABLE ForumsPosts (
							PostID INT IDENTITY(1,1) NOT NULL,
							TopicID INT NOT NULL,
							Content NVARCHAR(MAX) NOT NULL,
							IsBasePost BIT NOT NULL,
							UserID INT NOT NULL,
							IP NVARCHAR(40) NOT NULL,
							PostDate DATETIME NOT NULL,
							EditDate DATETIME NOT NULL,
							CONSTRAINT PK_ForumsPosts PRIMARY KEY (PostID),
							CONSTRAINT FK_ForumsPostsForumsTopics FOREIGN KEY (TopicID) REFERENCES ForumsTopics(TopicID),
							CONSTRAINT FK_ForumsPostsUsers FOREIGN KEY (UserID) REFERENCES WebsiteUsers(UserID)
						);
					END
GO

INSERT INTO ForumsPosts (TopicID,                                                                                    Content, IsBasePost, UserID,        IP,      PostDate,      EditDate)
                 VALUES (      1, '<p>The staff would like to welcome all members to the office TemplateWebsite forums.</p>',          1,      1, '0.0.0.1', SYSDATETIME(), SYSDATETIME())