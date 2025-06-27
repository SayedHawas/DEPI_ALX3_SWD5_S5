/*
The Basic Architecture of SQL Server
SQL Server Editions and Versions
Getting Started with SQL Server Management Studio
*/
/*
-- Introduction to Microsoft SQL SERVER 2016 --
------------------------------------------------

-- Lessons :- 
              1) Introducing SQL Server 2016
			  2) Getting Started with SSMS (SQL Server Management Studio) 
			  
===========================================================================

--== Lesson 1) Introducing SQL Server 2016 :- 
----------------------------------------------- 

-- Lesson Topics :- 
                   - SQL SERVER Architecture
				   - SQL SERVER Versions
				   - SQL SERVER Editions
				   - SQL SERVER Databases
				   - Course Sample Databases


* SQL SERVER Architecture :- 
----------------------------
 - SQL SERVER = (Services + Instances + Tools)

 - Services :-
    - SQL Server database engine :- responsible for executing commands with T-SQL and other features of SQL Server.
    - SQL Server Agent :- responsible for executing scheduled jobs, monitoring the system and administrative tasks. 
    - Business intelligence components :- which include Reporting Services, Analysis Services, Integration Services. 
 
 - Instances :- 
    - An instance is a copy of the SQLSERVR.EXE executable program.
    - An instance represents the programs and resource allocations that support a single copy of SQL Server.
    - Each instance is isolated from other instances on the same computer.
	- An instance > database engine > databases.

 - Tools :-
    - SSMS :- an integrated management, development, and querying application working with your databases. 
    - SQLCMD :- command-line client to submit T-SQL commands as an alternative to the graphical SSMS. 
    - SQL Server Configuration Manager :- tool for administrators for managing SQL Server software on client machines.
    - SQL Server Installation Center :- provides the ability to add, remove, modify SQL Server program features. 
--==========================================================
--Notes :-
----------:
Database Engine Instances (SQL Server)
An instance of the Database Engine is a copy of the sqlservr.exe 
executable that runs as an operating system service. 
Each instance manages several system databases and one or more user databases.
Each computer can run multiple instances of the Database Engine. 
Applications connect to the instance in order to perform work in a database 
managed by the instance.

Instances:-
An instance of the Database Engine operates as a service that handles all
application requests to work with the data in any of the databases managed 
by that instance. 
It is the target of the connection requests (logins) from applications. 
The connection runs through a network connection if the application 
and instance are on separate computers.


DUMP (Transact-SQL)
The DUMP statement is included for backward compatibility. 
This feature will be removed in a future version of Microsoft SQL Server. 
Avoid using this feature in new development work, and plan to modify 
applications that currently use this feature. Instead, use BACKUP.

Makes a backup copy of a database (DUMP DATABASE) or a copy of the 
transaction log (DUMP TRANSACTION). 

--==========================================================

*) SQL SERVER Versions :-
--------------------------
      - Version 1.0 in 1989 is the first version 
	  - Version 13.0 in 2016 is the last version till now.
	  - Version 4.21 in 1994 and later Support Windows OS.
	  - SQL Server 2008 R2 (release2) in 2010 is independent version not update or service pack for SQL Server 2008.

	   |===============|===================|
	   |   Version     |    Release Year   |
	   |---------------|-------------------|
	   |     1.0       |      1989         |
	   |     1.1       |      1991		   |
	   |     4.2	   |      1992		   |
	   |    4.2.1	   |      1994		   |
	   |     6.0	   |      1995		   |
	   |     6.5       |      1996		   |
       |     7.0	   |      1998		   |
	   |    2000	   |      2000		   |
	   |    2005	   |      2005		   |
	   |    2008       |      2008		   |
	   |    2008 R2	   |      2010		   |
	   |    2014	   |      2014		   |
	   |    2016	   |      2016		   |
	   |====================================




*) SQL SERVER Editions :-
--------------------------
      - SQL Server ships in several editions that provide different feature sets targeting different business scenarios.
	  - Enterprise :- the full features edition of SQL Server. 
      - Express    :- the limited features edition of SQL Server .
	  - Other Editions :- Standard, BI, Web, CE, Developer
	  - SQL Server builds : http://sqlserverbuilds.blogspot.com/


*) SQL SERVER Databases :- 
---------------------------
      - Database in SQL Server = Containers + Boundaries + Files
	  - Containers like :- Tables, Views, Functions, Procedures, Schemas, etc..
	  - Boundaries like :- Security accounts, Permissions, etc..
	  - Files like :- Data file .MDF,  Log file .LDF, Secondary data file .ndf
	  
	  - Databases Types in SQL SERVER :- User database , System database.
	  - User database create by database administrators (DBA) and database developers (DBD)
	  - System database :- 
	                  1) Master   :- the system configuration database.
					  2) Model    :- the template for new user databases.
					  3) Tempdb   :- store temporary data, dropped and recreated each time SQL Server restarts.
					  4) Msdb     :- the configuration database for the SQL Server Agent service.
					  5) Resource :- a hidden system configuration database that provides system objects to other databases.
					  -- For more info about system databases https://msdn.microsoft.com/en-us/library/ms178028(v=sql.110).aspx


*) Sample Databases
-------------------

         - Sample database is designed as a small, low-complexity database suitable for learning to write T-SQL queries.
	     - We will use Northwind + AdventureWorks2012.
		 - NorthWind  https://northwinddatabase.codeplex.com/
	     - AdventureWorks2012  http://msftdbprodsamples.codeplex.com/releases/view/93587
		 - AdventureWorks All  https://github.com/Microsoft/sql-server-samples/releases/tag/adventureworks

---------------------------------------------------------------------------------------------------------------------------------------
=======================================================================================================================================

2) Getting Started with SSMS (SQL Server Management Studio) :-
-------------------------------------------------------------
--=========================================================================================================================

-- Starting SSMS : Start menu , cmd(ssms)
-- tools menu > options > fonts , which window to start first , ....
-- Connecting to SQL Server :  hostname\instancename  or the name of the pc if its the default instance or the IP address
                               for SQL Azure : Server.Database.windows.net
-- Note : SQL Azure uses only SQL Sever Authentication only
-- using object explorer , new query , script object as file or new query or to job

--=========================================================================================================================

-- Script files & Project Solution explorer:
---------------------------------------------

1- SSMS can open .sql file and edit
2- SSMS can organize scripts into logical containers
  (*.ssmssqlproj) for projects and (*.ssmssln) for solution
3- solution > project > script    (see photo)
4- the ability to open multiple script files in SSMS at once.
5- you can drag script from one project to another after you save the solution
6- excute script : right click or execute bar or alt+X or ctrl+E or F5  --> 
result to  text/grid/file (ctrl+D or ctrl+T or ctrl+shift+F to print to file)  --->ctrl+R

--============================================================================================================================

-- Using Books Online 
-- ------------------ 
- Books Online (often abbreviated BOL) is the product documentation for SQL Server
- BOL can be accessed from the Help menu in SSMS. In a script window, context-sensitive help for T-SQL keywords is 
  available by selecting the keyword and pressing Shift+F1.
- Books Online can be browsed directly on Microsoft's website at 
  http://go.microsoft.com/fwlink/?LinkId=233779
  http://msdn.microsoft.com/en-us/library/ms130214%28v=SQL.110%29.aspx
  Optionally, it can be downloaded and installed locally.
---------------------------------------------------------------------------------------------------------------------------------
=================================================================================================================================

-- Extra :-
------------
-- Path :-
----------
-- SSMS path:-
C:\Program Files (x86)\Microsoft SQL Server\110\Tools\Binn\ManagementStudio

-- all SQL SERVER Programs :-
C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Microsoft SQL Server 2016
note that program data is a hidden folder

-- Databases Path 
C:\Program Files\Microsoft SQL Server\MSSQL13.SQLEXPRESS\MSSQL\DATA

-- Resource System Database Path
C:\Program Files\Microsoft SQL Server\MSSQL13.SQLEXPRESS\MSSQL\Binn

-- Default Backup Path 
C:\Program Files\Microsoft SQL Server\MSSQL13.SQLEXPRESS\MSSQL\Backup

------------------------------------------------------------------------------------
--- Links :-
-------------

-- What is a Database ?
https://www.youtube.com/watch?v=t8jgX1f8kc4

-- Download SQL SERVER 2016 Express Edition :-
https://www.microsoft.com/en-us/download/details.aspx?id=29062

-- Download Sample Databases Northwind + AdventureWorks2012 :-
https://northwinddatabase.codeplex.com/
http://msftdbprodsamples.codeplex.com/releases/view/93587

-- Learn RDBMS in 6 minutes! :-
https://www.youtube.com/watch?v=t48TGntrX4s

*/