CREATE TABLE [dbo].[employee] (
    [eid]      INT           IDENTITY (1, 1) NOT NULL,
    [ename]    VARCHAR (250) NOT NULL,
    [mobile]   BIGINT        NOT NULL,
    [emailid]  VARCHAR (120) NOT NULL,
    [username] VARCHAR (150) NOT NULL,
    [pass]     VARCHAR (150) NOT NULL,
    PRIMARY KEY CLUSTERED ([eid] ASC)
);

