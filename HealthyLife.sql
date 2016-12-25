begin transaction Tables
go

create table Specialization(
	Id int not null primary key identity(1,1),
	Name nvarchar(50) not null,
	[Description] nvarchar(200) null
)

create table [Address](
	Id int not null primary key identity(1,1),
	Country nvarchar(70),
	City nvarchar(70),
	TelNumber nvarchar(70),
	[Description] nvarchar(100)
)

create table [Account](
	Id int not null primary key identity(1,1),
	Name nvarchar(50) not null,
	SecondName nvarchar(50) not null,
	DateOfBirth DateTime,
	Email nvarchar(100) not null,
	[Password] nvarchar(50) not null,
	PasswordSalt nvarchar(255) not null,
	Photo nvarchar(250),
	AddressId int foreign key references [Address](Id),
	RoleId int foreign key references [Role](Id)
)

create table Doctor(
	Id int not null primary key identity(1,1),
	SpecializationId int foreign key references Specialization(Id),
	AccountId int foreign key references [Account](Id),
	DepartmentId int foreign key references Department(Id)
)

create table Patient(
	Id int not null primary key identity(1,1),
	SocialSecurityNumber nvarchar(100),
	AccountId int foreign key references [Account](Id)
)

--create table Reception(
--	Id int not null primary key identity(1,1),
--	Name nvarchar(100) not null,
--	[Description] nvarchar(250),
--	Price decimal
--)

create table Disease(
	Id int not null primary key identity(1,1),
	Name nvarchar(50) not null,
	[Description] nvarchar(250)
)

create table [Service](
	Id int not null primary key identity(1,1),
	--ReceptionId int foreign key references [Reception](Id),
	PatientId int foreign key references [Patient](Id),
	DoctorId int foreign key references [Doctor](Id),
	[Description] nvarchar(250),
	Price decimal,
	[Date] DateTime
)

create table PatientDisease(
	Id int not null primary key identity(1,1),
	StartDate DateTime,
	EndDate DateTime,
	DiseaseId int foreign key references Disease(Id),
	PatientId int foreign key references Patient(Id),
	ConditionId int foreign key references Condition(Id),
	[Description] nvarchar(250)
)

create table [Role](
	Id int primary key not null identity(1,1),
	Name nvarchar(50) not null
)

create table Department(
	Id int primary key not null identity(1,1),
	Name nvarchar(100) not null
)

create table Condition(
	Id int primary key not null identity(1,1),
	Name nvarchar(50) not null,
	[Description] nvarchar(250) null
)

commit transaction

