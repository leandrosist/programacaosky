@echo off
SETLOCAL

:: ====================== Definicao das pastas principais ======================
set SINACOR_REPO=K:\MS_REPO\repositories\snapshot\SIN-SC\QA
set QA_REPO=K:\MS_REPO\repositories\snapshot
set THIRDPARTY_REPO=K:\MS_REPO\repositories\3rdparty

:: Parametros 1=Nome da DLL, sem a extensao
IF "%~1" == "" (
	echo ERRO: Primeiro parametro nao foi definido com o nome do HELPER.
	exit 1
)

set HELPER=%1
echo ========== Copiando referencias do Helper [%HELPER%] ==========

:: ====================== Criacao da pasta DLL ======================
IF NOT EXIST %~dp0\DLL (mkdir %~dp0\DLL)
attrib -r %~dp0DLL\*.* >nul

:: ====================== Referencias HELPERS ======================
IF NOT EXIST %~dp0\DLL\%HELPER% (mkdir %~dp0\DLL\%HELPER%)
COPY "%QA_REPO%\SIN-QAHELCI\%HELPER%\*.*" %~dp0\DLL\%HELPER% /y
if %errorlevel% neq 0 (exit 1)

echo ========== Referencias do [%HELPER%] copiadas! ==========