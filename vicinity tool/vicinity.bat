@echo off
title Vicinity Tool - dejvv7
chcp 65001 >nul
cls

:start
cls
call :banner

:menu
echo 1. free vbucks generator
echo 2. terraria script
echo 3. konec programu
set /p input=Prosim vyber možnost: 

if /I "%input%"=="1" (
    if exist "openprogramy\fvbg\bin\Debug\net8.0-windows\fvbg.exe" (
        start "" "openprogramy\fvbg\bin\Debug\net8.0-windows\fvbg.exe"
        goto :start
    ) else (
        echo Error: fvbg.exe nebylo nalezeno!
        goto :banner
    )
    goto :menu
)
if /I "%input%"=="2" (
    if exist "openprogramy\script_terraria.bat" (
        start "" "openprogramy\script_terraria.bat"
        goto :start
    ) else (
        echo Error: script_terraria.bat nebylo nalezeno!
        goto :start
    )
    goto :menu
)
if /I "%input%"="3" (
    exit
) else (
    echo Error: Špatný input
    goto :start
) goto :menu

echo Špatná odpověď! Prosím zkus znovu.
goto :start
pause
goto :menu

:banner
echo.
echo.
echo   [38;2;80;0;130m          ██▒   █▓ ██▓ ▄████▄   ██▓ ███▄    █  ██▓▄▄▄█████▓▓██   ██▓ [0m
echo   [38;2;100;0;150m          ▓██░   █▒▓██▒▒██▀ ▀█  ▓██▒ ██ ▀█   █ ▓██▒▓  ██▒ ▓▒ ▒██  ██▒[0m
echo   [38;2;120;30;170m           ▓██  █▒░▒██▒▒▓█    ▄ ▒██▒▓██  ▀█ ██▒▒██▒▒ ▓██░ ▒░  ▒██ ██░[0m
echo   [38;2;140;50;190m            ▒██ █░░░██░▒▓▓▄ ▄██▒░██░▓██▒  ▐▌██▒░██░░ ▓██▓ ░   ░ ▐██▓░[0m
echo   [38;2;160;70;210m             ▒▀█░  ░██░▒ ▓███▀ ░░██░▒██░   ▓██░░██░  ▒██▒ ░   ░ ██▒▓░[0m
echo   [38;2;180;100;230m            ░ ▐░  ░▓  ░ ░▒ ▒  ░░▓  ░ ▒░   ▒ ▒ ░▓    ▒ ░░      ██▒▒▒ [0m
echo   [38;2;200;130;240m             ░ ░░   ▒ ░  ░  ▒    ▒ ░░ ░░   ░ ▒░ ▒ ░    ░     ▓██ ░▒░ [0m
echo   [38;2;220;160;250m               ░░   ▒ ░░         ▒ ░   ░   ░ ░  ▒ ░  ░       ▒ ▒ ░░  [0m
echo   [38;2;240;190;255m                ░   ░  ░ ░       ░           ░  ░            ░ ░     [0m
echo   [38;2;240;160;255m               ░       ░                                     ░ ░     [0m
echo.
echo.
