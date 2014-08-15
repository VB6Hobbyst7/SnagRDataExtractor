

/****** Object:  Table [dbo].[tSnagRFormsDataControl]    Script Date: 09/02/2013 19:13:07 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tSnagRFormsDataControl](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Datestamp] [datetime] NULL,
	[fromURL] [nvarchar](250) NULL,
 CONSTRAINT [PK_tSnagRFormsDataControl] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[tSnagRFormsDataControl] ADD  CONSTRAINT [DF_tSnagRFormsDataControl_Datestamp]  DEFAULT (getdate()) FOR [Datestamp]
GO

ALTER TABLE [dbo].[tSnagRFormsDataControl] ADD  CONSTRAINT [DF_tSnagRFormsDataControl_fromURL]  DEFAULT ('') FOR [fromURL]
GO



/****** Object:  Table [dbo].[tSnagRInspectionData]    Script Date: 09/14/2013 12:21:55 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tSnagRInspectionData](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ProjectTitle] [nvarchar](500) NULL,
	[ContractNo] [nvarchar](500) NULL,
	[Drawing] [nvarchar](500) NULL,
	[DrwgID] [int] NULL,
	[InspectionName] [nvarchar](500) NULL,
	[Location] [nvarchar](500) NULL,
	[LocID] [int] NULL,
	[LocationExtRef] [nchar](50) NULL,
	[PlotID] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedBy] [nvarchar](500) NULL,
	[Status] [nvarchar](500) NULL,
	[ClosedDate] [datetime] NULL,
	[ClosedBy] [nvarchar](500) NULL,
	[PPCGUID] [nvarchar](500) NULL,
	[CSStart] [datetime] NULL,
	[CSFinish] [datetime] NULL,
	[RIGUID] [nvarchar](500) NULL,
	[FormID] [int] NULL,
	[FormCode] [nvarchar](500) NULL,
	[FormName] [nvarchar](500) NULL,
	[FormShortName] [nvarchar](500) NULL,
	[IssuedDate] [datetime] NULL,
	[ValidUntil] [datetime] NULL,
	[IssuedTo] [nvarchar](500) NULL,
	[IssuedBy] [nvarchar](500) NULL,
	[AcceptedBy] [nvarchar](500) NULL,
	[Closed] [bit] NULL,
	[Passed] [bit] NULL,
	[CheckCode] [nvarchar](500) NULL,
	[Categ] [nvarchar](500) NULL,
	[Question] [nvarchar](500) NULL,
	[srt] [nvarchar](500) NULL,
	[Result] [bit] NULL,
	[ResultText] [nvarchar](500) NULL,
	[ResultImg] [image] NULL,
	[FIAID] [int] NULL,
	[Username] [nvarchar](500) NULL,
	[Datestamp] [datetime] NULL,
	[AnswerType] [nvarchar](500) NULL,
	[Mandatory] [bit] NULL,
	[PageNo] [int] NULL,
	[FCID] [int] NULL,
	[ListCode] [nvarchar](500) NULL,
	[LinkCheckCode] [nvarchar](500) NULL,
	[FCGUID] [nvarchar](500) NULL,
	[AutoSnagged] [bit] NULL,
 CONSTRAINT [PK_tSnagRInspectionData] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

ALTER TABLE [dbo].[tSnagRInspectionData] ADD  CONSTRAINT [DF_tSnagRInspectionData_ProjectTitle]  DEFAULT ('') FOR [ProjectTitle]
GO

ALTER TABLE [dbo].[tSnagRInspectionData] ADD  CONSTRAINT [DF_tSnagRInspectionData_ContractNo]  DEFAULT ('') FOR [ContractNo]
GO

ALTER TABLE [dbo].[tSnagRInspectionData] ADD  CONSTRAINT [DF_tSnagRInspectionData_Drawing]  DEFAULT ('') FOR [Drawing]
GO

ALTER TABLE [dbo].[tSnagRInspectionData] ADD  CONSTRAINT [DF_tSnagRInspectionData_DrwgID]  DEFAULT ((0)) FOR [DrwgID]
GO

ALTER TABLE [dbo].[tSnagRInspectionData] ADD  CONSTRAINT [DF_tSnagRInspectionData_InspectionName]  DEFAULT ('') FOR [InspectionName]
GO

ALTER TABLE [dbo].[tSnagRInspectionData] ADD  CONSTRAINT [DF_tSnagRInspectionData_Location]  DEFAULT ('') FOR [Location]
GO

ALTER TABLE [dbo].[tSnagRInspectionData] ADD  CONSTRAINT [DF_tSnagRInspectionData_LocID]  DEFAULT ((0)) FOR [LocID]
GO

ALTER TABLE [dbo].[tSnagRInspectionData] ADD  CONSTRAINT [DF_tSnagRInspectionData_LocationExtRef]  DEFAULT ('') FOR [LocationExtRef]
GO

ALTER TABLE [dbo].[tSnagRInspectionData] ADD  CONSTRAINT [DF_tSnagRInspectionData_PlotID]  DEFAULT ((0)) FOR [PlotID]
GO

ALTER TABLE [dbo].[tSnagRInspectionData] ADD  CONSTRAINT [DF_tSnagRInspectionData_CreatedBy]  DEFAULT ('') FOR [CreatedBy]
GO

ALTER TABLE [dbo].[tSnagRInspectionData] ADD  CONSTRAINT [DF_tSnagRInspectionData_Status]  DEFAULT ('') FOR [Status]
GO

ALTER TABLE [dbo].[tSnagRInspectionData] ADD  CONSTRAINT [DF_tSnagRInspectionData_CosedBy]  DEFAULT ('') FOR [ClosedBy]
GO

ALTER TABLE [dbo].[tSnagRInspectionData] ADD  CONSTRAINT [DF_tSnagRInspectionData_PPCGUID]  DEFAULT ('') FOR [PPCGUID]
GO

ALTER TABLE [dbo].[tSnagRInspectionData] ADD  CONSTRAINT [DF_tSnagRInspectionData_RIGUID]  DEFAULT ('') FOR [RIGUID]
GO

ALTER TABLE [dbo].[tSnagRInspectionData] ADD  CONSTRAINT [DF_tSnagRInspectionData_FormID]  DEFAULT ((0)) FOR [FormID]
GO

ALTER TABLE [dbo].[tSnagRInspectionData] ADD  CONSTRAINT [DF_tSnagRInspectionData_FormCode]  DEFAULT ('') FOR [FormCode]
GO

ALTER TABLE [dbo].[tSnagRInspectionData] ADD  CONSTRAINT [DF_tSnagRInspectionData_FormName]  DEFAULT ('') FOR [FormName]
GO

ALTER TABLE [dbo].[tSnagRInspectionData] ADD  CONSTRAINT [DF_tSnagRInspectionData_FormShortName]  DEFAULT ('') FOR [FormShortName]
GO

ALTER TABLE [dbo].[tSnagRInspectionData] ADD  CONSTRAINT [DF_tSnagRInspectionData_IssuedTo]  DEFAULT ('') FOR [IssuedTo]
GO

ALTER TABLE [dbo].[tSnagRInspectionData] ADD  CONSTRAINT [DF_tSnagRInspectionData_IssuedBy]  DEFAULT ('') FOR [IssuedBy]
GO

ALTER TABLE [dbo].[tSnagRInspectionData] ADD  CONSTRAINT [DF_tSnagRInspectionData_AcceptedBy]  DEFAULT ('') FOR [AcceptedBy]
GO

ALTER TABLE [dbo].[tSnagRInspectionData] ADD  CONSTRAINT [DF_tSnagRInspectionData_Closed]  DEFAULT ((0)) FOR [Closed]
GO

ALTER TABLE [dbo].[tSnagRInspectionData] ADD  CONSTRAINT [DF_tSnagRInspectionData_Passed]  DEFAULT ((0)) FOR [Passed]
GO

ALTER TABLE [dbo].[tSnagRInspectionData] ADD  CONSTRAINT [DF_tSnagRInspectionData_CheckCode]  DEFAULT ('') FOR [CheckCode]
GO

ALTER TABLE [dbo].[tSnagRInspectionData] ADD  CONSTRAINT [DF_tSnagRInspectionData_Categ]  DEFAULT ('') FOR [Categ]
GO

ALTER TABLE [dbo].[tSnagRInspectionData] ADD  CONSTRAINT [DF_tSnagRInspectionData_Question]  DEFAULT ('') FOR [Question]
GO

ALTER TABLE [dbo].[tSnagRInspectionData] ADD  CONSTRAINT [DF_tSnagRInspectionData_srt]  DEFAULT ('') FOR [srt]
GO

ALTER TABLE [dbo].[tSnagRInspectionData] ADD  CONSTRAINT [DF_tSnagRInspectionData_Result]  DEFAULT ((0)) FOR [Result]
GO

ALTER TABLE [dbo].[tSnagRInspectionData] ADD  CONSTRAINT [DF_tSnagRInspectionData_ResultText]  DEFAULT ('') FOR [ResultText]
GO

ALTER TABLE [dbo].[tSnagRInspectionData] ADD  CONSTRAINT [DF_tSnagRInspectionData_FIAID]  DEFAULT ((0)) FOR [FIAID]
GO

ALTER TABLE [dbo].[tSnagRInspectionData] ADD  CONSTRAINT [DF_tSnagRInspectionData_Username]  DEFAULT ('') FOR [Username]
GO

ALTER TABLE [dbo].[tSnagRInspectionData] ADD  CONSTRAINT [DF_tSnagRInspectionData_AnswerType]  DEFAULT ('') FOR [AnswerType]
GO

ALTER TABLE [dbo].[tSnagRInspectionData] ADD  CONSTRAINT [DF_tSnagRInspectionData_PageNo]  DEFAULT ((0)) FOR [PageNo]
GO

ALTER TABLE [dbo].[tSnagRInspectionData] ADD  CONSTRAINT [DF_tSnagRInspectionData_FCID]  DEFAULT ((0)) FOR [FCID]
GO

ALTER TABLE [dbo].[tSnagRInspectionData] ADD  CONSTRAINT [DF_tSnagRInspectionData_ListCode]  DEFAULT ('') FOR [ListCode]
GO

ALTER TABLE [dbo].[tSnagRInspectionData] ADD  CONSTRAINT [DF_tSnagRInspectionData_LinkCheckCode]  DEFAULT ('') FOR [LinkCheckCode]
GO

ALTER TABLE [dbo].[tSnagRInspectionData] ADD  CONSTRAINT [DF_tSnagRInspectionData_FCGUID]  DEFAULT ('') FOR [FCGUID]
GO

ALTER TABLE [dbo].[tSnagRInspectionData] ADD  CONSTRAINT [DF_tSnagRInspectionData_AutoSnagged]  DEFAULT ((0)) FOR [AutoSnagged]
GO


/****** Object:  View [dbo].[qLatestQuestionIDs]    Script Date: 10/02/2013 18:24:59 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[qLatestQuestionIDs]
AS
SELECT     MAX(ID) AS maxID, PlotID, CheckCode
FROM         dbo.tSnagRInspectionData
GROUP BY PlotID, CheckCode

GO

/****** Object:  View [dbo].[qLatestInspectionData]    Script Date: 10/02/2013 18:26:42 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[qLatestInspectionData]
AS
SELECT     dbo.tSnagRInspectionData.*
FROM         dbo.tSnagRInspectionData INNER JOIN
                      dbo.qLatestQuestionIDs ON dbo.tSnagRInspectionData.ID = dbo.qLatestQuestionIDs.maxID AND dbo.tSnagRInspectionData.PlotID = dbo.qLatestQuestionIDs.PlotID

GO

-- Defects section

/****** Object:  Table [dbo].[tProjectSnags]    Script Date: 10/07/2013 12:30:39 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  Table [dbo].[tProjectSnags]    Script Date: 10/14/2013 08:49:38 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tProjectSnags](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ProjectTitle] [nvarchar](500) NULL,
	[ContractNo] [nvarchar](500) NULL,
	[Drawing] [nvarchar](500) NULL,
	[SnagID] [int] NULL,
	[ProjectLinkID] [int] NULL,
	[DrwgID] [int] NULL,
	[Status] [nvarchar](10) NULL,
	[ShortDescrip] [nvarchar](1000) NULL,
	[LocID] [int] NULL,
	[LocationExtRef] [nvarchar](20) NULL,
	[Location] [nvarchar](50) NULL,
	[Xcoord] [int] NULL,
	[YCoord] [int] NULL,
	[Priority] [int] NULL,
	[Datestamp] [datetime] NULL,
	[DrwgLink] [int] NULL,
	[Photo] [image] NULL,
	[DoBy] [datetime] NULL,
	[GroupID] [int] NULL,
	[GroupInits] [nvarchar](8) NULL,
	[DateClosed] [datetime] NULL,
	[BigPhoto] [image] NULL,
	[Lat] [float] NULL,
	[Lng] [float] NULL,
	[Owner] [int] NULL,
	[SDCode] [nvarchar](10) NULL,
	[SDID] [int] NULL,
	[DateSync] [datetime] NULL,
	[FixStatus] [nvarchar](10) NULL,
	[MPGUID] [nvarchar](50) NULL,
	[Purge] [int] NULL,
	[DaysLeft] [int] NULL,
	[DrwgSrt] [int] NULL,
	[DrwgTitle] [nvarchar](50) NULL,
	[FixDescrip] [nvarchar](250) NULL,
	[By] [int] NULL,
	[UserID] [int] NULL,
	[Fullname] [nvarchar](50) NULL,
	[CanBeEmailed] [bit] NULL,
	[srt] [int] NULL,
	[LastChanged] [datetime] NULL,
	[Groupname] [nvarchar](50) NULL,
	[CoGroupID] [int] NULL,
 CONSTRAINT [PK_tProjectSnags_1] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

ALTER TABLE [dbo].[tProjectSnags] ADD  CONSTRAINT [DF_tProjectSnags_ProjectTitle]  DEFAULT ('') FOR [ProjectTitle]
GO

ALTER TABLE [dbo].[tProjectSnags] ADD  CONSTRAINT [DF_tProjectSnags_ContractNo]  DEFAULT ('') FOR [ContractNo]
GO

ALTER TABLE [dbo].[tProjectSnags] ADD  CONSTRAINT [DF_tProjectSnags_Drawing]  DEFAULT ('') FOR [Drawing]
GO

ALTER TABLE [dbo].[tProjectSnags] ADD  CONSTRAINT [DF_tProjectSnags_SnagID]  DEFAULT ((0)) FOR [SnagID]
GO

ALTER TABLE [dbo].[tProjectSnags] ADD  CONSTRAINT [DF_tProjectSnags_ProjectLinkID]  DEFAULT ((0)) FOR [ProjectLinkID]
GO

ALTER TABLE [dbo].[tProjectSnags] ADD  CONSTRAINT [DF_tProjectSnags_DrwgID]  DEFAULT ((0)) FOR [DrwgID]
GO

ALTER TABLE [dbo].[tProjectSnags] ADD  CONSTRAINT [DF_tProjectSnags_Status]  DEFAULT ('') FOR [Status]
GO

ALTER TABLE [dbo].[tProjectSnags] ADD  CONSTRAINT [DF_tProjectSnags_ShortDescrip]  DEFAULT ('') FOR [ShortDescrip]
GO

ALTER TABLE [dbo].[tProjectSnags] ADD  CONSTRAINT [DF_tProjectSnags_LocID1]  DEFAULT ((0)) FOR [LocID]
GO

ALTER TABLE [dbo].[tProjectSnags] ADD  CONSTRAINT [DF_tProjectSnags_LocationExtRef]  DEFAULT ('') FOR [LocationExtRef]
GO

ALTER TABLE [dbo].[tProjectSnags] ADD  CONSTRAINT [DF_tProjectSnags_Location]  DEFAULT ('') FOR [Location]
GO

ALTER TABLE [dbo].[tProjectSnags] ADD  CONSTRAINT [DF_tProjectSnags_Xcoord]  DEFAULT ((0)) FOR [Xcoord]
GO

ALTER TABLE [dbo].[tProjectSnags] ADD  CONSTRAINT [DF_tProjectSnags_YCoord]  DEFAULT ((0)) FOR [YCoord]
GO

ALTER TABLE [dbo].[tProjectSnags] ADD  CONSTRAINT [DF_tProjectSnags_Priority]  DEFAULT ((0)) FOR [Priority]
GO

ALTER TABLE [dbo].[tProjectSnags] ADD  CONSTRAINT [DF_tProjectSnags_DrwgLink]  DEFAULT ((0)) FOR [DrwgLink]
GO

ALTER TABLE [dbo].[tProjectSnags] ADD  CONSTRAINT [DF_tProjectSnags_GroupID]  DEFAULT ((0)) FOR [GroupID]
GO

ALTER TABLE [dbo].[tProjectSnags] ADD  CONSTRAINT [DF_tProjectSnags_GroupInits]  DEFAULT ('') FOR [GroupInits]
GO

ALTER TABLE [dbo].[tProjectSnags] ADD  CONSTRAINT [DF_tProjectSnags_Lat]  DEFAULT ((0)) FOR [Lat]
GO

ALTER TABLE [dbo].[tProjectSnags] ADD  CONSTRAINT [DF_tProjectSnags_Lng]  DEFAULT ((0)) FOR [Lng]
GO

ALTER TABLE [dbo].[tProjectSnags] ADD  CONSTRAINT [DF_tProjectSnags_Owner]  DEFAULT ((0)) FOR [Owner]
GO

ALTER TABLE [dbo].[tProjectSnags] ADD  CONSTRAINT [DF_tProjectSnags_SDCode]  DEFAULT ('') FOR [SDCode]
GO

ALTER TABLE [dbo].[tProjectSnags] ADD  CONSTRAINT [DF_tProjectSnags_SDID]  DEFAULT ((0)) FOR [SDID]
GO

ALTER TABLE [dbo].[tProjectSnags] ADD  CONSTRAINT [DF_tProjectSnags_FixStatus]  DEFAULT ('') FOR [FixStatus]
GO

ALTER TABLE [dbo].[tProjectSnags] ADD  CONSTRAINT [DF_tProjectSnags_MPGUID]  DEFAULT ('') FOR [MPGUID]
GO

ALTER TABLE [dbo].[tProjectSnags] ADD  CONSTRAINT [DF_tProjectSnags_Purge]  DEFAULT ((0)) FOR [Purge]
GO

ALTER TABLE [dbo].[tProjectSnags] ADD  CONSTRAINT [DF_tProjectSnags_DaysLeft]  DEFAULT ((0)) FOR [DaysLeft]
GO

ALTER TABLE [dbo].[tProjectSnags] ADD  CONSTRAINT [DF_tProjectSnags_DrwgSrt]  DEFAULT ((0)) FOR [DrwgSrt]
GO

ALTER TABLE [dbo].[tProjectSnags] ADD  CONSTRAINT [DF_tProjectSnags_DrwgTitle]  DEFAULT ('') FOR [DrwgTitle]
GO

ALTER TABLE [dbo].[tProjectSnags] ADD  CONSTRAINT [DF_tProjectSnags_FixDescrip]  DEFAULT ('') FOR [FixDescrip]
GO

ALTER TABLE [dbo].[tProjectSnags] ADD  CONSTRAINT [DF_tProjectSnags_By]  DEFAULT ((0)) FOR [By]
GO

ALTER TABLE [dbo].[tProjectSnags] ADD  CONSTRAINT [DF_tProjectSnags_UserID]  DEFAULT ((0)) FOR [UserID]
GO

ALTER TABLE [dbo].[tProjectSnags] ADD  CONSTRAINT [DF_tProjectSnags_CanBeEmailed]  DEFAULT ((0)) FOR [CanBeEmailed]
GO

ALTER TABLE [dbo].[tProjectSnags] ADD  CONSTRAINT [DF_tProjectSnags_srt]  DEFAULT ((0)) FOR [srt]
GO

ALTER TABLE [dbo].[tProjectSnags] ADD  CONSTRAINT [DF_tProjectSnags_Groupname_1]  DEFAULT ('') FOR [Groupname]
GO

ALTER TABLE [dbo].[tProjectSnags] ADD  CONSTRAINT [DF_tProjectSnags_CoGroupID]  DEFAULT ((0)) FOR [CoGroupID]
GO










