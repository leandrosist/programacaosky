@echo off
setlocal

:: ===============================================================================================
:: Coloque os parametros necessarios para rodar o teste localmente.
:: Caso nao queira executar o passo de atualizacao de resultados do XRay, coloque NONE como numero do ticket
:: ===============================================================================================


:: PARAMETROS
:: 1 = Diretorio atual de trabalho, pode deixar o valor %~dp0
:: 2 = Nome do arquivo com lista de testes que deseja rodar
::      (ao gerar um build do seu projeto, ele automaticamente irá gerar essas listas baseadas nas tags dos cenários)
:: 3 = Nome do projeto de testes (geralmente, por exemplo, Features.API.MODULO)
:: 4 = Ticket do TestPlan do XRay para que seja criado um TestExecution com os resultados
::      (coloque NONE para pular esse passo)
:: 5 = Usuario e senha do Jira, entre aspas, no seguinte formato: "usuario:senhaEncriptada"
:: ATENCAO!!!
::    A senha do Jira deve estar encriptada. Utilize o XRayTestUpdater com o 
::    parametro -e para encriptar sua senha!

call EXECUCAO.BAT %~dp0 lista.txt Features.WEB.Infra SINACOR-28027 "p-leandropsantos:C31DEB0C265DCEBE9106AB69CD746C29"
pause