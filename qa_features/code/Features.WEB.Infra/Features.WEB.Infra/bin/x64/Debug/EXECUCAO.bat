@echo off
setlocal
echo =====================================================
echo 1 - SETANDO VARIAVEIS LOCAIS DE AMBIENTE

:: Passar o caminho atual onde o teste esta como primeiro parametro desta batch
set CAMINHO=%1
:: Passar o nome do arquivo com a lista de testes como segundo parametro desta batch
set LISTA_TESTES=%2
:: Passar o nome do projeto de testes (sem o .dll) como terceiro parametro desta batch
set NOME_PROJETO=%3
:: Passar o numero do ticket do TestPlan como quarto parametro desta batch
set TICKET_JIRA=%4
:: Passar o usuario e a senha do Jira no seguinte formato (entre aspas): "usuario:senha" como quinto parametro desta batch
set JIRA_CREDENTIALS=%5

IF "%CAMINHO%" == "" (
	echo ERRO: O primeiro parametro nao contem o caminho correto!
	exit 1
)
IF "%LISTA_TESTES%" == "" (
	echo ERRO: O segundo parametro nao contem o arquivo da lista testes!
	exit 1
)
IF "%NOME_PROJETO%" == "" (
	echo ERRO: O terceiro parametro nao contem o nome do projeto de testes!
	exit 1
)
IF "%TICKET_JIRA%" == "" (
	echo ERRO: O quarto parametro nao contem o numero do ticket do TestPlan!
	exit 1
)
IF "%JIRA_CREDENTIALS%" == "" (
	echo ERRO: O quinto parametro nao contem as credenciais do Jira!
	exit 1
)

:: Gera um timestamp
for /F "delims=" %%a in ('%CAMINHO%\GetTimeStamp\GetTimeStamp.exe') do set RESULTS_TIMESTAMP=%%a

set NUNIT_CONSOLE=%CAMINHO%\nunit_console\nunit3-console.exe
set EXTENT_MAKER=%CAMINHO%\ExtentReportsDotNetCLI\extent.exe
set XRAY_TEST_UPDATER=%CAMINHO%\XRayTestUpdater\XRayTestUpdater.exe
set PASTA_RESULTADOS=%CAMINHO%\Results\%RESULTS_TIMESTAMP%

echo.
echo PARAMETROS SETADOS:
echo - CAMINHO=%CAMINHO%
echo - RESULTS_TIMESTAMP=%RESULTS_TIMESTAMP%
echo - NOME_PROJETO=%NOME_PROJETO%
echo - LISTA_TESTES=%LISTA_TESTES%
echo - TICKET_JIRA=%TICKET_JIRA%
echo - NUNIT_CONSOLE=%NUNIT_CONSOLE%
echo - EXTENT_MAKER=%EXTENT_MAKER%
echo - XRAY_TEST_UPDATER=%XRAY_TEST_UPDATER%
echo - PASTA_RESULTADOS=%PASTA_RESULTADOS%
echo.
echo =====================================================
echo 2 - CRIANDO PASTA DE RESULTADOS
IF NOT EXIST %CAMINHO%\Results (mkdir %CAMINHO%\Results)
echo.
echo =====================================================
echo 3 - EXECUTANDO OS TESTES
"%NUNIT_CONSOLE%" "%CAMINHO%\%NOME_PROJETO%.dll" --result="%PASTA_RESULTADOS%\%NOME_PROJETO%.xml;format=nunit3" --work="%PASTA_RESULTADOS%" --testlist="%CAMINHO%\%LISTA_TESTES%"
:: Erros do NunitConsoleRunner (erros igual ou acima de UM '1' eh o numero de testes que falhou, e ZERO '0' eh OK)
:: INVALID_ARG
IF %errorlevel% == -1 (exit 1)
:: INVALID_ASSEMBLY
IF %errorlevel% == -2 (exit 1)
:: INVALID_TEST_FIXTURE 
IF %errorlevel% == -4 (exit 1)
:: UNEXPECTED_ERROR 
IF %errorlevel% == -100 (exit 1)
echo.
echo =====================================================
echo 4 - CRIANDO O REPORT HTML
"%EXTENT_MAKER%" -d "%PASTA_RESULTADOS%" -o "%PASTA_RESULTADOS%" --name=%NOME_PROJETO%
echo.
echo =====================================================
echo 5 - ATUALIZACAO DO X-RAY
"%XRAY_TEST_UPDATER%" --ticketJira=%TICKET_JIRA% --results="%PASTA_RESULTADOS%\%NOME_PROJETO%.xml" --credentials=%JIRA_CREDENTIALS%
IF %errorlevel% neq 0 (exit 1)
echo.
echo =====================================================
echo 6 - OK!
echo.