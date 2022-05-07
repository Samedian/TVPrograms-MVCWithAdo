USE [Samarth]
GO

CREATE TABLE [dbo].[TVProgram](
	[TVProgramId] [int] IDENTITY(1,1) NOT NULL,
	[TVProgramName] [varchar](20) NOT NULL,
	[TVProgramCategory] [varchar](20) NULL,
	[TVProgramChannelName] [varchar](20) NULL,
	[TVProgramDesc] [varchar](20) NULL,
	[TVProgramDuration] [varchar](10) NULL,
)
GO

ALTER TABLE [dbo].[TVProgram]
ADD PRIMARY KEY([TVProgramId]) 
Go;
ALTER TABLE [dbo].[TVProgram]
ADD UNIQUE ([TVProgramName]) 
Go;
ALTER TABLE [dbo].[TVProgram]  WITH CHECK ADD FOREIGN KEY([TVProgramChannelName])
REFERENCES [dbo].[TVChannel] ([TVChannelName])
GO


