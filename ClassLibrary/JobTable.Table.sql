CREATE TABLE [dbo].[Table] (
    [PK_JobNo]         INT            NOT NULL,
    [Job Name]         NCHAR (10)     NULL,
    [Job Description ] NVARCHAR (MAX) NULL,
    [Date Job Posted]  DATETIME       NULL,
    [FK_EmployerNo]    INT            NULL,
    [FK_StaffNo]       INT            NULL,
    PRIMARY KEY CLUSTERED ([PK_JobNo] ASC)
);

