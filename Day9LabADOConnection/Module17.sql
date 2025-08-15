/*
 Module 17
 Implementing Error Handling
-----------------------------------


-- lessons :-
--------------
       
	    1- Using TRY / CATCH Blocks.
		2- Working with Error Information.


---------------------------------------------------------------------------------------------

-- Lesson 1) Using TRY / CATCH Blocks :-
--------------------------------------------

   - Try...Catch paradigm it is basically two blocks of code with your stored procedures 
     that lets you execute some code, this is the Try section and if there are errors they are handled in the Catch section. 

   - Structured exception handling allows a centralized response to runtime errors :-
                          A) TRY to run a block of commands and CATCH any errors
						  B) Execution moves to the CATCH block of commands when an error occurs
						  C) No need to check every statement to see if an error occurred
						  D) You decide whether the transaction should be rolled back, errors logged, etc.

   - Not all errors can be caught by TRY / CATCH :- 
                          A) Syntax or compile errors.
						  B) Some name resolution errors.

   - TRY block defined by BEGIN TRY...END TRY statements :-
                          A) Place all code that might raise an error between them
						  B) No code may be placed between END TRY and BEGIN CATCH
						  C) TRY and CATCH blocks may be nested
						  D) CATCH block defined by BEGIN CATCH...END CATCH

   - Execution moves to the CATCH block when catchable errors occur within the TRY block
*/

-- Example
-- SQL SERVER 2000
SELECT 1 /0 --perform an operation 
IF @@ERROR<> 0   PRINT 'Error :P hahahah :P'
GO

-- SQL SERVER 2005 - 2016 
-- TRY ---- CATCH 

-- Example 
-- Create Stored Procedure
Create PROC Test1
	@First int, @Second int
AS
	BEGIN TRY 
			SELECT @First/@Second
	END TRY
	BEGIN CATCH 
			SELECT (@First+@Second) *2
	END CATCH
GO

-- Run it , no error , 'Catch not working'
EXEC TEST1 4,2   -- No Error

-- Run it to get errro ' Catch working '
EXEC TEST1 10,0   -- Error 10/0 Can't happen

---------------------------------------------------------------------------------------------
/*
-- Lesson 2) Working with Error Information  :-
--------------------------------------------

          - SQL Server provides a set of metadata about runtime errors 
		    that may be queried (usually in a CATCH block) to return information about runtime errors.
		
		  - See Images Folder...

		  - SQL Server 2012 provides the new THROW statement.
		  - THROW enables you to include error-handling code in a CATCH block 
		    to raise the original runtime error and pass it to an upper layer,
		    such as a calling procedure or client application. 

		 - In previous versions of SQL Server, 
		   developers and administrators used the RAISERROR function to pass user-defined error messages to procedures and client applications.

		 - Use THROW instead of RAISERROR .
*/

-- Example For Error System Functions
-------------------------------------

select * from sys.messages

BEGIN TRY
    SELECT 1/0
END TRY
BEGIN CATCH
    SELECT ERROR_NUMBER() AS ErrorNumber
     ,ERROR_SEVERITY() AS ErrorSeverity
     ,ERROR_STATE() AS ErrorState
     ,ERROR_PROCEDURE() AS ErrorProcedure
     ,ERROR_LINE() AS ErrorLine
     ,ERROR_MESSAGE() AS ErrorMessage;
END CATCH
GO

-- Example For THROW :-
-- Anywhere 
------------------------
THROW 50002,  -- this number is message number , USER range of 50000 to 2147483647. , System range 1-49999
'I Can send any message any time :P :P ',1


-- Example For THROW :-
-- With TRY....CATCH :-
------------------------
BEGIN TRY
	SELECT 100/0 AS 'Problem'
END TRY
BEGIN CATCH
	PRINT 'error :P';
	THROW 50022,'Type Anything You Want',16
END CATCH



/*
-- How to read SQL Server error messages :- 
-------------------------------------------

Here is a typical error message:-

Server: Msg 547, Level 16, State 1, Line # Message Text….
---------------------------------------------------------------------

select * from sys.messages

1) Message number :- 
               - Each error message has a number. You can find most of the message numbers in the table sysmessages.
			   - (There some special numbers like 0 and 50000 that do not appear there.) 
			   - Message numbers from 50001 and up are user-defined. Lower numbers are system defined.


2) Severity level :-
               - A number from 0 to 25. If the severity level is in the range 0-10, the message is informational or a warning, and not an error.
			   - Errors resulting from programming errors in your SQL code have a severity level in the range 11-16. 
			   - Severity levels 17-25 indicate resource problems, hardware problems or internal problems in SQL Server, 
			     and a severity of 20 or higher is fatal, the connection will be terminated.

3) State :-
               - a value between 0 and 127. 
			   - The meaning of this item is specific to the error messages. 
			   - Microsoft has not documented these values.

4) Line :-
               - Line number within the procedure/function/trigger/batch the error occurred.
			   - A line number of 0 indicates that the problem occurred when the procedure was invoked.

5) Message text :-
               - The actual text of the message that tells you what went wrong.
			   - You can find this text in master..sysmessages, or rather a template for it, with placeholders for names of databases, tables etc.


-- These levels are documented in in the section :-
    Troubleshooting->Error Messages->Error Message Formats->Error Message Severity Levels in Books Online.
