@echo off
setlocal

call CopiaReferencias.bat
if %errorlevel% neq 0 (exit 1)

:: ==================================================================

call do_build.bat Features.APE.OMF
if %errorlevel% neq 0 (exit 1)

call do_build.bat Features.API.Exemplo
if %errorlevel% neq 0 (exit 1)

call do_build.bat Features.API.CLI
if %errorlevel% neq 0 (exit 1)

call do_build.bat Features.API.FAT
if %errorlevel% neq 0 (exit 1)

call do_build.bat Features.API.AUM
if %errorlevel% neq 0 (exit 1)

call do_build.bat Features.API.INFRA
if %errorlevel% neq 0 (exit 1)

call do_build.bat Features.WEB.Infra
if %errorlevel% neq 0 (exit 1)

call do_build.bat Features.WEB.FAT
if %errorlevel% neq 0 (exit 1)

call do_build.bat Features.WCF.MOR
if %errorlevel% neq 0 (exit 1)

call do_build.bat Features.WCF.OMF
if %errorlevel% neq 0 (exit 1)

call do_build.bat Features.FIX.FAT
if %errorlevel% neq 0 (exit 1)

call do_build.bat Features.WCF.Exemplo
if %errorlevel% neq 0 (exit 1)

call do_build.bat Features.FIX.Exemplo
if %errorlevel% neq 0 (exit 1)

call do_build.bat Features.FIX.AUM
if %errorlevel% neq 0 (exit 1)

call do_build.bat Features.FIX.FIXGEAR
if %errorlevel% neq 0 (exit 1)

call do_build.bat Features.WEB.BTB
if %errorlevel% neq 0 (exit 1)

call do_build.bat Features.WEB.EAT
if %errorlevel% neq 0 (exit 1)

call do_build.bat Features.WEB.CAC
if %errorlevel% neq 0 (exit 1)

call do_build.bat Features.WEB.SINCAD
if %errorlevel% neq 0 (exit 1)

call do_build.bat Features.API.MPG
if %errorlevel% neq 0 (exit 1)

call do_build.bat Features.WEB.MPG
if %errorlevel% neq 0 (exit 1)

call do_build.bat Features.TIBCO.MOR
if %errorlevel% neq 0 (exit 1)

call do_build.bat Features.WEB.RTC
if %errorlevel% neq 0 (exit 1)

call do_build.bat Features.APE.BMF
if %errorlevel% neq 0 (exit 1)
