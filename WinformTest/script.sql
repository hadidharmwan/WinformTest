Create Database db_test

USE [db_test]
GO
/****** Object:  Table [dbo].[karyawan]    Script Date: 23/01/2024 02:13:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[karyawan](
	[IDKaryawan] [varchar](30) NOT NULL,
	[NmKaryawan] [varchar](30) NULL,
	[TglMasukKerja] [datetime] NULL,
	[Usia] [int] NULL,
 CONSTRAINT [PK_karyawan] PRIMARY KEY CLUSTERED 
(
	[IDKaryawan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
