--Module 2
--Introduction to T-SQL Querying
/*
Introducing T-SQL
Understanding Sets
Understanding Predicate Logic
Understanding the Logical Order of Operations in SELECT Statements

*/
--==============================================================================================================
/* Module Topics :-
-------------------
  - SQL History.
  - About T-SQL.
  - T-SQL Elements.
  - T-SQL Categories.
  - Query Logical Processing.

==================================================================================================================

-- SQL History :
-----------------
- Transact-SQL, or T-SQL, is the language in which you will write your queries for Microsoft® SQL Server® 2016
- T-SQL is Microsoft’s implementation of the industry standard Structured Query Language. 
- Originally developed to support the new relational data model at International Business Machines (IBM) in the early 1970s, 
  SQL became a standard of the American National Standards Institute (ANSI) and of the International Organization for Standardization (ISO) in the 1980s.
- The ANSI standard has gone through several revisions, including SQL-89 and SQL-92
- Besides Microsoft’s implementation as T-SQL in SQL Server, Oracle implements SQL as PL/SQL.

====================================================================================================================
-- About T-SQL 
---------------
/*
Structured Query Language (SQL)
Developed by IBM in the 1970s
Adopted by ANSI and ISO standards bodies
Widely used in the industry
PL/SQL (Oracle), SQL Procedural Language (IBM), Transact-SQL (Microsoft)
Transact-SQL is commonly referred to as T-SQL
The querying language of SQL Server 2016
SQL is declarative
Describe what you want, not the individual steps
*/

A) T-SQL is a declarative language, not a procedural language :
--------------------------------------------------------------
  1- declarative :you describe the data you wish to display.
  2- procedural  :you tell SQL Server exactly how to retrieve it.

- Example procedural :
1)  Open a cursor to consume rows, one at a time 
2)  Fetch the first cursor record. 
3)  Examine first row.  
4)  If the city is Portland, return the row. 
5)  Move to next row. 
6)  If the city is Portland, return the row. 
7)  Fetch the next record 
8)  (Repeat until end of table is reached). 

- Example declarative :
Display all customers whose city is Portland.


B) Predicate Logic :-
--------------------

 - A predicate is a property or expression that is true or false. this referred to as a Boolean expression.
 - Extend your understanding of predicates from two possible outcomes (true or false) to three: true, false, or unknown.
 - The use of NULLs as a mark for missing data or unknown.


C) The set theory :-
----------------------
 1) Collection :-
 - We can think of a set as a single unit (such as a table) that contains zero or more members of the same type.
 - For example, a Customers table represents a set, specifically the set of all customers. You will also see that the results of a SELECT statement also form a set.
 - It will be important to think of the entire set at all times, instead of thinking of individual members. 
 - Working with sets requires thinking in terms of operations that occur "all at once" instead of one-at-a-time. 
 
 2) Distinct or Unique :- 
 - All members of a set must be unique In SQL Server .
 - Uniqueness is typically implemented using keys, such as a primary key column .
 - it will be important to keep mindful of how you will be able to uniquely address each member of a set.

 3) No Order to result set :-
 ----------------------------
 - Provide your own sorting instructions because result sets are not guaranteed to be returned in any order.
 - Will do that using Order By in select statement.

========================================================================================================================================
-- T-SQL Categories :- 
-----------------------

A) Data Manipulation Language "DML" :-   Working with "DATA" in database.
   - SELECT
   - INSERT
   - DELETE 
   - UPDATE

B) Data Definition Language "DDL" :-  Working with "Objects" in database.
   - CREATE
   - ALTER
   - DROP
   - Truncate

C) Data Control Language "DCL" :-  Working as "Boundaries" in database.  "Permission".
   - Grant
   - Deny 
   - Revoke

The Focus in Query Course is DML and in SELECT STATEMENT Specifically.
SELECT also Called Data Query Language "DQL" .

===========================================================================================================================

-- T-SQL ELEMENTS 
-----------------

1) Comment :- 
--------------
 - Very Usefull in Documentation or working in a Team.
 - line Comment use " -- ".
 - Multi line or Block Comment use /* Comments */. 

2) Batch Separators :- 
----------------------
 - Batches are sets of commands sent to SQL Server as a unit.
 - We use GO for Separate between batches in SQL SERVER.
 - GO is not a SQL Server T-SQL command.

3) Control of Flow, Errors, Transactions :-
------------------------------------------
 - Allow you to control the flow of execution within code, handle errors, and maintain transactions.
 - Used in programmatic code objects Stored procedures, triggers, statement blocks.
 - We Will see in it in Module 18.
 - Control of Flow :     IF...ELSE  , WHILE , CONTINUE , BEGIN...END.
 - Error Handling  :     TRY...CATCH.
 - Transaction Control : BEGIN TRANSACTION , COMMIT TRANSACTION , ROLLBACK TRANSACTION.

4) Expressions :- 
------------------ 
 - Combination of identifiers, values, and operators evaluated to obtain a single result.
 - Can be used in SELECT statements , WHERE clause. */

-- Example For Expressions

-- Before Expressions FirstName and LastName not in the same Column

select 'Welcome in SQL Server 2016 Query '

USE northwind

select * from Employees

SELECT EmployeeID,FirstName,LastName,City 
FROM Employees
GO
-- After Expressions FirstName and LastName in the same Column using Alias FullName
USE northwind

select 100 + 50 ;

SELECT EmployeeID,FirstName + ' ' + LastName AS FullName,City 
FROM Employees
GO
/*

5) Variables :- 
-----------------
 - To create a local variable in T-SQL, you must provide a name, a data type, and an value
 - The name must start with a single @ (at) symbol           
 - ‘system variables’ named with a double @@
 - Must be declared and used within the same batch

-- Example For Variables 
*/

DECLARE @MyVar int = 30
SELECT @MyVar AS MyVariable
GO
--OR
DECLARE @MyVar int 
SET @MyVar = 30
SELECT @MyVar AS AnotherWaytoGiveValue
GO
/*

6) Functions :- 
----------------
 - There is user-defined functions "We Create" Or built-in system functions "System Create".
 - Functions will be covered in Module 8.

*/
-- Example For built in Function
SELECT GETDATE() AS WhatIsTheTimeNow
GO

/*

7) Predicates & Operators :- 
---------------------------
- Predicates (true or false) : IN,like (pattern),between.
- Comparison operators : =,<,>,<>,<=,>=.
- Logical operators : And ,OR ,NOT.
- Arithmetic operators : + / - * %
- concatenation : +
- NOT ANSI Standard :-  !=(not equal to), !>(not greater than), !<(not less than)
*/
-- Example For Operators
USE NORTHWIND
SELECT * FROM   Employees WHERE EmployeeID > 2
GO

USE NORTHWIND
SELECT * FROM   Employees WHERE  FirstName LIKE 'A%'
GO

USE NORTHWIND
SELECT * FROM   Employees WHERE  City IN ('London', 'Seattle', 'Tacoma')
GO
/*
 - Relational DB:
 -----------------
   - A relational database is a complex database that stores data in multiple tables that are interrelated. 
   - Usually the tables in a relational database have one-to-many relationships. 
    
 - Relations
-------------
   - One  To One
   - One  To Many
   - Many To Many

 - Normalization
 ----------------
   - Normalization is the process of organizing data in a database.
   - Reasonable normalization of the logical database design = best performance.

 - Database Objects
--------------------
   - Tables
   - Views
   - Indexes
   - Triggers
   - Stored Procedures
   - Constraints

- Control of Flow, Errors, and Transactions  
--------------------------------------------
  1- Allow you to control the flow of execution within code, handle errors, and maintain transactions
  2- Used in programmatic code objects Stored procedures, triggers, statement blocks

         1- Control of Flow :  IF...ELSE  , WHILE , CONTINUE , BEGIN...END
         2- Error Handling  :  TRY...CATCH
         3- Transaction Control : BEGIN TRANSACTION , COMMIT TRANSACTION , ROLLBACK TRANSACTION
===========================================================================================================

Two methods for marking text as comments
A block comment, surround text with /* and */
An inline comment, precede text with --
Many T-SQL editors will color comments as above
*/
--------------------------------------------------------------------------
/*
Batches are sets of commands sent to SQL Server as a unit
Batches determine variable scope, name resolution
To separate statements into batches, use a separator:
SQL Server tools use the GO keyword
GO is not an SQL Server T-SQL command
GO [count] executes the preceding batch [count] times
*/
--SQLCMD > 
--------------------------------------------------------------------------
/*
Elements of a SELECT Statement
Logical Query Processing
Applying the Logical Order of Operations to Writing SELECT Statements
*/

/*
=======================================================================================
-- Element          Expression                            Role
---------------------------------------------------------------------------------------
-- SELECT          <select list>              Defines which columns to return
-- FROM            <table source>             Defines table(s) to query
-- WHERE           <search condition>         Filters returned data using a predicate
-- GROUP BY        <group by list>            Arranges rows by groups
-- HAVING          <search condition>         Filters groups by a predicate
-- ORDER BY        <order by list>            Sorts the results
=======================================================================================


Logical Query Processing
------------------------
5. 	SELECT		<select list> 
1. 	FROM		<table source>
2. 	WHERE		<search condition>
3.	GROUP BY		<group by list>
4.	HAVING		<search condition>
6.	ORDER BY		<order by list>



*/
SELECT EmployeeId, YEAR(OrderDate) AS OrderYear
FROM Orders
WHERE CustomerId = 'TOMSP'
GROUP BY EmployeeId, YEAR(OrderDate)
HAVING COUNT(*) > 1
ORDER BY EmployeeId, OrderYear;

