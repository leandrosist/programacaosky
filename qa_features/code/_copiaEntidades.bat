@echo off
SETLOCAL

:: ====================== Definicao das pastas principais ======================
set SINACOR_REPO=K:\MS_REPO\repositories\snapshot\SIN-SC\QA
set QA_REPO=K:\MS_REPO\repositories\snapshot
set THIRDPARTY_REPO=K:\MS_REPO\repositories\3rdparty

:: Parametros 1=Nome da DLL, sem a extensao
IF "%~1" == "" (
	echo ERRO: Primeiro parametro nao foi definido com o nome da ENTIDADE.
	exit 1
)

set ENTIDADE=%1
echo ========== Copiando entidade [%ENTIDADE%] ==========

:: ====================== Criacao da pasta DLL ======================
IF NOT EXIST %~dp0\DLL\Entidades (mkdir %~dp0\DLL\Entidades)

:: ====================== Referencias ENTIDADES ======================
COPY "%QA_REPO%\SIN-QAHELCI\Entidades\%ENTIDADE%.*" %~dp0\DLL\Entidades /y
if %errorlevel% neq 0 (exit 1)

echo ========== Entiadade [%ENTIDADE%] copiada! ==========