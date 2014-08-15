
/****** Object:  Table [dbo].[tSnagRFormsDataControl]    Script Date: 10/14/2013 08:53:53 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tSnagRFormsDataControl](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Datestamp] [datetime] NULL,
	[fromURL] [nvarchar](250) NOT NULL,
	[Tablename] [nvarchar](50) NOT NULL,
	[Cleared] [bit] NOT NULL,
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

ALTER TABLE [dbo].[tSnagRFormsDataControl] ADD  CONSTRAINT [DF_tSnagRFormsDataControl_Tablename]  DEFAULT ('') FOR [Tablename]
GO

ALTER TABLE [dbo].[tSnagRFormsDataControl] ADD  CONSTRAINT [DF_tSnagRFormsDataControl_Cleared]  DEFAULT ((0)) FOR [Cleared]
GO


