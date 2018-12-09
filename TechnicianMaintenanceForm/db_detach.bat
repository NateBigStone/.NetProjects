@ECHO off

:: batch file for
:: Murach's C# 2008 Projects
:: company: Mike Murach & Associates, Inc.
:: date:    February 13, 2008
:: 
:: Uses SQLCMD utility to run a SQL script that detaches
:: the TechSupport database.

ECHO Attempting to detach the TechSupport database . . . 
sqlcmd -S localhost\SQLExpress -E /i db_detach.sql
ECHO.
ECHO If no error message is shown, then the database detached correctly.
ECHO.
PAUSE