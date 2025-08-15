--========================
--Module 16
--Programming with T-SQL
--======================== 
/*
Controlling Program Flow

 --=======================================================================================================
 --Lesson 2: Controlling Program Flow
 --=================================

								--Understanding T-SQL Control-of-Flow Language
								--Working with IF…ELSE
								--Working with WHILE
*/
/*
--Understanding T-SQL Control-of-Flow Language
-----------------------------------------------
   SQL Server provides additional language elements that control the flow of execution of T-SQL statements
        - Used in batches, stored procedures, and multistatement functions

   Control-of-flow elements allow statements to be performed in a specified order or not at all
       - The default is for statements to execute sequentially

   Includes IF…ELSE, BEGIN…END, WHILE, RETURN, and others
*/
--=====
-- IF
--===== 
--True
--------

if 1=1
begin 
    print 'welcome in SQL'
end 
-------------------------------------------------------------------
/*
IF…ELSE uses a predicate to determine the flow of the code
The code in the IF block is executed if the predicate evaluates to TRUE 
The code in the ELSE block is executed if the predicate evaluates to FALSE or UNKNOWN
Very useful when combined with the EXISTS operator
*/
--IF ... Else
if 1=2
begin 
    print 'Hello in SQL'
end 
else
begin 
    print 'Finish  SQL Course'
end
 
----------------------------------
IF OBJECT_ID('dbo.t1') IS NULL
	PRINT 'Object does not exist';
ELSE
	select * from t1;
GO

--Meta Data Query 
select * from sys.dm_os_sys_info 
-- IF..Else Example :-
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES  WHERE TABLE_NAME = 'Employees')
   BEGIN 
         PRINT 'There is a Table'
		 select * from employees
   END 
ELSE
   BEGIN  
         PRINT 'Not Found' 
   END
GO
----------------------------------------------------------
--Working with WHILE
----------------------
-- WHILE enables code to execute in a loop
-- Statements in the WHILE block repeat as the predicate evaluates to TRUE
-- The loop ends when the predicate evaluates to FALSE or UNKNOWN
-- Execution can be altered by BREAK or CONTINUE
 -----------------------------
 --Loop While 
 Declare @x int = 1
 While (@X<=10)
 begin 
    Print concat('Welcome in SQL ',@x )
	set @x+=1 
 end 
 ----------------------------------------
 --break
 -------
 Declare @Number int = 1
 While (@Number<=10)
 begin 
    Print concat('Welcome in SQL ',@Number )
	set @Number= @Number+1 

	if(@number >5)
	  begin
	    break;
	  end
 end 
 -----------------------------------------------------
 --CONTINUE
 ------------
 Declare @Number int = 1
 While (@Number<=10)
 begin 
    Print concat('Welcome in SQL ',@Number )
	set @Number= @Number+1 

	if(@number <5)
	  begin
	    CONTINUE;
	  end
 end
 
 --------------------------------------------------------
 -- WHILE Example :-
DECLARE @empid AS INT = 1,
        @lname AS NVARCHAR(20)
WHILE  @empid <=5    
       BEGIN  
	        SELECT @lname = lastname 
			FROM Employees   
			WHERE EmployeeID = @empid  
			PRINT @lname  
			SET @empid += 1    
		END
GO 
/*
--===================================================================================================
