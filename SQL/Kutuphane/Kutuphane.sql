﻿USE [KUTUPHANE]
GO
/****** Object:  Table [dbo].[KATEGORI]    Script Date: 14.07.2017 15:00:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KATEGORI](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ADI] [nchar](150) NULL,
 CONSTRAINT [PK_KATEGORI] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KITAP]    Script Date: 14.07.2017 15:00:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KITAP](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ADI] [nchar](150) NULL,
	[YAZAR] [nchar](150) NULL,
	[SAYFASAYISI] [smallint] NULL,
	[GMT] [datetime] NULL CONSTRAINT [DF_KITAP_GMT]  DEFAULT (getdate()),
	[HOSTNAME] [nvarchar](150) NULL CONSTRAINT [DF_KITAP_HOSTNAME]  DEFAULT (host_name()),
	[KATEGORIID] [int] NULL,
 CONSTRAINT [PK_KITAP_1] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[KITAP]  WITH CHECK ADD  CONSTRAINT [FK_KITAP_KATEGORI] FOREIGN KEY([ID])
REFERENCES [dbo].[KATEGORI] ([ID])
GO
ALTER TABLE [dbo].[KITAP] CHECK CONSTRAINT [FK_KITAP_KATEGORI]
GO
/****** Object:  StoredProcedure [dbo].[SP_DELETE_KATEGORI]    Script Date: 14.07.2017 15:00:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_DELETE_KATEGORI]
@ID INT
AS
DELETE FROM KATEGORI WHERE ID=@ID

GO
/****** Object:  StoredProcedure [dbo].[SP_DELETE_KITAP]    Script Date: 14.07.2017 15:00:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[SP_DELETE_KITAP]
@ID INT
AS
DELETE FROM KITAP WHERE ID=@ID


GO
/****** Object:  StoredProcedure [dbo].[SP_INSERT_KATAGORI]    Script Date: 14.07.2017 15:00:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_INSERT_KATAGORI]
@ADI NVARCHAR(150)
AS
INSERT INTO KATEGORI (ADI) VALUES(@ADI)


GO
/****** Object:  StoredProcedure [dbo].[SP_INSERT_KITAP]    Script Date: 14.07.2017 15:00:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_INSERT_KITAP]
@ADI NVARCHAR(150),
@YAZAR NVARCHAR(150),
@SAYFASAYISI smallint,
@KATEGORIID int

AS

INSERT INTO KITAP(ADI,YAZAR,SAYFASAYISI,KATEGORIID)
 VALUES(@ADI,@YAZAR,@SAYFASAYISI,@KATEGORIID)

GO
/****** Object:  StoredProcedure [dbo].[SP_SELECT_KATEGORI]    Script Date: 14.07.2017 15:00:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[SP_SELECT_KATEGORI]
@ID INT
AS
SELECT * FROM KATEGORI WHERE ID = @ID
GO
/****** Object:  StoredProcedure [dbo].[SP_SELECT_KATEGORILIST]    Script Date: 14.07.2017 15:00:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[SP_SELECT_KATEGORILIST]
AS
SELECT * FROM KATEGORI
GO
/****** Object:  StoredProcedure [dbo].[SP_SELECT_KITAP]    Script Date: 14.07.2017 15:00:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[SP_SELECT_KITAP]
@ID INT
AS
SELECT * FROM KITAP WHERE ID = @ID


GO
/****** Object:  StoredProcedure [dbo].[SP_SELECT_KITAPLIST]    Script Date: 14.07.2017 15:00:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_SELECT_KITAPLIST]
AS
SELECT  T1.*, T2.ADI AS KATEGORIADI FROM KITAP T1
INNER JOIN KATEGORI T2 ON T2.ID = T1.KATEGORIID
GO
/****** Object:  StoredProcedure [dbo].[SP_UPDATE_KATEGORI]    Script Date: 14.07.2017 15:00:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_UPDATE_KATEGORI]
@ADI NVARCHAR (150),
@ID INT
as
UPDATE KATEGORI SET ADI = @ADI WHERE ID = @ID
GO
/****** Object:  StoredProcedure [dbo].[SP_UPDATE_KITAP]    Script Date: 14.07.2017 15:00:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



create proc [dbo].[SP_UPDATE_KITAP]

@ID int,
@ADI NVARCHAR(150),
@YAZAR NVARCHAR(150),
@SAYFASAYISI smallint,
@KATEGORIID int
AS
UPDATE KITAP SET ADI = @ADI,
				 YAZAR = @YAZAR,	
				 SAYFASAYISI = @SAYFASAYISI,
				 KATEGORIID = @KATEGORIID,
				 HOSTNAME = HOST_NAME(),
				 GMT = GETDATE()
				 WHERE ID = @ID
GO
