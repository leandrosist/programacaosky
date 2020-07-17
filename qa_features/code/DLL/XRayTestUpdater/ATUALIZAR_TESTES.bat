@echo off
setlocal

:: Modificar a variavel abaixo com a informacao de usuario e senha do jira aqui. A senha deve ser encriptada.
set JIRA_CREDENTIALS=jiraUsuario:jiraSenhaEncriptada
:: Modificar a variavel abaixo com o caminho onde está o projeto de features (é onde está o .csproj do seu projeto de features)
set FEATURE_CSPROJECT_PATH=C:\dseproj\git\qa_features\code\Features.TECH.MODULO\Features.TECH.MODULO

XRayTestUpdater.exe --credentials="%JIRA_CREDENTIALS%" --featureCSProjectPath="%FEATURE_CSPROJECT_PATH%"
IF %errorlevel% == 0 (pause)
IF %errorlevel% == 1 (pause)