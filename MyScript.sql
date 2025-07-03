--T-SQL 
--Welcome in SQL 
/*
 Hello World 
 SQL Query 
*/
--Script -->Batch Go 
-- Services + Insance + Tools Connection 
-- Install Services Configuration (Instance )
-- Tools SSMS SQL Server Managment Studio 

PRINT 'Welcome in SQL '
print 'Welcome in SQL 2 '
Print 5+10
GO
select 'Sayed hawas' AS FullName
select 'Sayed hawas'  FullName
select FullName ='Sayed hawas'  
--Database  Collection Objects (Table , View , Function , SP , Schema ..)
--Exec Sp_help employees
--Query      SQL Command 
 --1) DDL Data Defination Lanaguage (Create , Alter , Drop) table 
 --2) DML Data Manipliation Lanuage (Insert , Update, Delete ,Select) Rows
 --3) DCL Data Control Language (Deny , Invoke...)
 --4)DQL Data Query Language (Select)
 ------------------------------------------------------
 --DML SELECT 
 --USE <Database Name> Context = Database 
 USE MASTER
 --Using Northwind 
 USE Northwind
 GO
 --Select From 
 --Select <List Of Colums> FROM <Table Name>
 SELECT * FROM Employees
 SELECT FirstName From Employees
 SELECT FirstName , LastName From Employees
 Select FirstName , LastName , FirstName +' '+ LastName As [Full Name] FROM Employees
 
 --DDL
    --Create Database 
	--Drop Database 
	--Create table 
	--Drop table 
	--Alter table Add 
	--Alter table Drop

	--Truncate Table  Delete Data And rest Identity 

 --DML
   -- Select * from 
   -- Insert Into
   -- Insert Bulk
   -- Update 
   -- Update Bulk Without Where 
   -- Delete Where 
   -- Delete Bulk  Keeping Identity
 --DQL

 --Create Database <Database>  MyDatabaseDB , CompanyDB , SchoolDB
 Create Database CompanyDB
  --Prefix lkp   tbl
 --Lookup Data  LkpCities
 --Tranasction  tblInvoices 
 Drop Database CompanyDB
 --Create Table <Table Name >(ID 
 USE CompanyDB
 GO
 Create table TblEmployees(employeeId int primary key identity,
 FullName nvarchar(50),
 Email varchar(100),
 Mobile varchar(11),
 Job nvarchar(50),
 Age tinyint)

 Drop table TblEmployees
 altEr table TblEmployees Add  DOB Datetime 

 Alter table TblEmployees Drop Column DOB
-- (ID , EmployeeId )- INT , Primary Key ,Identity
-----------------------------------------------------
USE CompanyDB
--DML
Select * from tBlemployEes
GO
Insert into TblEmployees (FullName,Email ,Mobile ,Job ,Age )
values ('Sayed Hawas','Sayed@yahoo.com',012354687,'Developer',40)


Insert into TblEmployees 
values ('Ahmed Ali','Ahmed@yahoo.com',012354222,'DBA',25)


Insert into TblEmployees (FullName,Job ,Age )
values ('Retaj','DR',26)



Insert into TblEmployees (Age , Job ,FullName )
values (24,'Eng','Mariem')

--Insert Bulk
Insert into TblEmployees 
values ('Ahmed Ali1','Ahmed1@yahoo.com',012354222,'DBA',25),
('Ahmed Ali2','Ahmed2@yahoo.com',012354222,'DBA',25),
('Ahmed Ali3','Ahmed3@yahoo.com',012354222,'DBA',25)


Insert into TblEmployees 
values ('Toto','Ahmed1@yahoo.com','012555555','DBA',25)

--Update 
update TblEmployees Set Email = 'Retaj@yahoo.com' ,Mobile= 012365478 where  employeeID = 3 

update TblEmployees Set Email = 'M_@yahoo.com' ,Mobile= 01225658 where  employeeID = 4 

Update TblEmployees Set Mobile = '0'+Mobile 


--Delete 
Delete From TblEmployees Where EmployeeId = 5 

Delete From TblEmployees

--DDL 
Truncate table TblEmployees


SET IDENTITY_INSERT [dbo].[TblEmployees] ON 
Insert into TblEmployees (EmployeeID ,FullName,Email ,Mobile ,Job ,Age )
values (10,'Sayed Hawas','Sayed@yahoo.com',012354687,'Developer',40)
SET IDENTITY_INSERT [dbo].[TblEmployees] OFF 

Select * from tblEmployees

Insert into TblEmployees (FullName,Email ,Mobile ,Job ,Age )
values ('Sayed Hawas','Sayed@yahoo.com',012354687,'Developer',40)

------------------------------------------------
GO
DECLARE @Name char(10);  --AnSI
Set @Name = 'Ahmed Alis'
Select @Name 
GO
DECLARE @Name nchar(10);
Set @Name = N'أحمد علي'
Select @Name 

GO
DECLARE @Name varchar(8000);
Set @Name = 'Ahmed Alis'
Select @Name 
GO
DECLARE @Name nvarchar(4000);
Set @Name = 'Ahmed Alis'
Select @Name 

DEclare @x Decimal(9,2)   --123.55
--nvarchar(max)

sp_help varchar
Sp_help nvarchar


-- How to reset Ientity Without Delete Data ?
--Task :
--Create Database With YourName DB
--Create Table Employee
--Insert  4 Rows 
--Update 
--Delete 
--Truncate
--Send Your Script   Send WhatSapp Private 