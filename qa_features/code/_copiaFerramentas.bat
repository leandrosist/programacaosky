@echo off
SETLOCAL

:: ====================== Definicao das pastas principais ======================
set SINACOR_REPO=K:\MS_REPO\repositories\snapshot\SIN-SC\QA
set QA_REPO=K:\MS_REPO\repositories\snapshot
set THIRDPARTY_REPO=K:\MS_REPO\repositories\3rdparty


:: ====================== Criacao da pasta DLL ======================
IF NOT EXIST %~dp0\DLL (mkdir %~dp0\DLL)
attrib -r %~dp0DLL\*.* >nul

:: ====================== Referencias Ferramentas ======================
echo ========== Copiando referencias das Ferramentas ==========

IF NOT EXIST %~dp0\DLL\ExecutionListMaker (mkdir %~dp0\DLL\ExecutionListMaker)
COPY "%QA_REPO%\SIN-QAFERCI\ExecutionListMaker\*.*" %~dp0\DLL\ExecutionListMaker /y
if %errorlevel% neq 0 (exit 1)

IF NOT EXIST %~dp0\DLL\ExtentReportsDotNetCLI (mkdir %~dp0\DLL\ExtentReportsDotNetCLI)
COPY "%QA_REPO%\SIN-QAFERCI\ExtentReportsDotNetCLI\*.*" %~dp0\DLL\ExtentReportsDotNetCLI /y
if %errorlevel% neq 0 (exit 1)

IF NOT EXIST %~dp0\DLL\XRayTestUpdater (mkdir %~dp0\DLL\XRayTestUpdater)
COPY "%QA_REPO%\SIN-QAFERCI\XRayTestUpdater\*.*" %~dp0\DLL\XRayTestUpdater /y
if %errorlevel% neq 0 (exit 1)

IF NOT EXIST %~dp0\DLL\GetTimeStamp (mkdir %~dp0\DLL\GetTimeStamp)
COPY "%QA_REPO%\SIN-QAFERCI\GetTimeStamp\*.*" %~dp0\DLL\GetTimeStamp /y
if %errorlevel% neq 0 (exit 1)

echo ========== Referencias das Ferramentas copiadas! ==========