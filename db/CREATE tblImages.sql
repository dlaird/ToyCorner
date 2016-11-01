USE [ToyCorner]
GO

/****** Object:  Table [dbo].[tblImages]    Script Date: 10/21/2016 4:49:13 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblImages](
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

ALTER TABLE [dbo].[tblImages]  WITH CHECK ADD  CONSTRAINT [FK_tblImages_tblItems] FOREIGN KEY([ItemName])
REFERENCES [dbo].[tblItems] ([ItemName])
GO

ALTER TABLE [dbo].[tblImages] CHECK CONSTRAINT [FK_tblImages_tblItems]
GO


