@echo off
setlocal

set MSBUILD="C:\Program Files (x86)\Microsoft Visual Studio\2017\Enterprise\MSBuild\15.0\Bin\msbuild.exe"
set LOGFILE_FOLDER=..\Log
set NUGET_PATH=C:\nuget\4.1.0

IF NOT EXIST "%LOGFILE_FOLDER%" (mkdir "%LOGFILE_FOLDER%")

IF "%~1" == "" (
	echo ERRO: Primeiro parametro nao foi definido com o nome da ferramenta.
	exit 1
)

set PROJNAME=%1
echo ========== Buildando [%PROJNAME%] ==========
%NUGET_PATH%\nuget.exe restore "%PROJNAME%\%PROJNAME%.sln" -MsbuildPath "C:\Program Files (x86)\Microsoft Visual Studio\2017\Enterprise\MSBuild\15.0\Bin"
if %errorlevel% neq 0 (exit 1)
%MSBUILD% "%PROJNAME%\%PROJNAME%.sln" /p:Configuration=Release /p:ReferencePath=..\..\..\Publish\%PROJNAME%\Ref /p:OutputPath=..\..\..\Publish\%PROJNAME% /flp1:PerformanceSummary;Verbosity=normal;LogFile=..\Log\Logbuild_%PROJNAME%.txt
if %errorlevel% neq 0 (exit 1)
echo ========== Build [%PROJNAME%] esta OK ==========
echo.
