CREATE DATABASE StaffRotation_DB
GO

USE StaffRotation_DB
go

CREATE TABLE ZipCode
(
	code			CHAR(4)			PRIMARY KEY, 
	municipality	VARCHAR(100)
)


CREATE TABLE Job
(
	id				INT				PRIMARY KEY IDENTITY(1,1),
	title			VARCHAR(50),
	[desc]			VARCHAR(100)
)

CREATE TABLE Employee
(
	id						INT				PRIMARY KEY IDENTITY(101,1),
	lastname				VARCHAR(60)		NOT NULL,
	firstname				VARCHAR(60)		NOT NULL,
	middlename				VARCHAR(60)		NOT NULL,
	gender					CHAR(1)			CHECK (gender IN ('M', 'F')) DEFAULT('M'), 
	birthdate				VARCHAR(60),		 
	photo					VARCHAR(MAX),			
	[signature]				VARCHAR(MAX),
	job_id					INT				FOREIGN KEY REFERENCES Job(id) on delete cascade,
	[address]				VARCHAR(100), 
	zip_code				CHAR(4)			FOREIGN KEY REFERENCES ZipCode(code) on delete cascade,		
	email_address			VARCHAR(100),	
	UMID					varchar(30)		not null,
	TIN						varchar(30)		not null,
	BankAccountNumber		varchar(30)		not null,
	TaxExemptionStatus		varchar(30)		not null,
	DailyContractRate		varchar(30)		not null,
	OverTime				varchar(30)		not null,
	phone_no				VARCHAR(MAX),
    homephone				VARCHAR(MAX)
)


CREATE TABLE JobHistory 
(
	employ_date		SMALLDATETIME,
	emp_id			INT				FOREIGN KEY REFERENCES Employee(id) on delete no action, 
	job_id			INT				FOREIGN KEY REFERENCES Job(id) on delete no action
)



CREATE TABLE ScodeTable
(
	Scode_ID			varchar(5)		primary key,
	firstTimeIn			varchar(7)		null,
	firstTimeOut		varchar(7)		null,
	SecondTimeIn		varchar(7)		null,
	SecondTimeOut		varchar(7)		null,
	[desc]				varchar(100)	null
)
CREATE TABLE RcodeTable
(
	Rcode_ID			varchar(5)		primary key,
	[desc]				varchar(100)		not null
	scode1				varchar(20)		FOREIGN KEY REFERENCES ScodeTable(Scode_ID),
	scode2				varchar(20)		FOREIGN KEY REFERENCES ScodeTable(Scode_ID),
	scode3				varchar(20)		FOREIGN KEY REFERENCES ScodeTable(Scode_ID),
	scode4				varchar(20)		FOREIGN KEY REFERENCES ScodeTable(Scode_ID),
	scode5				varchar(20)		FOREIGN KEY REFERENCES ScodeTable(Scode_ID)
)

CREATE TABLE SchedulePeriod
(
	schedperiod_id		int				primary key identity(1,1),
	beginDate			varchar(20)		not null,
	endDate				varchar(20)		not null,
	[Status]			varchar(5)		not null
)


CREATE TABLE RotationSchedule
(
	rotation_id			int				primary key identity (1,1),
	rcode_id			varchar(5)		foreign key references RcodeTable(Rcode_ID) on delete cascade,
	scode_id			varchar(5)		foreign key references ScodeTable(Scode_ID) on delete cascade,
	schedperiod_id		int				foreign key references SchedulePeriod(schedperiod_id) on delete cascade
)

CREATE TABLE EmployeeSchedule
(
	employeesched_id			int			primary key identity(1,1),
	rotation_id					int			foreign key references RotationSchedule(rotation_id),
	emp_id						int			foreign key references Employee(id)
)

CREATE TABLE ImportedAttendance
(
	id						int				primary key identity(1,1),
	employeeid				int				foreign key references Employee(id),
	[date]					varchar(10)		null,
	firstshiftIn			varchar(10)	    null,
	firstshiftOut			varchar(10)		null,
	secondshiftIn			varchar(10)		null,
	secondshiftOut			varchar(10)		null,
	overtimeIn				varchar(10)		null,
	overtimeOut				varchar(10)		null
)

CREATE TABLE ActualAttendance
(
	id						int				primary key identity(1,1),
	employeeid				int				foreign key references Employee(id),
	[date]					varchar(10)		null,
	firstshiftIn			varchar(10)	    null,
	firstshiftOut			varchar(10)		null,
	secondshiftIn			varchar(10)		null,
	secondshiftOut			varchar(10)		null,
	overtimeIn				varchar(10)		null,
	overtimeOut				varchar(10)		null
)

CREATE TABLE EmployeeOFF
(
	empoffid				int				primary key identity(1,1),
	emp_id					int				foreign key references Employee(id),
	schedperID				int				foreign key references SchedulePeriod(schedperiod_id),
	date					varchar(10)		not null
)

create table SSSContribution
(
	SSSContributionID				int							primary key identity(1,1),
	MonthlyRange					varchar(20)					not null,
	Compesation						varchar(20)					not null
)

create table PhilHealthContribution
(
	PhilHealthContributionID				int							primary key identity(1,1),
	MonthlyRange					varchar(20)					not null,
	Compesation						varchar(20)					not null
)

create table PagIbigContribution
(
	PagIbigContributionID				int							primary key identity(1,1),
	MonthlyRange					varchar(20)					not null,
	Compesation						varchar(20)					not null
)


//------------------------------------------------------------------------

CREATE PROC changePeriodStatus
	@sched_id			int,
	@status				varchar(30)
as
update SchedulePeriod
SET  Status		= @status
	where
		schedperiod_id        = @sched_id

CREATE PROC checkforData
	@empid				int,
	@dates				varchar(10)
as
select *
from ActualAttendance
where
employeeid = @empid and date = @dates

CREATE PROC checkforDataCorrected
	@empid				int,
	@dates				varchar(10)
as
select *
from ImportedAttendance
where
employeeid = @empid and date = @dates

CREATE PROC DeleteEmployee
	@id			int
as
	delete Employee
	where id = @id

CREATE PROC deleteRcode
	@rcode			varchar(5)
as
delete from RcodeTable
where Rcode_ID = @rcode

CREATE PROC deleteSchedPeriod
	@schedperiod  int
as
	delete from SchedulePeriod
	where schedperiod_id = @schedperiod

CREATE PROC DeleteScode
		@code		varchar(20)
	as
	delete from ScodeTable
	where Scode_ID = @code

CREATE PROC GetAllRcode
as
select *
from RcodeTable

CREATE PROC getAllRotationSched
as
select *
from RotationSchedule

CREATE PROC GetAllSchedulePeriod
as
select *
from SchedulePeriod

CREATE PROC GetAllZipCodes
as
select *
from ZipCode
order by code

CREATE PROC getEmployeeid
	@rot_id		int
as
select emp_id
from EmployeeSchedule
where rotation_id = @rot_id

CREATE PROC GetEmployeeList
as
select *
from Employee
INNER JOIN Job
ON Employee.job_id = Job.id
INNER JOIN ZipCode
ON Employee.zip_code = ZipCode.code

CREATE PROC GetJobList
as
select *
from Job
order by title

CREATE PROC getRCODE
@schedperiod_id			int,
@dates					varchar(10)
as
select rcode_id
from RotationSchedule
where schedperiod_id = @schedperiod_id and date = @dates

CREATE PROC getRcodeandScode
	@emp_id			int,
	@date			varchar(10)
as
select rcode_id, scode_id
from EmployeeSchedule
inner join RotationSchedule
on EmployeeSchedule.rotation_id = RotationSchedule.rotation_id
where emp_id = @emp_id and RotationSchedule.date = @date

CREATE PROC getRcodeInRotationSchedule
	@period_id		int,
	@date			varchar(10)
as
select *
from RotationSchedule
where schedperiod_id = @period_id and date = @date

CREATE PROC getRotationID
	@rcode				varchar(10),
	@scode_id			varchar(10),
	@schedid			int,
	@dates				varchar(10)
as
	select rotation_id
	from RotationSchedule
	where  rcode_id = @rcode and scode_id = @scode_id and schedperiod_id = @schedid and date = @dates

CREATE PROC getRotationIDValidation
@sched_id		int,
@date			varchar(10)
as
select rotation_id
from RotationSchedule
where schedperiod_id = @sched_id and date = @date

CREATE PROC GetRotationScheduleDates
	@schedulerperiodid		int,
	@rcodeid				varchar(1)
as
	select [date]
	from RotationSchedule
	where schedperiod_id = @schedulerperiodid and rcode_id = @rcodeid

CREATE PROC getScheduleForAWeek
	@emp_id			int,
	@sched_id		int
as
select scode_id, date
from EmployeeSchedule
inner join RotationSchedule
on EmployeeSchedule.rotation_id = RotationSchedule.rotation_id
where emp_id = @emp_id and RotationSchedule.schedperiod_id = @sched_id

CREATE PROC GetScode
as
select *
from ScodeTable

CREATE PROC getScodeFromRotationSchedule
@rcode    varchar(10),
@dates	  varchar(10)
as
select scode_id
from RotationSchedule
where rcode_id = @rcode and date = @dates

CREATE PROC getSelectedEmployeeDetails
		@emp_id			int
as
select *
from Employee
INNER JOIN Job
ON Employee.job_id = Job.id
INNER JOIN ZipCode
ON Employee.zip_code = ZipCode.code
where @emp_id = Employee.id

CREATE PROC getSelectedSchedulePeriod
	@id			int
as
	select *
	from SchedulePeriod
	where schedperiod_id = @id

CREATE PROC getSelectedScode
@code			varchar(10)
as
select *
from ScodeTable
where Scode_ID = @code

CREATE PROC getSpecificEmployee
@emp_id			int
as
select firstname, middlename, lastname
from Employee
where id = @emp_id

CREATE PROC getSpecificEmployeeSchedule
	@rotationperiod		int,
	@emp_id				int,
	@date				varchar(10)
as
select *
from EmployeeSchedule
inner join RotationSchedule
on EmployeeSchedule.rotation_id = RotationSchedule.rotation_id
where RotationSchedule.rotation_id = @rotationperiod and emp_id = @emp_id and RotationSchedule.date = @date

CREATE PROC GetSpecificZipcode
	@code		varchar(100)
as
SELECT municipality
from ZipCode
where code = @code

CREATE PROC getSpecifiRcode
	@rcode		varchar(20)
as
select *
from RcodeTable
where Rcode_ID = @rcode

CREATE PROC rotationDates
@sched_id			int
as
select date
from RotationSchedule
where schedperiod_id = @sched_id

CREATE PROC SaveActualAttendance
	@empid					int,
	@date					varchar(20),
	@1stshiftIn				varchar(10),
	@1stshiftOut			varchar(10),
	@2ndshiftIn				varchar(10),
	@2ndshiftOut			varchar(10),
	@overtimeIn				varchar(10),
	@overtimeOut			varchar(10)
AS
	INSERT INTO ActualAttendance(employeeid,[date],firstshiftIn,firstshiftOut,secondshiftIn,secondshiftOut,overtimeIn,overtimeOut)
	values(@empid,@date,@1stshiftIn,@1stshiftOut,@2ndshiftIn,@2ndshiftOut,@overtimeIn,@overtimeOut)


CREATE PROC SaveEmployee
	@lastname				varchar(50),
	@firstname				varchar(50),
	@middlename				varchar(50),
	@gender					char(1),
	@birthdate				varchar(60),
	@photo					varchar(MAX),
	@signature				varchar(MAX),
	@jobid					int,
	@address				varchar(100),
	@zip_code				CHAR(4),
	@email_address			varchar(100),	
	@UMID					varchar(30),	
	@TIN					varchar(30),
	@BankAccountNumber		varchar(30),	
	@TaxExemptionStatus		varchar(30),	
	@DailyContractRate		varchar(30),		
	@OverTime				varchar(30),		
	@phone_no				varchar(MAX),
    @homephone				varchar(MAX)

as
	insert into Employee(lastname,firstname,middlename,gender,birthdate,photo,[signature],job_id,[address],zip_code,
	email_address,UMID,TIN,BankAccountNumber,TaxExemptionStatus,DailyContractRate,OverTime,phone_no,homephone)
				values (@lastname,@firstname,@middlename,@gender,@birthdate,@photo,@signature,@jobid,@address,@zip_code,
				@email_address,@UMID,@TIN,@BankAccountNumber,@TaxExemptionStatus,@DailyContractRate,@OverTime,@phone_no,@homephone)


CREATE PROC saveEmployeeSched
	@rotation_id			int,
	@emp_id					int
as
	insert into EmployeeSchedule(rotation_id,emp_id)
	values(@rotation_id,@emp_id)

CREATE PROC SaveImportedAttendance
	@empid					int,
	@date					varchar(20),
	@1stshiftIn				varchar(10),
	@1stshiftOut			varchar(10),
	@2ndshiftIn				varchar(10),
	@2ndshiftOut			varchar(10),
	@overtimeIn				varchar(10),
	@overtimeOut			varchar(10)
AS
	INSERT INTO ImportedAttendance(employeeid,[date],firstshiftIn,firstshiftOut,secondshiftIn,secondshiftOut,overtimeIn,overtimeOut)
	values(@empid,@date,@1stshiftIn,@1stshiftOut,@2ndshiftIn,@2ndshiftOut,@overtimeIn,@overtimeOut)

CREATE PROC SaveRcode
	@rcode		varchar(3),
	@desc		varchar(100),
	@scode1		varchar(5),
	@scode2		varchar(5),
	@scode3		varchar(5),
	@scode4		varchar(5),
	@scode5		varchar(5)
as
		insert into RcodeTable(Rcode_ID,[desc],scode1,scode2,scode3,scode4,scode5)
		values(@rcode,@desc,@scode1,@scode2,@scode3,@scode4,@scode5)


CREATE PROC saveRotationSchedule
		@rcode_id			varchar(1),
		@scode_id			varchar(5),
		@schedulePeriod		int,
		@date				varchar(10)
as
	insert into RotationSchedule(rcode_id,scode_id,schedperiod_id,[date])
	values (@rcode_id,@scode_id,@schedulePeriod,@date)


CREATE PROC saveSchedulePeriod
	@begindate		varchar(20),
	@enddate		varchar(20),
	@status			varchar(20),
	@num			int
as
	insert into SchedulePeriod(beginDate,endDate,Status,withSchedule)
	values(@begindate,@enddate,@status,@num)


CREATE PROC SaveSCODE
		@code			varchar(20),
		@description	varchar(100),
		@firstIn		varchar(100),
		@firstOut		varchar(100),
		@secondIn		varchar(100),
		@secondOut		varchar(100)

as

	INSERT INTO ScodeTable(Scode_ID,[desc],firstTimeIn,firstTimeOut,SecondTimeIn,SecondTimeOut)
	values (@code,@description,@firstIn,@firstOut,@secondIn,@secondOut)


CREATE PROC selectEmployeeDayOff
	@schedperiodID				int,
	@date						varchar(10)
as
	select emp_id
	from EmployeeOff
	where schedperID = @schedperiodID and date = @date

CREATE PROC selectEmployeeSchedule
@rotation_id			int
as
select *
from EmployeeSchedule
where rotation_id = @rotation_id

CREATE PROC setEmployeeOff
	@empid				int,
	@schedperiodID		int,
	@date				varchar(10)
as
	insert into EmployeeOff(emp_id,schedperID,[date])
	values(@empid,@schedperiodID,@date)


CREATE PROC updateEmployee
	@empid					int,
	@lastname				varchar(50),
	@firstname				varchar(50),
	@middlename				varchar(50),
	@gender					char(1),
	@birthdate				varchar(60),
	@photo					varchar(MAX),
	@signature				varchar(MAX),
	@jobid					int,
	@address				varchar(100),
	@zip_code				CHAR(4),
	@email_address			varchar(100),	
	@UMID					varchar(30),	
	@TIN					varchar(30),
	@BankAccountNumber		varchar(30),	
	@TaxExemptionStatus		varchar(30),	
	@DailyContractRate		varchar(30),		
	@OverTime				varchar(30),		
	@phone_no				varchar(30),
    @homephone				int
as
	UPDATE Employee
	SET lastname		=	@lastname,
		firstname		=	@firstname,
		middlename		=	@middlename,
		gender			=	@gender,
		birthdate		=	@birthdate,
		photo			=	@photo,
		[signature]		=	@signature,
		job_id			=	@jobid,
		[address]		=	@address,
		zip_code		=	@zip_code,
		email_address	=	@email_address,
		UMID			=	@UMID,
		TIN				=	@TIN,
		BankAccountNumber = @BankAccountNumber,
		TaxExemptionStatus= @TaxExemptionStatus,
		DailyContractRate = @DailyContractRate,
		OverTime		  = @OverTime,
		phone_no		  = @phone_no,
		homephone		  = @homephone
	where
		id				=	@empid


CREATE PROC updateRcode
	@rcodeId		varchar(10),
	@desc			varchar(100),
	@scode1			varchar(10),
	@scode2			varchar(10),
	@scode3			varchar(10),
	@scode4			varchar(10),
	@scode5			varchar(10),
	@flag			int
as
			update RcodeTable
			set 
			[desc]		 =       @desc,
			scode1		 =		 @scode1,
			scode2		 =	     @scode2,
			scode3		 =		 @scode3,
			scode4		 =		 @scode4,
			scode5       =       @scode5
			where
			Rcode_ID	 =		 @rcodeId


			
CREATE PROC UpdateScode
	@code		varchar(5),
	@desc		varchar(100),
	@firstIn		varchar(5),
	@firstOut		varchar(5),
	@secondIn		varchar(5),
	@secondOut		varchar(5)
as
	UPDATE ScodeTable
	SET  Scode_ID		= @code,
		 [desc]			= @desc,
		 firstTimeIn	= @firstIn,
		 firstTimeOut	= @firstOut,
		 SecondTimeIn	= @secondIn,
		 SecondTimeOut	= @secondOut
	where
		Scode_ID        =@code



CREATE PROC updateWithSchedule
		@withSchedule		int,
		@schedperiod		int
as
	update SchedulePeriod
	set
		withSchedule		=			@withSchedule
	where schedperiod_id = @schedperiod


Create Proc getEmployeeScheduleForPayroll
	@emp_id				int
as
select *
from RotationSchedule
inner join EmployeeSchedule
on EmployeeSchedule.rotation_id = RotationSchedule.rotation_id
where emp_id = @emp_id


/* SA Pagibig ini */
insert into PhilHealthContribution(MonthlyRange, Compesation)
values ('below-1500','0.01')
insert into PhilHealthContribution(MonthlyRange, Compesation)
values ('1500-above','0.02')


/* SA Philhealth ini */
insert into PhilHealthContribution(MonthlyRange, Compesation)
values ('below-10000','137.00')
insert into PhilHealthContribution(MonthlyRange, Compesation)
values ('10000.1 - 11000','151.25')
insert into PhilHealthContribution(MonthlyRange, Compesation)
values ('11000.1 - 12000','165.00')
insert into PhilHealthContribution(MonthlyRange, Compesation)
values ('12000.1-13000','178.75')
insert into PhilHealthContribution(MonthlyRange, Compesation)
values ('13000.1-14000','192.50')
insert into PhilHealthContribution(MonthlyRange, Compesation)
values ('14000.1-15000','206.25')
insert into PhilHealthContribution(MonthlyRange, Compesation)
values ('15000.1-16000','220.00')
insert into PhilHealthContribution(MonthlyRange, Compesation)
values ('16000.1-17000','233.75')
insert into PhilHealthContribution(MonthlyRange, Compesation)
values ('17000.1-18000','247.50')
insert into PhilHealthContribution(MonthlyRange, Compesation)
values ('18000.1-19000','261.25')
insert into PhilHealthContribution(MonthlyRange, Compesation)
values ('19000.1-20000','275.00')
insert into PhilHealthContribution(MonthlyRange, Compesation)
values ('20000.1-21000','288.75')
insert into PhilHealthContribution(MonthlyRange, Compesation)
values ('21000.1-22000','302.50')
insert into PhilHealthContribution(MonthlyRange, Compesation)
values ('22000.1-23000','316.25')
insert into PhilHealthContribution(MonthlyRange, Compesation)
values ('23000.1-24000','330.00')
insert into PhilHealthContribution(MonthlyRange, Compesation)
values ('24000.1-25000','343.75')
insert into PhilHealthContribution(MonthlyRange, Compesation)
values ('25000.1-26000','357.50')
insert into PhilHealthContribution(MonthlyRange, Compesation)
values ('26000.1-27000','371.25')
insert into PhilHealthContribution(MonthlyRange, Compesation)
values ('27000.1-28000','385.00')
insert into PhilHealthContribution(MonthlyRange, Compesation)
values ('28000.1-29000','398.75')
insert into PhilHealthContribution(MonthlyRange, Compesation)
values ('29000.1-30000','412.50')
insert into PhilHealthContribution(MonthlyRange, Compesation)
values ('30000.1-31000','426.25')
insert into PhilHealthContribution(MonthlyRange, Compesation)
values ('31000.1-32000','440.00')
insert into PhilHealthContribution(MonthlyRange, Compesation)
values ('32000.1-33000','453.75')
insert into PhilHealthContribution(MonthlyRange, Compesation)
values ('33000.1-34000','467.50')
insert into PhilHealthContribution(MonthlyRange, Compesation)
values ('34000.1-35000','481.25')
insert into PhilHealthContribution(MonthlyRange, Compesation)
values ('35000.1-36000','495.00')
insert into PhilHealthContribution(MonthlyRange, Compesation)
values ('36000.1-37000','508.75')
insert into PhilHealthContribution(MonthlyRange, Compesation)
values ('37000.1-38000','522.50')
insert into PhilHealthContribution(MonthlyRange, Compesation)
values ('38000.1-39000','536.25')
insert into PhilHealthContribution(MonthlyRange, Compesation)
values ('39000.1-39999','543.13')
insert into PhilHealthContribution(MonthlyRange, Compesation)
values ('40000-above','550.00')

/* SA SSS ini */
insert into SSSContribution(MonthlyRange, Compesation)
values ('below-2249','250')
insert into SSSContribution(MonthlyRange, Compesation)
values ('2250-2749','310')
insert into SSSContribution(MonthlyRange, Compesation)
values ('2750-3249','370')
insert into SSSContribution(MonthlyRange, Compesation)
values ('3250-3749','430')
insert into SSSContribution(MonthlyRange, Compesation)
values ('3750-4249','490')
insert into SSSContribution(MonthlyRange, Compesation)
values ('4250-4749','550')
insert into SSSContribution(MonthlyRange, Compesation)
values ('4750-5249','610')
insert into SSSContribution(MonthlyRange, Compesation)
values ('5250-5749','670')
insert into SSSContribution(MonthlyRange, Compesation)
values ('5750-6249','730')
insert into SSSContribution(MonthlyRange, Compesation)
values ('6250-6749','790')
insert into SSSContribution(MonthlyRange, Compesation)
values ('6750-7249','850')
insert into SSSContribution(MonthlyRange, Compesation)
values ('7250-7749','910')
insert into SSSContribution(MonthlyRange, Compesation)
values ('7750-8249','970')
insert into SSSContribution(MonthlyRange, Compesation)
values ('8250-8749','1030')
insert into SSSContribution(MonthlyRange, Compesation)
values ('8750-9249','1090')
insert into SSSContribution(MonthlyRange, Compesation)
values ('9250-9749','1150')
insert into SSSContribution(MonthlyRange, Compesation)
values ('9750-10249','1210')
insert into SSSContribution(MonthlyRange, Compesation)
values ('10250-10749','1270')
insert into SSSContribution(MonthlyRange, Compesation)
values ('10750-11249','1330')
insert into SSSContribution(MonthlyRange, Compesation)
values ('11250-11749','1390')
insert into SSSContribution(MonthlyRange, Compesation)
values ('11750-12249','1450')
insert into SSSContribution(MonthlyRange, Compesation)
values ('12250-12749','1510')
insert into SSSContribution(MonthlyRange, Compesation)
values ('12750-13249','1570')
insert into SSSContribution(MonthlyRange, Compesation)
values ('13250-13749','1630')
insert into SSSContribution(MonthlyRange, Compesation)
values ('13750-14249','1690')
insert into SSSContribution(MonthlyRange, Compesation)
values ('14250-14749','1750')
insert into SSSContribution(MonthlyRange, Compesation)
values ('14750-15249','1830')
insert into SSSContribution(MonthlyRange, Compesation)
values ('15250-15749','1890')
insert into SSSContribution(MonthlyRange, Compesation)
values ('15750-16249','1950')
insert into SSSContribution(MonthlyRange, Compesation)
values ('16250-16749','2010')
insert into SSSContribution(MonthlyRange, Compesation)
values ('16750-17249','2070')
insert into SSSContribution(MonthlyRange, Compesation)
values ('17250-17749','2130')
insert into SSSContribution(MonthlyRange, Compesation)
values ('17750-18249','2190')
insert into SSSContribution(MonthlyRange, Compesation)
values ('18250-18749','2250')
insert into SSSContribution(MonthlyRange, Compesation)
values ('18750-19249','2310')
insert into SSSContribution(MonthlyRange, Compesation)
values ('19250-19749','2370')
insert into SSSContribution(MonthlyRange, Compesation)
values ('19750-above','2430')


insert into ZipCode (code, municipality)
values('4432','Baao')
insert into ZipCode (code, municipality)
values('4436','Balatan')
insert into ZipCode (code, municipality)
values('4435','Bato')
insert into ZipCode (code, municipality)
values('4404','Bombon')
insert into ZipCode (code, municipality)
values('4433','Buhi')
insert into ZipCode (code, municipality)
values('4430','Bula')
insert into ZipCode (code, municipality)
values('4406','Cabusao')
insert into ZipCode (code, municipality)
values('4405','Calabanga')
insert into ZipCode (code, municipality)
values('4401','Camaligan')
insert into ZipCode (code, municipality)
values('4402','Canaman')
insert into ZipCode (code, municipality)
values('4429','Caramoan')
insert into ZipCode (code, municipality)
values('4411','Del Gallego')
insert into ZipCode (code, municipality)
values('4412','Gainza')
insert into ZipCode (code, municipality)
values('4428','Garchitorena')
insert into ZipCode (code, municipality)
values('4422','Goa')
insert into ZipCode (code, municipality)
values('4431','Iriga City')
insert into ZipCode (code, municipality)
values('4425','Lagunoy')
insert into ZipCode (code, municipality)
values('4407','Libmanan')
insert into ZipCode (code, municipality)
values('4409','Lupi')
insert into ZipCode (code, municipality)
values('4403','Magarao')
insert into ZipCode (code, municipality)
values('4413','Milaor')
insert into ZipCode (code, municipality)
values('4414','Minalabac')
insert into ZipCode (code, municipality)
values('4434','Nabua')
insert into ZipCode (code, municipality)
values('4400','Naga City')
insert into ZipCode (code, municipality)
values('4419','Ocampo')
insert into ZipCode (code, municipality)
values('4416','Pamplona')
insert into ZipCode (code, municipality)
values('4417','Pasacao')
insert into ZipCode (code, municipality)
values('4418','Pili')
insert into ZipCode (code, municipality)
values('4424','Presentacion')
insert into ZipCode (code, municipality)
values('4410','Ragay')
insert into ZipCode (code, municipality)
values('4421','Sagnay')
insert into ZipCode (code, municipality)
values('4415','San Fernando')
insert into ZipCode (code, municipality)
values('4423','San Jose')
insert into ZipCode (code, municipality)
values('4408','Sipocot')
insert into ZipCode (code, municipality)
values('4427','Siruma')
insert into ZipCode (code, municipality)
values('4420','Tigaon')
insert into ZipCode (code, municipality)
values('4426','Tinambac')


insert into Job(title,[desc])
values('Administrator','A person who handles all the employee information, overall control in anything')
insert into Job (title,[desc])
values('Sales Associate','A person who is in charge in managing sales')
insert into Job (title,[desc])
values('Janitor','A person who cleans the vicinity')