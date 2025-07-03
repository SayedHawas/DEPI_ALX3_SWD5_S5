--Module 6
--Working with SQL Server 2016 Data Types
--============================================
/*
          -- Lessons :-
		  --------------
		               1- Introducing SQL Server 2016 Data Types.
					   2- Working with Character Data.
					   3- Working with Date and Time Data.
--Working with SQL Server Data Types
--==================================================================================
									--Data type 
									--T-SQL Variables Overview :
									--system supplied Data Types
-----------------------------------------------------------------------------------------
--1-Character DataTypes:
/*
Non-Unicode character char[(n)]                     1-8000                          n bytes, padded
					  varchar[(n)]                  1-8000                          n+2 bytes
					  varchar(max)                  1-2^31-1 characters             Actual length + 2
					  text							0ñ2(GB)  Deprecated
----------------------------------------------------------------------------
Unicode character     nchar[(n)]                    1ñ4,000 characters             2*n bytes, padded
					  nvarchar[(n)]					1ñ4,000 characters             (2*n) +2 bytes
					  nvarchar(max)					1-2^31-1 characters             Actual length + 2
					  ntext							0-2(GB)  Deprecated
----------------------------------------------------------------------------
*/
--2-Exact Numeric Data Types
/*
													
					  tinyint						0 to 255			           1
					  smallint                      -32,768 to 32,767              2
                      int							-2^31 (-2,147,483,648) to      4
                                                     2^31-1 (2,147,483,647)              
					  bigint                        -2^63 to 2^63-1                8
					                                (+/- 9 quintillion)
					  bit                           1/0 or true/false              1
                     -----------------------------------------------------------------------------
                     decimal/numeric               - 10^38 +1 through 10^38 ñ 1    7-15
					                                when maximum precision is used
      
					 money                          -922,337,203,685,477.5808       8
					                                to 922,337,203,685,477.5807
                     smallmoney                     - 214,748.3648 to 214,748.3647  4
*/
---------------------------------------------------------------------------------------------------
--Note that while decimal is ISO standards-compliant, decimal and numeric
--are equivalent to one another. Numeric is kept for compatibility with earlier versions of SQL Server

-- decimal [ (p[ ,s] )] and numeric[ (p[ ,s] )] 
--p (precision)  : The maximum total number of decimal digits that can be stored
--s (scale)  : The maximum number of decimal digits that can be stored to the right of the decimal point
/*
Precision           Storage bytes
1 - 9               5
10-19               9
20-28               13
29-38               17
*/
----------------------------------------------------------------------------------------------------
--ex:
--Decimal(5)
--Decimal(100)
--Decimal(5,2)
--Money & small money are monetary DataTypes
----------------------------------------------------------------------------------------------------
--3-Approximate Numeric Types
/*
Approximate numeric  float[(n)]                                                     8
					 real                                                           4
----------------------------------------------------------------------------------------------------
-- float [ (n) ]
--it must be a value between 1 and 53. The default value of n is 53.


 n value             Precision          Storage size
 1-24               7 digits           4 bytes
 25-53              15 digits          8 bytes

Note: SQL Server treats n as one of two possible values. If 1<=n<=24, n is treated as 24. If 25<=n<=53, n is treated as 53.
*/
----------------------------------------------------------------------------------------------------
--real is equivalent to float(24)
--4-Date and Time Data Types
/*
Data type category    SQL Server system supplied      Number of bytes           Range                         Formate                     
					  data types
---------------------------------------------------------------------------------------------------------------------------------------------
Date and time        datetime						   8                        from January 1, 1753          YYYY-MM-DD hh:mm:ss[.nnn]
														                        to December 31, 9999
					
					datetime2                          6-8                      0001-01-01                    YYYY-MM-DD hh:mm:ss[.nnnnnnn]
					                                                            00:00:00.0000000 
					                                                            through 9999-12-31 
					                                                            23:59:59.9999999
									 
					
					 smalldatetime					   4                        from January 1, 1900          YYYY-MM-DD hh:mm:ss
														                        to June 6, 2079 
														 

					 Time							   3-5	                    00:00:00.0000000              hh:mm:ss[.nnnnnnn]
					                                                            through 23:59:59.9999999
	                      
                     date                              3                        0001-01-01 through 9999-12-31 YYYY-MM-DD
                     
                     datetimeoffset                    8-10                     0001-01-01 00:00:00.0000000   YYYY-MM-DD hh:mm:ss[.nnnnnnn] 
                                                                                through 9999-12-31            [+|-]hh:mm    
                                                                                23:59:59.9999999 (in UTC)
*/
--------------------------------------------------------------------------------------------------
--5-Binary Data Types
--Binary String Data Types
/*   
Data type category    SQL Server system supplied   Range                       Number of bytes
					  data types
------------------------------------------------------------------------------------------------------
Binary Strings		  binary[(n)]                   1-8000                         n bytes
				      varbinary[(n)]				1-8000                         n bytes + 2
					  varbinary(max)				1-2.1 billion (approx) bytes   actual length + 2
-------------------------------------------------------------------------------------------------------
Image				  image                         0ñ2(GB)                        
-------------------------------------------------------------------------------------------------------
--6-Other Data Types
Data type category    SQL Server system supplied   Range                       Number of bytes
					  data types
---------------------------------------------------------------------------------------------------------
                     uniqueidentifier               Auto-generated     				    16
 					 xml							0ñ2(GB)                             0-2 GB 
           			 SQl_variant					0-8000 bytes                        Depends on content
					 rowversion                     Auto-generated                      8					
                     table                          N/A                                 N/A
-----------------------------------------------------------------------------------------------------------	
*/
 -- Lesson 1) Introducing SQL Server 2016 Data Types :-
 -------------------------------------------------------
      -- SQL Server Data Types :-	
	  ---------------------------
	   - Data types specify the type, length, precision, and scale of data. 
	   - SQL Server associates columns, expressions, variables, and parameters with data types.
	   - Data types determine what kind of data can be held:-
                                       Integers, characters, dates, money, binary strings, etc.
	   - SQL Server supplies :- 
	   1) Built-in data types.  
	   2) User defined custom data types.

	   - SQL Server Data types Categories :-  -- Please See Images 
	   -------------------------------------

	                                   - Exact Numeric.
									   - Approximate Numeric.
									   - Data & Time.
									   - Character Strings.
									   - Unicode Characters.
									   - Binary Strings.
									   - Others
---------------------------------------------------------------------------------------------------
		 Numeric Data Types :-
		--------------------------
           1) Exact Numeric:-
		   -------------------
			  - Integers :-    TinyInt , SmallInt , Int , BigInt .

			  - Decimal Or Numeric :-  Decimal Is ANSI Standard ,
			                           Numeric is kept for compatibility with earlier versions of SQL Server.

			  - Money & SmallMoney :- Money(8byte) Smallmoney(4byte) are also exact and map to Decimal and have 4 decimal points.

			  - Bit :-  1 , 0 OR NULL . 
		  2) Approximate Numeric :-
		   -------------------------
			  - Float :-  Like DECIMAL but only 6 right point of the decimal ,
			              Will Approximate values .
			         FLOAT(24) :- range 1 to 24 = 4bytes
			         FLOAT(53) :- range 25 to 53 = 8bytes

			  - Real :-  ISO synonym for float(24) = 4bytes
*/
--Examples For Numeric Data Types :-
---------------------------------------
--TinyInt -- (0) TO (255) 1byte
DECLARE @TinyInt TINYINT = 300   --erro if try 300
SELECT @TinyInt 
GO
--SmallInt -- (-32,768) TO (+32,768) 2bytes
DECLARE @SMALLINT SMALLINT = -32769   -- error if try 33000
SELECT @SMALLINT
GO
--Int  -- (-2,147,483,648) TO (+2,147,483,647) 4bytes
DECLARE @INT INT = 200000000000000  -- error if try 3000000000
SELECT @INT
GO
--BigInt  -- (-9,223,372,036,854,775,808) TO (+9,223,372,036,854,775,807) 8bytes
DECLARE @BIGINT BIGINT = 9000000000000000  --error if try 10000000000000000000
SELECT @BIGINT
GO

-- SmallMoney -- (-213,748.3648) TO (+213,748.3647) 4bytes
DECLARE @SMALLMONEY SMALLMONEY = 200123.3212     --error if try 300,2000.2134
SELECT @SMALLMONEY 
GO
-- Money -- (-922,337,203,685,477.5808) TO (-922,337,203,685,477.5807) 8bytes
DECLARE @MONEY MONEY = 900400300200100.1234    --error if try 950400300200100.1234
SELECT @MONEY 
GO
--Bit -- (0) Or (1) Or (NULL) 1byte
DECLARE @BIT BIT = NULL     --if try any other number will show 1
SELECT @BIT 
GO
/*
 DECIMAL (P,S) & NUMERIC (P,S) 
--P (Precision) :- The maximum total number of decimal digits that can be stored(38).
--S (Scale) :- The maximum number of decimal digits that can be stored to the right of the decimal point.
--Both have (18, 0) as default (precision,scale) parameters in SQL server.
Storage :-
-----------
Precision           Storage bytes
1 - 9               5
10-19               9
20-28               13
29-38               17
*/

--Example DECIMAL 1)
DECLARE @DECIMAL DECIMAL(4,2) = 42.12  --error if try 321.21
SELECT @DECIMAL
GO
--Example DECIMAL 2)
DECLARE @DECIMAL DECIMAL(6,1) = 23.231  --error if try 1234221.22
SELECT @DECIMAL
GO
--Example DECIMAL 3)
DECLARE @DECIMAL DECIMAL = 23.231  -- no (0) so default will be (18.0)
SELECT @DECIMAL
GO
--Example DECIMAL 4)
DECLARE @DECIMAL DECIMAL(30,10) = 3123123.123123  --error if try more than 30 digits.
SELECT @DECIMAL
GO
-- DECIMAL = NUMERIC 
-- Example NUMERIC 
DECLARE @NUMERIC NUMERIC(5,4) = 2.121133 --error if try 22.22
SELECT @NUMERIC
GO
-- Example FLOAT 
DECLARE @FLOAT FLOAT(24) = 2.1211367
SELECT @FLOAT
GO
-- Example REAL 
DECLARE @REAL REAL = 2.1211367 -- REAL not using (n) because it always (24) 
SELECT @REAL
GO
/*
-- 3) Binary String Data Types :-
---------------------------------
         - Binary string data types allow a developer to store binary information,
		   Such as serialized files, images, bytestreams, and other specialized data.

              - BINARY(n)       :- Fixed-width   = n bytes
              - VARBINARY(n)    :- Varying-width = n bytes + 2bytes
			  - VARBINARY(MAX)  :- MAX-Width 1-2.1 billion bytes = Actual length + 2bytes
*/
-- Example Binary
DECLARE @BINARY BINARY(4) = 123
SELECT @BINARY
GO
-- Example VarBinary
DECLARE @VARBINARY VARBINARY(5) = 12321
SELECT @VARBINARY
GO
-- Example VarBinary(max)
DECLARE @VARBINARY VARBINARY(MAX) = 12312111
SELECT @VARBINARY
GO
/*
-- 4) Other Data Types :-  -- Rarely Used
---------------------------
   - In addition to numeric and binary types, SQL Server also supplies some other data types,
     allowing you to store and process XML, generate globally unique identifiers (GUIDs),
	 represent hierarchies, and more. Some of these have limited use, others are more generally useful.

         - Rowversion       :-  Binary value, auto-incrementing when a row in a table is inserted or updated.

		 - Uniqueidentifier :-  Provides a mechanism for an automatically generated value that is unique across multiple systems.
		                        It is stored as a 16 byte value. by using the NEWID() system function.

		 - XML              :-  Allows the storage and manipulation of eXtensible Markup Language data. 
		                        This data type stores up to 2 GB of data per instance of the type. 
							    
		 - Cursors          :-  listed here for completeness. A SQL Server cursor is not a data type for storing data,
		                        But rather for use in variables or stored procedures .

		 - Hierarchyid      :-  Used to store hierarchical position data, such as levels of an organizational chart or bill of materials.
		                        SQL Server stores hierarchy data as binary data and exposes it through builtin functions. 
 
		 - SQL_variant      :-  Column data type that can store other common data types.
		                        Its use is not a best practice for typical data storage and may indicate design problems. 

		 - Table            :-  You will learn more about table types later in this course. 
		                        Note that table types cannot be used as a data type for a column (such as to store nested tables). 

*/

--XML
Declare @x xml =
 '<authors>
    <au_id>409-56-7008</au_id>
    <au_lname>Bennet</au_lname>
    <au_fname>Abraham</au_fname>
  </authors>
'
Select @x

-- Example RowVersion 
CREATE TABLE ExampleTable1 (PKey int PRIMARY KEY, VersionCol rowversion) 
GO
INSERT ExampleTable1(PKey)VALUES(1),(2)
SELECT * FROM  ExampleTable1;
GO

-- Example Uniqueidentifier
DECLARE @GUID Uniqueidentifier = NEWID()   -- Run this again , result will change random
SELECT @GUID
GO

-- Example SQL_Variant      -- Accept all types of data , no recommended
DECLARE @SQL_V1 SQL_Variant = 0 ,
        @SQL_V2 SQL_Variant = '4/4/2000' ,
		@SQL_V3 SQL_Variant = $123.112 ,
		@SQL_V4 SQL_Variant = 32

SELECT @SQL_V1 AS BIT ,
       @SQL_V2 AS DATE,
	   @SQL_V3 AS MONEY,
	   @SQL_V4 AS INT
GO 
/*
  -- Data Type Precedence :- 
  --------------------------
      - Which data type will be chosen when expressions of different types are combined.
      - Data type with the lower precedence will implicitly converted to the data type with the higher precedence.
      - Conversion to  lower precedence must be made explicitly Using (CAST OR CONVERT functions)
      - 1. XML 2. Datetime2 3. Date 4. Time 5. Decimal 6. Int 7. Tinyint 8. Nvarchar 9. Char 
*/
-- Example 
DECLARE @TINYINT  TINYINT = 100
DECLARE @SMALLINT  SMALLINT = 1000
SELECT  @TINYINT + @SMALLINT
DECLARE @RESULT sql_variant = @TINYINT + @SMALLINT
SELECT  @RESULT
SELECT	sql_variant_property(@RESULT, 'BaseType')  -- To Show The Result data type will be SMALLINT
GO
/*
-- Convert Data Type To another :- 
------------------------------------
    - Data type conversion scenarios :- 
                 A) When data is moved, compared, or combined with other data.
                 B) During variable assignment.
                 C) When using any operator that involves two operands of different types.
                 D) When T-SQL code explicitly converts one type to another, using a CAST or CONVERT function.
	- Conversion Types :-
	             A) Implicit conversion :- When comparing data of one type to another, Transparent to user.
				 B) Explicit conversion :- Uses CAST or CONVERT functions
    - Not all conversions allowed by SQL Server.
*/
-- Example for Implicit Conversion Working 
DECLARE @myTinyInt TINYINT = 25,
        @myInt INT = 1000
SELECT @myTinyInt + @myInt
GO
-- Example for Implicit Conversion Failed 
DECLARE @char CHAR(3) = 'One',
        @int INT = 1 
SELECT @char + @int
GO
-- Example for Explicit Conversion Using CAST 
-- Syntax :- CAST('OldDataType' AS 'NewDataType') 
DECLARE @char CHAR(3) = 'One',
        @int INT = 1 
SELECT @char + CAST(@int AS CHAR(1))
GO
-- Example for Explicit Conversion Using CONVERT
-- Syntax :- CONVERT ('NewDataType','OldDataType')
DECLARE @char CHAR(3) = 'One',
        @int INT = 1 
SELECT @char + CONVERT(CHAR(1),@int)
GO
-- Another Examples 
SELECT CONVERT(CHAR(4),1000) + 'k' AS 'Explicit Conversion'
GO
SELECT CAST(1000 AS CHAR(4)) + 'k' AS 'Explicit Conversion'
GO
--Conversion to type of lower precedence must be made explicitly (with CAST function)
--Example (low to high):
--CHAR -> VARCHAR -> NVARCHAR -> TINYINT -> INT -> DECIMAL -> TIME -> DATE -> DATETIME2 -> XML
-----------------------------------------------------------------------------------------------------------------------------------
/*
 -- Lesson 2) Working with Character Data :-
 --------------------------------------------
 
     -- Character Data Types :-
	 ---------------------------
	               - Store 1 byte per character.
				   - 265 Possible character Only - Limits language support
				   - Inserting data with single quotes, such as 'SQL'
				   
				   Types :- 
                           Char(n)      :-  1-8000 character . Take (n) as fixed storage.
						   Varchar(n)   :-  1-8000 character.  Take the actual character as storage.
						   Varchar(max) :-  2GB per instance.
						   Text         :-  Use Varchar(Max) instead of Text .
*/
-- Example Char(n)
DECLARE @Char CHAR(6) = 'Ahmed'  -- error if try 'AhmedAliMohamed'
SELECT @Char

-- Example Varchar(n)
DECLARE @VARChar VarChar(6) = 'Ahmed'  -- error if try 'AhmedAliMohamed'
SELECT @VARChar

-- Example Varchar(max)
DECLARE @VARCharMAX VARCHAR(Max) = 'One initial choice is character types based on a simple ASCII set versus Unicode'  
SELECT @VARCharMAX
/*
     -- Unicode Character Data Types :-
	 -----------------------------------
	               - Store 2 byte per character.
				   - 65000 Possible characters including special characters from many languages.
				   - Inserting data using this type have an N prefix (for National), such as N'SQL'. 
				   
				   Types :- 
                           NChar(n)      :-  1-8000 character . Take (n) as fixed storage.
						   NVarchar(n)   :-  1-8000 character.  Take the actual character as storage.
						   NVarchar(max) :-  2GB per instance.
						   NText         :-  Use NVarchar(Max) instead of NText 
*/
-- Example Nchar(n)
DECLARE @NCHAR NCHAR(10) = N'?hmed'
SELECT @NCHAR
-- Example NVARCHAR(n)
DECLARE @NVARCHAR NVARCHAR(10) = N'?hmed'
SELECT @NVARCHAR
-- Example NVARCHAR(max)
DECLARE @NVARCHARMAX NVARCHAR(MAX) = N'?hmed Íaaaaaa'
SELECT @NVARCHARMAX
GO
/* 
   -- String Concatenation :-
   ---------------------------
          - Using + (Plus) Or CONCAT() Function.
		  - When using + Concatenating a value with a NULL returns a NULL. 
		  - CONCATE() Converts NULL to empty string before concatenation.
*/
-- Example Concate Nulls using + (Plus) :-
USE Northwind
SELECT EmployeeID,City,Region,
       Country,( City + ', ' + region + ', ' + country ) AS Location
FROM Employees
GO
-- Example Concate Nulls using CONCATE() :-
USE Northwind
SELECT EmployeeID,City,Region,
	   Country,CONCAT( City , ', ' , region , ', ' , country ) AS Location
FROM Employees
GO
/*
       -- Character String Functions :-
	   --------------------------------
	   - In addition to retrieving character data as-is from SQL Server,
	      you may also need to extract portions of text or determine the location of characters within a larger string. 
		  SQL Server provides a number of builtin functions to accomplish these tasks. Some of these functions include:-
*/
-- FORMAT() :- new to SQL Server 2012 - allows you to format an input value to a character string  
USE Northwind
SELECT TOP (3) orderid,
       OrderDate,
       FORMAT(orderdate,'d','en-us') AS US,
	   FORMAT(orderdate,'d','de-DE') AS DE 
FROM Orders
GO
----------------------------------------------------------------------
--Collation
-------------
/*
- In addition to size and character set, SQL Server character data types are assigned a collation.
- This assignment may be at one of several levels: the server instance,
   the database (default), or a collation assigned to a column in a table or in an expression.
- Collations are collections of properties that govern several aspects of character data:-
    ï Supported languages 
	ï Sort order 
	ï Case sensitivity 
	ï Accent sensitivity  

- Note A default collation is established during the installation of SQL Server but can be overridden on a per-database or per-column basis.
-  As you will see, you may also override the current collation for some character data by explicitly setting a different collation in your query.
*/


-- All SQL SERVER Collations
--Query MetaData
SELECT * FROM   fn_helpcollations()
GO

-- COLLATE Option to Force collation.
USE Northwind
SELECT EmployeeID,FirstName,lastname  
FROM   Employees 
WHERE FirstName = 'nancy'


SELECT EmployeeID,FirstName,lastname
FROM   Employees 
WHERE FirstName COLLATE Latin1_General_CS_AS = N'nancy'



SELECT EmployeeID,FirstName,lastname
FROM   Employees 
WHERE FirstName COLLATE Latin1_General_CS_AS = N'Nancy'
GO

-- Example For Collation Case InSensitive (CI) & Case Sensitive CS
USE tempdb
CREATE TABLE Table1
(
    CI VARCHAR(15) COLLATE Latin1_General_CI_AS,
    CS VARCHAR(14) COLLATE Latin1_General_CS_AS
) 
GO
INSERT Table1
VALUES ('Ahmed','Ali'),
       ('ahmed','ali'),
       ('mohamed','mohamed'),
       ('Mohamed','Mohamed');
GO

-- Retrieve Data
SELECT *FROM Table1
GO

-- Order By CI
SELECT * FROM Table1
ORDER BY CI
GO
-- Order By CS
SELECT * FROM Table1
ORDER BY CS
GO


-- Example of Width Sensitive (WS) and Width Insensitive (WI)
USE TempDB
GO
CREATE TABLE Table2
(IDWI NVARCHAR(100) COLLATE Latin1_General_CI_AI,
 IDWS NVARCHAR(100) COLLATE Latin1_General_CI_AI_WS)
GO
INSERT INTO Table2
VALUES ('E=mc≤ Albert Einstein',
        'E=mc≤ Albert Einstein')
GO
SELECT * FROM Table2
WHERE IDWI LIKE 'E=mc2%'
GO
SELECT *
FROM Table2
WHERE IDWS LIKE 'E=mc2%'


SELECT *
FROM Table2
WHERE IDWS LIKE 'E=mc≤%'


SELECT lastname
FROM employees
WHERE firstname = '√Õ„œ';

SELECT lastname
FROM employees
WHERE firstname  COLLATE Latin1_General_CS_AS = N'√Õ„œ';

SELECT lastname
FROM employees
WHERE firstname = N'√Õ„œ';


GO
--===================================================================================
--Character String Functions
---------------------------
-- SUBSTRING() :- for returning part of a character string given a starting point and a number of characters to return
SELECT SUBSTRING('Microsoft SQL Server',11,3) AS Result
-- LEFT() :- for returning the leftmost or rightmost characters, respectively, up to a provided point in a string 
SELECT LEFT('Microsoft SQL Server',9) AS Result
-- RIGHT() :- for returning the leftmost or rightmost characters, respectively, up to a provided point in a string
SELECT RIGHT('Microsoft SQL Server',10) AS Result
-- LEN() and DATALENGTH()  :-
-- Providing metadata about the number of characters or number of bytes stored in a string. Given a string padded with spaces
SELECT LEN('Microsoft SQL Server     ')   AS [LEN],
       DATALENGTH('Microsoft SQL Server     ')  AS [DATALEN]
-- CHARINDEX() :- for returning a number representing the position of a string within another string
SELECT CHARINDEX('SQL','Microsoft SQL Server') AS Result
-- REPLACE() for substituting one set of characters with another set within a string
SELECT REPLACE('Microsoft SQL Server Denali','Denali','2012') AS Result
--  UPPER() and LOWER() :- for performing case conversions 
SELECT UPPER('Microsoft SQL Server') AS 'Upper',
       LOWER('Microsoft SQL Server') AS 'Lower' 
GO
-----------------------------------------------------------------------------------------------------------------------------------
/*
The LIKE predicate can be used to check a character string for a match with a pattern
Patterns are expressed with symbols:-

    % (Percent) represents a string of any length
    _ (Underscore) represents a single character
   [<List of characters>] represents a single character within the supplied list
   [<Character> - <character>] represents a single character within the specified range
   [^<Character list or range>] represents a single character not in the specified list or range
   ESCAPE Character allows you to search for characters that would otherwise be treated as part of a pattern  - %, _, [, and ])
*/
-----------------------------------------------------------------------------------------------------------------------------------
/*
 -- Lesson 3) Working with Date and Time Data :-
 -----------------------------------------------
    -- Date and Time Data Types :-
	-------------------------------
	   - Older versions of SQL Server supported only DATETIME and SMALLDATETIME.
	   - DATE, TIME, DATETIME2, and DATETIMEOFFSET introduced in SQL Server 2008.
*/
-- DATETIME :- 'YYYYMMDD hh:mm:ss.nnn' 
DECLARE @DATETIME DATETIME ='20120212 12:30:15.123' 
SELECT @DATETIME

-- SMALLDATETIME 'YYYYMMDD hh:mm'  
DECLARE @SMALLDATETIME SMALLDATETIME ='20120212 12:30' 
SELECT @SMALLDATETIME

-- DATETIME2 'YYYY-MM-DD' 
DECLARE @DATETIME2 DATETIME2 ='2012-02-12'
SELECT @DATETIME2

-- DATE 'YYYYMMDD' 'YYYY-MM-DD' 
DECLARE @DATE DATE ='20120212' 
SELECT @DATE

-- TIME 'hh:mm:ss.nnnnnnn' 
DECLARE @TIME TIME ='12:30:15.1234567' 
SELECT @TIME

-- DATETIMEOFFSET 'YYYYMMDD hh:mm:ss.nnnnnnn [+|-]hh:mm'  
DECLARE @DATETIMEOFFSET DATETIMEOFFSET = '20120212 12:30:15.1234567 +02:00'  
SELECT @DATETIMEOFFSET


-- Datetime Column :
-- ------------------
 SELECT 
     Convert(time(7),'2007-05-08 12:35:29. 1234567' )  AS '( Time ) new in 2008' 
    ,Convert(date,'2007-05-08 12:35:29. 1234567'    )  AS '( Date ) new in 2008' 
    ,Convert(smalldatetime,'2007-05-08 12:35:29.123')  AS 'Smalldatetime' 
    ,Convert(datetime,'2007-05-08 12:35:29.123'     )  AS 'Datetime' 
    ,Convert(datetime2(7),'2007-05-08 12:35:29. 1234567 +12:15') AS 
        '( Datetime2 ) new in 2008'
    ,Convert(datetimeoffset(7),'2007-05-08 12:35:29.1234567 +12:15' ) AS 
        '( Datetimeoffset ) new in 2008'

 --======================================================================================================================
declare @id uniqueidentifier
set @id = NEWID()
select @id
--=====================
--Conversion 
 ------------

 --Step 2: Use implicit conversion in a query
--Demonstrate implicit conversion from the lower type (varchar)
-- to the higher (int)
SELECT 1 + '2' AS result;

--Step 3: Use implicit conversion in a query
--Demonstrate implicit conversion from the lower type (varchar) 
-- to the higher (int)
--NOTE: THIS WILL FAIL

SELECT 1 + 'abc' AS result;

--Step 4: Use explicit conversion in a query

SELECT CAST(1 AS VARCHAR(10)) + 'abc' AS result;

SELECT CAST('09/15/2000' AS datetime2) AS [Using CAST Function]
SELECT CONVERT(datetime2, '09/15/2000') AS [Using CONVERT Function]

--------------------------------------------------
--Conversion
--Implicit
DECLARE @myTinyInt  TINYINT = 25;
DECLARE @myInt  INT = 9999;
SELECT @myTinyInt + @myInt;

--check this?
DECLARE @somechar CHAR(5) = '6';
DECLARE @someint INT = 1
SELECT @somechar + @someint;

--what about this??
DECLARE @somechar CHAR(3) = 'six';
DECLARE @someint INT = 1
SELECT @somechar + @someint;

--Explicit
DECLARE @somechar CHAR(3) = 'six';
DECLARE @someint INT = 1
SELECT @somechar + cast( @someint as char(1)) ;

declare @date date = getdate();
select @somechar + cast ( @date AS nvarchar);
----------------------------------------------------------------------
