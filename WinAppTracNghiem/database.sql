create database WinAppTracNghiem
use WinAppTracNghiem
create table Accounts(
username varchar(15) primary key,
password varchar(15),
Role int,
Status nvarchar(10)
)
create table Semesters(
Code varchar(10) primary key,
Year int,
beginDate date,
endDate date
)
create table Courses(
Code varchar(10) primary key,
Title varchar(100)
)
create table Enroll(
Username varchar(15) references Accounts(username),
Semester varchar(10) references Semesters(Code),
Course varchar(10) references Courses(Code)
primary key (Username,Semester,Course)
)
create table TypeOfQuestion(
ID int primary key,
Name varchar(30)
)
create table Questions(
ID int IDENTITY(1,1) primary key,
Title text,
NumberOfAnswers int,
[Type] int references TypeOfQuestion(ID)
)
create table Answers(
ID int IDENTITY(1,1) primary key,
Content ntext
)
create table AnswersOfQuestion(
Question int references Questions(ID),
Answer int references Answers(ID),
IsTrue bit
primary key (Question,Answer)
)
create table ExamCode(
Code varchar(50) primary key,
Semester varchar(10) references Semesters(Code),
Course varchar(10) references Courses(Code),
DateBegin date,
TimeBegin float,
Long int
)
alter table ExamCode
add Status varchar(10)
alter table ExamCode
add NumberOfQuestion int
create table QuestionOfCode(
ExamCode varchar(50) references ExamCode(Code),
Question int references Questions(ID)
primary key (ExamCode,Question)
)
create table Practice(
username varchar(15) references Accounts(username),
ExamCode varchar(50) references ExamCode(Code),
TimeBegin datetime,
Long int,
Mark float,
Status varchar(10)
primary key (username,ExamCode)
)
alter table Practice
add Mark decimal(4,2)
alter table Questions
add Course varchar(10) references Courses(Code)
alter table Questions
alter column Title varchar(300)
alter table Answers
alter column Content varchar(300)
insert into Accounts
values ('admin','Admin123',1,'active'),('hoctthe170098','Hoc5050',2,'active')
insert into Accounts
values ('dungngu12345','Dungngu',2,'active')
insert into Courses
values (N'CSI104', N'Introduction to Computer Science'),(N'ITA203c', N'Management information systems'),
(N'PMG202c', N'Project management'),(N'CSD201', N'Data Structures and Algorithms'),
( N'CSD203', N'Data Structures and Algorithm with Python'), (N'DBI202', N'Introduction to Databases'),
(N'NWC203c', N'Computer Networking')
insert into TypeOfQuestion
values (1,'True/False'),(2,'One Answer'),(3,'Multi answer')
select * from Questions
select * from Answers
select * from AnswersOfQuestion
select * from ExamCode
select * from Enroll
select * from Accounts
select * from Semesters
select * from Courses
select * from QuestionOfCode
insert into Enroll
values ('hoctthe170098','Fa2023','DBI202')

