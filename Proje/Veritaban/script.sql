USE [DERSKAYITSISTEM]
GO
/****** Object:  Table [dbo].[ACILANDERS]    Script Date: 20.07.2017 14:55:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ACILANDERS](
	[ADersKodu] [int] NOT NULL,
	[DersKodu] [int] NOT NULL,
	[TCNo] [int] NOT NULL,
	[DerslikNo] [int] NOT NULL,
	[Sube] [int] NOT NULL,
 CONSTRAINT [PK_ACILANDERS] PRIMARY KEY CLUSTERED 
(
	[ADersKodu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[BINA]    Script Date: 20.07.2017 14:55:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BINA](
	[BinaNo] [int] NOT NULL,
	[BinaAdi] [nchar](50) NOT NULL,
 CONSTRAINT [PK_BINA] PRIMARY KEY CLUSTERED 
(
	[BinaNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[BOLUM]    Script Date: 20.07.2017 14:55:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BOLUM](
	[BolumNo] [int] NOT NULL,
	[FakulteNo] [int] NOT NULL,
	[BolumAdı] [nchar](50) NOT NULL,
 CONSTRAINT [PK_BOLUM] PRIMARY KEY CLUSTERED 
(
	[BolumNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[BOLUMBASKANI]    Script Date: 20.07.2017 14:55:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BOLUMBASKANI](
	[BaskanID] [int] NOT NULL,
	[BolumNo] [int] NOT NULL,
 CONSTRAINT [PK_BOLUMBASKANI_1] PRIMARY KEY CLUSTERED 
(
	[BaskanID] ASC,
	[BolumNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DEKANL]    Script Date: 20.07.2017 14:55:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DEKANL](
	[dekanID] [int] NOT NULL,
	[TCNo] [int] NOT NULL,
 CONSTRAINT [PK_DEKANL] PRIMARY KEY CLUSTERED 
(
	[dekanID] ASC,
	[TCNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Derslik]    Script Date: 20.07.2017 14:55:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Derslik](
	[DerslikNo] [int] NOT NULL,
	[BinaNo] [int] NOT NULL,
 CONSTRAINT [PK_Derslik] PRIMARY KEY CLUSTERED 
(
	[DerslikNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[FAKULTE]    Script Date: 20.07.2017 14:55:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FAKULTE](
	[universiteNo] [int] NOT NULL,
	[FakulteNo] [int] NOT NULL,
 CONSTRAINT [PK_FAKULTE] PRIMARY KEY CLUSTERED 
(
	[FakulteNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KATALOGDERS]    Script Date: 20.07.2017 14:55:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KATALOGDERS](
	[DersKodu] [int] NOT NULL,
	[BolumNo] [int] NOT NULL,
	[DersAdi] [nchar](50) NOT NULL,
	[Kredi] [int] NOT NULL,
 CONSTRAINT [PK_KATALOGDERS] PRIMARY KEY CLUSTERED 
(
	[DersKodu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KAYIT]    Script Date: 20.07.2017 14:55:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KAYIT](
	[ADersKodu] [int] NOT NULL,
	[ogrenciNo] [int] NOT NULL,
	[tarih] [datetime] NULL,
 CONSTRAINT [PK_KAYIT] PRIMARY KEY CLUSTERED 
(
	[ADersKodu] ASC,
	[ogrenciNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LOGIN]    Script Date: 20.07.2017 14:55:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOGIN](
	[userID] [int] NOT NULL,
	[password] [int] NOT NULL,
 CONSTRAINT [PK_LOGIN] PRIMARY KEY CLUSTERED 
(
	[userID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[OGRENCI]    Script Date: 20.07.2017 14:55:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OGRENCI](
	[ogrenciNo] [int] NOT NULL,
	[BolumNo] [int] NOT NULL,
	[DanismanID] [int] NOT NULL,
	[kredi] [int] NOT NULL,
	[OgrenciAD] [nchar](50) NOT NULL,
	[OgrenciSOYAD] [nchar](50) NOT NULL,
 CONSTRAINT [PK_OGRENCI] PRIMARY KEY CLUSTERED 
(
	[ogrenciNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[OGRETIMUYESI]    Script Date: 20.07.2017 14:55:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OGRETIMUYESI](
	[TCNo] [int] NOT NULL,
	[BolumNo] [int] NOT NULL,
	[Ad] [nchar](50) NOT NULL,
	[SoyAd] [nchar](50) NOT NULL,
 CONSTRAINT [PK_OGRETIMUYESI] PRIMARY KEY CLUSTERED 
(
	[TCNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UNIVERSITE]    Script Date: 20.07.2017 14:55:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UNIVERSITE](
	[universiteNo] [int] IDENTITY(1,1) NOT NULL,
	[ADI] [nchar](50) NOT NULL,
	[TELEFONU] [int] NOT NULL,
 CONSTRAINT [PK_UNIVERSITE] PRIMARY KEY CLUSTERED 
(
	[universiteNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[KAYIT] ADD  CONSTRAINT [DF_KAYIT_tarih]  DEFAULT (getdate()) FOR [tarih]
GO
ALTER TABLE [dbo].[ACILANDERS]  WITH CHECK ADD  CONSTRAINT [FK_ACILANDERS_Derslik] FOREIGN KEY([DerslikNo])
REFERENCES [dbo].[Derslik] ([DerslikNo])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ACILANDERS] CHECK CONSTRAINT [FK_ACILANDERS_Derslik]
GO
ALTER TABLE [dbo].[ACILANDERS]  WITH CHECK ADD  CONSTRAINT [FK_ACILANDERS_KATALOGDERS] FOREIGN KEY([DersKodu])
REFERENCES [dbo].[KATALOGDERS] ([DersKodu])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ACILANDERS] CHECK CONSTRAINT [FK_ACILANDERS_KATALOGDERS]
GO
ALTER TABLE [dbo].[ACILANDERS]  WITH CHECK ADD  CONSTRAINT [FK_ACILANDERS_OGRETIMUYESI] FOREIGN KEY([TCNo])
REFERENCES [dbo].[OGRETIMUYESI] ([TCNo])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ACILANDERS] CHECK CONSTRAINT [FK_ACILANDERS_OGRETIMUYESI]
GO
ALTER TABLE [dbo].[BOLUM]  WITH CHECK ADD  CONSTRAINT [FK_BOLUM_FAKULTE] FOREIGN KEY([FakulteNo])
REFERENCES [dbo].[FAKULTE] ([FakulteNo])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[BOLUM] CHECK CONSTRAINT [FK_BOLUM_FAKULTE]
GO
ALTER TABLE [dbo].[BOLUMBASKANI]  WITH CHECK ADD  CONSTRAINT [FK_BOLUMBASKANI_BOLUM2] FOREIGN KEY([BolumNo])
REFERENCES [dbo].[BOLUM] ([BolumNo])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[BOLUMBASKANI] CHECK CONSTRAINT [FK_BOLUMBASKANI_BOLUM2]
GO
ALTER TABLE [dbo].[BOLUMBASKANI]  WITH CHECK ADD  CONSTRAINT [FK_BOLUMBASKANI_OGRETIMUYESI] FOREIGN KEY([BaskanID])
REFERENCES [dbo].[OGRETIMUYESI] ([TCNo])
GO
ALTER TABLE [dbo].[BOLUMBASKANI] CHECK CONSTRAINT [FK_BOLUMBASKANI_OGRETIMUYESI]
GO
ALTER TABLE [dbo].[DEKANL]  WITH CHECK ADD  CONSTRAINT [FK_DEKANL_FAKULTE] FOREIGN KEY([dekanID])
REFERENCES [dbo].[FAKULTE] ([FakulteNo])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DEKANL] CHECK CONSTRAINT [FK_DEKANL_FAKULTE]
GO
ALTER TABLE [dbo].[DEKANL]  WITH CHECK ADD  CONSTRAINT [FK_DEKANL_OGRETIMUYESI] FOREIGN KEY([TCNo])
REFERENCES [dbo].[OGRETIMUYESI] ([TCNo])
GO
ALTER TABLE [dbo].[DEKANL] CHECK CONSTRAINT [FK_DEKANL_OGRETIMUYESI]
GO
ALTER TABLE [dbo].[Derslik]  WITH CHECK ADD  CONSTRAINT [FK_Derslik_BINA] FOREIGN KEY([BinaNo])
REFERENCES [dbo].[BINA] ([BinaNo])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Derslik] CHECK CONSTRAINT [FK_Derslik_BINA]
GO
ALTER TABLE [dbo].[FAKULTE]  WITH CHECK ADD  CONSTRAINT [FK_FAKULTE_UNIVERSITE] FOREIGN KEY([universiteNo])
REFERENCES [dbo].[UNIVERSITE] ([universiteNo])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[FAKULTE] CHECK CONSTRAINT [FK_FAKULTE_UNIVERSITE]
GO
ALTER TABLE [dbo].[KATALOGDERS]  WITH CHECK ADD  CONSTRAINT [FK_KATALOGDERS_BOLUM] FOREIGN KEY([BolumNo])
REFERENCES [dbo].[BOLUM] ([BolumNo])
GO
ALTER TABLE [dbo].[KATALOGDERS] CHECK CONSTRAINT [FK_KATALOGDERS_BOLUM]
GO
ALTER TABLE [dbo].[KAYIT]  WITH CHECK ADD  CONSTRAINT [FK_KAYIT_ACILANDERS] FOREIGN KEY([ADersKodu])
REFERENCES [dbo].[ACILANDERS] ([ADersKodu])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[KAYIT] CHECK CONSTRAINT [FK_KAYIT_ACILANDERS]
GO
ALTER TABLE [dbo].[KAYIT]  WITH CHECK ADD  CONSTRAINT [FK_KAYIT_OGRENCI] FOREIGN KEY([ogrenciNo])
REFERENCES [dbo].[OGRENCI] ([ogrenciNo])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[KAYIT] CHECK CONSTRAINT [FK_KAYIT_OGRENCI]
GO
ALTER TABLE [dbo].[LOGIN]  WITH CHECK ADD  CONSTRAINT [FK_LOGIN_OGRETIMUYESI] FOREIGN KEY([userID])
REFERENCES [dbo].[OGRETIMUYESI] ([TCNo])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[LOGIN] CHECK CONSTRAINT [FK_LOGIN_OGRETIMUYESI]
GO
ALTER TABLE [dbo].[OGRENCI]  WITH CHECK ADD  CONSTRAINT [FK_OGRENCI_BOLUM] FOREIGN KEY([BolumNo])
REFERENCES [dbo].[BOLUM] ([BolumNo])
GO
ALTER TABLE [dbo].[OGRENCI] CHECK CONSTRAINT [FK_OGRENCI_BOLUM]
GO
ALTER TABLE [dbo].[OGRENCI]  WITH CHECK ADD  CONSTRAINT [FK_OGRENCI_OGRETIMUYESI] FOREIGN KEY([DanismanID])
REFERENCES [dbo].[OGRETIMUYESI] ([TCNo])
GO
ALTER TABLE [dbo].[OGRENCI] CHECK CONSTRAINT [FK_OGRENCI_OGRETIMUYESI]
GO
ALTER TABLE [dbo].[OGRETIMUYESI]  WITH CHECK ADD  CONSTRAINT [FK_OGRETIMUYESI_BOLUM] FOREIGN KEY([BolumNo])
REFERENCES [dbo].[BOLUM] ([BolumNo])
GO
ALTER TABLE [dbo].[OGRETIMUYESI] CHECK CONSTRAINT [FK_OGRETIMUYESI_BOLUM]
GO
/****** Object:  StoredProcedure [dbo].[SP_DELETE_ACILANDERS]    Script Date: 20.07.2017 14:55:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create proc [dbo].[SP_DELETE_ACILANDERS]
@ADersKodu INT
AS
DELETE FROM ACILANDERS WHERE AdersKodu=@ADersKodu


GO
/****** Object:  StoredProcedure [dbo].[SP_DELETE_BINA]    Script Date: 20.07.2017 14:55:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[SP_DELETE_BINA]
@BinaNo INT
AS
DELETE FROM BINA WHERE BinaNo = @BinaNo


GO
/****** Object:  StoredProcedure [dbo].[SP_DELETE_BOLUM]    Script Date: 20.07.2017 14:55:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[SP_DELETE_BOLUM]
@BolumNo INT
AS

DELETE FROM KATALOGDERS WHERE BolumNo = @BolumNo;
DELETE FROM BOLUMBASKANI WHERe BolumNo = @BolumNo;
DELETE FROM OGRENCI WHERE BolumNo = @BolumNo;
DELETE FROM OGRETIMUYESI WHERE BolumNo = @BolumNo;
DELETE FROM BOLUM WHERE BolumNo=@BolumNo


GO
/****** Object:  StoredProcedure [dbo].[SP_DELETE_BOLUMBASKANI]    Script Date: 20.07.2017 14:55:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[SP_DELETE_BOLUMBASKANI]
@BaskanID INT
AS
DELETE FROM BOLUMBASKANI WHERE BaskanID = @BaskanID


GO
/****** Object:  StoredProcedure [dbo].[SP_DELETE_DEKANL]    Script Date: 20.07.2017 14:55:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[SP_DELETE_DEKANL]
@dekanID INT
AS
DELETE FROM DEKANL WHERE dekanID = @dekanID


GO
/****** Object:  StoredProcedure [dbo].[SP_DELETE_DERSLIK]    Script Date: 20.07.2017 14:55:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[SP_DELETE_DERSLIK]
@DerslikNo INT
AS
DELETE FROM Derslik WHERE DerslikNo = @DerslikNo


GO
/****** Object:  StoredProcedure [dbo].[SP_DELETE_FAKULTE]    Script Date: 20.07.2017 14:55:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[SP_DELETE_FAKULTE]
@FakulteNO INT
AS
DELETE FROM FAKULTE WHERE FakulteNo = @FakulteNO

GO
/****** Object:  StoredProcedure [dbo].[SP_DELETE_KATALOGDERS]    Script Date: 20.07.2017 14:55:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[SP_DELETE_KATALOGDERS]
@DersKodu INT
AS
DELETE FROM ACILANDERS WHERE DersKodu = @DersKodu;
DELETE FROM KATALOGDERS WHERE DersKodu = @DersKodu;


GO
/****** Object:  StoredProcedure [dbo].[SP_DELETE_KAYIT]    Script Date: 20.07.2017 14:55:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[SP_DELETE_KAYIT]
@ogrenciNo INT
AS
DELETE FROM KAYIT WHERE ogrenciNo = @ogrenciNo


GO
/****** Object:  StoredProcedure [dbo].[SP_DELETE_LOGIN]    Script Date: 20.07.2017 14:55:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_DELETE_LOGIN]

@userID int
AS
delete from LOGIN  WHERE userID = @userID
GO
/****** Object:  StoredProcedure [dbo].[SP_DELETE_OGRENCI]    Script Date: 20.07.2017 14:55:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[SP_DELETE_OGRENCI]
   @ogrenciNo int
AS
BEGIN
    DELETE FROM LOGIN WHERE userID = @ogrenciNo;   
	DELETE FROM KAYIT WHERE ogrenciNo = @ogrenciNo;
	 DELETE FROM OGRENCI WHERE ogrenciNo = @ogrenciNo;
END

GO
/****** Object:  StoredProcedure [dbo].[SP_DELETE_OGRETIMUYESI]    Script Date: 20.07.2017 14:55:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[SP_DELETE_OGRETIMUYESI]
@TcNo INT
AS
DELETE FROM LOGIN WHERE userID = @TcNo;
DELETE FROM ACILANDERS WHERE TCNo = @TcNo;
DELETE FROM BOLUMBASKANI WHERE BaskanID = @TcNo;
DELETE FROM DEKANL WHERE dekanID = @TcNo;
DELETE FROM OGRETIMUYESI WHERE TcNO = @TcNo;


GO
/****** Object:  StoredProcedure [dbo].[SP_DELETE_UNIVERSITE]    Script Date: 20.07.2017 14:55:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[SP_DELETE_UNIVERSITE]
@universiteNo int
AS

DELETE from	ACILANDERS  
DELETE from KATALOGDERS 
DELETE from BOLUMBASKANI
DELETE from DEKANL
DELETE from LOGIN 
DELETE from OGRETIMUYESI 
DELETE from KAYIT 
DELETE from OGRENCI 
DELETE from Derslik
DELETE from BINA
DELETE from BOLUM  
DELETE from FAKULTE 
DELETE from UNIVERSITE where universiteNo = @universiteNo



GO
/****** Object:  StoredProcedure [dbo].[SP_INSERT_ACILANDERS]    Script Date: 20.07.2017 14:55:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_INSERT_ACILANDERS]

 @ADersKodu int,
 @DersKodu int,
 @TCNo int,
 @DerslikNo int,
 @Sube int

 AS 

 insert into ACILANDERS(ADersKodu,DersKodu,TCNo,DerslikNo,Sube)
 Values(@ADersKodu,@DersKodu,@TCNo,@DerslikNo,@Sube)
GO
/****** Object:  StoredProcedure [dbo].[SP_INSERT_BINA]    Script Date: 20.07.2017 14:55:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_INSERT_BINA]

 @BinaAdi nchar(50),
 @BinaNo int

 AS 

 insert into BINA(BinaAdi,BinaNo)
 Values(@BinaAdi,@BinaNo)
GO
/****** Object:  StoredProcedure [dbo].[SP_INSERT_BOLUM]    Script Date: 20.07.2017 14:55:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_INSERT_BOLUM]
  @FakulteNo int,
  @BolumNo int,
  @BolumAdı nchar(50)

  AS

  
INSERT INTO BOLUM(FakulteNo,BolumNo,BolumAdı)
 VALUES(@FakulteNo,@BolumNo,@BolumAdı)
GO
/****** Object:  StoredProcedure [dbo].[SP_INSERT_BOLUMBASKANI]    Script Date: 20.07.2017 14:55:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_INSERT_BOLUMBASKANI]

@BaskanID int,
@BolumNo int

as 

 insert into BOLUMBASKANI(BaskanID,BolumNo)
 VALUES (@BaskanID,@BolumNo)

GO
/****** Object:  StoredProcedure [dbo].[SP_INSERT_DEKANL]    Script Date: 20.07.2017 14:55:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE proc [dbo].[SP_INSERT_DEKANL]

 @dekanID int,
 @TCNo int

 as

 insert into DEKANL(dekanID,TCNo)
 values(@dekanID,@TCNo)
GO
/****** Object:  StoredProcedure [dbo].[SP_INSERT_Derslik]    Script Date: 20.07.2017 14:55:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_INSERT_Derslik]

 @DerslikNo int,
 @BinaNo int

 AS 

 insert into Derslik(DerslikNo,BinaNo)
 Values(@DerslikNo,@BinaNo)
GO
/****** Object:  StoredProcedure [dbo].[SP_INSERT_FAKULTE]    Script Date: 20.07.2017 14:55:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[SP_INSERT_FAKULTE]

@universiteNo int,
@FakulteNo int

AS

INSERT INTO FAKULTE(universiteNo,FakulteNo)
 VALUES(@universiteNo,@FakulteNo)

GO
/****** Object:  StoredProcedure [dbo].[SP_INSERT_KATALOGDERS]    Script Date: 20.07.2017 14:55:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_INSERT_KATALOGDERS]

 @BolumNo int,
 @DersKodu int,
 @DersAdi nchar(50),
 @Kredi int

 AS 

 insert into KATALOGDERS(BolumNo,DersKodu,DersAdi,Kredi)
 Values(@BolumNo,@DersKodu,@DersAdi,@Kredi)
GO
/****** Object:  StoredProcedure [dbo].[SP_INSERT_KAYIT]    Script Date: 20.07.2017 14:55:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_INSERT_KAYIT]

 @ogrenciNo int,
 @ADersKodu int

 AS 

 insert into KAYIT(ogrenciNo,ADersKodu)
 Values(@ogrenciNo,@ADersKodu)
GO
/****** Object:  StoredProcedure [dbo].[SP_INSERT_LOGIN]    Script Date: 20.07.2017 14:55:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE proc [dbo].[SP_INSERT_LOGIN]

 @userID int,
 @password int

 as

 insert into LOGIN(userID,password)
 values(@userID,@password)
GO
/****** Object:  StoredProcedure [dbo].[SP_INSERT_OGRENCI]    Script Date: 20.07.2017 14:55:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_INSERT_OGRENCI]

 @ogrenciNo int,
 @bolumNo int,
 @danismanNo int,
 @kredi int,
 @ogrenciAD nchar(50),
 @ogrenciSOYAD nchar(50)

 AS 

 insert into OGRENCI(ogrenciAD,ogrenciSOYAD,ogrenciNo,BolumNo,DanismanID,kredi)
 Values(@ogrenciAD,@ogrenciSOYAD,@ogrenciNo,@bolumNo,@danismanNo,@kredi)
GO
/****** Object:  StoredProcedure [dbo].[SP_INSERT_OGRETIMUYESI]    Script Date: 20.07.2017 14:55:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_INSERT_OGRETIMUYESI]

@ADI NCHAR(50),
@SOYADI NCHAR(50),
@TCNO int,
@BolumNo int
AS

INSERT INTO OGRETIMUYESI(TCNo,BolumNo,Ad,SoyAd)
 VALUES(@TCNO,@BolumNo,@ADI,@SOYADI)
GO
/****** Object:  StoredProcedure [dbo].[SP_INSERT_UNIVERSITE]    Script Date: 20.07.2017 14:55:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[SP_INSERT_UNIVERSITE]

@UNIADI NVARCHAR(50),
@TELEFONU NVARCHAR(50)


AS

INSERT INTO UNIVERSITE(TELEFONU,ADI)
 VALUES(@TELEFONU,@UNIADI)

GO
/****** Object:  StoredProcedure [dbo].[SP_SELECT_LOGINLIST]    Script Date: 20.07.2017 14:55:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[SP_SELECT_LOGINLIST]
AS
SELECT * FROM LOGIN
GO
/****** Object:  StoredProcedure [dbo].[SP_SELECT_UNIVERSITELIST]    Script Date: 20.07.2017 14:55:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




create proc [dbo].[SP_SELECT_UNIVERSITELIST]
AS
SELECT * FROM UNIVERSITE

GO
/****** Object:  StoredProcedure [dbo].[SP_UPDATE_ACILANDERS]    Script Date: 20.07.2017 14:55:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create proc [dbo].[SP_UPDATE_ACILANDERS]

@ADersKodu int,
@DersKodu int,
@TCNo int,
@DerslikNo int,
@Sube int

AS

UPDATE ACILANDERS SET 
						DersKodu = @DersKodu,
						TCNo = @TCNo,
						DerslikNo = @DerslikNo,
						Sube = @Sube
				 WHERE ADersKodu = @ADersKodu
GO
/****** Object:  StoredProcedure [dbo].[SP_UPDATE_BINA]    Script Date: 20.07.2017 14:55:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



Create proc [dbo].[SP_UPDATE_BINA]

@BinaNo int,
@BinaAdi nchar(50)

AS

UPDATE BINA SET 
						BinaAdi = @BinaAdi
					
				 WHERE BinaNo = @BinaNo



GO
/****** Object:  StoredProcedure [dbo].[SP_UPDATE_BOLUM]    Script Date: 20.07.2017 14:55:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



Create proc [dbo].[SP_UPDATE_BOLUM]

@BolumNo int,
@FakulteNo int,
@BolumAdı nchar(50)

AS

UPDATE BOLUM SET 
					    BolumNo = @BolumNo,
						FakulteNo = @FakulteNo,
						BolumAdı = @BolumAdı

				 WHERE BolumNo = @BolumNo


GO
/****** Object:  StoredProcedure [dbo].[SP_UPDATE_BOLUMBASKANI]    Script Date: 20.07.2017 14:55:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_UPDATE_BOLUMBASKANI]

@BaskanID int,
@BolumNo int

AS
UPDATE BOLUMBASKANI SET 
                         BaskanID = @BaskanID

				 WHERE BolumNo = @BolumNo
GO
/****** Object:  StoredProcedure [dbo].[SP_UPDATE_DEKANL]    Script Date: 20.07.2017 14:55:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



Create proc [dbo].[SP_UPDATE_DEKANL]

@dekanID int,
@TCNo int

AS

UPDATE DEKANL SET 
						TcNO = @TcNO

				 WHERE dekanId = @dekanID


GO
/****** Object:  StoredProcedure [dbo].[SP_UPDATE_Derslik]    Script Date: 20.07.2017 14:55:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



Create proc [dbo].[SP_UPDATE_Derslik]

@DerslikNo int,
@BinaNo int

AS

UPDATE Derslik SET 
						BinaNo = @BinaNo,
						DerslikNo = @DerslikNo

				 WHERE DerslikNo = @DerslikNo


GO
/****** Object:  StoredProcedure [dbo].[SP_UPDATE_FAKULTE]    Script Date: 20.07.2017 14:55:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



Create proc [dbo].[SP_UPDATE_FAKULTE]

@universiteNo int,
@FakulteNo int

AS

UPDATE FAKULTE SET 
						FakulteNo = @Fakulteno

				 WHERE universiteNo = @universiteNo


GO
/****** Object:  StoredProcedure [dbo].[SP_UPDATE_KATALOGDERS]    Script Date: 20.07.2017 14:55:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



Create proc [dbo].[SP_UPDATE_KATALOGDERS]

@DersKodu int,
@BolumNo int,
@kredi int,
@DersAdi nchar(50)

AS

UPDATE KATALOGDERS SET 
						DersKodu = @DersKodu,
						BolumNo = @BolumNo,
						DersAdi = @DersAdi,
						Kredi = @Kredi

				 WHERE DersKodu = @DersKodu


GO
/****** Object:  StoredProcedure [dbo].[SP_UPDATE_KAYIT]    Script Date: 20.07.2017 14:55:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




Create proc [dbo].[SP_UPDATE_KAYIT]

@ADersKodu int,
@tarih date,
@ogrenciNo int

AS

UPDATE KAYIT SET 
						ADersKodu = @ADersKodu,
						tarih = @tarih

				 WHERE ogrenciNo = @ogrenciNo

GO
/****** Object:  StoredProcedure [dbo].[SP_UPDATE_LOGIN]    Script Date: 20.07.2017 14:55:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



Create proc [dbo].[SP_UPDATE_LOGIN]

@userID int,
@password int

AS

UPDATE LOGIN SET 
						password = @password

				 WHERE userID = @userID


GO
/****** Object:  StoredProcedure [dbo].[SP_UPDATE_OGRENCI]    Script Date: 20.07.2017 14:55:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



Create proc [dbo].[SP_UPDATE_OGRENCI]

@ogrenciNo int,
@bolumNo int,
@danismanID int,
@kredi int


AS

UPDATE OGRENCI SET 
						
						BolumNo = @bolumNo,
						DanismanID = @DanismanID,
						kredi = @kredi

				 WHERE ogrenciNo = @ogrenciNo


GO
/****** Object:  StoredProcedure [dbo].[SP_UPDATE_OGRETIMUYESI]    Script Date: 20.07.2017 14:55:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



Create proc [dbo].[SP_UPDATE_OGRETIMUYESI]

@Ad nchar(50),
@SoyAd nchar(50),
@BolumNo int,
@TCNo int


AS

UPDATE OGRETIMUYESI SET 
						BolumNo = @BolumNo,
						Ad = @Ad,
						SoyAd = @SoyAd

				 WHERE TCNo = @TCNo


GO
/****** Object:  StoredProcedure [dbo].[SP_UPDATE_UNIVERSITE]    Script Date: 20.07.2017 14:55:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



Create proc [dbo].[SP_UPDATE_UNIVERSITE]

@universiteNo int,
@telefon int,
@ADI nchar(50)

AS

UPDATE UNIVERSITE SET 
						telefonu = @telefon,
						ADI = @ADI

				 WHERE universiteNo = @universiteNo


GO
