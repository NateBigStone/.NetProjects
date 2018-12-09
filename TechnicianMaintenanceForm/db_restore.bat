@ECHO off

:: batch file for
:: Murach's C# 2008 Projects
:: company: Mike Murach & Associates, Inc.
:: date:    February 13, 2008
:: 
:: Uses SQLCMD utility to run a SQL script that restores
:: the TechSupport database.

ECHO Attempting to restore the TechSupport database . . . 
sqlcmd -S localhost\SQLExpress -E /i db_detach.sql
copy "C:\Murach\C# 2008\Original project database\TechSupport_Data.mdf" "C:\Murach\C# 2008\Project database"
copy "C:\Murach\C# 2008\Original project database\TechSupport_Log.ldf"  "C:\Murach\C# 2008\Project database"
sqlcmd -S localhost\SQLExpress -E /i db_attach.sql
ECHO.
ECHO If no error message is shown, then the database was successfully restored.
ECHO.
PAUSE