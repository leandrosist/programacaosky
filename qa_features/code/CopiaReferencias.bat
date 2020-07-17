
@echo off
cls
SETLOCAL
echo ========== CopiaReferencias.bat ==========

:: ====================== Definicao das pastas principais ======================
set SINACOR_REPO=K:\MS_REPO\repositories\snapshot\SIN-SC\QA
set QA_REPO=K:\MS_REPO\repositories\snapshot
set THIRDPARTY_REPO=K:\MS_REPO\repositories\3rdparty


:: ====================== Criacao da pasta DLL ======================
IF NOT EXIST %~dp0\DLL (mkdir %~dp0\DLL)
attrib -r %~dp0DLL\*.* >nul

:: ====================== Referencias FERRAMENTAS ======================
call %~dp0\_copiaFerramentas.bat

:: ====================== Referencias HELPERS ======================
call %~dp0\_copiaHelpers.bat APEHelper
call %~dp0\_copiaHelpers.bat APIHelper
call %~dp0\_copiaHelpers.bat ConfigHelper
call %~dp0\_copiaHelpers.bat DBHelper
call %~dp0\_copiaHelpers.bat FIXHelper
call %~dp0\_copiaHelpers.bat SeleniumHelper
call %~dp0\_copiaHelpers.bat SOAPHelper
call %~dp0\_copiaHelpers.bat TIBCOHelper
call %~dp0\_copiaHelpers.bat UtilsHelper
call %~dp0\_copiaHelpers.bat WCFHelper

:: ====================== Referencias STEPS ======================
call %~dp0\_copiaSteps.bat Steps.APE.OMF
call %~dp0\_copiaSteps.bat Steps.API.Infra
call %~dp0\_copiaSteps.bat Steps.API.FAT
call %~dp0\_copiaSteps.bat Steps.API.AUM
call %~dp0\_copiaSteps.bat Steps.WCF.OMF
call %~dp0\_copiaSteps.bat Steps.WCF.Infra
call %~dp0\_copiaSteps.bat Steps.WCF.MOR
call %~dp0\_copiaSteps.bat Steps.WEB.Infra
call %~dp0\_copiaSteps.bat Steps.FIX.Infra
call %~dp0\_copiaSteps.bat Steps.TIBCO.Infra
call %~dp0\_copiaSteps.bat Steps.SOAP.EXEMPLO
call %~dp0\_copiaSteps.bat Steps.WEB.FAT
call %~dp0\_copiaSteps.bat Steps.WEB.BTB
call %~dp0\_copiaSteps.bat Steps.WEB.CAC
call %~dp0\_copiaSteps.bat Steps.WEB.EAT
call %~dp0\_copiaSteps.bat Steps.WEB.MPG
call %~dp0\_copiaSteps.bat Steps.WEB.RTC
call %~dp0\_copiaSteps.bat Steps.WEB.SINCAD

:: ====================== Referencias de Entidades de Automacao ======================
echo ========== Copiando referencias de ENTIDADES ==========
call %~dp0\_copiaEntidades.bat Entidades.WEB.FAT
call %~dp0\_copiaEntidades.bat Entidades.WEB.CAC
call %~dp0\_copiaEntidades.bat Entidades.WEB.BTB

:: ====================== Referencias Sinacor ======================
echo ========== Copiando referencias do SINACOR ==========
call _copiaArquivosSinacor.bat "%SINACOR_REPO%\Compilados64\Sinacor\Servicos\Infra Services\Bin\Sinacor.BusinessSupport.Pendencias.Contracts.dll" "%~dp0\DLL"
call _copiaArquivosSinacor.bat "%SINACOR_REPO%\Compilados64\Sinacor\BusinessSupport\Sinacor.BusinessSupport.Pendencias.Entities.dll" "%~dp0\DLL"
call _copiaArquivosSinacor.bat "%SINACOR_REPO%\Compilados64\Sinacor\Servicos\Bmf\Bin\Sinacor.Bmf.Mercadoria.Contracts.dll" "%~dp0\DLL"
call _copiaArquivosSinacor.bat "%SINACOR_REPO%\Compilados64\Sinacor\Servicos\Bmf\Bin\Sinacor.Bmf.Mercadoria.Service.dll" "%~dp0\DLL"
call _copiaArquivosSinacor.bat "%SINACOR_REPO%\Compilados64\Sinacor\Servicos\Ordens\Bin\Sinacor.Ordens.Ordens.Contracts.dll" "%~dp0\DLL"
call _copiaArquivosSinacor.bat "%SINACOR_REPO%\Compilados64\Sinacor\Infra\V19\Sinacor.Infra.Service.Common.dll" "%~dp0\DLL"
call _copiaArquivosSinacor.bat "%SINACOR_REPO%\Compilados64\Sinacor\Servicos\Ordens\Bin\Sinacor.Ordens.Operadores.Contracts.dll" "%~dp0\DLL" 

:: ====================== Referências Sinacor APE ======================
call _copiaArquivosSinacor.bat "%SINACOR_REPO%\Compilados64\Sinacor\Ape\Bmf\Tarifacao\Sinacor.Ape.Bmf.Tarifacao.Entity.dll" "%~dp0\DLL"
call _copiaArquivosSinacor.bat "%SINACOR_REPO%\Compilados64\Sinacor\Ape\Bmf\Importacao\Sinacor.Ape.Bmf.Importacao.Entity.dll" "%~dp0\DLL"

echo ========== Referencias do SINACOR copiadas! ==========

echo.
echo.
echo ========== OK OK OK OK OK OK OK OK OK OK OK OK OK OK OK OK OK OK OK OK OK OK OK OK OK OK ==========
echo ========== Todas as referencias foram copiadas! ==========
echo.
ping localhost -n 2 >nul