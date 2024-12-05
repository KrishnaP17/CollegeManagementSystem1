create database college;

create table NewAdmission(
	studentID int NOT NULL IDENTITY(1,1) primary key,
	fName varchar(250) NOT NULL,
	lName varchar(250) NOT NULL,
	mobile bigint NOT NULL,
	email varchar(150) NOT NULL,
	schoolName varchar(250) NOT NULL,
	gender varchar(10) NOT NULL,
	dob varchar(50) NOT NULL,
	duration varchar(120) NOT NULL,
	addres varchar(250) NOT NULL
)

alter table NewAdmission add subjects varchar(120); 

Select * from NewAdmission;

select max(studentID) from NewAdmission;



create table fees(
	fID int NOT NULL IDENTITY(1,1) primary key,
	studentID int NOT NULL,
	fees int NOT NULL
)
select * from fees;


create table NewTeacher(
	teacherID int NOT NULL IDENTITY(1,1) primary key,
	tfName varchar(250) NOT NULL,
	tlName varchar(250) NOT NULL,
	tGender varchar(10) NOT NULL,
	tSubject varchar(120) NOT NULL,
	tMobile bigint NOT NULL,
	tDOB varchar(50) NOT NULL,
	tEmail varchar(150) NOT NULL,
	tSchoolName varchar(250) NOT NULL,
	tAddress varchar(250) NOT NULL

)
select * from NewTeacher;

select max(teacherID) from NewTeacher;

insert into NewTeacher (teacherID, tfName, tlName, tGender, tSubject, tMobile, tDOB, tEmail, tSchoolName, tAddress) values (1, 'Krishna', 'Patel', 'Female', 'ITSC 1212', 9806166532, '03/17/2005', 'kpate234@charlotte.edu', 'UNCC', '465 Kate Dr');
