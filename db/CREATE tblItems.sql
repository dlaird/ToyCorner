USE [ToyCorner]
GO

/****** Object:  Table [dbo].[tblItems]    Script Date: 10/21/2016 4:48:33 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblItems](
	[ItemID] [int] IDENTITY(1,1) NOT NULL,
	[TypeName] [nvarchar](30) NOT NULL,
	[ItemName] [nvarchar](50) NOT NULL,
	[ItemDescription] [nvarchar](400) NULL,
	[ItemPrice] [real] NULL,
	[IsAvailable] [int] NULL,
 CONSTRAINT [PK_tblItems] PRIMARY KEY CLUSTERED 
(
	[ItemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UK_tblItems] UNIQUE NONCLUSTERED 
(
	[ItemName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[tblItems]  WITH CHECK ADD  CONSTRAINT [FK_tblItems_tblTypes] FOREIGN KEY([TypeName])
REFERENCES [dbo].[tblTypes] ([TypeName])
GO

ALTER TABLE [dbo].[tblItems] CHECK CONSTRAINT [FK_tblItems_tblTypes]
GO


