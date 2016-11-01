USE [atxtexme_db1]
GO

/****** Object:  Table [tc].[tblImages]    Script Date: 10/21/2016 4:49:13 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [tc].[tblImages](
	[ImageID] [int] IDENTITY(1,1) NOT NULL,
	[ItemName] [nvarchar](50) NOT NULL,
	[ImageFileName] [nvarchar](50) NOT NULL,
	[ImageFilePath] [nvarchar](400) NULL,
 CONSTRAINT [PK_tblImages] PRIMARY KEY CLUSTERED 
(
	[ImageID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [tc].[tblImages]  WITH CHECK ADD  CONSTRAINT [FK_tblImages_tblItems] FOREIGN KEY([ItemName])
REFERENCES [tc].[tblItems] ([ItemName])
GO

ALTER TABLE [tc].[tblImages] CHECK CONSTRAINT [FK_tblImages_tblItems]
GO


