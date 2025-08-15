Select * from employees

/*
Module 18
Implementing Transactions
-----------------------------
-- lessons :-
--------------
	   1- Transactions and the Database Engine.
	   2- Controlling Transactions.
--------------------------------------------------------------------------------------------
-- Lesson 1) Transactions and the Database Engine  :-
-------------------------------------------------------
       - A transaction is a group of tasks defining a unit of work.
	   - The entire unit must succeed or fail together – no partial completion is permitted.
       - Individual data modification statements are automatically treated as standalone transactions.
       - User transactions can be managed with T-SQL commands: BEGIN/ COMMIT/ROLLBACK TRANSACTION.
	   - SQL Server uses locking mechanisms and the transaction log to support transactions.
	   - Transaction commands identify blocks of code that must succeed or fail together,
	         and provide points where database engine can roll back, or undo, operations.
---------------------------------------------------------------------------------------------
-- Lesson 2) Controlling Transactions  :-
-------------------------------------------
    - BEGIN TRANSACTION :-
	----------------------
	        - BEGIN TRANSACTION marks the starting point of an explicit, user-defined transaction.
			- Transactions last until :-
			               A) COMMIT statement is issued.
			               B) ROLLBACK is manually issued. 
						   C) The connection is broken and the system issues a ROLLBACK.
			- In your T-SQL code: Mark the start of the transaction's work.
	- COMMIT TRANSACTION :-
	-----------------------
	        - COMMIT ensures all of the transaction's modifications are made a permanent part of the database.
			- COMMIT frees resources, such as locks, used by the transaction
			- In your T-SQL code: If a transaction is successful, commit it.
	- ROLLBACK TRANSACTION :-
	-------------------------
	        - A ROLLBACK statement undoes all modifications made in the transaction ,
			  by reverting the data to the state it was in at the beginning of the transaction .
			- ROLLBACK frees resources, such as locks, held by the transaction.
			- Before rolling back, you can test the state of the transaction with the XACT_STATE function.
			- In your T-SQL code: If an error occurs, ROLLBACK to the point of the BEGIN TRANSACTION statement.
	- Using XACT_ABORT :- 
	-----------------------
	        - SQL Server does not automatically roll back transactions when errors occur.
			- To roll back, either use ROLLBACK statements in error-handling logic or enable XACT_ABORT.
			- XACT_ABORT specifies whether SQL Server automatically rolls back the current transaction when a runtime error occurs.
			- SET XACT_ABORT OFF is the default setting.
			- Change XACT_ABORT value with the SET command :- " SET XACT_ABORT ON "
----------------------------------------------------------------------------------------------------------------------------------
-- Understanding of Transactions and Locks
-- ---------------------------------------
-- Review On Transactions:
-- ----------------------
-1- Transactions allow you to define a unit of activity that will be considered 
    atomic :all or nothing.
-2- Transactions are known as ACID (Atomicity, Consistency, Isolation, and Durability).
    * Atomicity ( One Failed All Failed )
    * Consistency ( Data must be in a good form )
    * Isolation (Transaction must be isolated from others ) 
    * Durability (Transaction must be permanent in DB )
-3- Note : Whenever you submit a change to the database, SQL Server first checks 
           whether the pages that need to be affected already reside in cache.
           If they do, the pages are modified in cache. 
           If they don't, they're first loaded from disk into the cache and modified
           there. 
     -SQL Server records the changes in the database's transaction log. 
     Once in a while, a process called checkpoint flushes changed pages 
     ("dirty pages") from cache to the data portion of the database on disk.
-- Every transaction is recorded on DB log to  later recovery (Demonstration)
   Committed   --Rollforward ,written to DB
   Uncommitted --Rollback
-- Locking is used to prevent users from reading data  
   that is in the process of being modified
-- Locking is automatic.
-- Without locking, the database may become logically  incorrect, 
   updates may be lost, and queries against the data may produce 
   unexpected results.
-- SQL server automatically manages locking on the database or its objects OR -
   You Can use locking hints, 
   you use special statements to configure the rules for setting and    
   releasing locks. However, using locking hints is not recommended. 
-- Two main types of lock:
		Read locks – Allow others to read but not write
		Write locks – Stop others from reading or writing
-- Locks prevent update conflicts
*/
-- Managing Transactions:
-- Types of transactions
-- ---------------------
-- Autocommit Transactions (Default)
-- ---------------------------------
-- Every statement is committed or rolled back 
   --when it has completed
--If it completes successfully : it is committed
--If it fails : it is rolled back
-------------------------------------------------------------------
Create Proc Sp_Insert
As 
begin 
     begin try 
	          begin tran
			 --Insert table 1 ..
			 --Insert Table 2.
			 Select 'Welcome in Transaction'
			  commit
     End Try 
	 begin Catch
	         Rollback
			 print Error_Message()
	 End Catch

END 







CREATE TABLE NewTable (Id INT PRIMARY KEY, Info CHAR(3))   --fail
INSERT INTO NewTable VALUES (3, 'aaa')
INSERT INTO NewTable VALUES (1, 'bbb')
INSERT INTO NewTable VALUSE (3, 'ccc') -- Syntax Error
GO
SELECT * FROM NewTable -- Returns no rows.
GO
-------------------------------------------------------------------
--try
CREATE TABLE NewTable (Id INT PRIMARY KEY, Info CHAR(3))   --done
go
INSERT INTO NewTable VALUES (3, 'aaa')
INSERT INTO NewTable VALUES (1, 'bbb')
INSERT INTO NewTable VALUSE (3, 'ccc') -- Syntax Error
GO
SELECT * FROM NewTable -- Returns no rows.
GO
------------------------------------------------------------------- 
/*
- Committing inner transactions is ignored by the SQL Server Database Engine
- If the outer transaction is committed,the inner nested  transactions are also committed.
- If the outer transaction  is rolled back, then all inner transactions are also 
  rolled back
*/
-------------------------vip ex for Transaction ------------------------------
go
create database TranstestDB
go 
use TranstestDB
go 
create table names (ID int identity (1,1), name nvarchar(50),
                    city nvarchar(20),job nvarchar(20));
go 
create table Salary (SalaryID int identity(1,1),nameID int ,
                      Salary decimal (18,2), Bouns decimal (18,2),
					   dis decimal (18,2),net decimal (18,2))
------------------------------------------------
-- procerdue to insert into two Tables 
go
create proc SP_insert_With_Identity
--- table name
@name nvarchar (50),
@City nvarchar (20),
@job nvarchar (20),
---table salary 
@salary decimal (18,2)
as 
declare @nameID int
declare @bouns decimal (18,2) = @salary * 0.10
declare @dis decimal (18,2)   = @salary * 0.05
declare @net decimal (18,2)   = @salary +@bouns - @dis

insert into names values (@name , @city , @job)
set @nameId = (select SCOPE_IDENTITY())
insert into salary values (@nameID,@salary,@bouns,@dis,@net)

go 
exec SP_insert_With_Identity 'yasser','Cairo','Develper',2000

select * from names
select * from salary 
-----------------------------------------------------------
--With Transaction 
-- Do All Or Not All 
--error
------------------------------------------------------------
go
create proc SP_Make_Erro
--- table name
@name nvarchar (50),
@City nvarchar (20),
@job nvarchar (20),
@salary decimal (18,2)
as 
insert into names values (@name , @city , @job)
---table salary 
declare @nameID int
declare @bouns decimal (18,2) = @salary * 'yah'
declare @dis decimal (18,2)   = @salary * 0.05
declare @net decimal (18,2)   = @salary +@bouns - @dis
set @nameId = (select SCOPE_IDENTITY())
insert into salary values (@nameID,@salary,@bouns,@dis,@net)
go 

exec SP_Make_Erro 'yasser','Cairo','Deve',2000
select * from names
select * from salary 
-----------------------------------------------
-- To Soliving this problem 
go
Alter proc SP_Make_Tranc
--- table name
@name nvarchar (50),
@City nvarchar (20),
@job nvarchar (20),
@salary decimal (18,2)
as 
begin try 
	begin transaction --|tarnsaction
		insert into names values (@name , @city , @job)
		---table salary 
		declare @nameID int
		declare @bouns decimal (18,2) = @salary *.1
		declare @dis decimal (18,2)   = @salary * 0.05
		declare @net decimal (18,2)   = @salary +@bouns - @dis
		set @nameId = (select SCOPE_IDENTITY())
		insert into salary values (@nameID,@salary,@bouns,@dis,@net)
	commit transaction
end try
begin catch 
	rollback transaction 
	print error_message()
end catch 
go 
exec SP_Make_Tranc 'Mohamed','Cairo','Deve',2000
select * from names
select * from salary 
-------------------------------------------------------------------------------------------------

--===============================================================================================
-------------------------------------------------------------------------------------------------
/*
                 --Thank you Every One    ... :)   Keep Coding    Sayed Hawas
*/
-------------------------------------------------------------------------------------------------
--===================================================================================================================