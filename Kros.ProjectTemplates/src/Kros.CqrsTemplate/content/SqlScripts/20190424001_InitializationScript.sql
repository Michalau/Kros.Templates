﻿SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[RRREntityNameRRR_Plural_](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[CreatedTimestamp] datetimeoffset(2) NOT NULL DEFAULT CURRENT_TIMESTAMP,
    [LastModifiedTimestamp] datetimeoffset(2) NOT NULL
 CONSTRAINT [PK_RRREntityNameRRR_Plural_] PRIMARY KEY CLUSTERED
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO