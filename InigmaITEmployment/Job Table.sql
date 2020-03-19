CREATE TABLE [dbo].[Table]
(
	[PK_JobNo] INT NOT NULL PRIMARY KEY, 
    [Job Name] NCHAR(10) NULL, 
    [Job Description ] NVARCHAR(MAX) NULL, 
    [Date Job Posted] DATETIME NULL, 
    [FK_EmployerNo] INT NULL, 
    [FK_StaffNo] INT NULL
)
