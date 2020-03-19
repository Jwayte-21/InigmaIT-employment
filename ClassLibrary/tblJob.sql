CREATE TABLE [dbo].[Table]
(
	[PK_JobNo] INT NOT NULL PRIMARY KEY, 
    [Job Name] NCHAR(10) NULL, 
    [Job Description] NVARCHAR(50) NULL, 
    [Date Job Added] DATETIME NULL, 
    [FK_EmployerNo] INT NULL, 
    [FK_StaffNo] INT NULL
)
