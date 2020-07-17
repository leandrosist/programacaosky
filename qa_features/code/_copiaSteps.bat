@echo off
SETLOCAL

:: ====================== Definicao das pastas principais ======================
set SINACOR_REPO=K:\MS_REPO\repositories\snapshot\SIN-SC\QA
set QA_REPO=K:\MS_REPO\repositories\snapshot
set THIRDPARTY_REPO=K:\MS_REPO\repositories\3rdparty

:: Parametros 1=Nome da DLL, sem a extensao
IF "%~1" == "" (
	echo ERRO: Primeiro parametro nao foi definido com o nome do STEP.
	exit 1
)

set STEP=%1
echo ==========  Copiando referencias do Step [%STEP%] ==========

:: ====================== Criacao da pasta DLL ======================
IF NOT EXIST %~dp0\DLL (mkdir %~dp0\DLL)
attrib -r %~dp0DLL\*.* >nul

:: ====================== Referencias STEPS ======================
COPY "%QA_REPO%\SIN-QASTECI\%STEP%\%STEP%.dll" %~dp0\DLL /y
if %errorlevel% neq 0 (exit 1)
COPY "%QA_REPO%\SIN-QASTECI\%STEP%\%STEP%.dll.config" %~dp0\DLL /y
if %errorlevel% neq 0 (exit 1)
COPY "%QA_REPO%\SIN-QASTECI\%STEP%\%STEP%.pdb" %~dp0\DLL /y
if %errorlevel% neq 0 (exit 1)

echo ========== Referencias do [%STEP%] copiadas! ==========