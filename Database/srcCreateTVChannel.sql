USE [Samarth]
GO

CREATE TABLE [dbo].[TVChannel](
	[TVChannelId] [int] IDENTITY(1,1) NOT NULL,
	[TVChannelName] [varchar](20) NOT NULL,
	[TVChannelType] [varchar](20) NOT NULL,
	[Description] [varchar](20) NULL,
)
GO

ALTER TABLE [dbo].[TVChannel]
ADD PRIMARY KEY([TVChannelId]) 
Go;
ALTER TABLE [dbo].[TVChannel]
ADD UNIQUE ([TVChannelName]) 
Go;



