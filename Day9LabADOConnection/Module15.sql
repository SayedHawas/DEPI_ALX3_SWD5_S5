/*
Module 15 
Executing Stored Procedures
------------------------------

				Querying Data with Stored Procedures
				Passing Parameters to Stored Procedures
				Creating Simple Stored Procedures
				Working with Dynamic SQL


Lesson 1: Querying Data with Stored Procedures
-----------------------------------------------
			Examining Stored Procedures
			Executing Stored Procedures


Examining Stored Procedures
	- Stored procedures are collections of T-SQL statements stored in a database
	- Procedures can return results, manipulate data, and perform administrative actions on the server
	- With other objects, procedures can provide a trusted application programming interface to a database, insulating applications from database structure changes
			* Use views, functions, and procedures to return data
			* Use procedures to modify and add new data
			* Alter procedure definition in one place, rather than update application code

Executing Stored Procedures
      -Invoke a stored procedure using EXECUTE or EXEC
      -Call procedure with two-part name
      -Pass parameters in @name=value form, using appropriate data type
*/

-- Procedure  DML (Insert , Update , Delete , Select ) DDL Create . alter . Drop 
-- Paramteres  In , OUT 
-- Function  (Select)  Param IN 

Select * from employees  -- 5

--Create , Alter , Drop
GO
Create Procedure Sp_ShowEmployee
As 
BEGIN 
       --Code 
	   Select * from employees 
END 
GO
--Execute 
Exec Sp_ShowEmployee 


GO
Create Procedure Sp_ShowEmployeeById
@id int --IN
As 
BEGIN 
       --Code 
	   Select * from employees Where EmployeeID = @id 
END 
GO

exec Sp_ShowEmployeeById 5


GO
Create Procedure Sp_ShowEmployeeWithName
@letter nvarchar(50), --IN
@RowCounter int out   --OUT
As 
BEGIN 
       --Code 
	Select * from employees Where FirstNAme Like  '%'+@letter+'%'
	Set @RowCounter =@@ROWCOUNT
END 
GO

Declare @result int
exec Sp_ShowEmployeeWithName 'm', @result out
Select @result





use Northwind
go
--Create Procedure
Create Proc sp_ShowEmployees
as 
begin 
   select employeeId , FirstName,Lastname,Country from employees
end

--call Procedure 
exec sp_ShowEmployees
------------------------------------------------------------------------------------------------
--Lesson 2: Passing Parameters to Stored Procedures
-------------------------------------------------------
			--Passing Input Parameters to Stored Procedures

/*
Parameters are defined in the header of the procedure code, including name, data type and direction (input is default)
Parameters are discoverable using SQL Server Management Studio and the sys.parameters view
To pass parameters in an EXEC statement, use names defined in procedure

*/
go
Create  Proc sp_ShowEmployeesByCountry @Country nvarchar(50) 
as 
begin 
   select employeeId , FirstName,Lastname,Country 
   from employees
   where Country = @Country
end
go

exec sp_ShowEmployeesByCountry 'usa'

-------------------------------------------------------------------------------
--MetaData Query 
Exec Sp_help 'Sp_ShowEmployeeWithName'
Exec Sp_helptext 'Sp_ShowEmployeeWithName'

Declare @x nvarchar(50) 
set @x = 'Select * from Customers'
Exec Sp_ExecuteSQL @x


GO
Create Proc Sp_DynamicSQL
@database nvarchar(50),
@table nvarchar(50),
@Cols nvarchar(50),
@Cond nvarchar(50)
AS
begin 
   Declare @x nvarchar(500)
   Set @x = 'USE '+@database+ ' Select '+@Cols+' from '+@table+ ' Where '+ @Cond
   Exec Sp_ExecuteSQL @x
end 

exec Sp_DynamicSQL 'Northwind','Customers','[CustomerID],[CompanyName],[Country]','Country = ''USA'''
exec Sp_DynamicSQL 'Northwind','Employees','[employeeID],[FirstName],[Country]','Country = ''UK'''

/*
Writing Queries with Dynamic SQL

 - Using sp_executesql
			- Accepts string as code to be run
			- Supports input, output parameters for query
			- Allows parameterized code while minimizing risk of SQL injection
			- Can perform better than EXEC due to query plan reuse

Syntax:-
--------
DECLARE @sqlcode AS NVARCHAR(256) = 	N'<code_to_run>';
EXEC sys.sp_executesql @statement = @sqlcode;

DECLARE @sqlcode AS NVARCHAR(256) = N'SELECT GETDATE() AS dt';
EXEC sys.sp_executesql @statement = @sqlcode;



*/
DECLARE @sqlcode AS NVARCHAR(256) = N'SELECT GETDATE() AS dt';
EXEC sys.sp_executesql @statement = @sqlcode;

declare @Database nvarchar(100) = 'Northwind';
declare @Table nvarchar(100) = 'Employees';
declare @Columns nvarchar(200) = 'EmployeeId , FirstName,LastName , Country ';
declare @Condition nvarchar(100) = 'country = ''usa''';

declare @Command  nvarchar(max) = 'use '+ @database +';'+' select '+ @Columns + ' From ' + @table + ' Where ' + @condition;  
EXEC sys.sp_executesql  @command










