@echo off
SETLOCAL

:: Parametros 1=Caminho completo do arquivo de origem
IF "%~1" == "" (
	echo ERRO: Primeiro parametro nao foi definido com o caminho do arquivo de origem
	exit 1
)

:: Parametros 2=Caminho completo da pasta de destino
IF "%~2" == "" (
	echo ERRO: Segundo parametro nao foi definido com o caminho da pasta de destino
	exit 1
)

set origem=%1
set destino=%2

:: ============================================
echo Copiando %origem%...
COPY %origem% %destino% /y
if %errorlevel% neq 0 (exit 1)
