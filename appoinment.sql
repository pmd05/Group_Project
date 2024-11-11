CREATE TABLE [dbo].[booking] (
    [userid]   INT           IDENTITY (1, 1)  PRIMARY KEY,
    [user]     VARCHAR (250) NOT NULL,
    [phone]    BIGINT        NOT NULL,
    [date]     VARCHAR (250) NOT NULL,
    [dichvu]   VARCHAR (250) NOT NULL,
    [coso]     VARCHAR (250) NOT NULL,
    [stylist]  VARCHAR (250) NOT NULL,
    [booked]   VARCHAR (50)  DEFAULT ('NO') NULL
);
