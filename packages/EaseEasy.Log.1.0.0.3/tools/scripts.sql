--错误日志
CREATE TABLE [dbo].[Sys_Error](
    [ID] [int] IDENTITY(1,1) NOT NULL,
    [LogTime] [datetime] NOT NULL,
    [Content] [text]  NULL,
    [UserID] [varchar](50)  NULL,
    [UserName] [nvarchar](50)  NULL,
    [Application] [nvarchar](50)  NULL,
    [Module] [nvarchar](50)  NULL,
    [Function] [nvarchar](50)  NULL,
    [Action] [nvarchar](50)  NULL,
    [Url] [varchar](500)  NULL,
    [ExceptionStack] [text]  NULL,
    [ExceptionType] [nvarchar](50)  NULL
 CONSTRAINT [PK_Sys_Error] PRIMARY KEY CLUSTERED
(
    [ID] ASC
))
 
--操作日志
CREATE TABLE [dbo].[Sys_Log](
    [ID] [int] IDENTITY(1,1) NOT NULL,
    [LogTime] [datetime] NOT NULL,
    [Content] [text] NULL,
    [UserID] [varchar](50) NULL,
    [UserName] [nvarchar](50) NULL,
    [Application] [nvarchar](50) NULL,
    [Module] [nvarchar](50) NULL,
    [Function] [nvarchar](50) NULL,
    [Action] [nvarchar](50) NULL,
    [Url] [varchar](500) NULL,
    [LogType] [varchar](50) NULL,
 CONSTRAINT [PK_Sys_Log] PRIMARY KEY CLUSTERED
(
    [ID] ASC
))