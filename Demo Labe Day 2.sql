--Create Database 
--Create database <DataBaseName>
--School
Create database SchoolDB
GO
--change Context
use SchoolDB
--How to create table 
--Data type 
--INT 
--Decimal(6,2) 1234.56
--nvarchar(50) 
--Datetime
--Create table <table Name> (<ColName> <Type> , ....) 
--First Column  ID,  INT, Primary Key , identity

Create table Test (TeacherId INT Primary Key , FirstName nvarchar(50)) 
Create table test2 (ID INT Primary Key Identity , FirstName nvarchar(50))

--DDL Data definition Language
--Create  , alter , Drop
--DML  insert , 
select NewID()

--Context ==> Database 
--Entity  ==> table 
--Entry  ===> Row 
--Attr ==> column 
use SchoolDB

Drop table Table_1

Alter table test2 Add Code int 
Alter table test2 alter column FirstName nvarchar(100)

Alter table test2 Add Email varchar(150)
Alter table test2 Add [Select] varchar(150) --Not Null

Alter table test2 Drop column [Select]

--Create Database 
--Create table 
--First Column (ID INT Primary Key Identity)
--Alter table Add
--Alter table alter Column 
--alter table Drop Column 
--My ReName 
--Alter table test2 Rename From Code TO Serial 
 
sp_rename 'dbo.test2.Serials','Serial','Column'
--Exec sp_rename '',''

sp_helptext 'Sp_Rename'

