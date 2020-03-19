CREATE PROCEDURE sproc_tblJob_add
--create paramiters
@PK_JobNo int,
@JobName varchar(10),
@JobDescription varchar(50),
@DateJobAdded date,
@FK_EmployerNo int,
@FK_StaffNo int

as
insert into tblJob (PK_JobNo, [Job Name], [Job Description], [Date Job Added], FK_EmployerNo, FK_StaffNo)
values (@PK_JobNo, @JobName, @JobDescription, @DateJobAdded, @FK_EmployerNo, @FK_StaffNo)
RETURN @@Identity
