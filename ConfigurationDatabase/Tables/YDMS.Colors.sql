﻿CREATE TABLE [YDMS].[Colors]
(
	[Id] UNIQUEIDENTIFIER NOT NULL DEFAULT NEWID(),
	[Red] TINYINT NOT NULL DEFAULT 0, 
    [Green] TINYINT NOT NULL DEFAULT 0, 
    [Blue] TINYINT NOT NULL DEFAULT 0, 
    CONSTRAINT [PK_YDMS_Colors] PRIMARY KEY ([Id])
)
